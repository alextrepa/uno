﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using Uno.Extensions;
using Uno.Logging;
using Uno.UI.Tasks.Helpers;
using Windows.ApplicationModel.Resources.Core;

namespace Uno.UI.Tasks.ResourcesGenerator
{
	/// <summary>
	/// Parse Resources.resw files and generate the corresponding Localizable.strings (iOS) and Strings.xml (Android) files.
	/// </summary>
	public class ResourcesGenerationTask_v0 : Task
	{
		private const string CommentPattern = @"
	WARNING : THIS FILE HAS BEEN GENERATED BY A TOOL DO NOT UPDATE MANUALLY

	Tool name: {0}
	Source: {1}
";
		[Required]
		public ITaskItem[] Resources { get; set; }

		public string TargetPlatform { get; set; }

		[Required]
		public string TargetProjectDirectory { get; set; }

		[Required]
		public string IntermediateOutputPath { get; set; }

		[Required]
		public string DefaultLanguage { get; set; }

		[Output]
		public ITaskItem[] GeneratedFiles { get; set; }

		private string OutputPath => Path.Combine(TargetProjectDirectory, IntermediateOutputPath, "g", "ResourcesGenerator");

		public override bool Execute()
		{
			LogExtensionPoint.AmbientLoggerFactory.AddProvider(new TaskLoggerProvider(Log));

			this.Log().Info("Generating resources for platform : {0}".InvariantCultureFormat(TargetPlatform));

			try
			{
				GeneratedFiles = Resources
					// TODO: Add support for other resources file names
					.Where(resource => resource.ItemSpec?.EndsWith("Resources.resw") ?? false)
					// TODO: Merge duplicates (based on file name and qualifiers)
					.SelectMany(GetResourcesForItem)
					.Trim()
					.ToArray();

				return true;
			}
			catch (Exception ex)
			{
				this.Log().Error($"Failed to generate resources. Details: {ex.Message}");
			}

			return false;
		}

		private IEnumerable<ITaskItem> GetResourcesForItem(ITaskItem resource)
		{
			this.Log().Info("Resources file found : {0}".InvariantCultureFormat(resource.ItemSpec));

			var resourceCandidate = ResourceCandidate.Parse(resource.ItemSpec, resource.ItemSpec);

			var language = resourceCandidate.GetQualifierValue("language");
			if (language == null)
			{
				// TODO: Add support for resources without a language qualifier
				this.Log().Info("No language found, resources ignored");
				yield break;
			}

			this.Log().Info("Language found : {0}".InvariantCultureFormat(language));

			var resourceFile = resource.ItemSpec;
			var sourceLastWriteTime = new FileInfo(resourceFile).LastWriteTimeUtc;
			var resources = WindowsResourcesReader.Read(resourceFile);
			var comment = CommentPattern.InvariantCultureFormat(this.GetType().Name, resourceFile);

			this.Log().Info("{0} resources found".InvariantCultureFormat(resources.Count));

			if (TargetPlatform == "android")
			{
				yield return GenerateAndroidResources(language, sourceLastWriteTime, resources, comment);
			}
			else if (TargetPlatform == "ios")
			{
				yield return GenerateiOSResources(language, sourceLastWriteTime, resources, comment);
			}

			yield return GenerateUnoPRIResources(language, sourceLastWriteTime, resources, comment);
		}

		private ITaskItem GenerateUnoPRIResources(string language, DateTime sourceLastWriteTime, Dictionary<string, string> resources, string comment)
		{
			var logicalTargetPath = Path.Combine($"{language}", "resources.upri");
			var actualTargetPath = Path.Combine(OutputPath, logicalTargetPath);

			Directory.CreateDirectory(Path.GetDirectoryName(actualTargetPath));

			var targetLastWriteTime = new FileInfo(actualTargetPath).LastWriteTimeUtc;

			if (sourceLastWriteTime > targetLastWriteTime)
			{
				this.Log().Info("Writing resources to {0}".InvariantCultureFormat(actualTargetPath));

				UnoPRIResourcesWriter.Write(language, resources, actualTargetPath, comment);
			}
			else
			{
				this.Log().Info($"Skipping unmodified file {actualTargetPath}");
			}

			return new TaskItem
			(
				actualTargetPath,
				new Dictionary<string, string>()
				{
					{ "UnoResourceTarget", "Uno" },
					{ "LogicalName", logicalTargetPath.Replace(Path.DirectorySeparatorChar, '.') }
				}
			);
		}

		private ITaskItem GenerateiOSResources(string language, DateTime sourceLastWriteTime, Dictionary<string, string> resources, string comment)
		{
			var logicalTargetPath = Path.Combine($"{language}.lproj", "Localizable.strings"); // this path is required by Xamarin
			var actualTargetPath = Path.Combine(OutputPath, logicalTargetPath);

			var targetLastWriteTime = new FileInfo(actualTargetPath).LastWriteTimeUtc;

			if (sourceLastWriteTime > targetLastWriteTime)
			{
				this.Log().Info("Writing resources to {0}".InvariantCultureFormat(actualTargetPath));

				iOSResourcesWriter.Write(resources, actualTargetPath, comment);
			}
			else
			{
				this.Log().Info($"Skipping unmodified file {actualTargetPath}");
			}

			return new TaskItem
			(
				actualTargetPath,
				new Dictionary<string, string>()
				{
					{ "UnoResourceTarget", "iOS" },
					{ "LogicalName", logicalTargetPath }
				}
			);
		}

		private ITaskItem GenerateAndroidResources(string language, DateTime sourceLastWriteTime, Dictionary<string, string> resources, string comment)
		{
			// Resources targetting the default application language must go in a directory called "Values" (no language extension).
			var localizedDirectory = DefaultLanguage == language ? "values" : $"values-{language}";

			var logicalTargetPath = Path.Combine(localizedDirectory, "strings.xml"); // this path is required by Xamarin
			var actualTargetPath = Path.Combine(OutputPath, logicalTargetPath);

			var targetLastWriteTime = new FileInfo(actualTargetPath).LastWriteTimeUtc;

			if (sourceLastWriteTime > targetLastWriteTime)
			{
				this.Log().Info("Writing resources to {0}".InvariantCultureFormat(actualTargetPath));

				AndroidResourcesWriter.Write(resources, actualTargetPath, comment);
			}
			else
			{
				this.Log().Info($"Skipping unmodified file {actualTargetPath}");
			}

			return new TaskItem
			(
				actualTargetPath,
				new Dictionary<string, string>()
				{
					{ "UnoResourceTarget", "Android" },
					{ "LogicalName", logicalTargetPath }
				}
			);
		}
	}
}

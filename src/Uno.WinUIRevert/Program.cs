#nullable enable
using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace UnoWinUIRevert
{
	class Program
	{
		static void Main(string[] args)
		{
			var basePath = args[0];

			DeleteFolder(Path.Combine(basePath, @"src\Uno.UI\Generated"));
			DeleteFolder(Path.Combine(basePath, @"src\Uno.UWP\Generated"));
			DeleteFolder(Path.Combine(basePath, @"src\Uno.UWP\UI\Composition"));

			var compositionPath = Path.Combine(basePath, @"src\Uno.UI\UI\Composition");
			if (Directory.Exists(compositionPath))
			{
				Console.WriteLine(@"Moving composition");
				Directory.Move(compositionPath, Path.Combine(basePath, @"src\Uno.UWP\UI\Composition"));
			}

			var colorsFilepath = Path.Combine(basePath, @"src\Uno.UI\UI\Colors.cs");
			if (File.Exists(colorsFilepath))
			{
				File.Move(colorsFilepath, Path.Combine(basePath, @"src\Uno.uwp\UI\Colors.cs"), true);
			}

			var colorHelperFilePath = Path.Combine(basePath, @"src\Uno.UI\UI\ColorHelper.cs");
			if (File.Exists(colorHelperFilePath))
			{
				File.Move(colorHelperFilePath, Path.Combine(basePath, @"src\Uno.uwp\UI\ColorHelper.cs"), true);
			}

			// Generic remplacements
			var genericReplacements = new[] {
				("Microsoft.UI.Xaml", "Windows.UI.Xaml"),
				("Microsoft.UI.Composition", "Windows.UI.Composition"),
				("Microsoft.UI.Colors", "Windows.UI.Colors"),
				("Microsoft.UI.ColorHelper", "Windows.UI.ColorHelper"),
				("Microsoft.UI.Xaml", "Windows.UI.Xaml"),
				("Uno.UI.Controls.Legacy\", \"ProgressRing", "Windows.UI.Xaml.Controls\", \"ProgressRing"),
			};

			ReplaceInFolders(basePath, genericReplacements);

			// Restore ProgressRing
			var progressRingReplacements = new[] {
				("Uno.UI.Controls.Legacy", "Windows.UI.Xaml.Controls"),
			};

			ReplaceInFolders(Path.Combine(basePath, @"src\Uno.UI\UI\Xaml\Controls\ProgressRing"), progressRingReplacements);
			ReplaceInFile(Path.Combine(basePath, @"src\Uno.UI\UI\Xaml\Controls\ProgressRing\ProgressRing.xaml"), "legacy:", "");

			// Adjust Colors
			ReplaceInFile(Path.Combine(basePath, @"src\Uno.UWP\UI\Colors.cs"), "Microsoft.UI", "Windows.UI");
			ReplaceInFile(Path.Combine(basePath, @"src\Uno.UWP\UI\ColorHelper.cs"), "Microsoft.UI", "Windows.UI");
			ReplaceInFile(Path.Combine(basePath, @"src\SourceGenerators\Uno.UI.SourceGenerators\XamlGenerator\XamlConstants.cs"), "Microsoft.UI", "Windows.UI");
			ReplaceInFile(Path.Combine(basePath, @"src\Uno.UI\UI\Xaml\Markup\Reader\XamlConstants.cs"), "Microsoft.UI", "Windows.UI");

			// Revert partial changes for WinUI 2.4 imported controls
			foreach (var file in Directory.EnumerateFiles(Path.Combine(basePath, @"src\Uno.UI\Microsoft\UI\Xaml\Controls"), "*.*", SearchOption.AllDirectories))
			{
				ReplaceInFile(file, "namespace Windows.UI.Xaml.Controls", "namespace Microsoft.UI.Xaml.Controls");
			}
		}

		private static void ReplaceInFolders(string basePath, (string from, string to)[] replacements, string searchPattern = "*.*")
		{
			foreach (var file in Directory.EnumerateFiles(basePath, searchPattern, SearchOption.AllDirectories))
			{
				if (file.Contains(@"\obj\") || file.Contains(@"\bin\") || file.Contains(@"\.git") || file.Contains(@"\.vs"))
				{
					continue;
				}

				var updated = false;
				var content = File.ReadAllText(file);

				for (int i = 0; i < replacements.Length; i++)
				{
					if (content.Contains(replacements[i].from))
					{
						content = content.Replace(replacements[i].from, replacements[i].to);
						updated = true;
					}
				}

				if (updated)
				{
					Console.WriteLine($"Updating [{file}]");
					File.WriteAllText(file, content);
				}
			}
		}

		private static void DeleteFolder(string path)
		{
			if (Directory.Exists(path))
			{
				Console.WriteLine($"Deleting {path}");
				Directory.Delete(path, true);
			}
		}

		private static void ReplaceInFile(string filePath, string from, string to)
		{
			Console.WriteLine($"Updating [{filePath}]");

			var txt = File.ReadAllText(filePath);
			txt = txt.Replace(from, to);
			File.WriteAllText(filePath, txt);
		}
	}
}

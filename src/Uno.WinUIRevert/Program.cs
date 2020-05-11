#nullable enable
using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace UnoWinUIRevert
{
	class Program
	{
		static Regex _WUXReplace = new Regex(@"Microsoft\.UI\.Xaml");
		static Regex _WUCReplace = new Regex(@"Microsoft\.UI\.Composition");
		static Regex _ColorsReplace = new Regex(@"Microsoft\.UI\.Colors");

		static void Main(string[] args)
		{
			var basePath = args[0];
				
			DeleteFolder(Path.Combine(basePath, @"src\Uno.UI\Generated"));
			DeleteFolder(Path.Combine(basePath, @"src\Uno.UWP\Generated"));
			DeleteFolder(Path.Combine(basePath, @"src\Uno.UWP\UI\Composition"));

			Console.WriteLine(@"Moving composition");
			Directory.Move(Path.Combine(basePath, @"src\Uno.UI\UI\Composition"), Path.Combine(basePath, @"src\Uno.UWP\UI\Composition"));
			File.Move(Path.Combine(basePath, @"src\Uno.UI\UI\Colors.cs"), Path.Combine(basePath, @"src\Uno.uwp\UI\Colors.cs"));
			File.Move(Path.Combine(basePath, @"src\Uno.UI\UI\ColorHelper.cs"), Path.Combine(basePath, @"src\Uno.uwp\UI\ColorHelper.cs"));

			foreach (var file in Directory.EnumerateFiles(basePath, "*.*", SearchOption.AllDirectories))
			{
				if (file.Contains(@"\obj\") || file.Contains(@"\bin\") || file.Contains(@"\.git") || file.Contains(@"\.vs"))
				{
					continue;
				}

				var updated = false;
				var content = File.ReadAllText(file);

				if (content.Contains("Microsoft.UI.Xaml"))
				{
					content = _WUXReplace.Replace(content, "Windows.UI.Xaml");
					updated = true;
				}

				if (content.Contains("Microsoft.UI.Composition"))
				{
					content = _WUCReplace.Replace(content, "Windows.UI.Composition");
					updated = true;
				}

				if (content.Contains("Microsoft.UI.Colors"))
				{
					content = _ColorsReplace.Replace(content, "Windows.UI.Colors");
					updated = true;
				}

				if (updated)
				{
					Console.WriteLine($"Updating [{file}]");
					File.WriteAllText(file, content);
				}
			}

			// Adjust Colors
			ReplaceInFile(Path.Combine(basePath, @"src\Uno.UWP\UI\Colors.cs"), "Microsoft.UI", "Windows.UI");
			ReplaceInFile(Path.Combine(basePath, @"src\Uno.UWP\UI\ColorHelper.cs"), "Microsoft.UI", "Windows.UI");
			ReplaceInFile(Path.Combine(basePath, @"src\SourceGenerators\Uno.UI.SourceGenerators\XamlGenerator\XamlConstants.cs"), "Microsoft.UI", "Windows.UI");
			ReplaceInFile(Path.Combine(basePath, @"src\Uno.UI\UI\Xaml\Markup\Reader\XamlConstants.cs"), "Microsoft.UI", "Windows.UI");
		}

		private static void DeleteFolder(string path)
		{
			if (Directory.Exists(path))
			{
				Console.WriteLine($"Deleting {path}");
				Directory.Delete(path, true);
			}
		}

		private static void ReplaceInFile(string colorsClassPath, string from, string to)
		{
			var txt = File.ReadAllText(colorsClassPath);
			txt = txt.Replace(from, to);
			File.WriteAllText(colorsClassPath, txt);
		}
	}
}

﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

//
// This file is a C# translation of the ResourceAccessor.cpp file from WinUI controls.
//

using System;
using System.Collections.Generic;
using System.Text;
using Windows.ApplicationModel.Core;
using Windows.ApplicationModel.Resources.Core;
using Windows.Foundation;
using Windows.UI.Core;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;

namespace Uno.UI.Helpers.WinUI
{
	internal class ResourceAccessor
	{
		public const string MUXCONTROLS_PACKAGE_NAME = "Microsoft.UI.Xaml.3.0";
		private const string c_resourceLoc = "Microsoft.UI.Xaml/Resources";

#if !IS_UNO
		private static ResourceMap s_resourceMap = GetPackageResourceMap();
		private static ResourceContext s_resourceContext = ResourceContext.GetForViewIndependentUse();

		private static ResourceMap GetPackageResourceMap()
		{
			if (SharedHelpers.IsInFrameworkPackage())
			{
				string packageName = MUXCONTROLS_PACKAGE_NAME;
				if (ResourceManager.Current.AllResourceMaps.TryGetValue(packageName, out var value))
				{
					return value;
				}

				return null;
			}
			else
			{
				return ResourceManager.Current.MainResourceMap;
			}
		}

		private static ResourceMap GetResourceMap()
		{
			return s_resourceMap.GetSubtree(c_resourceLoc);
		}
#endif

		public static string GetLocalizedStringResource(string resourceName)
		{
#if !IS_UNO
			return s_resourceMap.GetValue(resourceName, s_resourceContext).ToString ();
#else
			return Windows.ApplicationModel.Resources.ResourceLoader.GetForViewIndependentUse().GetString(resourceName);
#endif
		}

		public static LoadedImageSurface GetImageSurface(string assetName, Size imageSize)
		{
			Uri getImageUri() {
				if (SharedHelpers.IsInFrameworkPackage())
				{
					return new Uri("ms-resource://" + MUXCONTROLS_PACKAGE_NAME + "/Files/Microsoft.UI.Xaml/Assets/" + assetName + ".png");
				}
				else
				{
					return new Uri("ms-resource:///Files/Microsoft.UI.Xaml/Assets/"+assetName  + ".png");
				}
			}

			return LoadedImageSurface.StartLoadFromUri(getImageUri(), imageSize);
		}
	}
}

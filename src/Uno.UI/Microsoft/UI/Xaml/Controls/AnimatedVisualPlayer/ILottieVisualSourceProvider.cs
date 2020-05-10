using System;

namespace Microsoft.UI.Xaml.Controls
{
	public interface ILottieVisualSourceProvider
	{
		IAnimatedVisualSource CreateFromLottieAsset(Uri sourceFile);
	}
}

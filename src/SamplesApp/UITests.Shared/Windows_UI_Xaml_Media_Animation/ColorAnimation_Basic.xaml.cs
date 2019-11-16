using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Uno.UI.Samples.Controls;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UITests.Shared.Windows_UI_Xaml_Media_Animation
{
	[SampleControlInfo("Animations", "ColorAnimation_Basic")]
	public sealed partial class ColorAnimation_Basic : UserControl
    {
        public ColorAnimation_Basic()
        {
            this.InitializeComponent();
        }

		private void BeginAnimation(object sender, RoutedEventArgs e)
		{
			if (sender is FrameworkElement elt
				&& elt.Resources.TryGetValue("Storyboard", out var res)
				&& res is Storyboard storyboard)
			{
				Storyboard.SetTarget(storyboard, elt);
				storyboard.Begin();
			}
		}
	}
}

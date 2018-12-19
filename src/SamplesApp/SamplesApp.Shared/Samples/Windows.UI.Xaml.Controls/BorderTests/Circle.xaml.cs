﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Uno.UI.Samples.Controls;
#if NETFX_CORE
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
#elif HAS_UNO
using Windows.UI.Xaml.Controls;
using System.Globalization;
#endif


namespace Uno.UI.Samples.Content.UITests.BorderTestsControl
{
    [SampleControlInfoAttribute("Border", "Circle")]
    public sealed partial class Circle : Page
    {
        public Circle()
        {
            this.InitializeComponent();
        }
    }
}

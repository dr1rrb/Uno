using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Uno.UI.Samples.Controls;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace UITests.Shared.Windows_ApplicationModel
{
	[SampleControlInfo("Windows.ApplicationModel", "PackageId", ignoreInAutomatedTests: true, description: "Test the PackageId API. Some properties intentionally not filled out.")]
	public sealed partial class PackageIdTests : UserControl
	{
		public PackageIdTests()
		{
			this.InitializeComponent();			
			var packageId = Package.Current.Id;
			Architecture = packageId.Architecture;			
			FamilyName = packageId.FamilyName;
			FullName = packageId.FullName;
			Name = packageId.Name;			
			Publisher = packageId.Publisher;
			PublisherId = packageId.PublisherId;
			ResourceId = packageId.ResourceId;
			Version = $"{packageId.Version.Major}.{packageId.Version.Minor}.{packageId.Version.Revision}.{packageId.Version.Build}";
		}

		public ProcessorArchitecture Architecture { get; }

		public string Author { get; }

		public string FamilyName { get; set; }

		public string FullName { get; set; }

		public string ProductId { get; set; }

		public string Publisher { get; set; }

		public string PublisherId { get; set; }

		public string ResourceId { get; set; }

		public string Version { get; set; }
	}
}

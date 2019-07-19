#if __IOS__ 
#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
using Foundation;

namespace Windows.ApplicationModel
{
	public  partial class PackageId 
	{
		private const string BundleDisplayNameKey = "CFBundleDisplayName";
		private const string BundleIdentifierKey = "CFBundleIdentifier";
		private const string BundleShortVersionKey = "CFBundleShortVersionString";
		private const string BundleVersionKey = "CFBundleVersion";

		[global::Uno.NotImplemented]
		public global::Windows.System.ProcessorArchitecture Architecture
		{
			get
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.PackageId", "Architecture");
				return System.ProcessorArchitecture.Unknown;
			}
		}

		[global::Uno.NotImplemented]
		public string FamilyName
		{
			get
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.PackageId", "FamilyName");
				return "Unknown";
			}
		}

		public string FullName => NSBundle.MainBundle.InfoDictionary[BundleIdentifierKey].ToString();

		public string Name => NSBundle.MainBundle.InfoDictionary[BundleDisplayNameKey].ToString();

		public PackageVersion Version
		{
			get
			{
				var versionString = NSBundle.MainBundle.InfoDictionary[BundleShortVersionKey].ToString();
				var bundleVersion = NSBundle.MainBundle.InfoDictionary[BundleVersionKey].ToString();
				var rawVersion = string.Empty;
				if (!string.IsNullOrEmpty(versionString) && !bundleVersion.Contains("."))
				{
					rawVersion = $"{versionString}.";
				}
				rawVersion += bundleVersion;

				// TODO: use Regex to replace alpha char with period
				string cleanVersion = string.Empty.Replace('a', '.').Replace('b', '.').Replace('d', '.').Replace("fc", ".");

				return Version.Parse(cleanVersion);
			}
		}
	}
}
#endif

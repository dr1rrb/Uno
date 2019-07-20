#if __ANDROID__
#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
using Android.App;
using Android.Content.PM;
using Android.Support.V4.Content.PM;
using SystemVersion = global::System.Version;

namespace Windows.ApplicationModel
{
	public  partial class PackageId 
	{
		private readonly PackageInfo _packageInfo;

		public PackageId()
		{			
			_packageInfo = Application.Context.PackageManager.GetPackageInfo(
				Application.Context.PackageName,
				PackageInfoFlags.MetaData);
		}

		[global::Uno.NotImplemented]
		public global::Windows.System.ProcessorArchitecture Architecture
		{
			get
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.PackageId", "Architecture");
				return System.ProcessorArchitecture.Unknown;
			}
		}

		public string FamilyName => Application.Context.PackageName;

		public string FullName => Application.Context.PackageName;

		public string Name => _packageInfo.PackageName;

		public PackageVersion Version
		{
			get
			{
				var version = SystemVersion.Parse(_packageInfo.VersionName);
				return new PackageVersion(
					(ushort)version.Major,
					(ushort)version.Minor,
					(ushort)version.Build,
					(ushort)version.Revision);
			}
		}
	}
}
#endif

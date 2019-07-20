namespace Windows.ApplicationModel
{
	public partial struct PackageVersion
	{
		internal PackageVersion(
			ushort major,
			ushort minor,
			ushort build,
			ushort revision)
		{
			Major = major;
			Minor = minor;
			Build = build;
			Revision = revision;
		}

		public ushort Major;
		public ushort Minor;
		public ushort Build;
		public ushort Revision;
	}
}

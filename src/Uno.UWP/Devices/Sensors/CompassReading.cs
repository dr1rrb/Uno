using System;

namespace Windows.Devices.Sensors
{
	public  partial class CompassReading 
	{
		public CompassReading(
			double headingMagneticNorth,
			double? headingTrueNorth,
			DateTimeOffset timestamp,
			MagnetometerAccuracy headingAccuracy)
		{
			HeadingMagneticNorth = HeadingMagneticNorth;
			HeadingTrueNorth = headingTrueNorth;
			Timestamp = timestamp;
			HeadingAccuracy = headingAccuracy;
		}

		public double HeadingMagneticNorth { get; }
		public  double? HeadingTrueNorth { get; }
		public  DateTimeOffset Timestamp { get; }
		public MagnetometerAccuracy HeadingAccuracy { get; }
	}
}

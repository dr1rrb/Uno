#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sensors
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public partial class CompassReading 
	{
		// Skipping already declared property HeadingMagneticNorth
		// Skipping already declared property HeadingTrueNorth		
		// Skipping already declared property Timestamp
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.TimeSpan? PerformanceCount
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan? CompassReading.PerformanceCount is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IReadOnlyDictionary<string, object> Properties
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyDictionary<string, object> CompassReading.Properties is not implemented in Uno.");
			}
		}
		#endif
		// Skipping already declared property HeadingAccuracy
		// Forced skipping of method Windows.Devices.Sensors.CompassReading.Timestamp.get
		// Forced skipping of method Windows.Devices.Sensors.CompassReading.HeadingMagneticNorth.get
		// Forced skipping of method Windows.Devices.Sensors.CompassReading.HeadingTrueNorth.get
		// Forced skipping of method Windows.Devices.Sensors.CompassReading.HeadingAccuracy.get
		// Forced skipping of method Windows.Devices.Sensors.CompassReading.PerformanceCount.get
		// Forced skipping of method Windows.Devices.Sensors.CompassReading.Properties.get
	}
}

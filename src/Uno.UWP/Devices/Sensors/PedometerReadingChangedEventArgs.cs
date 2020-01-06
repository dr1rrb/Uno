#if __ANDROID__ || __IOS__
namespace Windows.Devices.Sensors
{
	public partial class PedometerReadingChangedEventArgs
	{
		internal PedometerReadingChangedEventArgs(
			PedometerReading reading)
		{
			Reading = reading;
		}

		public PedometerReading Reading { get; }
	}
}
#endif

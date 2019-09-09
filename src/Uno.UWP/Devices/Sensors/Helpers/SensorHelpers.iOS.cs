#if __IOS__
using Foundation;
using System;

namespace Uno.Devices.Sensors.Helpers
{
	internal static class SensorHelpers
	{
		public static DateTimeOffset TimestampToDateTimeOffset(double timestamp)
		{
			var bootTime = NSDate.FromTimeIntervalSinceNow(-NSProcessInfo.ProcessInfo.SystemUptime);
			var date = (DateTime)bootTime.AddSeconds(timestamp);
			return new DateTimeOffset(date);
		}

		public static DateTimeOffset TimestampToDateTimeOffset(NSDate date)
		{
			var reference = new DateTimeOffset(2001, 1, 1, 0, 0, 0, TimeSpan.Zero);
			return reference.AddSeconds(date.SecondsSinceReferenceDate);
		}
	}
}
#endif

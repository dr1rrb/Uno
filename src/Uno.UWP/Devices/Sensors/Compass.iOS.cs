#if __IOS__
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLocation;
using CoreMotion;
using Foundation;
using Uno.Devices.Sensors.Helpers;

namespace Windows.Devices.Sensors
{
	public partial class Compass
	{
		private readonly CLLocationManager _locationManager;

		private Compass(CLLocationManager locationManager)
		{
			_locationManager = locationManager;
		}

		private static Compass TryCreateInstance()
		{
			return CLLocationManager.HeadingAvailable ?
				new Compass(new CLLocationManager()) : null;
		}

		private void StartReading()
		{
			_locationManager.UpdatedHeading += LocationManagerUpdatedHeading;
			_locationManager.StartUpdatingHeading();
		}

		private void LocationManagerUpdatedHeading(object sender, CLHeadingUpdatedEventArgs e)
		{
			MagnetometerAccuracy accuracy;
			if ( e.NewHeading.HeadingAccuracy < 0 )
			{
				accuracy = MagnetometerAccuracy.Unknown;
			} else if ( e.NewHeading.HeadingAccuracy < 20)
			{
				accuracy = MagnetometerAccuracy.High;
			} else if (e.NewHeading.HeadingAccuracy < 90)
			{
				accuracy = MagnetometerAccuracy.Approximate;
			}
			else
			{
				accuracy = MagnetometerAccuracy.Unreliable;
			}
			CompassReading reading = new CompassReading(
				e.NewHeading.MagneticHeading,
				e.NewHeading.TrueHeading,
				SensorHelpers.TimestampToDateTimeOffset(e.NewHeading.Timestamp),
				accuracy);
			OnReadingChanged(reading);
		}

		private void StopReading()
		{
			_locationManager.StopUpdatingHeading();
			_locationManager.UpdatedHeading -= LocationManagerUpdatedHeading;
		}
	}
}
#endif

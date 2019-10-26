
using Android.Content;
#if __ANDROID__
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking.Connectivity.Internal;
using Android.App;

namespace Windows.Networking.Connectivity
{
	public partial class NetworkInformation
	{
		private static ConnectivityChangeBroadcastReceiver _connectivityChangeBroadcastReceiver;

		private static void StartNetworkStatusChanged()
		{
			_connectivityChangeBroadcastReceiver = new ConnectivityChangeBroadcastReceiver();

#pragma warning disable CS0618 // Type or member is obsolete
			Application.Context.RegisterReceiver(
				_connectivityChangeBroadcastReceiver,
				new IntentFilter(Android.Net.ConnectivityManager.ConnectivityAction));
#pragma warning restore CS0618 // Type or member is obsolete
		}

		private static void StopNetworkStatusChanged()
		{
			if( _connectivityChangeBroadcastReceiver == null)
			{
				return;
			}

			Application.Context.UnregisterReceiver(
				_connectivityChangeBroadcastReceiver);
			_connectivityChangeBroadcastReceiver?.Dispose();
			_connectivityChangeBroadcastReceiver = null;
		}
	}
}
#endif

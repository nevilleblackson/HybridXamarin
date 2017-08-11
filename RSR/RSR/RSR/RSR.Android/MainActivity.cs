using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Android.Locations;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

using static RSR.MapPage;

namespace RSR.Droid
{
    [Activity (MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, Theme = "@style/MainTheme")]
	public class MainActivity : Xamarin.Forms.Platform.Android.FormsAppCompatActivity, ILocationListener
    {
        LocationManager locMgr;

        public void GetLocation(string latitude, string longitude)
        {

        }

        public void OnLocationChanged(Location location)
        {
            if (!avalable)
            {
                return;
            }

            var position = new Position(location.Latitude, location.Longitude); // Latitude, Longitude

            var pin = new Pin
            {
                Type = PinType.Generic,
                Position = position,
                Label = "custom pin",
                Address = "custom detail info"
            };

            mMyMap.Pins.Clear();
            mMyMap.Pins.Add(pin);

            mMyMap.MoveToRegion(
            MapSpan.FromCenterAndRadius(
            new Position(location.Latitude, location.Longitude), Distance.FromMeters(10)));
        }

        protected override void OnResume()
        {
            base.OnResume();

            locMgr = GetSystemService(LocationService) as LocationManager;


            string Provider = LocationManager.GpsProvider;

            if (locMgr.IsProviderEnabled(Provider))
            {
                locMgr.RequestLocationUpdates(Provider, 0, 0, this);
            }
            else
            {
            }
        }


        public void OnProviderDisabled(string provider)
        {

        }

        public void OnProviderEnabled(string provider)
        {

        }

        public void OnStatusChanged(string provider, [GeneratedEnum] Availability status, Bundle extras)
        {

        }

        protected override void OnCreate(Bundle bundle){
            base.OnCreate(bundle);

            Xamarin.FormsMaps.Init(this, bundle);

            Forms.Init(this, bundle);
            LoadApplication(new RSR.App());
        }

        protected override void OnStart()
        {
            base.OnStart();
        }

        protected override void OnPause()
        {
            base.OnPause();
            locMgr.RemoveUpdates(this);
            }
    }
}
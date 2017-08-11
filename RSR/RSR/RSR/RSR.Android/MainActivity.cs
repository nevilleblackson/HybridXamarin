using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Locations;
using Android.Content;
using Android.Util;

namespace RSR.Droid
{
	[Activity (MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, Theme = "@style/MainTheme")]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity, ILocationListener
    {
        LocationManager locMgr;
        String latitude = "wow";
        String longitude = "wow";

        public string Longitude { get => longitude; set => longitude = value; }

        public string Latitude { get => latitude; set => latitude = value; }

        public void OnLocationChanged(Location location)
        {
            latitude = $"Latitude: {location.Latitude}";
            longitude = $"Longitude: {location.Longitude}";
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

        protected override void OnCreate(Bundle bundle)
        {
            locMgr = GetSystemService(Context.LocationService) as LocationManager;

            Xamarin.FormsMaps.Init(this, bundle);

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new RSR.App());

            String Provider = LocationManager.GpsProvider;

            if (locMgr.IsProviderEnabled(Provider))
            {
                locMgr.RequestLocationUpdates(Provider, 0, 0, this);
            }
            else
            {

            }
        }

         protected override void OnPause()
        {
            base.OnPause();
            locMgr.RemoveUpdates(this);
        }

        public void CallRSR(object sender, EventArgs e)
        {
            var uri = Android.Net.Uri.Parse("tel:06612669910");
            var intent = new Intent(Intent.ActionDial, uri);
            StartActivity(intent);
        }
    }
}
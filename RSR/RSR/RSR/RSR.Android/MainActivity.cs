using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms;
using Android.Content;
using RSR.Droid;
using Android.Locations;
using System;
using Xamarin.Forms.Maps;

using static RSR.MapPage;
using Android.Runtime;

[assembly: Dependency(typeof(MainActivity))]
namespace RSR.Droid
{
    [Activity (MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, Theme = "@style/MainTheme")]
	public class MainActivity : Xamarin.Forms.Platform.Android.FormsAppCompatActivity, IStartMap, ILocationListener
    {

        LocationManager locMgr;

        public void GetLocation(string latitude, string longitude)
        {

        public MainActivity() { }

        public void StartMap()
        {
            latitude = $"Latitude: {location.Latitude}";
            longitude = $"Longitude: {location.Longitude}";
        }
            var uri = Android.Net.Uri.Parse("tel:06612669910");
            var intent = new Intent(Intent.ActionDial, uri);
            StartActivity(intent);
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Xamarin.FormsMaps.Init(this, bundle);

            Forms.Init(this, bundle);
            LoadApplication(new RSR.App());
        }


        protected override void OnResume()
        {
            base.OnResume();

            locMgr = GetSystemService(LocationService) as LocationManager;


            string Provider = LocationManager.GpsProvider;


            if (locMgr.IsProviderEnabled(Provider))
            {
                locMgr.RequestLocationUpdates(Provider, 500, 0, this);
            }
        }

        protected override void OnPause()
        {
            base.OnPause();
            locMgr.RemoveUpdates(this);
        }

        public void OnProviderEnabled(string provider)
        {
        }
        public void OnLocationChanged(Location location)
        {
            if (!avalable)
            {
                return;
            }

            var position = new Position(location.Latitude, location.Longitude); // Latitude, Longitude

        public void OnStatusChanged(string provider, [GeneratedEnum] Availability status, Bundle extras)
        {
            
        }
            var pin = new Pin
            {
                Type = PinType.Generic,
                Position = position,
                Label = "custom pin",
                Address = "custom detail info"
            };

            mMyMap.Pins.Clear();
            mMyMap.Pins.Add(pin);

        protected override void OnCreate(Bundle bundle)
        {
            locMgr = GetSystemService(Context.LocationService) as LocationManager;

            throw new NotImplementedException();
        }

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

        public void OnProviderEnabled(string provider)
        {
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
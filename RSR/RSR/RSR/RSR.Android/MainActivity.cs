using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Xamarin.Forms;
using Android.Content;
using RSR.Droid;
using Android.Locations;
using System;
using Xamarin.Forms.Maps;

using static RSR.MapPage;
using System.Linq;

[assembly: Dependency(typeof(MainActivity))]
namespace RSR.Droid
{
    [Activity(MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, Theme = "@style/MainTheme")]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsAppCompatActivity, IStartMap, ILocationListener
    {

        LocationManager locMgr;

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

        public void OnStatusChanged(string provider, [GeneratedEnum] Availability status, Bundle extras)
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
        }


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Xamarin.FormsMaps.Init(this, bundle);

            Forms.Init(this, bundle);
            LoadApplication(new RSR.App());

            locMgr = GetSystemService(Context.LocationService) as LocationManager;

            String Provider = LocationManager.GpsProvider;

            if (locMgr.IsProviderEnabled(Provider))
            {
                locMgr.GetLastKnownLocation(Provider);
                locMgr.RequestLocationUpdates("gps", 2000, 0, this);
                Location loc = locMgr.GetLastKnownLocation(Provider);
                Latitude = loc.Latitude;
                Longitude = loc.Longitude;
            }

            getCurrentAddress();
        }

        public void CallRSR(object sender, EventArgs e)
        {
            var uri = Android.Net.Uri.Parse("tel:06612669910");
            var intent = new Intent(Intent.ActionDial, uri);
            StartActivity(intent);
        }

        public void StartMap()
        {
            throw new NotImplementedException();
        }

        public void OnProviderDisabled(string provider)
        {
            throw new NotImplementedException();
        }

        private async void getCurrentAddress()
        {
            try
            {
                var currentPosition = new Xamarin.Forms.Maps.Position(Latitude, Longitude);
                Xamarin.Forms.Maps.Geocoder geoCoder = new Xamarin.Forms.Maps.Geocoder();

                var address = await geoCoder.GetAddressesForPositionAsync(currentPosition);

                String addresInfo = "";

                var possibleAddresses = await geoCoder.GetAddressesForPositionAsync(currentPosition);

                addresInfo += possibleAddresses.ElementAt(0);

                mAddresInfo = addresInfo.Replace(",",",\n");

            }
            catch
            {
            //EMPTY
            }
        }
    }
}
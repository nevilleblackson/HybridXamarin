using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;
using Android.Content;

namespace RSR
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MapPage : ContentPage {

      
        public MapPage()
        {
            InitializeComponent();

            var Latitude = 52.479189;
            var Longitude = 5.899431;

            var position = new Position(Latitude, Longitude); // Latitude, Longitude

            var pin = new Pin
            {
                Type = PinType.Generic,
                Position = position,
                Label = "custom pin",
                Address = "custom detail info"
            };

            MyMap.Pins.Clear();
            MyMap.Pins.Add(pin);

            MyMap.MoveToRegion(
            MapSpan.FromCenterAndRadius(
            new Position(Latitude, Longitude), Distance.FromMeters(10)));

        }

        void OnBackBtnClicked(object sender, EventArgs e)
        {
            base.SendBackButtonPressed();
        }
        void OnCallDialogClicked(object sender, EventArgs e)
        {
            OpenCallDialogButton.IsVisible = false;
            CallDialog.IsVisible = true;
            CloseCallDialogButton.IsVisible = true;
        }
        void OnCloseDialogButtonClicked(object sender, EventArgs e)
        {
            CallDialog.IsVisible = false;
            CloseCallDialogButton.IsVisible = false;
            OpenCallDialogButton.IsVisible = true;
        }
        void OnCallButtonClicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri(String.Format("tel:{0}", "0612669910")));
        }
    }
}
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
	public partial class MapPage : ContentPage
    {

        public static bool avalable;
        public static Map mMyMap;

        
        public MapPage()
        {
            InitializeComponent();

            var position = new Position(51.99975, 4.9998); // Latitude, Longitude

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
            new Position(51.99975, 4.9998), Distance.FromMeters(10)));

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
            
        }
    }
}
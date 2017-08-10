using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;


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
    }
}
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
	public partial class MapPage : ContentPage
    {

        public static bool avalable;
        public static Map mMyMap;

        
        public MapPage()
        {
            avalable = true;
            InitializeComponent();

            var position = new Position(51.99975, 4.9998); // Latitude, Longitude

            var pin = new Pin
            {
                Type = PinType.Generic,
                Position = position,
                Label = "custom pin",
                Address = "custom detail info"
            };

            mMyMap = MyMap;

            mMyMap.Pins.Clear();
            mMyMap.Pins.Add(pin);

            mMyMap.MoveToRegion(
            MapSpan.FromCenterAndRadius(
            new Position(51.99975, 4.9998), Distance.FromMeters(10)));

        }

        public string GetLocation(string latitude, string longitude)
        {
            throw new NotImplementedException();
        }

        void OnBackBtnClicked(object sender, EventArgs e)
        {
            avalable = false; 
            SendBackButtonPressed();
        } 

    }
}
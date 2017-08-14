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
        public static String mAddresInfo = "UNKNOWN";
        public static double Latitude = 0;
        public static double Longitude = 0;


        public MapPage()
        {
            InitializeComponent();
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
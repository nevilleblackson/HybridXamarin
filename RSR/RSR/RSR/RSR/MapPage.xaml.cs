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

        }
        void OnBackBtnClicked(object sender, EventArgs e)
        {
            base.SendBackButtonPressed();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RSR
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutApp : ContentPage
    {
        public AboutApp()
        {
            InitializeComponent();
        }
        void OnBackBtnClicked(object sender, EventArgs e)
        {
            base.SendBackButtonPressed();
        }
        void onWebLinkClicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.rsr.nl/"));
        }
    }
}
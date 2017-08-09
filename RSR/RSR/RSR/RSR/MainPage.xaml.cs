using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RSR
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
        }

        void onInfoIconClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AboutApp(), false);
        }

        public void StartMap(object sender, EventArgs args)
        {
           
        }

    }
}

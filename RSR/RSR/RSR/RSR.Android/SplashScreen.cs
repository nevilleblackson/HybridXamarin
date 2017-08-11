﻿
using Android.App;
using Android.Content;
using Android.OS;
using System.Threading.Tasks;
using Android.Support.V7.App;

namespace RSR.Droid
{

    [Activity(MainLauncher = true, NoHistory = true, Label = "RSR", Icon = "@drawable/ic_launcher", Theme = "@style/MyTheme.Splash")]
    public class SplashActivity : AppCompatActivity
    {
        //static readonly string TAG = "X:" + typeof(SplashActivity).Name;

        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnCreate(savedInstanceState, persistentState);
            //Log.Debug(TAG, "SplashActivity.OnCreate");
        }

        // Launches the startup task
        protected override void OnResume()
        {
            base.OnResume();
            Task startupWork = new Task(() => { SimulateStartup(); });
            startupWork.Start();
        }

        // Simulates background work that happens behind the splash screen
        void SimulateStartup()
        {
           StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}
using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace Android
{
    [Activity(Label = "Android", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/MyTheme")]
    public sealed class MainActivity : ActionBarActivity
    {
        public MainActivity()
        {
            Debug.StartMethodTracing("startup");
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }

        public override void OnAttachedToWindow()
        {
            base.OnAttachedToWindow();
            Debug.StopMethodTracing();
        }
    }
}


﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using GitAll.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace GitAll.Droid
{
    [Activity(Label = "GitAll", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            Plugin.Iconize.Iconize.With(new Plugin.Iconize.Fonts.FontAwesomeModule());

            global::Xamarin.Forms.Forms.Init(this, bundle);

            FormsPlugin.Iconize.Droid.IconControls.Init(Resource.Id.toolbar, Resource.Id.tabMode);
            
            LoadApplication(new App());            
        }
    }

    
}


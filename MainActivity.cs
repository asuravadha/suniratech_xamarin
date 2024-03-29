﻿using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using Android.Views;

namespace suniratech_xamarin
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            var listView = FindViewById<ListView>(Resource.Id.listView1);
            var data = new string[] { "Eswar", "hi", "mahanth", "shiv", "karan" };
            listView.Adapter = new ArrayAdapter(this, Resource.Layout.listview, data);


            var gridView = FindViewById<GridView>(Resource.Id.gridview1);
            gridView.Adapter = new ImageAdapter(this);
            gridView.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
              {
                  Toast.MakeText(this, args.Position.ToString(), ToastLength.Short).Show();
              };
           
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
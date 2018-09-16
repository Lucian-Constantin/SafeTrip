using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SafeTrip;

[Activity(Label = "Companies")]
public class Companies : Activity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        try
        {
            base.OnCreate(savedInstanceState);
            //SetContentView(Resource.Layout.Settings);
        }
        catch (Exception e)
        {
            AlertDialog.Builder dialog = new AlertDialog.Builder(this);
            AlertDialog alert = dialog.Create();
            alert.SetTitle(GetString(Resource.String.Error));
            alert.SetMessage(e.Message);
            alert.Show();
        }
    }
}
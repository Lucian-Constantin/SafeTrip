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

[Activity(Label = "Settings")]
public class Settings : Activity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.Trip);
        InitData();
    }

    private void InitData()
    {
        try
        {

        }
        catch (Exception e)
        {
            Android.App.AlertDialog.Builder dialog = new AlertDialog.Builder(this);
            AlertDialog alert = dialog.Create();
            alert.SetTitle(GetString(Resource.String.Error));
            alert.SetMessage(e.Message);
            alert.Show();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Gms.Maps;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SafeTrip;

[Activity(Label = "@string/YourTrip")]
public class Trip : Activity, IOnMapReadyCallback
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.Trip);
        InitData();
    }

    private void InitData()
    {
        //add controls - todo

        var mapFragment = (MapFragment)FragmentManager.FindFragmentById(Resource.Id.map);
        mapFragment.GetMapAsync(this);
    }

    public void OnMapReady(GoogleMap map)
    {
        // Do something with the map, i.e. add markers, move to a specific location, etc.
        map.MapType = GoogleMap.MapTypeNormal;
        map.UiSettings.ZoomControlsEnabled = true;
        map.UiSettings.CompassEnabled = false;


        // adding a marker with defined color - EXAMPLE :
        //MarkerOptions markerOpt1 = new MarkerOptions();
        //markerOpt1.SetPosition(new LatLng(50.379444, 2.773611));
        //markerOpt1.SetTitle("Vimy Ridge");

        //var bmDescriptor = BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueCyan);
        //markerOpt1.InvokeIcon(bmDescriptor);

        //map.AddMarker(markerOpt1);
    }
}
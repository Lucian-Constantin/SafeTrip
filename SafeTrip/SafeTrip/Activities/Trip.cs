using Android.App;
using Android.Gms.Maps;
using Android.OS;
using SafeTrip;
using System;

[Activity(Label = "@string/YourTrip")]
public class Trip : Activity, IOnMapReadyCallback
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        try
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Trip);
            InitData();
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
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using SafeTrip;
using System;
using Android.Content;
using AlertDialog = Android.App.AlertDialog;

[Activity(Theme = "@style/AppTheme", MainLauncher = true)]
public class Menu : AppCompatActivity
{
    Button btnStartTrip, btnHistory, btnComapnies, btnAbout, btnSettings, btnExit;
    TextView lblWelcome;

    protected override void OnCreate(Bundle savedInstanceState)
    {
        try
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Menu);
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
        try
        {
            btnStartTrip = FindViewById<Button>(Resource.Id.btnStartTrip);
            btnHistory = FindViewById<Button>(Resource.Id.btnViewHistory);
            btnComapnies = FindViewById<Button>(Resource.Id.btnCompanies);
            btnAbout = FindViewById<Button>(Resource.Id.btnAbout);
            btnSettings = FindViewById<Button>(Resource.Id.btnSettings);
            //lblWelcome = FindViewById<TextView>(Resource.Id.lblWelcome); - todo
            // btnExit - todo

            btnStartTrip.Click += BtnStartTrip_Click;
            btnHistory.Click += BtnHistory_Click;
            btnComapnies.Click += BtnCompanies_Click;
            btnAbout.Click += BtnAbout_Click;
            btnSettings.Click += BtnSettings_Click;
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

    private void BtnSettings_Click(object sender, EventArgs e)
    {
        try
        {
            var intent = new Intent(this, typeof(Settings));
            StartActivity(intent);
            Finish();
        }
        catch (Exception ex)
        {
            AlertDialog.Builder dialog = new AlertDialog.Builder(this);
            AlertDialog alert = dialog.Create();
            alert.SetTitle(GetString(Resource.String.Error));
            alert.SetMessage(ex.Message);
            alert.Show();
        }
    }

    private void BtnAbout_Click(object sender, EventArgs e)
    {
        try
        {
            //var intent = new Intent(this, typeof(About));
            //StartActivity(intent);
            //Finish();
        }
        catch (Exception ex)
        {
            AlertDialog.Builder dialog = new AlertDialog.Builder(this);
            AlertDialog alert = dialog.Create();
            alert.SetTitle(GetString(Resource.String.Error));
            alert.SetMessage(ex.Message);
            alert.Show();
        }
    }

    private void BtnCompanies_Click(object sender, EventArgs e)
    {
        try
        {
            var intent = new Intent(this, typeof(Companies));
            StartActivity(intent);
            Finish();
        }
        catch (Exception ex)
        {
            AlertDialog.Builder dialog = new AlertDialog.Builder(this);
            AlertDialog alert = dialog.Create();
            alert.SetTitle(GetString(Resource.String.Error));
            alert.SetMessage(ex.Message);
            alert.Show();
        }
    }

    private void BtnHistory_Click(object sender, EventArgs e)
    {
        try
        {
            var intent = new Intent(this, typeof(History));
            StartActivity(intent);
            Finish();
        }
        catch (Exception ex)
        {
            AlertDialog.Builder dialog = new AlertDialog.Builder(this);
            AlertDialog alert = dialog.Create();
            alert.SetTitle(GetString(Resource.String.Error));
            alert.SetMessage(ex.Message);
            alert.Show();
        }
    }

    private void BtnStartTrip_Click(object sender, EventArgs e)
    {
        try
        {
            var intent = new Intent(this, typeof(Trip));
            StartActivity(intent);
            Finish();
        }
        catch (Exception ex)
        {
            AlertDialog.Builder dialog = new AlertDialog.Builder(this);
            AlertDialog alert = dialog.Create();
            alert.SetTitle(GetString(Resource.String.Error));
            alert.SetMessage(ex.Message);
            alert.Show();
        }
    }
}
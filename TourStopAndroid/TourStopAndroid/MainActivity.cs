using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
namespace TourStopAndroid
{
    [Activity(Label = "1st screen", MainLauncher = true, Icon = "@drawable/androidIcon")]
    public class MainActivity : Activity
    {
        //int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button1 = FindViewById<Button>(Resource.Id.callButton1);
            Button button2 = FindViewById<Button>(Resource.Id.callButton2);

            //Add delegate
            button1.Click += delegate {
                callNumber(button1.Text);
            };
			button2.Click += delegate {
                callNumber(button2.Text);
			};
        }

        private void callNumber(string phoneNumber)
        {
            var callDialog = new AlertDialog.Builder(this);    
            callDialog.SetMessage("Call " + phoneNumber);
            callDialog.SetPositiveButton("Call ", delegate {
                var callIntent = new Intent(Intent.ActionCall);
                callIntent.SetData(Android.Net.Uri.Parse("tel:" + phoneNumber));
                StartActivity(callIntent);
            });
            callDialog.SetNegativeButton("Cancel", delegate {
                
            });
            callDialog.Show();
        }
    }
}


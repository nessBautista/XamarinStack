using Android.App;
using Android.Widget;
using Android.OS;
using Android.Text;
using System;

namespace Xamarin_Android_02_lifeCycle
{
    [Activity(Label = "Xamarin_Android_02_lifeCycle", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        public static String globalMessage = "Ready" + "\n";
        TextView txtText;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //Get UI elements
            Button button = FindViewById<Button>(Resource.Id.myButton);
            button.Click += delegate { button.Text = $"{count++} clicks!"; };

            Button btnRun = FindViewById<Button>(Resource.Id.run_button);
            btnRun.Click += delegate {
                Console.WriteLine("RUN");
            };
            txtText = FindViewById<TextView>(Resource.Id.txtLog);

            //Start logs

            logMessage("OnCreate");
        }

        protected override void OnPause()
        {
            base.OnPause();
            logMessage("OnPause");
        }

        protected override void OnResume()
        {
            base.OnResume();
            logMessage("OnResume");
        }

        protected override void OnStop()
        {
            base.OnStop();
            logMessage("OnStop");
        }

        protected override void OnStart()
        {
            base.OnStart();
            logMessage("OnStart");
        }

        private void logMessage(String Message)
        {
            //Write to console
            Console.WriteLine(Message);

            //Update textview
            //globalMessage = globalMessage + Message + "\n";
            //txtText.Text = globalMessage;
			txtText.Append(Message + "\n");

			//TODO: Need to configure layouts

			//ScrollDown 
			//Layout layout = txtText.Layout;
			//if (layout != null){
			//    //int scrollAmount = layout.getLineTop(mLog.getLineCount()) - mLog.getHeight();
			//    int scrollAmount = layout.GetLineTop(txtText.LineCount) - txtText.Height;
			//    txtText.ScrollTo(0, scrollAmount > 0 ? scrollAmount : 0);
			//}
		}
    }
}


using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content.Res;
using Android.Content;


namespace Xamarin_Android_03_listviews
{
    [Activity(Label = "Xamarin_Android_03_listviews", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected ListView ListView;		
		string[] items = Application.Context.Resources.GetStringArray(Resource.Array.clothing);
 
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, items);
            ListView = (Android.Widget.ListView) FindViewById(Resource.Id.listView);
            ListView.Adapter = adapter;
        }
    }
}


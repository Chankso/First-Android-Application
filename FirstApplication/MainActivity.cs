using Android.App;
using Android.Widget;
using Android.OS;

namespace FirstApplication
{
    [Activity(MainLauncher = true)]
    public class MainActivity : Activity
    {
        int count = 1;
        int count2 = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
           



        }
    }
}


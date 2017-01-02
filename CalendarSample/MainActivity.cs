using Android.App;
using MaterialCalendarLibrary;
using Android.OS;

namespace CalendarSample
{
    [Activity(Label = "Calendar Sample", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            var calendar = FindViewById<MaterialCalendarView>(Resource.Id.calendarView);

        }
    }
}


using Android.App;
using Android.Content.PM;
using Android.OS;
using System.Threading;
using Android.Content;
using Android.Support.V7.App;
using Android.Util;
using System.Threading.Tasks;

namespace VizyonOne.Droid
{
    [Activity(Theme = "@style/MyTheme.Splash", Icon = "@drawable/vizyon_logo", MainLauncher = true, NoHistory = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class SplashActivity : AppCompatActivity
    {
        static readonly string TAG = "X:" + typeof(SplashActivity).Name;

        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnCreate(savedInstanceState, persistentState);
            Log.Debug(TAG, "SplashActivity.OnCreate");
        }

        protected override void OnResume()
        {
            base.OnResume();

            Task startupWork = new Task(() =>
            {
                Log.Debug(TAG, "Performing some startup work that takes a bit of time.");
                Task.Delay(5000);  // Simulate a bit of startup work.
                Log.Debug(TAG, "Working in the background - important stuff.");
            });

            startupWork.ContinueWith(t =>
            {
                Log.Debug(TAG, "Work is finished - start Activity1.");
                StartActivity(new Intent(Application.Context, typeof(MainActivity)));
            }, TaskScheduler.FromCurrentSynchronizationContext());

            startupWork.Start();
        }
    }

}
//using Android.App;
//using Android.Content.PM;
//using Android.OS;
//using System.Threading;
//using Android.Content;

//namespace VizyonOne.Droid
//{
//    [Activity(Label = "VizyonOne", Theme = "@android:style/Theme.Holo", Icon = "@drawable/vizyon_logo", MainLauncher = true, NoHistory = true,
//        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
//    public class SplashScreen : Activity
//    {
//        protected override void OnCreate(Bundle bundle)
//        {
//            base.OnCreate(bundle);
//            Thread.Sleep(3000);
//            var intent = new Intent(this, typeof(MainActivity));
//            StartActivity(intent);
//            Finish();
//        }
//    }
//}
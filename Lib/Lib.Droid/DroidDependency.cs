using Android.Util;

[assembly: Xamarin.Forms.Dependency(typeof(Lib.Droid.DroidDependency))]
namespace Lib.Droid
{
    class DroidDependency: IDependency
    {
        public void DoStuff()
        {
            Log.Info("STUFF", "Doing stuff on Android.");
        }
    }
}
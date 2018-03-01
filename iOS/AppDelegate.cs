using Foundation;
using UIKit;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace SQLiteNETSharedProject.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    namespace FormsExample.iOS
    {
        [Register("AppDelegate")]
        public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
        {
            public override bool FinishedLaunching(UIApplication app, NSDictionary options)
            {
                global::Xamarin.Forms.Forms.Init();

                AppCenter.Start("ae827c97-7c00-4fe2-8092-6fdbaa84d288",
                   typeof(Analytics), typeof(Crashes));

                LoadApplication(new App());

                Analytics.TrackEvent("SQLite App about to be started! 哈哈哈");

                // Newer version of Visual Studio for Mac and Visual Studio provide the
                // ENABLE_TEST_CLOUD compiler directive in the Debug configuration,
                // but not the Release configuration.
                #if ENABLE_TEST_CLOUD
                    Xamarin.Calabash.Start();
                #endif

                return base.FinishedLaunching(app, options);
            }
        }
    }

}



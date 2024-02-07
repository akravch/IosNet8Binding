namespace NativeLibrary.Consumer;

[Register("AppDelegate")]
public class AppDelegate : UIApplicationDelegate
{
    public override UIWindow? Window { get; set; }

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        Window = new UIWindow(UIScreen.MainScreen.Bounds);
        var vc = new UIViewController();
        vc.View!.AddSubview(new UILabel(Window!.Frame)
        {
            BackgroundColor = UIColor.SystemBackground,
            TextAlignment = UITextAlignment.Center,
            Text = NativeLibrary.Binding.Constants.PLCrashReporterException ?? "<null>",
            AutoresizingMask = UIViewAutoresizing.All,
        });
        Window.RootViewController = vc;
        Window.MakeKeyAndVisible();

        return true;
    }
}
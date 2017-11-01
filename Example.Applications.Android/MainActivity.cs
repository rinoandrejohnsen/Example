using Android.App;
using Android.Widget;
using Android.OS;
using DryIoc;
using Prism.DryIoc;

namespace Example.Applications.Android
{
    [Activity(Theme = "@style/Theme.NoTitle", Label = "Example.Applications.Android", MainLauncher = true)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            this.LoadApplication(new Example.Applications.App.App(new AndroidInitializer()));
        }
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainer container)
        {

        }
    }
}


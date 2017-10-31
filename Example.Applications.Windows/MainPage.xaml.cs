using DryIoc;
using Prism.DryIoc;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Example.Applications.Windows
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.LoadApplication(new Example.Applications.App.App(new UwpInitialer()));
        }
    }

    public class UwpInitialer : IPlatformInitializer
    {
        public void RegisterTypes(IContainer container)
        {

        }
    }
}

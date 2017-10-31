using Example.Modules.Sample.ViewModels;
using System;
using Xamarin.Forms;

namespace Example.Modules.Sample.Views
{
    public class SampleView : ContentPage
    {
        public SampleView(SampleViewModel sampleViewModel)
        {
            this.BindingContext = sampleViewModel ?? throw new ArgumentNullException(nameof(sampleViewModel));

            this.Content = new Label
            {
                Text = "Hello world! (From Sample Module)",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };
        }
    }
}

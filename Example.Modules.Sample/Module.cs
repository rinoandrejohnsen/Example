using DryIoc;
using Example.Commons.Infrastructure;
using Example.Modules.Sample.ViewModels;
using Example.Modules.Sample.Views;
using Prism.DryIoc;
using Prism.Modularity;

namespace Example.Modules.Sample
{
    public class Module : IModule
    {
        public Module(IContainer container)
        {
            this.Container = container;
        }

        private IContainer Container { get; set; }

        public void Initialize()
        {
            this.Container.Register<SampleViewModel>();

            this.Container.RegisterTypeForNavigation<SampleView>(ViewNames.SampleView);
        }
    }
}

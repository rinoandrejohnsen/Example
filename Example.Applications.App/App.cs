using Example.Commons.Infrastructure;
using Prism.DryIoc;
using Prism.Modularity;
using System;

namespace Example.Applications.App
{
    public class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override async void OnInitialized()
        {
            await this.NavigationService.NavigateAsync(ViewNames.SampleView);
        }

        protected override void RegisterTypes()
        {
            //Container.RegisterTypeForNavigation<MainPage>();

            //Container.RegisterTypeForNavigation<HomePage>();

            //Container.RegisterTypeForNavigation<DataEntryPage>();
        }

        protected override void ConfigureModuleCatalog()
        {
            Type sampleModuleType = typeof(Modules.Sample.Module);

            ModuleCatalog.AddModule(
                new ModuleInfo()
                {
                    ModuleName = sampleModuleType.Name,

                    ModuleType = sampleModuleType,

                    InitializationMode = InitializationMode.WhenAvailable
                });
        }
    }
}

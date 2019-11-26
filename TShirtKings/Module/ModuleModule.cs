using Prism.Ioc;
using Prism.Modularity;
using Module.Views;
using Module.ViewModels;

namespace Module
{
    public class ModuleModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
        }
    }
}

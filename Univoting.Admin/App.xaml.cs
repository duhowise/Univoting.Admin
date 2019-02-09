using System;
using Univoting.Admin.Views;
using Prism.Ioc;
using System.Windows;
using UniVoting.Data;
using UniVoting.Services;

namespace Univoting.Admin
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            try
            {
                containerRegistry.RegisterInstance(typeof(ElectionDbContext),new ElectionDbContext());
                containerRegistry.Register<IElectionConfigurationService, ElectionConfigurationService>();

            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message,e);
            }
        }
    }
}

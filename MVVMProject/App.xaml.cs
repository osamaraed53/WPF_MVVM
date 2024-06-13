using Microsoft.Extensions.DependencyInjection;
using MVVMProject.Models;
using MVVMProject.MVVM;
using MVVMProject.ViewModel;
using System;
using System.Windows;

namespace MVVMProject
{
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;

        public App()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<IHotel, Hotel>(serviceProvider => new Hotel("Osama Hotel"));

            services.AddSingleton<MainWindow>(provider => new MainWindow
            {
                DataContext = provider.GetRequiredService<MainViewModel>(),
            });

            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MakeReservationViewModel>();
            services.AddSingleton<ReservationListingViewModel>();
            services.AddSingleton<INavigationService, NavigationService>();
            services.AddSingleton<Func<Type, ViewModelBase>>(seviceProvider => ViewModelType => (ViewModelBase)seviceProvider.GetRequiredService(ViewModelType));


            _serviceProvider = services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();

            base.OnStartup(e);
        }
    }
}

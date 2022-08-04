using Prism;
using Prism.Ioc;
using System;
using System.IO;
using FlowerInventory.Services.Interfaces;
using FlowerInventory.Services;
using FlowerInventory.ViewModels;
using FlowerInventory.Views;
using Xamarin.Forms;
using Xamarin.Essentials.Interfaces;
using Xamarin.Essentials.Implementation;
using FlowerInventory.Models.Models;

namespace FlowerInventory
{
    public partial class App
    {
        private static Database database;

        public static Database Database
        {
            get {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "flower.db3))"));
                }
                return database;
            }
        }

        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/HomeMasterDetailPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<HomeMasterDetailPage, HomeMasterDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<ProductsPage, ProductsPageViewModel>();

            containerRegistry.Register<IProductsService, ProductsService>();
        }
    }
}

using Prism;
using Prism.Ioc;
using FlowerInventory.Services.Interfaces;
using FlowerInventory.Services;
using FlowerInventory.ViewModels;
using FlowerInventory.Views;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace FlowerInventory
{
    public partial class App
    {
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
            containerRegistry.RegisterForNavigation<BasketPage, HeaderPageViewModel>();
        }
    }
}

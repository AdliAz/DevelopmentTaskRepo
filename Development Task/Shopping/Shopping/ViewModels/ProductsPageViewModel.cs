using Newtonsoft.Json;
using Prism.Commands;
using Prism.Navigation;
using FlowerInventory.Models.Models;
using FlowerInventory.Services.Interfaces;
using FlowerInventory.Views;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;
using Xamarin.Essentials;

namespace FlowerInventory.ViewModels
{
    public class ProductsPageViewModel : ViewModelBase
    {
        #region Properties
        public IProductsService productsService;

        public IEnumerable<ProductModel> productsList;

        public IEnumerable<ProductModel> ProductsList
        {
            get => productsList;
            set => SetProperty(ref productsList, value);
        }


        #endregion

        #region Commands
        public ICommand ShowProductDetailsCommand { get; private set; }
        public ICommand AddNewFlower { get; set; }

        #endregion

        public ProductsPageViewModel(INavigationService navigationService, IProductsService productsService)
            : base(navigationService)
        {
           this.productsService = productsService;
            AddNewFlower = new DelegateCommand(AddFlower);
        }

        private void AddFlower()
        {
            Console.WriteLine(Preferences.Get("NewFlowerName", "Failed"));
            Console.WriteLine(Preferences.Get("NewFlowerQty", "Failed"));
            Console.WriteLine(Preferences.Get("NewFlowerPrice", "Failed"));
            ProductsList = productsService.AddList(Preferences.Get("NewFlowerName", "Failed"), 
                int.Parse(Preferences.Get("NewFlowerQty", "Failed")), 
                float.Parse(Preferences.Get("NewFlowerPrice", "Failed")));
            Preferences.Clear();
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
         
        }
        public override void Initialize(INavigationParameters parameters)
        {
            string categoryName = parameters.GetValue<string>("CategoryName");
            Title = categoryName;
            InitData(categoryName);
        }

        private void InitData(string categoryName)
        {
            ProductsList = productsService.GetProductsByGategoryName(categoryName);
        }
    }
}

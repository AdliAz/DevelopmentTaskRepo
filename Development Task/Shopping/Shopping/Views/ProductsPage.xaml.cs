using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Windows.Input;
using Xamarin.Essentials;
using System;

namespace FlowerInventory.Views
{
    public partial class ProductsPage : ContentPage
    {
        public ProductsPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            Preferences.Clear();
            Preferences.Set("NewFlowerName", NewFlowerName.Text);
            Preferences.Set("NewFlowerQty", NewFlowerQty.Text);
            Preferences.Set("NewFlowerPrice", NewFlowerPrice.Text);
            confirm_btn.IsVisible = true;
            lbl_AddConfirm.Text = "Confirm?";
        }

        private void confirm_btn_Clicked(object sender, EventArgs e)
        {
            confirm_btn.IsVisible = false;
            NewFlowerName.Text = "";
            NewFlowerQty.Text = "";
            NewFlowerPrice.Text = "";
            NewFlowerName.Placeholder = "Flower Name";
            NewFlowerQty.Placeholder = "Quantity";
            NewFlowerPrice.Placeholder = "Price";
            lbl_AddConfirm.Text = "New Flower has been Added";
        }
    }
}

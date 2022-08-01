using Xamarin.Forms;
using FlowerInventory.Services;

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
            Btn_AddConfirm.Text = "Flower had been added";
            entryName.Text = "";
            entryName.Placeholder = "Flower Name";
            entryQty.Text = "";
            entryQty.Placeholder = "Quantity";
            entryPrice.Text = "";
            entryPrice.Placeholder = "Price";

        }
    }
}

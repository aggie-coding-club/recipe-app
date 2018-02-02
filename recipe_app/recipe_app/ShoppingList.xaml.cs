using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace recipe_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShoppingList : ContentPage
    {
        public ShoppingList()
        {
            InitializeComponent();

            IngredientList.ItemsSource = new List<string>
            {
                "Item 1", "Item 2", "Item 3"
            };
        }
    }
}
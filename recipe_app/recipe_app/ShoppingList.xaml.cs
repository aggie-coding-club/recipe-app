using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

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
            Ingredient temp = new Ingredient { IName = "Pepperoni", ICount = 1};
            temp.IName = "Pepperone";
            ObservableCollection<Ingredient> IList = new ObservableCollection<Ingredient>();    //Creates updateable list of Ingredients
            IngredientList.ItemsSource = IList; //Sets ItemSource to IList
            IList.Add(temp);    //Adds temp
            IList.Add(new Ingredient { IName = "Water", ICount = 3 }); //Adds new ingredient called "Apples"
            for ( int  i = 0; i < 50; i++)
            {
                IList.Add(new Ingredient { IName = "Apples", ICount = 12 });
            }
        }
    }
}
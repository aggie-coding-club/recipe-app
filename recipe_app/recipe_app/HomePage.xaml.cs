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
	public partial class HomePage : CarouselPage
	{
		public HomePage ()
		{
			InitializeComponent ();

            new CarouselPage
            {
                Children =
                 {
                    new Pantry(),
                    new Suggestions(),
                    new ShoppingList()
                 }
            };
        }
	}
}
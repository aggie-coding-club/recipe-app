using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recipe_app
{
    class Ingredient   
    {
        public string IName { get; set; }       //Name of ingreident
        public string ICategory { get; set; }   //Ingredient Category
        public int ICount { get; set; }        //Quantity of Ingredient
        public string ICountType { get; set; }  //Type of quantity (oz, lb, g, l, etc.)
    }
}

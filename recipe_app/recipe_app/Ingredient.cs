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
         public bool InList { get; set; }    //Boolean true if ingredient is in shopping list
         public bool InPantry { get; set; }  //Boolean true if ingredient is in pantry

         public Ingredient() //Default constructor with null/invalid values which will be later ignored
        {
            IName = "null";
            ICategory = "null";
            ICount = -1;
            ICountType = "null";
            InPantry = true;
            InList = true;
        }

         public void MoveToPantry()  //Function to move item to pantry
        {
            InPantry = true;
            InList = false;
        }

         public void MoveToList()    //Function to move item to list
        {
            InPantry = false;
            InList = true;
        }
    }   
}

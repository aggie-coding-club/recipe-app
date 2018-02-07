using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recipe_app
{
    class Recipe
    {
        public string RName { get; set; }  //Name of recipe
        public double Rating { get; set; }
        public int RatingCount = 0;
        public int CookTime { get; set; }   //Cooking time (minutes)
        public string FullRecipe { get; set; }  //Full text of recipe
        public string[] Requirements { get; set; }  //Full list of ingredients
        public double Difficulty { get; set; } //Difficulty of recipe
        public string[] Images { get; set; } //array containing names of all images
        public string Author { get; set; } //Author of recipe

        public void UpdateRating(int NewRating)    //Updates rating
        {
            double temp = Math.Floor(RatingCount * Rating);
            Rating = (temp + NewRating) / (RatingCount + 1);
            if (RatingCount >= 100)
            {
                RatingCount = 100;
            }
            else
            {
                RatingCount++;
            }
        }

    }
}

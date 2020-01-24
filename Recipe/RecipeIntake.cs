using System;
using System.Collections.Generic;
using System.Text;

namespace Recipe
{
    /// <summary>
    /// This is a Recipe collection program 
    /// Where all family members can drop thier recipes
    /// It will have number of recipes submitted, mostpopular and lesspopular 
    /// </summary>
    class RecipeIntake
    {
        #region Properties
        public String RecipeName { get; set; }
        public string RecipeCatagory { get; set; }
        public String SubmittedBy { get; set; }
        public string EmailAddress { get; set; }
        public int NumbeOfIngredients { get; set; }
        #endregion
    }
}

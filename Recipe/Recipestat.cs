using System;
using System.Collections.Generic;
using System.Text;

namespace Recipe
{
    /// <summary>
    /// This calss is for getting the overall stats for recipes that have been submitted 
    /// </summary>
    class Recipestat

    {
        #region
        public int NumberOfRecipesTotal { get; set; }
        public int MostPopularRecipe { get; set; }
        public int LessPopularRecipe { get; set; }
        #endregion
    }

}

using System;

namespace Recipe
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyRecipe = new Recipe();
            
            Console.WriteLine($"RN:{MyRecipe.RecipeName},Ing:{MyRecipe.Ingridents},RT:{MyRecipe.RecType}, RI:{MyRecipe.Instructions},TTK:{MyRecipe.TimeToCook},AUID:{MyRecipe.AuthorID},EA:{MyRecipe.Emailaddress}");
            
            
        }
    }
}

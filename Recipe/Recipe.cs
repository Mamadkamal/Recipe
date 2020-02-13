using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace Recipes
{
    /// <summary>
    /// This is a Recipe collection program 
    /// Where all family members can drop thier recipes
    /// It will have number of recipes submitted, mostpopular and lesspopular 
    /// </summary>
    enum TypeOfRecipes
    {
        Breakfast,
        Lunch,
        Dinner,
        Desert,
        Appetizer,
        Snack
    }
    class Recipe
    {
      
        #region Properties  
        public string Recipename { get; set; }
        public TypeOfRecipes RecType { get; set; }
        public string AuthorId { get; set; }
        public string Emailaddress { get; set; }
        public int TotalTime { get; set; }
        public int complexity { get; set; }
        public string Instructions { get; set; }
        public int Ingredints{ get; set; }


    }

    }

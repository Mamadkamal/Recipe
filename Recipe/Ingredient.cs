using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes

{
    /// <summary>
    /// This calss is for ingredints collection 
    enum MeasurmentType
    {
        cup, 
        tsp, 
        Tbs, 
        pound, 
        gram, 
        liter, 
        gallon, 
        lbs 
    };

    enum MeasureValue
    {
        1,
        2, 
        3, 
        4, 
        5
    };
    class Ingredient
    { 
        #region
    public MeasurmentType Measure { get; set; }
    public MeasureValue meaureval { get; set; }
    public string Name { get; set; }

        #endregion
    }
    /// Method
    

}

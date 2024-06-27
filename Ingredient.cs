﻿using System;

namespace RecipeAppGUI
{
    
    public class Ingredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public int Calories { get; set; }
        public string FoodGroup { get; set; }

        public Ingredient(string name, double quantity, string unit, int calories, string foodGroup)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
            Calories = calories;
            FoodGroup = foodGroup;
        }

        public override string ToString()
        {
            return $"{Quantity} {Unit} of {Name}, {Calories} calories, Food Group: {FoodGroup}";
        }
    }
}

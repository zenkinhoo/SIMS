// File:    RecipeRepository.cs
// Author:  Lenovo T450
// Created: Thursday, April 15, 2021 1:06:06 PM
// Purpose: Definition of Class RecipeRepository

using System;
using System.Collections.Generic;
using Bolnica.Model;
namespace Bolnica.Repository
{
   public class RecipeRepository
   {
        private String fileLocation = @"recipes.txt";

        public List<Recipe> GetAll()
      {
            List<Recipe> recipes = new List<Recipe>();

            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                int id = Convert.ToInt32(fields[0]);
                string medicine = fields[1];
                double quantity = Convert.ToDouble(fields[2]);
                string instruction = fields[3];
                int howOften = Convert.ToInt32(fields[4]);
                string startTime = fields[5];

                Recipe recipe = new Recipe(id, medicine, quantity, instruction, howOften, startTime);
                recipes.Add(recipe);
            }
            return recipes;
        }
        public List<Recipe> getAllRecipesFromSpecificMedicalCardById(int id)
        {
            List<Recipe> recipes = new List<Recipe>();
            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                if (Convert.ToInt32(fields[0]) == id)
                {
                    recipes.Add(new Recipe(Convert.ToInt32(fields[0]), fields[1], Convert.ToInt32(fields[2]), fields[3] , Convert.ToInt32(fields[4]), fields[5]));
                }
            }
            return recipes;
        }
        public Recipe GetOne(int id)
      {
         throw new NotImplementedException();
      }
      
      public Recipe Save(Recipe newRecipe)
      {
         throw new NotImplementedException();
      }
      
      public bool Delete(Recipe recipe)
      {
         throw new NotImplementedException();
      }
   
   }
}
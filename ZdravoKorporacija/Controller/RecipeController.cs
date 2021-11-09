// File:    RecipeController.cs
// Author:  Aleksandra
// Created: Sunday, April 18, 2021 6:19:33 AM
// Purpose: Definition of Class RecipeController

using System;
using System.Collections.Generic;
using Bolnica.Model;
using Bolnica.Service;

namespace Bolnica.Controller
{
   public class RecipeController
   {
        public RecipeService recipeService = new RecipeService();
        public List<Recipe> ReadAll()
      {
            List<Recipe> recipes = recipeService.ReadAll();
            return recipes;
      }

        

    }
}
// File:    RecipeService.cs
// Author:  Aleksandra
// Created: Sunday, April 18, 2021 6:14:39 AM
// Purpose: Definition of Class RecipeService

using System;
using System.Collections.Generic;
using Bolnica.Model;
using Bolnica.Repository;
namespace Bolnica.Service
{
   public class RecipeService
   {
        public RecipeRepository recipeRepository = new RecipeRepository();
        public List<Recipe> ReadAll()
      {
            List<Recipe> recipes = recipeRepository.GetAll();
            return recipes;
      }
      
   
   
   }
}
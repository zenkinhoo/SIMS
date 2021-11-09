
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolnica.Model;
using System.Windows;
using Bolnica.Repository;
using Bolnica;

namespace Bolnica.Service
{
   public class MedicalCardService
    {
        MedicalCardRepository medicalCardRepository = new MedicalCardRepository();
      public List<MedicalCard> GetAllMedicalCards()
      {
         throw new NotImplementedException();
      }
      
      public MedicalCard GetOneById(int id)
      {
            return medicalCardRepository.getOne(id);
      }
      
      public MedicalCard Save(MedicalCard medicalCard)
      {
         throw new NotImplementedException();
      }
      
      public bool Delete(MedicalCard medicalCard)
      {
         throw new NotImplementedException();
      }
      
      public Anamnesis WriteAnamnesis(Anamnesis newAnamnesis)
      {
          throw new NotImplementedException();
      }
      
      public List<Anamnesis> GetAllAnamnesis()
      {
            return anamnesisRepository.getAll();
        }
      
      public List<Anamnesis> GetAllAnamnesisByMedicalCard(int id)
      {
          throw new NotImplementedException();
      }
      
      public Anamnesis GetOneAnamnesisById(int id)
      {
          throw new NotImplementedException();
      }
      
      public Anamnesis UpdateAnamnesis(Anamnesis newAnamnesis)
      {
          throw new NotImplementedException();
      }
      
      public List<Recipe> GetAllRecipes()
      {
            return recipeRepository.GetAll();
        }
      
      public List<MedicalInstruction> GetAllMedicalInstructions()
      {
            return medicalInstructionRepository.GetAllMedicalInstructions();
      }
        public List<MedicalInstruction> GetAllSpecificTreatmentMedicalInstructions(MedicalInstructionType requestedTreatmentType)
        {
            return medicalInstructionRepository.GetAllSpecificTreatmentMedicalInstructions(requestedTreatmentType);
        }

        public AnamnesisRepository anamnesisRepository = new AnamnesisRepository();
      public MedicalInstructionRepository medicalInstructionRepository = new MedicalInstructionRepository();
      public RecipeRepository recipeRepository = new RecipeRepository();
   
   }
}


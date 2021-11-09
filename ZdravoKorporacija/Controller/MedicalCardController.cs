using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolnica.Service;
using Bolnica.Model;

namespace Bolnica.Controller
{
   public class MedicalCardController
   {
      public List<MedicalCard> GetAllMedicalCards()
      {
         throw new NotImplementedException();
      }
      
      public MedicalCard GetOneById(int id)
      {
            return medicalCardService.GetOneById(id);
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
            return medicalCardService.GetAllAnamnesis();
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
            return medicalCardService.GetAllRecipes();
      }
      
      public List<MedicalInstruction> GetAllMedicalInstructions()
      {
            return medicalCardService.GetAllMedicalInstructions();
      }
        public List<MedicalInstruction> GetAllSpecificTreatmentMedicalInstructions(MedicalInstructionType requestedTreatmentType)
        {
            return medicalCardService.GetAllSpecificTreatmentMedicalInstructions(requestedTreatmentType);
        }

        public Bolnica.Service.MedicalCardService medicalCardService = new MedicalCardService();
   
   }
}


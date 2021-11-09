using System;
using Bolnica.Repository;
using System.Collections.Generic;
using Bolnica.Model;

namespace Bolnica.Model
{
    public class MedicalCard
    {
        public int Id { get; set; }
        private List<Allergen> allergens = new List<Allergen>();
        private List<Anamnesis> anamnesiss = new List<Anamnesis>();
        Patient patient = new Patient();

        private List<Recipe> recipes = new List<Recipe>();
        private List<MedicalInstruction> medicalInstructions = new List<MedicalInstruction>();

      //  private PatientRepository patientRepository = new PatientRepository();
        private AllergenRepository allergenRepository = new AllergenRepository();
        private AnamnesisRepository anamnesisRepository = new AnamnesisRepository();
        private RecipeRepository recipeRepository = new RecipeRepository();
        private MedicalInstructionRepository medicalInstructionRepository = new MedicalInstructionRepository();
        public MedicalCard() { }
        public MedicalCard(int id)
        {
            this.Id = id;
            this.allergens = allergenRepository.getAllByMedicalCardId(id);
            this.anamnesiss = anamnesisRepository.getAllAnamenesisFromSpecificMedicalCardById(id);
            this.recipes = recipeRepository.getAllRecipesFromSpecificMedicalCardById(id);
            this.medicalInstructions = medicalInstructionRepository.getAllMedicalInstructionsFromSpecificMedicalCardById(id);
        }
    }
}
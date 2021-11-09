
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolnica.Model;

namespace Bolnica.Repository
{
    public class AllergenRepository
    {
        private String fileLocation = @"allergens.txt";

        public AllergenRepository() { }
        public List<Allergen> getAll()
        {
            List<Allergen> allergens = new List<Allergen>();
            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                allergens.Add(new Allergen(Convert.ToInt32(fields[0]), Convert.ToInt32(fields[1]), fields[2]));
            }
            return allergens;
        }
        public List<Allergen> getAllByMedicalCardId(int id)
        {
            List<Allergen> allergens = new List<Allergen>();
            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                if (Convert.ToInt32(fields[1]) == id)
                {
                    allergens.Add(new Allergen(Convert.ToInt32(fields[0]), Convert.ToInt32(fields[1]), fields[2]));
                }
            }
            return allergens;
        }


        public Allergen GetOne(int id)
      {
         throw new NotImplementedException();
      }
      
      public Allergen Save(Allergen newAlergen)
      {
         throw new NotImplementedException();
      }
      
      public bool Delete(Allergen alergen)
      {
         throw new NotImplementedException();
      }
      
      public Allergen Update(Allergen newAlergen)
      {
         throw new NotImplementedException();
      }
   
   }
}


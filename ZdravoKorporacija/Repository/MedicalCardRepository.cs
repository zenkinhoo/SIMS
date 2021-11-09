using System;
using Bolnica.Model;
using System.IO;
using System.Collections.Generic;
namespace Bolnica.Repository
{
    public class MedicalCardRepository
    {
        private String fileLocation = @"medicalCards.txt";

        public MedicalCardRepository() { }
        public MedicalCard getOne(int id)
        {
            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                if (Convert.ToInt32(line[0]) == id) return (new MedicalCard(id));
            }
            return null;
        }
        public List<MedicalCard> getAll()
        {
            List<MedicalCard> medicalCards = new List<MedicalCard>();
            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                if (line == "") continue;
                medicalCards.Add(new MedicalCard(Convert.ToInt32(line[0])));
            }
            return medicalCards;
        }
    
      
      public MedicalCard Save(MedicalCard medicalCard)
      {
         throw new NotImplementedException();
      }
      
      public bool Delete(MedicalCard medicalCard)
      {
         throw new NotImplementedException();
      }
      
     
   
   }

}
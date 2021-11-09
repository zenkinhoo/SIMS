
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolnica.Model;

namespace Bolnica.Repository
{
    public class AnamnesisRepository
    {
        private String fileLocation = @"anamnesis.txt";

        public AnamnesisRepository() { }
        public List<Anamnesis> getAllAnamenesisFromSpecificMedicalCardById(int id)
        {
            List<Anamnesis> anamnesis = new List<Anamnesis>();
            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                if (Convert.ToInt32(fields[1]) == id)
                {
                    anamnesis.Add(new Anamnesis(Convert.ToInt32(fields[0]), Convert.ToInt32(fields[1]), fields[2], Convert.ToDateTime(fields[3])));
                }
            }
            return anamnesis;
        }


        public Anamnesis GetOne(int id)
      {
         throw new NotImplementedException();
      }
      
      public Anamnesis Save(Anamnesis newAnamnesis)
      {
         throw new NotImplementedException();
      }
      
      public bool Delete(Anamnesis anamnesis)
      {
         throw new NotImplementedException();
      }
      
      public Anamnesis Update(Anamnesis newAnamnesis)
      {
         throw new NotImplementedException();
      }


        public List<Anamnesis> getAll()
        {
            List<Anamnesis> anamnesis = new List<Anamnesis>();
            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                anamnesis.Add(new Anamnesis(Convert.ToInt32(fields[0]), Convert.ToInt32(fields[1]), fields[2], Convert.ToDateTime(fields[3])));
            }
            return anamnesis;
        }

    }
}


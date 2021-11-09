/***********************************************************************
 * Module:  ExaminationFileStorage.cs
 * Author:  Acer
 * Purpose: Definition of the Class ExaminationFileStorage
 ***********************************************************************/

using System;
using System.Collections.Generic;
using Bolnica.Model;

namespace Bolnica.Repository
{
   public class MedicalInstructionRepository
   {
        private String fileLocation = @"medicalInstructions.txt";

        public List<MedicalInstruction> GetAllMedicalInstructions()
      {
            List<MedicalInstruction> instructions= new List<MedicalInstruction>();

            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                if (line == "")
                {
                    continue;
                }
                string[] fields = line.Split(',');
                int id = Convert.ToInt32(fields[0]);
                int idPatient = Convert.ToInt32(fields[1]);
                int idDoctor = Convert.ToInt32(fields[2]);
                String instruction = fields[3].ToString();
                MedicalInstructionType treatmentType = (MedicalInstructionType)Enum.Parse(typeof(MedicalInstructionType), fields[4]);
                bool used = Convert.ToBoolean(fields[5]);

                MedicalInstruction medicalInstruction = new MedicalInstruction(id,idPatient,idDoctor,instruction,treatmentType,used);
                instructions.Add(medicalInstruction);
            }
            return instructions;
        }
        public List<MedicalInstruction> GetAllSpecificTreatmentMedicalInstructions(MedicalInstructionType requestedTreatmentType)
        {
            List<MedicalInstruction> instructions = new List<MedicalInstruction>();

            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                if (line == "")
                {
                    continue;
                }
                string[] fields = line.Split(',');
                MedicalInstructionType treatmentType = (MedicalInstructionType)Enum.Parse(typeof(MedicalInstructionType), fields[4]);
                if (treatmentType == requestedTreatmentType)
                {
                    instructions.Add(new MedicalInstruction(Convert.ToInt32(fields[0]), Convert.ToInt32(fields[1]), Convert.ToInt32(fields[2]), fields[3], treatmentType, Convert.ToBoolean(fields[5])));
                }
            }
            return instructions;
        }
        public List<MedicalInstruction> getAllMedicalInstructionsFromSpecificMedicalCardById(int id)
        {
            List<MedicalInstruction> instructions = new List<MedicalInstruction>();
            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                if (line == "")
                {
                    continue;
                }
                MedicalInstructionType treatmentType = (MedicalInstructionType)Enum.Parse(typeof(MedicalInstructionType), fields[4]);
                if (Convert.ToInt32(fields[0]) == id)
                {
                    instructions.Add(new MedicalInstruction(Convert.ToInt32(fields[0]), Convert.ToInt32(fields[1]), Convert.ToInt32(fields[2]), fields[3],treatmentType , Convert.ToBoolean(fields[5])));
                }
            }
            return instructions;
        }

        public void InstructionExpired(int id) // ne moze vise puta da koristi isti uput
        {
            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            int i = 0;
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                if (line == "")
                {
                    continue;
                }
                int idInstruction = Convert.ToInt32(fields[0]);

                if (idInstruction == id)
                {
                    int idPatient = Convert.ToInt32(fields[1]);
                    int idDoctor = Convert.ToInt32(fields[2]);
                    String instruction = fields[3].ToString();
                    MedicalInstructionType treatmentType = (MedicalInstructionType)Enum.Parse(typeof(MedicalInstructionType), fields[4]);
                    bool used = true;
                    lines[i] = idInstruction.ToString() + "," + idPatient.ToString() + "," + idDoctor.ToString() + "," + instruction.ToString() + "," +"," + treatmentType.ToString() + "," + used.ToString();
                    break;
                }
                i++;
            }
            System.IO.File.WriteAllLines(fileLocation, lines);
        }

        public MedicalInstruction GetOne(int id)
      {
         throw new NotImplementedException();
      }
      
      public MedicalInstruction Save(MedicalInstruction newMedicalInstruction)
      {
         throw new NotImplementedException();
      }
      
      public bool Delete(MedicalInstruction medicalInstruction)
      {
         throw new NotImplementedException();
      }
   
   }
}
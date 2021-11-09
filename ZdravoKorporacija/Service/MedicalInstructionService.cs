// File:    MedicalInstructionService.cs
// Author:  Lenovo T450
// Created: Sunday, May 2, 2021 11:51:42 PM
// Purpose: Definition of Class MedicalInstructionService

using System;
using System.Collections.Generic;
using Bolnica.Model;
using Bolnica.Repository;

namespace Bolnica.Service
{
   public class MedicalInstructionService
   {
      public List<MedicalInstruction> GetAllMedicalInstructions()
      {
            return medicalInstructionRepository.GetAllMedicalInstructions();
      }
     public List<MedicalInstruction> GetAllSpecificTreatmentMedicalInstructions(MedicalInstructionType requestedTreatmentType)
        {
            return medicalInstructionRepository.GetAllSpecificTreatmentMedicalInstructions(requestedTreatmentType);
        }


      public int doctorExistsInMedicalInstruction(Doctor doc)
        {
           // int ret = -1
            List<MedicalInstruction> medicalInstructions = medicalInstructionRepository.GetAllMedicalInstructions();
            foreach(MedicalInstruction mi in medicalInstructions)
            {
 
                if (doc.user.id==mi.idDoctor)
                {
                    return mi.id;
                }
            }
            return -1;
        }
        public void InstructionExpired(int id)
        {
             medicalInstructionRepository.InstructionExpired(id);
        }



        public Bolnica.Repository.MedicalInstructionRepository medicalInstructionRepository = new Repository.MedicalInstructionRepository();
   
   }
}
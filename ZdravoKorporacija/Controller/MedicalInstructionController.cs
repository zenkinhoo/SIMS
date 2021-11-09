// File:    MedicalInstructionController.cs
// Author:  Lenovo T450
// Created: Sunday, May 2, 2021 11:54:33 PM
// Purpose: Definition of Class MedicalInstructionController

using System;
using System.Collections.Generic;
using Bolnica.Model;

namespace Bolnica.Controller
{
   public class MedicalInstructionController
   {
      public List<MedicalInstruction> GetAllMedicalInstructions()
      {
            return medicalInstructionService.GetAllMedicalInstructions();
        }
        public List<MedicalInstruction> GetAllSpecificTreatmentMedicalInstructions(MedicalInstructionType requestedTreatmentType)
        {
            return medicalInstructionService.GetAllSpecificTreatmentMedicalInstructions(requestedTreatmentType);
        }
        public int doctorExistsInMedicalInstruction(Doctor doc)
        {
            return medicalInstructionService.doctorExistsInMedicalInstruction(doc);
        }
        public void InstructionExpired(int id)
        {
            medicalInstructionService.InstructionExpired(id);
        }
        public Bolnica.Service.MedicalInstructionService medicalInstructionService = new Service.MedicalInstructionService();
   
   }
}
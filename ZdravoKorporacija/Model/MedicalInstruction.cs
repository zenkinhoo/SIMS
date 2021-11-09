// File:    MedicalInstruction.cs
// Author:  Lenovo T450
// Created: Sunday, May 2, 2021 11:38:09 PM
// Purpose: Definition of Class MedicalInstruction

using System;

namespace Bolnica.Model
{
   public class MedicalInstruction
   {
      public int id;
      public int idPatient;
      public int idDoctor;
      public String instruction;
      public bool used;
      public MedicalInstructionType treatmentType;


      public Patient patient;
      public Doctor doctor;
        public MedicalInstruction()
        {

        }

        public MedicalInstruction(int id, int idPatient, int idDoctor, string instruction)
        {
            this.id = id;
            this.idPatient = idPatient;
            this.idDoctor = idDoctor;
            this.instruction = instruction;
            this.used = false;
        }
        public MedicalInstruction(int id, int idPatient, int idDoctor, string instruction,MedicalInstructionType treatmentType, bool used)
        {
            this.id = id;
            this.idPatient = idPatient;
            this.idDoctor = idDoctor;
            this.instruction = instruction;
            this.treatmentType = treatmentType;
            this.used = used;
        }

      
        public MedicalCard medicalCard;



       

    }
}
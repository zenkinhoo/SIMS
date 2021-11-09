// File:    Recipe.cs
// Author:  Lenovo T450
// Created: Thursday, April 15, 2021 12:39:59 PM
// Purpose: Definition of Class Recipe

using System;

namespace Bolnica.Model
{
   public class Recipe
   {
      public int id;
        public String medicine;
        public Double quantity;
        public String instruction;
        public Double howOften;
        public String startTime;
      
      public Patient patient;
        public Recipe(int id, String medicine, Double quantity, String instruction, Double howOften, String startTime)
        {
            this.id = id;
            this.medicine = medicine;
            this.quantity = quantity;
            this.instruction = instruction;
            this.howOften = howOften;
            this.startTime = startTime;
        }

 
        public MedicalCard medicalCard;

        public override string ToString()
        {
            return this.medicine + " " + this.quantity.ToString() + " " + this.howOften.ToString() + " " + this.startTime.ToString();
        }
    }
}
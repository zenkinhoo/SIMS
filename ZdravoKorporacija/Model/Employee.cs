// File:    Employee.cs
// Author:  Srdjan Topic
// Created: Sunday, March 28, 2021 2:16:24 PM
// Purpose: Definition of Class Employee

using System;

namespace Bolnica.Model
{
   public class Employee
   {
      public int salary { get; set; }
      public double workingHours { get; set; }
      public int annualLeave { get; set; }
      
      public User user { get; set; }
   
   }
}
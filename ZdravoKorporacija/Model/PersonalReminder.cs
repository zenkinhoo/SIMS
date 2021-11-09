// File:    PersonalReminder.cs
// Author:  Lenovo T450
// Created: Saturday, May 22, 2021 12:43:37 AM
// Purpose: Definition of Class PersonalReminder

using System;

namespace Bolnica.Model
{
   public class PersonalReminder
   {
        public int id;
        public String personalReminderName;
        public String personalReminderDescription;
        public DateTime remindingTime;
        public int remindingPeriod;
        public bool hasReminded;
        public Patient patient;
        public PersonalReminder() 
        { }
        public PersonalReminder(int id, string personalReminderName, string personalReminderDescription, DateTime remindingTime, int remindingPeriod, bool hasReminded)
        {
            this.id = id;
            this.personalReminderName = personalReminderName;
            this.personalReminderDescription = personalReminderDescription;
            this.remindingTime = remindingTime;
            this.remindingPeriod = remindingPeriod;
            this.hasReminded = hasReminded;
        }
       
        public override string ToString()
        {
            return id.ToString() + "," + personalReminderName.ToString() + "," + personalReminderDescription.ToString() + "," + remindingTime.ToString() + "," + remindingPeriod.ToString()+","+hasReminded.ToString();
        }
    }
}
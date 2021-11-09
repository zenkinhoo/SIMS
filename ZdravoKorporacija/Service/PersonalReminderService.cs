// File:    PersonalReminderService.cs
// Author:  Lenovo T450
// Created: Saturday, May 22, 2021 12:52:30 AM
// Purpose: Definition of Class PersonalReminderService

using System;
using Bolnica.Model;
using System.Collections.Generic;
using Bolnica.Repository;
using System.Windows;

namespace Bolnica.Service
{
   public class PersonalReminderService
   {
      public List<PersonalReminder> GetAllPersonalReminders()
      {
            return personalReminderRepository.GetAllPersonalReminders();
      }
      
      public PersonalReminder GetOnePersonalReminder(int personalReminderId)
      {
            return personalReminderRepository.GetOnePersonalReminder(personalReminderId);
      }

        public void SavePersonalReminder(PersonalReminder personalReminder)
        {
                personalReminderRepository.SavePersonalReminder(personalReminder);
        }

      public void DeletePersonalReminderByIndex(int index)
      {
            personalReminderRepository.DeletePersonalReminderByIndex(index);
      }
      
      public void UpdatePersonalReminder(PersonalReminder personalReminder)
      {
            personalReminderRepository.UpdatePersonalReminder(personalReminder);
      }

      public void remindAllPatients()
       {
            List<PersonalReminder> personalReminders = this.GetAllPersonalReminders();
           this.resetRemindingTimesBasedOnPeriod(personalReminders);
            foreach(PersonalReminder p in personalReminders)
            {
                remindOnePatient(p);
            }
        }

        private  void remindOnePatient(PersonalReminder p)
        {
            if (ifRemindingTime(p) && !p.hasReminded)
            {
                MessageBox.Show("Podsecamo vas na vas " + p.personalReminderName.ToString());
                p.hasReminded = true;
                this.UpdatePersonalReminder(p);
            }
        }
      

        private static bool ifRemindingTime(PersonalReminder p)
        {
            return DateTime.Now.Year == p.remindingTime.Year && DateTime.Now.Month >= p.remindingTime.Month && DateTime.Now.Day >= p.remindingTime.Day && DateTime.Now.Hour >= p.remindingTime.Hour && DateTime.Now.Minute >= p.remindingTime.Minute;
        }

        private void resetRemindingTimesBasedOnPeriod(List<PersonalReminder> personalReminders)
        {
            foreach (PersonalReminder p in personalReminders)
            {
                updateResetedPersonalReminder(p);
            }
        }

        private void updateResetedPersonalReminder(PersonalReminder p)
        {

            if (ifResetingReminderTime(p))
            {
                p.hasReminded = false;
                this.UpdatePersonalReminder(p);
            }
        }

        private static bool ifResetingReminderTime(PersonalReminder p)
        {
            return (DateTime.Now.Day % p.remindingPeriod) == (DateTime.Now.Day % p.remindingTime.Day) && DateTime.Today.Date == p.remindingTime;
        }

        public PersonalReminderRepository personalReminderRepository = new PersonalReminderRepository();
   
   }
}
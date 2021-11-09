// File:    PersonalReminderController.cs
// Author:  Lenovo T450
// Created: Saturday, May 22, 2021 12:54:05 AM
// Purpose: Definition of Class PersonalReminderController

using System;
using Bolnica.Model;
using System.Collections.Generic;
using Bolnica.Service;
using System.Windows;

namespace Bolnica.Controller
{
   public class PersonalReminderController
   {
        public List<PersonalReminder> GetAllPersonalReminders()
        {
            return personalReminderService.GetAllPersonalReminders();
        }

        public PersonalReminder GetOnePersonalReminder(int personalReminderId)
      {
            return personalReminderService.GetOnePersonalReminder(personalReminderId);
        }

        public void SavePersonalReminder(PersonalReminder personalReminder) 
        {
                personalReminderService.SavePersonalReminder(personalReminder);
                MessageBox.Show("Personal reminder successfully created!");
          
        }

        public void DeletePersonalReminderByIndex(int index)
        {
            try
            {
                personalReminderService.DeletePersonalReminderByIndex(index);
            }
            catch(ArgumentOutOfRangeException e)
            {
                MessageBox.Show("You must select one reminder");
            }
            
        }

        public void UpdatePersonalReminder(PersonalReminder personalReminder)
        {
            try
            {
                personalReminderService.UpdatePersonalReminder(personalReminder);
                MessageBox.Show("Personal reminder successfully updated!");
            }
              catch (ArgumentOutOfRangeException e)
            {
                MessageBox.Show("You must select one reminder");
            }
        }
        public void remindAllPatients()
        {
            personalReminderService.remindAllPatients();
        }

        public PersonalReminderService personalReminderService = new PersonalReminderService();
   
   }
}
/***********************************************************************
 * Module:  ExaminationFileStorage.cs
 * Author:  Acer
 * Purpose: Definition of the Class ExaminationFileStorage
 ***********************************************************************/

using System;
using Bolnica.Model;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
using System.Linq;

namespace Bolnica.Repository
{
   public class PersonalReminderRepository
   {
      private String fileLocation = @"personalReminders.txt";
      
      public List<PersonalReminder> GetAllPersonalReminders()
      {
            List<PersonalReminder> personalReminders = new List<PersonalReminder>();
            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                if (line == "") continue;
                personalReminders.Add(new PersonalReminder(Convert.ToInt32(fields[0]), fields[1], fields[2], Convert.ToDateTime(fields[3]), Convert.ToInt32(fields[4]), Convert.ToBoolean(fields[5])));
            }
            return personalReminders;
        }
      
      public PersonalReminder GetOnePersonalReminder(int personalReminderId)
      {
            PersonalReminder personalReminder = new PersonalReminder();
            string[] lines = File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                if (line == "") continue;
                if(Convert.ToInt32(fields[0]) == personalReminderId)
                {
                    return new PersonalReminder(Convert.ToInt32(fields[0]), fields[1], fields[2], Convert.ToDateTime(fields[3]), Convert.ToInt32(fields[4]),Convert.ToBoolean(fields[5]));
                }
            }
            return null;
        }

        public void SavePersonalReminder(PersonalReminder personalReminder)
      {
            int newId = GetAllPersonalReminders().Count+1;
            string newLine = "\n" + newId.ToString() + "," + personalReminder.personalReminderName + "," + personalReminder.personalReminderDescription + "," + personalReminder.remindingTime.ToString() + "," + personalReminder.remindingPeriod.ToString() + "," +personalReminder.hasReminded.ToString();
            System.IO.File.AppendAllText(fileLocation, newLine);
        }
      
      public void DeletePersonalReminderByIndex(int index)
      {
            List<string> linesFromFile = File.ReadAllLines(fileLocation).ToList();
            linesFromFile.RemoveAt(index);
            linesFromFile = linesFromFile.Where(s => s != "").ToList(); //uklanja prazne redove u listi stringova
            File.WriteAllLines(fileLocation, linesFromFile.ToList());
        }
      
      public void UpdatePersonalReminder(PersonalReminder personalReminder)
      {
            PersonalReminder oldPersonalReminder = this.GetOnePersonalReminder(personalReminder.id);
            String oldRow = oldPersonalReminder.ToString();
            String newRow = personalReminder.ToString();
            string[] lines = File.ReadAllLines(fileLocation);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == oldRow)
                {
                    lines[i] = newRow;
                    break;
                }
            }
            File.WriteAllLines(fileLocation, lines.ToArray());
        }
   
   }
}
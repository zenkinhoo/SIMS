/***********************************************************************
 * Module:  ExaminationFileStorage.cs
 * Author:  Acer
 * Purpose: Definition of the Class ExaminationFileStorage
 ***********************************************************************/

using System;
using Bolnica.Model;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Bolnica.Repository

{
   public class AppointmentHistoryRepository
   {
        private String fileLocation = @"appointmenthistory.txt";

        public List<MedicalAppointment> GetAllPastAppointments()
      {
            List<MedicalAppointment> appointments = new List<MedicalAppointment>();

            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                if (line == "")
                {
                    continue;
                }

                int id = Convert.ToInt32(fields[0]);
                int idPatient = Convert.ToInt32(fields[1]);
                int idDoctor = Convert.ToInt32(fields[2]);
                DateTime startTime = Convert.ToDateTime(fields[3]);
                double duration = Convert.ToDouble(fields[4]);

                AppointmentType type = (AppointmentType)Enum.Parse(typeof(AppointmentType), fields[5]);

                int idRoom = Convert.ToInt32(fields[6]);

                MedicalAppointment medicalAppointment = new MedicalAppointment(id, idPatient, idDoctor, startTime, duration, type, idRoom);
            //    if(!(medicalAppointment.startTime < DateTime.Today))
            //    {
                    appointments.Add(medicalAppointment);
            //    }
               
            }
            return appointments;
        }
      
      public MedicalAppointment GetOne(int id)
      {
         throw new NotImplementedException();
      }
      
      public MedicalAppointment Save(MedicalAppointment newAppointment)
      {
            string noviRed = "\n" + newAppointment.id + "," + newAppointment.patient.user.id + "," + newAppointment.doctor.user.id + "," + newAppointment.startTime + "," + newAppointment.durationInHoours + "," + newAppointment.type + "," + newAppointment.room.id;
            fileLocation = Regex.Replace(fileLocation, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline); //uklanja prazne redove u stringu
            System.IO.File.AppendAllText(fileLocation, noviRed);
            return newAppointment;
        }
      
      public bool Delete(MedicalAppointment appointment)
      {
         throw new NotImplementedException();
      }
   
   }
}
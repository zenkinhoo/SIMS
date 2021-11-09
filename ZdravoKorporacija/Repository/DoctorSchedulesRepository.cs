using System;
using System.Collections.Generic;
using System.IO;
using Bolnica.Model;
using Bolnica.Repository;
using System.IO;
using System.Windows;
namespace Bolnica.Repository
{
   public class DoctorSchedulesRepository
   {

      private String fileLocation=@"doctorSchedule.txt";
       
        public DoctorSchedulesRepository()
        {
            
        }
        

        public List<DoctorSchedules> GetAll()
      {
            List<DoctorSchedules> schedule = new List<DoctorSchedules>();

            string[] lines = System.IO.File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                if(line=="")
                {
                    continue;
                }
                string[] fields = line.Split(',');
                int id = Convert.ToInt32(fields[0]);
                DateTime startTime = Convert.ToDateTime(fields[1]);
                DateTime endTime = Convert.ToDateTime(fields[2]);

                DoctorSchedules doctorSchedules = new DoctorSchedules(id,startTime,endTime);
                schedule.Add(doctorSchedules);
            }
            return schedule;
        }
    
 


        public DoctorSchedules Save(DoctorSchedules newSchedule)
        {
            String newRow = "\n" + newSchedule.idDoctor + "," + newSchedule.startTime + "," + newSchedule.endTime;
            File.AppendAllText(fileLocation, newRow);
            return newSchedule;
        }



        public bool Delete(String schedule)
      {
         throw new NotImplementedException();
      }
   
   }
}
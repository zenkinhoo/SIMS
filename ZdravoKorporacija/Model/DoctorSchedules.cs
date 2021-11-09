using System;

namespace Bolnica.Model
{
   public class DoctorSchedules
   {

      public DoctorSchedules() { }
      
      public int idDoctor { get; set; }
      public DateTime startTime { get; set; }
      public DateTime endTime { get; set; }

      

       
        public DoctorSchedules(int idDoctor, DateTime startTime, DateTime endTime)
        {
            this.idDoctor = idDoctor;
            this.startTime = startTime;
            this.endTime = endTime;
        }
    }

}
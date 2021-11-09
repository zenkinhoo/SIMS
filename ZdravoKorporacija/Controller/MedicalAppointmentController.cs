using System;
using System.Collections.Generic;
using Bolnica.Model;
using Bolnica.Service;
namespace Bolnica.Controller
{
   public class MedicalAppointmentController
   {
        DoctorService doctorService = new DoctorService();
      public List<MedicalAppointment> PatientReadAll()
      {
         throw new NotImplementedException();
      }
      
      public List<MedicalAppointment> DoctorReadAll()
      {
         throw new NotImplementedException();
      }
        public void scheduleEmergencyAppointment(MedicalAppointment newMedicalAppointment)
        {
            medicalAppointmentService.scheduleEmergencyAppointment(newMedicalAppointment);
        }
        public Doctor findFreeDoctorAccordingType(String doctorType)
        {
            return medicalAppointmentService.findFreeDoctorAccordingType(doctorType);
        }

        public List<DateTime> FindFreeTerms(DateTime startPoint, DateTime endPoint, Bolnica.Model.Doctor doctor)
      {
            List<DateTime> slobodniTermini=new List<DateTime>();
            slobodniTermini=medicalAppointmentService.FindFreeTermsSecretary(startPoint,endPoint,doctor,"");
            return slobodniTermini;
      }
      
      public List<String> DoctorPriority()
      {
         throw new NotImplementedException();
      }
      
      public List<Doctor> TimePriority()
      {
         throw new NotImplementedException();
      }
      
      public MedicalAppointment ScheduleAppointment(Bolnica.Model.Doctor doctor, Bolnica.Model.Patient patient, Bolnica.Model.Room room, DateTime startTime, double duration, Bolnica.Model.AppointmentType type)
      {
            return medicalAppointmentService.ScheduleAppointment(doctor,patient,room,startTime,duration,type);
      }

        public bool CancelAppointment(MedicalAppointment appointment)
      {
            return medicalAppointmentService.CancelAppointment(appointment);
        }
      
      public MedicalAppointment UpdateAppointment(MedicalAppointment appointment)
      {
            return medicalAppointmentService.UpdateAppointment(appointment);
        }
      
      public bool CancelAppointmentByIndex(int index)
      {
            return medicalAppointmentService.CancelAppointmentByIndex(index);

      }
        public List<MedicalAppointment> getAllPastAppointments()
        {
            return medicalAppointmentService.getAllPastAppointments();
        }

        public bool IsRoomAvailable(Bolnica.Model.Room room, DateTime startTime)
      {
         throw new NotImplementedException();
      }
      
      public Bolnica.Service.MedicalAppointmentService medicalAppointmentService = new MedicalAppointmentService();
     
   }
}
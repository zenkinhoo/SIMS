using Bolnica.Model;
using Bolnica.Repository;
using System;

namespace Bolnica.Service
{
    public class AppointmentCrudCounterService
    {
        public int GetOneCounter(Patient patient)
        {
            return appointmentCrudCounterRepository.GetOneCounter(patient);
        }
        public void IncrementCounter(Patient patient)
        {
            appointmentCrudCounterRepository.IncrementCounter(patient);
        }
        public void SaveCounter(Patient patient, int counter)
        {
            appointmentCrudCounterRepository.SaveCounter(patient, counter);
        }
        public void ResetCounterPatient(Patient patient)
        {
            appointmentCrudCounterRepository.ResetCounter(patient);
        }
        public void disablePatient(Patient patient)
        {
            appointmentCrudCounterRepository.disablePatient(patient);
        }
        public bool resetTimePassed()
        {
            if ((new DateTime()).DayOfWeek == DayOfWeek.Sunday)
            {
                return true;
            }
            return false;
        }

        public AppointmentCrudCounterRepository appointmentCrudCounterRepository = new AppointmentCrudCounterRepository();
    }

}
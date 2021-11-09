using Bolnica.Model;
using System;

namespace Bolnica.Controller
{
    public class AppointmentCrudCounterController
    {
        public int GetOneCounter(Patient patient)
        {
            return appointmentCrudCounterService.GetOneCounter(patient);
        }
        public void IncrementCounter(Patient patient)
        {
            appointmentCrudCounterService.IncrementCounter(patient);
        }
        public void SaveCounter(Patient patient, int counter)
        {
            appointmentCrudCounterService.SaveCounter(patient, counter);
        }


        public void ResetCounter(Patient patient)
        {
            appointmentCrudCounterService.ResetCounterPatient(patient);
        }
        public void disablePatient(Patient patient)
        {
            appointmentCrudCounterService.disablePatient(patient);
        }

        public bool resetTimePassed()
        {
            return appointmentCrudCounterService.resetTimePassed();
        }

        public Bolnica.Service.AppointmentCrudCounterService appointmentCrudCounterService = new Service.AppointmentCrudCounterService();

    }
}
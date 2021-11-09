using System;
using System.Collections.Generic;
using Bolnica.Model;
using Bolnica.Repository;

namespace Bolnica.Model
{

    public class Patient
    {
        public Patient() {
        }

      public List<MedicalAppointment> medicalAppointment;
        public bool isDisabled;

        public Patient(String jmbg, int id, String firstName, String lastName, String phone, String adress, String password, String username,bool isDisabled)

        {
            User u = new User();
            u.jmbg = jmbg;
            u.id = id;
            u.firstName = firstName;
            u.lastName = lastName;
            u.phone = phone;
            u.adress = adress;
            u.password = password;
            u.username = username;
            this.isDisabled = isDisabled;
            this.user = u;
        }

        public User user { get; set; }

       

        public List<MedicalAppointment> MedicalAppointment
        {
            get
            {
                if (medicalAppointment == null)
                    medicalAppointment = new System.Collections.Generic.List<MedicalAppointment>();
                return medicalAppointment;
            }
            set
            {
                RemoveAllMedicalAppointment();
                if (value != null)
                {
                    foreach (MedicalAppointment oMedicalAppointment in value)
                        AddMedicalAppointment(oMedicalAppointment);
                }
            }
        }

        public void AddMedicalAppointment(MedicalAppointment newMedicalAppointment)
        {
            if (newMedicalAppointment == null)
                return;
            if (this.medicalAppointment == null)
                this.medicalAppointment = new System.Collections.Generic.List<MedicalAppointment>();
            if (!this.medicalAppointment.Contains(newMedicalAppointment))
            {
                this.medicalAppointment.Add(newMedicalAppointment);
                newMedicalAppointment.patient = this;
            }
        }
        public void RemoveMedicalAppointment(MedicalAppointment oldMedicalAppointment)
        {
            if (oldMedicalAppointment == null)
                return;
            if (this.medicalAppointment != null)
                if (this.medicalAppointment.Contains(oldMedicalAppointment))
                {
                    this.medicalAppointment.Remove(oldMedicalAppointment);
                    oldMedicalAppointment.patient = null;
                }
        }

        public void RemoveAllMedicalAppointment()
        {
            if (medicalAppointment != null)
            {
                System.Collections.ArrayList tmpMedicalAppointment = new System.Collections.ArrayList();
                foreach (MedicalAppointment oldMedicalAppointment in medicalAppointment)
                    tmpMedicalAppointment.Add(oldMedicalAppointment);
                medicalAppointment.Clear();
                foreach (MedicalAppointment oldMedicalAppointment in tmpMedicalAppointment)
                    oldMedicalAppointment.patient = null;
                tmpMedicalAppointment.Clear();
            }
        }
        public MedicalCard medicalCard;
        public System.Collections.Generic.List<Recipe> recipe;


      
     
        public AppointmentCrudCounter appointmentCrudCounter;
        


    }
}
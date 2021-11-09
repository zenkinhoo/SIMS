// File:    PatientController.cs
// Author:  Lenovo T450
// Created: Friday, April 16, 2021 8:17:22 PM
// Purpose: Definition of Class PatientController

using System;
using System.Collections.Generic;
using Bolnica.Model;
using Bolnica.Service;

namespace Bolnica.Controller
{

    public class PatientController
    {
        public Bolnica.Model.Patient MakeRegularAccount(Bolnica.Model.Patient newPatient)
        {
            throw new NotImplementedException();
        }
        public Patient FindByFirstAndLastName(String fistname, String lastname)
        {
            return patientService.FindByFirstAndLastName(fistname, lastname);
        }


        public void MakeGuestAccount(String firstName, String lastName, String jmbg)
        {
            patientService.MakeGuestAccount(firstName,lastName,jmbg);
        }

        public bool UpdatePatient(Bolnica.Model.Patient patient)
        {
            return patientService.Update(patient);
        }

        public List<Patient> ReadAll()
        {
            return patientService.ReadAll();
        }

        public bool Delete(Patient patient)
        {
            return patientService.Delete(patient);
        }
        public bool IsPatientExist(String firtname, String lastname)
        {
            return patientService.IsPatientExist(firtname, lastname);
        }
        

        public int lengthJmbg;

        public Bolnica.Service.PatientService patientService = new PatientService();


      
        public Patient GetOne(int idPatient)
        {
            return patientService.GetOne(idPatient);
        }

        public void setMedicalCard(Patient p)
        {
            patientService.setMedicalCard(p);
        }
       


    }

}
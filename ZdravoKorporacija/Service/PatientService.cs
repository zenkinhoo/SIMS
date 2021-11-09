using System;
using System.Collections.Generic;
using Bolnica.Model;
using Bolnica.Repository;

namespace Bolnica.Service
{

    public class PatientService
    {
        public Patient MakeRegularAccount(Bolnica.Model.Patient newPatient)
        {
            throw new NotImplementedException();
        }
        public Patient FindByFirstAndLastName(String fistname, String lastname)
        {
            List<Patient> patients = patientRepository.GetAll();
            foreach(Patient p in patients)
            {
                if(p.user.firstName==fistname && p.user.lastName == lastname)
                {
                    return p;
                }
            }
            return null;
        }


        public Patient MakeGuestAccount(String firstName, String lastName, String jmbg)
        {
            Patient newPatient=new Patient(jmbg,1, firstName, lastName,"", "", "","",false);
            patientRepository.Save(newPatient);
            return newPatient;
        }

        public bool IsJmbgUnique(String jmbg)
        {
            throw new NotImplementedException();
        }

        public bool IsJmbgValid(String jmbg)
        {
            throw new NotImplementedException();
        }

        public bool Update(Patient changedPatient)
        {
            Patient oldPatient = patientRepository.GetOne(changedPatient.user.id);
            String oldRow = oldPatient.user.jmbg + "," + oldPatient.user.id + "," + oldPatient.user.firstName + "," + oldPatient.user.lastName + "," + oldPatient.user.phone + "," + oldPatient.user.adress + "," + oldPatient.user.password + "," + oldPatient.user.username + ","+oldPatient.isDisabled;
            String newRow = changedPatient.user.jmbg + "," + changedPatient.user.id + "," + changedPatient.user.firstName + "," + changedPatient.user.lastName + "," + changedPatient.user.phone + "," + changedPatient.user.adress + "," + changedPatient.user.password + "," + changedPatient.user.username +","+ changedPatient.isDisabled;
            bool b= patientRepository.UpdateRowInFile(oldRow,newRow);
            return b;
        }

        public List<Patient> ReadAll()
        {
            return patientRepository.GetAll();
        }

        public bool Delete(Patient patient)
        {
            String deleteRow = patient.user.jmbg + "," + patient.user.id + "," + patient.user.firstName + "," + patient.user.lastName + "," + patient.user.phone + "," + patient.user.adress + "," + patient.user.password + "," + patient.user.username +","+ patient.isDisabled;
            return patientRepository.DeleteRowInFile(deleteRow);
        }
        public bool IsPatientExist(String firtname, String lastname) {
            if (this.FindByFirstAndLastName(firtname, lastname) != null)
            {
                return true;
            }
            return false;
        }
       

        public int lengthJmbg;

        public PatientRepository patientRepository = new PatientRepository();

    


        public Patient GetOne(int idPatient)
        {
            return patientRepository.GetOne(idPatient);
        }
        public void setMedicalCard(Patient p)
        {
            MedicalCardRepository medicalCardRepository = new MedicalCardRepository();
            MedicalCard medicalCard = medicalCardRepository.getOne(p.user.id);
        }
    }

}
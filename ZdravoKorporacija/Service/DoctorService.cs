using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolnica.Model;
using Bolnica.Repository;

namespace Bolnica.Service
{
    public class DoctorService
    {
        DoctorRepository doctorRepository = new DoctorRepository();
        public List<Doctor> findDoctorsByType(String type) {
            List<Doctor> foundDoctors = new List<Doctor>();
            List<Doctor> doctors = new List<Doctor>();
            doctors = doctorRepository.GetAll();
            foreach(Doctor d in doctors)
            {
                if (d.type == type) foundDoctors.Add(d);
            }
            return foundDoctors;
        }
        public bool Update(Doctor updateDoctor) {
            Doctor oldDoctor = doctorRepository.GetOne(updateDoctor.user.id);
            String oldRow = oldDoctor.user.jmbg + "," + oldDoctor.user.id + "," + oldDoctor.user.firstName + "," + oldDoctor.user.lastName + "," + oldDoctor.user.phone + "," + oldDoctor.user.adress + "," + oldDoctor.user.password + "," + oldDoctor.user.username + "," + oldDoctor.type + "," + oldDoctor.room.id;
            String newRow = updateDoctor.user.jmbg + "," + updateDoctor.user.id + "," + updateDoctor.user.firstName + "," + updateDoctor.user.lastName + "," + updateDoctor.user.phone + "," + updateDoctor.user.adress + "," + updateDoctor.user.password + "," + updateDoctor.user.username + "," + updateDoctor.type + "," + updateDoctor.room.id;
            return doctorRepository.Update(oldRow,newRow);
        }
        public void Save(Doctor newDoctor)
        {
            doctorRepository.Save(newDoctor);
        }
        public bool Delete(Doctor doctor)
        {
            String oldRow = doctor.user.jmbg + "," + doctor.user.id + "," + doctor.user.firstName + "," + doctor.user.lastName + "," + doctor.user.phone + "," + doctor.user.adress + "," + doctor.user.password + "," + doctor.user.username + "," + doctor.type + "," + doctor.room.id;
            return doctorRepository.Delete(oldRow);
        }
    }
}

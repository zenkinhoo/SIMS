using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolnica.Service;
using Bolnica.Model;
namespace Bolnica.Controller
{
    public class DoctorController
    {
        DoctorService doctorService = new DoctorService();
        public List<Doctor> findDoctorsByType(String type)
        {
            return doctorService.findDoctorsByType(type);
        }
        public bool Delete(Doctor doctor) {
            return doctorService.Delete(doctor);
        }
    }
}

using Bolnica.Controller;
using Bolnica.Model;
using Bolnica.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.ViewModel
{
    class MedicalHistoryViewModel
    {
        public ObservableCollection<string> MedicalHistory { get; set; }

        public MedicalHistoryViewModel()
        {
            LoadMedicalHistory();
        }

        public void LoadMedicalHistory()
        {
            ObservableCollection<string> medicalHistory = new ObservableCollection<string>();
            adaptMedicalHistory(medicalHistory);
            MedicalHistory = medicalHistory;
        }

    
     

        private void adaptMedicalHistory(ObservableCollection<string> medicalHistory)
        {
            AppointmentHistoryRepository appointmentHistoryRepository = new AppointmentHistoryRepository();

            MedicalCardController medicalCardController = new MedicalCardController();
            List<MedicalAppointment> ma = appointmentHistoryRepository.GetAllPastAppointments();
            DoctorRepository doctorRepository = new DoctorRepository();
            List<Doctor> doctors = new List<Doctor>();
            doctors = doctorRepository.GetAll();
            foreach (MedicalAppointment m in ma)
            {
                String info = "";
                info += m.id.ToString() + " ";
                foreach (Doctor d in doctors)
                {
                    if (d.user.id == m.doctor.user.id)
                    {
                        info += d.user.id + " " + d.user.firstName + " " + d.user.lastName;
                    }
                }
                info += " " + m.startTime.ToString();
                medicalHistory.Add(info);
            }
        }
    }
}

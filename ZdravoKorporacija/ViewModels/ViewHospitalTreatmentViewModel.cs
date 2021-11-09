using Bolnica.Controller;
using Bolnica.Model;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.ViewModel
{
    class ViewHospitalTreatmentViewModel
    {
        public ObservableCollection<string> HospitalTreatments { get; set; }

        public RelayCommand<ICloseable> CloseWindowCommand { get; private set; }
        public ViewHospitalTreatmentViewModel()
        {
            this.CloseWindowCommand = new RelayCommand<ICloseable>(this.CloseWindow);
            LoadHospitalTreatments();
        }

        public void LoadHospitalTreatments()
        {
            ObservableCollection<string> hospitalTreatments = new ObservableCollection<string>();
            adaptHospitalTreatments(hospitalTreatments);
            HospitalTreatments = hospitalTreatments;
        }
        private void CloseWindow(ICloseable window)
        {
            if (window != null)
            {
                window.Close();
            }
        }

        private void adaptHospitalTreatments(ObservableCollection<string> hospitalTreatments)
        {
            MedicalCardController medicalCardController = new MedicalCardController();
            List<MedicalInstruction> instructions = medicalCardController.GetAllSpecificTreatmentMedicalInstructions((MedicalInstructionType.HospitalTreatment));

            List<String> instructionsInfo = new List<string>();
            foreach (MedicalInstruction mi in instructions)
            {
                string temp = "";
                Doctor doc = ObjectFinder.findDoctor(mi.idDoctor);
                temp += doc.user.firstName.ToString() + " " + doc.user.lastName.ToString() + " " + mi.instruction.ToString();
                hospitalTreatments.Add(temp);
            }
    
        }
    }
}

using Bolnica.Controller;
using Bolnica.Model;
using Bolnica.Repository;
using GalaSoft.MvvmLight.Command;
using project;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Bolnica.ViewModel
{
    public interface ICloseable
    {
        void Close();
    }
    class ViewAnamnesisViewModel : BindableBase
    {
        public ObservableCollection<string> Anamnesis { get; set; }

        public RelayCommand<ICloseable> CloseWindowCommand { get; private set; }
        public ViewAnamnesisViewModel()
        {
            this.CloseWindowCommand = new RelayCommand<ICloseable>(this.CloseWindow);
            LoadAnamnesis();
        }

        public void LoadAnamnesis()
        {
            ObservableCollection<string> anamnesis = new ObservableCollection<string>();
            adaptAnamnesis(anamnesis);
            Anamnesis = anamnesis;
        }
        private void CloseWindow(ICloseable window)
        {
            if (window != null)
            {
                window.Close();
            }
        }

        private void adaptAnamnesis(ObservableCollection<string> anamnesis)
        {
            MedicalCardController medicalCardController = new MedicalCardController();
            List<Anamnesis> anamnesiss = medicalCardController.GetAllAnamnesis();

            List<String> anamnesisInfo = new List<string>();
            foreach (Anamnesis a in anamnesiss)
            {
                anamnesis.Add(a.ToString());
            }
        }


    }
}

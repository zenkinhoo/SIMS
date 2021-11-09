using Bolnica.Controller;
using Bolnica.Model;
using Bolnica.ViewModel;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.ViewModel
{
    class ViewAllRecipesViewModel
    {
        public ObservableCollection<string> Recipes { get; set; }

        public RelayCommand<ICloseable> CloseWindowCommand { get; private set; }
        public ViewAllRecipesViewModel()
        {
            this.CloseWindowCommand = new RelayCommand<ICloseable>(this.CloseWindow);
            LoadRecipes();
        }

        public void LoadRecipes()
        {
            ObservableCollection<string> recipes = new ObservableCollection<string>();
            adaptRecipes(recipes);
            Recipes= recipes;
        }
        private void CloseWindow(ICloseable window)
        {
            if (window != null)
            {
                window.Close();
            }
        }

        private void adaptRecipes(ObservableCollection<string> recipes)
        {
            MedicalCardController medicalCardController = new MedicalCardController();
            List<Recipe> rs = medicalCardController.GetAllRecipes();

            foreach (Recipe r in rs)
            {
                recipes.Add(r.ToString());
            }
        }
    }
}

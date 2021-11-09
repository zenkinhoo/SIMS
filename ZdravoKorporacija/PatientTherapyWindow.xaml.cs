using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Bolnica.Model;
using Bolnica.Controller;
using Bolnica.Repository;
using Bolnica.Service;

namespace Bolnica
{
    /// <summary>
    /// Interaction logic for PatientTherapyWindow.xaml
    /// </summary>
    public partial class PatientTherapyWindow : Window
    {
        public PatientTherapyWindow()
        {
            InitializeComponent();
        }

        //   RecipeController recipeController = new RecipeController();
        RecipeController recipeController = new RecipeController();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Recipe> recipes = recipeController.ReadAll();
            List<String> relevantInfo = new List<String>(); //imena lekova i vremena kada pacijent treba da ih uzme
            String notification = "Uskoro trebate uzeti:" + "\n"; //obavestenje kada pacijent treba da uzme lek,pojavljuje se 2 sata ili manje do uzimanja leka



            foreach (Recipe r in recipes)
            {
                double currentSeconds = Convert.ToDouble((DateTime.Now.Hour * 3600) + (DateTime.Now.Minute) * 60); //trenutno vreme u sekundama

                String nameDose = r.medicine + " " + r.quantity.ToString();
                String tempSchedule = nameDose + "mg         "; //ovo dodajemo na raspored
                string[] hoursMinutes = r.startTime.Split(':');
                int hours = Convert.ToInt32(hoursMinutes[0]);
                int minutes = Convert.ToInt32(hoursMinutes[1]);

                double seconds = Convert.ToDouble(hours * 3600 + minutes * 60); //pretvaramo u sekunde radi daljih kalkulacija
                double frequencyHours = 86400 / Convert.ToDouble(r.howOften); // na koliko sekundi pije 

                for (int i = 0; i < r.howOften; i++)
                {

                    int hours1 = Convert.ToInt32(((seconds + frequencyHours * i) / 3600) % 24);
                    int minutes1 = Convert.ToInt32((seconds + frequencyHours * i) % 3600 / 60);
                    if (minutes < 10) //lepimo nulu ispred
                    {
                        tempSchedule += hours1.ToString() + ":0" + minutes1.ToString() + ",";
                        if ((hours1*3600+minutes1*60) - currentSeconds <= 7200 && (hours1 * 3600 + minutes1 * 60) - currentSeconds>0) //2 sata ima 7200 sekunde
                        {
                            notification += nameDose + "mg u " + hours1.ToString() + ":0" + minutes1.ToString() + "\n";
                        }
                    }
                    else
                    {
                        tempSchedule += hours1.ToString() + ":" + minutes1.ToString() + ",";
                        if ((hours1 * 3600 + minutes1 * 60) - currentSeconds <= 7200 && (hours1 * 3600 + minutes1 * 60) - currentSeconds > 0)
                        {
                            notification += nameDose + "mg u " + hours1.ToString() + ":" + minutes1.ToString() + "\n";
                        }
                    }
                    Console.WriteLine((hours1 * 3600 + minutes1 * 60).ToString());
                    Console.WriteLine((currentSeconds).ToString());
                }
                relevantInfo.Add(tempSchedule);


            }

            TherapySchedule.ItemsSource = relevantInfo;
            MessageBox.Show(notification, "Podsetnik za lekove", MessageBoxButton.OK, MessageBoxImage.Information);

        }
    }
}

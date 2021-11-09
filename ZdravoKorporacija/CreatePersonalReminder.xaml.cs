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
using Bolnica.Controller;
using Bolnica.Model;
using Bolnica.HelperClasses;

namespace Bolnica
{
    /// <summary>
    /// Interaction logic for CreatePersonalReminder.xaml
    /// </summary>
    public partial class CreatePersonalReminder : Window
    {
        public CreatePersonalReminder()
        {
            InitializeComponent();
        }
    
      
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PersonalReminderController personalReminderController = new PersonalReminderController();
            try 
            {
                int[] hoursAndMinutes = TextSplitter.TextBoxTimeSplitter(tbReminderTime);
                DateTime reminderTime = dpReminderDate.SelectedDate.Value.AddHours(hoursAndMinutes[0]).AddMinutes(hoursAndMinutes[1]);
               PersonalReminder p = new PersonalReminder(1, tbReminderName.Text.ToString(), tbDescription.Text.ToString(), reminderTime, Convert.ToInt32(tbPeriod.Text),false);
                personalReminderController.SavePersonalReminder(p);
                this.Close();
            }
            catch (FormatException f)
            {
                MessageBox.Show(f.Message);
            }
          
        }
   
    }
}

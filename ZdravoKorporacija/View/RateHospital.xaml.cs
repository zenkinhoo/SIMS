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
using System.Windows.Forms;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for RateHospital.xaml
    /// </summary>
    public partial class RateHospital : Window
    {
        public string rate { get; set; }

        public RateHospital()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        void OnLoad(object sender, RoutedEventArgs e)
        {
        }

        private void cancel_hospital_rating(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void rate_hospital(object sender, RoutedEventArgs e)
        {
            
                if (tbComment.Text != "" && tbRate.Text != "")
                {
                    Survey survey = new Survey(1, 50, tbComment.Text.ToString(), Convert.ToInt32(tbRate.Text), SurveyType.HospitalSurvey);
                    SurveyController surveyController = new SurveyController();
                    surveyController.SaveSurvey(survey);
                System.Windows.MessageBox.Show("Survey successfully filled", "Survey success", MessageBoxButton.OK, (MessageBoxImage)MessageBoxIcon.Information);
                tbComment.Text = "";
                    tbRate.Text = "";
                    this.Close();
                }
                else
                {
                System.Windows.MessageBox.Show("You must fill all fields!", "Survey fail", MessageBoxButton.OK, (MessageBoxImage)MessageBoxIcon.Error);
            }
        }
           
        }
    }


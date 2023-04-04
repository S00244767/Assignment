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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AssignmentWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public double CalcPremium(int age, string location)
        {
            double premium;

            if (location == "rural")
            {
                if ((age >= 18) && (age < 30))
                    premium = 5.0;
                else if (age >= 31)
                    premium = 2.50;
                else
                    premium = 0.0;
            }
            else if (location == "urban")
            {
                if ((age >= 18) && (age <= 35))
                    premium = 6.0;
                else if (age >= 36)
                    premium = 5.0;
                else
                    premium = 0.0;
            }
            else
                premium = 0.0;

            double discount = 0.70;
            if (age >= 50)
                premium = premium * discount;
            return premium;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string location = LocationBox.Text;
            string number = AgeBox.Text;
            int realNumber;
            string result = "Incorrect value entered";
            if (location != null && number != null)
            {
                if (int.TryParse(number, out realNumber))
                {
                    double res = CalcPremium(realNumber,location);
                    result = res.ToString();
                }
            }
            Result.Text = result;
        }
    }
}

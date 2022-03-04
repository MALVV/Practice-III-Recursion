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

namespace Tarea_04_03
{
    /// <summary>
    /// Lógica de interacción para ejr1Window.xaml
    /// </summary>
    public partial class ejr1Window : Window
    {
        public ejr1Window()
        {
            InitializeComponent();
        }
        public double calculateCapital(int years, double initialAmount, int interesRate)
        {
            if (years == 0)
            {
                return initialAmount;

            }
            double total = calculateCapital(years - 1, initialAmount, interesRate);
            double result = total + (total * interesRate / 100);
            show.Items.Add("Año " + years + "->" + result );
            return result;
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            calculateCapital(int.Parse(txtAños.Text), int.Parse( txtMontoInicial.Text), 10);

        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtAños.Clear();
            txtMontoInicial.Clear();
            show.Items.Clear();
        }
    }
}

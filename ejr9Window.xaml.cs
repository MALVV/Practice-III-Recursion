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
    /// Lógica de interacción para ejr9Window.xaml
    /// </summary>
    public partial class ejr9Window : Window
    {
        public ejr9Window()
        {
            InitializeComponent();
        }
        public static int calculateRabbits(int months)
        {
            if (months == 0)
            {
                return 0;
            }
            else if (months == 1)
            {
                return 1;
            }
            else
            {
                return calculateRabbits(months - 1) + calculateRabbits(months - 2);
            }
        }
        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            int countRabbits = calculateRabbits(int.Parse(txtMonths.Text));
            MessageBox.Show("El granjero podra poner en venta " + countRabbits / 2 + " pares conejos al cabo de " + txtMonths.Text + " meses");
        }
    }
}

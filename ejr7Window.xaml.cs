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
    /// Lógica de interacción para ejr7Window.xaml
    /// </summary>
    public partial class ejr7Window : Window
    {
        public ejr7Window()
        {
            InitializeComponent();
        }
        public static int function(int x)
        {
            if (x > 100)
            {
                return (x - 10);
            }
            else
            {
                return function(function(x + 11));
            }


        }
        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            int answer = function(int.Parse(txtNum.Text));
            show.Items.Add("Numero "+txtNum.Text+"->"+answer.ToString());
            txtNum.Clear();
        }
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            show.Items.Clear();
        }
    }
}

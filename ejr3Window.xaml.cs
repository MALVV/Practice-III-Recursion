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
    /// Lógica de interacción para ejr3Window.xaml
    /// </summary>
    public partial class ejr3Window : Window
    {
        public ejr3Window()
        {
            InitializeComponent();
        }
        public int sumNumberN(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n % 2 == 0)
            {
                return n + sumNumberN(n - 2); ;

            }
            return sumNumberN(n - 1);

        }

        private void btnSum_Click(object sender, RoutedEventArgs e)
        {
            int answer = sumNumberN(int.Parse(txtNum.Text));
            MessageBox.Show("El resultado de la suma es " + answer);
            txtNum.Clear();
        }
    }
}

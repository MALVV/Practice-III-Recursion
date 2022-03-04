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
    /// Lógica de interacción para ejr5Window.xaml
    /// </summary>
    public partial class ejr5Window : Window
    {
        public ejr5Window()
        {
            InitializeComponent();
        }
        public int functionQ(int a, int b)
        {
            if (a < b)
            {
                return 0;
            }
            return functionQ(a - b, b) + 1;
        }
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El valor es " + functionQ(3, 2).ToString());
  
        }

    }
}

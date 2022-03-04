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
    /// Lógica de interacción para ejr6Window.xaml
    /// </summary>
    public partial class ejr6Window : Window
    {
        public ejr6Window()
        {
            InitializeComponent();
        }
        public void factorsNumber(int num, int div)
        {
            if (num > 1)
            {
                if ((num % div) == 0)
                {
                    show.Items.Add(div);
                    factorsNumber(num / div, div);
                }
                else
                {
                    factorsNumber(num, div + 1);
                }
            }


        }
        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            show.Items.Add("Factores:");
            factorsNumber(int.Parse(txtNum.Text), 2);
        }
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtNum.Clear();
            show.Items.Clear();
        }
    }
}

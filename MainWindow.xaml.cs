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

namespace Tarea_04_03
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

        private void btn_ejr1_Click(object sender, RoutedEventArgs e)
        {
            ejr1Window ejercicio1 = new ejr1Window();
            ejercicio1.Show();

        }

        private void btn_ejr2_Click(object sender, RoutedEventArgs e)
        {
            ejr2Window ejercicio2 = new ejr2Window();
            ejercicio2.Show();

        }

        private void btn_ejr3_Click(object sender, RoutedEventArgs e)
        {
            ejr3Window ejercicio3 = new ejr3Window();
            ejercicio3.Show();
        }

        private void btn_ejr4_Click(object sender, RoutedEventArgs e)
        {
            ejr4Window ejercicio4 = new ejr4Window();
            ejercicio4.Show();
        }

        private void btn_ejr5_Click(object sender, RoutedEventArgs e)
        {
            ejr5Window ejercicio5 = new ejr5Window();
            ejercicio5.Show();
        }

        private void btn_ejr6_Click(object sender, RoutedEventArgs e)
        {
            ejr6Window ejercicio6 = new ejr6Window();
            ejercicio6.Show();
        }

        private void btn_ejr7_Click(object sender, RoutedEventArgs e)
        {
            ejr7Window ejercicio7 = new ejr7Window();
            ejercicio7.Show();
        }

        private void btn_ejr8_Click(object sender, RoutedEventArgs e)
        {
            ejr8Window ejercicio8 = new ejr8Window();
            ejercicio8.Show();
        }

        private void btn_ejr9_Click(object sender, RoutedEventArgs e)
        {
            ejr9Window ejercicio9 = new ejr9Window();
            ejercicio9.Show();
        }

        private void btn_ejr10_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

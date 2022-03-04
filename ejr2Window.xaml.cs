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
    /// Lógica de interacción para ejr2Window.xaml
    /// </summary>
    public partial class ejr2Window : Window
    {
        public ejr2Window()
        {
            InitializeComponent();
        }
        public string decomposeWord(string word, int i)
        {
            if (i == 0)
            {
                show.Items.Add(word[i].ToString());
                return word[i].ToString();
            }
            string result = decomposeWord(word, i - 1);
            result = result + word[i].ToString();
            show.Items.Add(result);
            return result;
            
        }
        private void btnGenerar_Click(object sender, RoutedEventArgs e)
        {
            string word = txtWord.Text;
            decomposeWord(word, word.Length - 1);
        }
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtWord.Clear();
            show.Items.Clear();
        }
    }
}

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
    /// Lógica de interacción para ejr4Window.xaml
    /// </summary>
    public partial class ejr4Window : Window
    {
        public ejr4Window()
        {
            InitializeComponent();
        }
        public static bool isPalindrom(string word)
        {
            if (word.Length < 2)
            {
                return true;
            }
            if (word[0] == word[word.Length - 1])
            {
                return isPalindrom(word.Substring(1, word.Length - 2));
            }
            return false;

        }

        private void btnVerify_Click(object sender, RoutedEventArgs e)
        {
            bool answer = isPalindrom(txtWord.Text);
            if (answer)
            {
                MessageBox.Show("Es palindroma!");
            }
            else
            {
                MessageBox.Show("No es palindroma!");
            }
            txtWord.Clear();
        }
    }
}

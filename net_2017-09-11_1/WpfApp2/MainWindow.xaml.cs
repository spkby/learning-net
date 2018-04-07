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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /// <remarks>
            /// Clear TextBox
            /// </remarks>
            TextBoxS.Text = "";
            TextBoxD.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /// <remarks>
            /// Clear Destenation TextBox
            /// </remarks>
            TextBoxD.Text = "";

            /// <remarks>
            /// Parse String and Appaned to Destenation TextBox
            /// </remarks>
            string tmpstr = TextBoxS.Text.Replace("\r\n", " ").Trim();          
            string[] str = tmpstr.Split(' ');
            for (int i = 0; i < str.Length; i++)
            {
                string[] numbers = str[i].Split(',');

                for (int j = 0; j < numbers.Length; j++)
                {
                    numbers[j] = numbers[j].Replace('.', ',');
                }
                TextBoxD.AppendText("X: " + numbers[0] + " Y: " + numbers[1] + "\n");
            }
        }
    }
}

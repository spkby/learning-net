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
using ClassLibrary;

namespace WpfAppRoot
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Initialized(object sender, EventArgs e)
        {
            labelChk.Content = "";
            labelRslt.Content = "";
            textNumber.Text = "";
            textPow.Text = "";
            textAcc.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClassRoot root = new ClassRoot();
            double d = root.root(Convert.ToDouble(textPow.Text.Replace(".",",")), Convert.ToDouble(textNumber.Text.Replace(".", ",")), Convert.ToDouble(textAcc.Text.Replace(".", ",")));
            labelRslt.Content = d.ToString();
            

            d = root.chk(Convert.ToDouble(textPow.Text.Replace(".", ",")), Convert.ToDouble(textNumber.Text.Replace(".", ",")), Convert.ToDouble(textAcc.Text.Replace(".", ",")));
            labelChk.Content = d.ToString();

        }
    }
}

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

namespace ps
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //MessageBox.Show(alfa(1,2).ToString());
            //aggiunto commento
        }

        public int alfa(int a, int b)
        {
            return a + b;
        }

        public string lancia()
        {
            Random rn = new Random();
            rn.Next(1, 101);
            return rn.ToString();
        }

        private void btnEsegui_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(alfa(5, 5)+alfa(5, 5).ToString() + "qua tutto bellissimo " + lancia());
        }
    }
}

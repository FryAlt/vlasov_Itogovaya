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

namespace vlasov_Itogovaya
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int x = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void minusBtn_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(tb_Summ.Text);
            if (n > 0)
            {
                n = n - 5;
                tb_Summ.Text = Convert.ToString(n);
            }
        }

        private void plusBtn_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(tb_Summ.Text);
            if (n < 100)
            {
                n = n + 5;
                tb_Summ.Text = Convert.ToString(n);
            }
        }

        private void buyBtn_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(tb_Summ.Text);
            x += n;
            txt_Summ.Text = ("$") + Convert.ToString(x);
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            tb_Name.Text = "";
            cb_Runner.Text = "";
            tb_Card.Text = "";
            tb_cardNumber.Text = "";
            tb_monthCard.Text = "";
            tb_yearCard.Text = "";
            tb_cvcCard.Text = "";
            txt_Summ.Text = "$0";
            tb_Summ.Text = "50";
        }
    }
}

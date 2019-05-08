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

namespace CashWPF.View
{
    /// <summary>
    /// Interaction logic for CashMenuBar.xaml
    /// </summary>
    public partial class CashMenuBar : UserControl
    {
        public CashMenuBar()
        {
            InitializeComponent();
        }


        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to logout?", "Confirm", MessageBoxButton.YesNo)==MessageBoxResult.Yes)
            {
                var logWin = new LoginWindow { };
                logWin.ShowDialog();
            }
            
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Welcome to Cash WPF app", "About");
        }

        private void TipOfDay_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Random tip of the day", "Tip of the Day");
        }
    }
}

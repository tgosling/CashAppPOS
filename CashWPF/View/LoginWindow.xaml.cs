﻿using System;
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
using CashWPF.ViewModel;
using CashWPF.Helpers;

namespace CashWPF.View
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
      
        public LoginWindow()
        {
            InitializeComponent();
            
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
                 
            var mainWin = new MainWindow { };
            mainWin.Owner = this;
            if(Helpers.WindowHelper.IsWindowOpen<Window>("Point of Sale"))
            {
                MessageBox.Show("Window is already Open");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Poo");
                this.Hide();
                mainWin.ShowDialog();
            }
        }
    }
}

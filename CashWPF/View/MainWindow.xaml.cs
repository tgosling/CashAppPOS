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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CashWPF
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

        //Number Pad Click handlers
        #region NumBadButtons
        private void NumPadClick(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            tbUserCurr.Text += b.Content.ToString();
        }

        private void PadEscClick(object sender, RoutedEventArgs e)
        {
            tbUserCurr.Text = "";
        }

        private void PadBacClick(object sender, RoutedEventArgs e)
        {
            string s = tbUserCurr.Text;

            if (s.Length > 1)
                s = s.Substring(0, s.Length - 1);
            else
                s = "";

            tbUserCurr.Text = s;
        }
        #endregion

        //Menu Bar Click Handlers
        #region MenuBar
        private void ApplicationClose(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }

       
        #endregion
    }
}

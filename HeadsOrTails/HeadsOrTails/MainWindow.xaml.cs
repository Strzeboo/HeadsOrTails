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

namespace HeadsOrTails
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int liczba = 0;
        int howManyTimesTailsHappend = 0;
        int howManyTimesHeadsHappend = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            liczba = RollHelper.RollOnce();

            if (liczba.Equals(0))
            {
                textBlock.Text = "TAILS";
                howManyTimesTailsHappend++;
                howManyTimesTailsTextBlock.Text = howManyTimesTailsHappend.ToString();
            }
            else
            {
                textBlock.Text = "HEADS";
                howManyTimesHeadsHappend++;
                howManyTimesHeadsTextBlock.Text = howManyTimesHeadsHappend.ToString();
            }
        }


    }
}

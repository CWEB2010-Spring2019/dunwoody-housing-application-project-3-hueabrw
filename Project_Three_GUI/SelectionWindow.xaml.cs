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

namespace Project_Three_GUI
{
    /// <summary>
    /// Interaction logic for SelectionWindow.xaml
    /// </summary>
    public partial class SelectionWindow : Window
    {
        public SelectionWindow()
        {
            InitializeComponent();
        }

        private void MouseEnterHandler(object sender, RoutedEventArgs e)
        {
            var button = e.OriginalSource as Button;
            button.Background = Brushes.White;
            button.Foreground = Brushes.DarkRed;
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void NewResidentButton_Click(object sender, RoutedEventArgs e)
        {
            NewResidentWindow newResidentWindow = new NewResidentWindow();
            newResidentWindow.Show();
            this.Close();
        }
        
        

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            SearchWindow searchWindow = new SearchWindow();
            searchWindow.Show();
            this.Close();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Top
{
    /// <summary>
    /// Menu.xaml の相互作用ロジック
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();

            this.DataContext = new TopModel();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var navigationWindow = (NavigationWindow)Application.Current.MainWindow;
            var uri = new Uri("/Report1;component/Form.xaml", UriKind.Relative);
            navigationWindow.Navigate(uri);
        }

        private void getPage(string uriStr)
        {
            var navigationWindow = (NavigationWindow)Application.Current.MainWindow;
            var uri = new Uri(uriStr, UriKind.Relative);
            navigationWindow.Navigate(uri);
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            getPage("/Report1;component/ReportEntryPage.xaml");
        }
    }
}

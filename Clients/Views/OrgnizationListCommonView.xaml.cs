﻿using System;
using System.Collections.Generic;
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

namespace Clients.Views
{
    /// <summary>
    /// Логика взаимодействия для OrgnizationListCommonView.xaml
    /// </summary>
    public partial class OrgnizationListCommonView : UserControl
    {
        public OrgnizationListCommonView()
        {
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(OrgList.SelectedItem!=null)
            OrgList.ScrollIntoView(OrgList.SelectedItem);
        }
    }
}

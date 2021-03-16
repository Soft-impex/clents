using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Clients.ViewModels;

namespace Clients.Views
{
    /// <summary>
    /// Логика взаимодействия для OrganizationLicenseeLDView.xaml
    /// </summary>
    public partial class OrganizationLicenseeLDView : Window
    {
        public OrganizationLicenseeLDView()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OrgList.SelectedItem != null)
                OrgList.ScrollIntoView(OrgList.SelectedItem);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void OrgList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (OrgList.SelectedItem != null)
                DialogResult = true;
        }
    }
}

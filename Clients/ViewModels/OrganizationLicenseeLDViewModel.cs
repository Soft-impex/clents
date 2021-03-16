using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Clients.DataContext;
using System.Linq;
using Prism.Commands;
using System.Runtime.CompilerServices;

namespace Clients.ViewModels
{
    public class OrganizationLicenseeLDViewModel:INotifyPropertyChanged
    {
        ClientsContext db;
        public Organization OrganizationSelected { get; set; }
        public List<Organization> Organizations { get; set; }
        string find;
        public string Find { 
            get => find; 
            set { 
                find = value;
                OrganizationSelected = Organizations.FirstOrDefault(o => o.Alias.ToLower().IndexOf(value.ToLower()) > -1);
                OnPropertyChanged("Find");
                OnPropertyChanged(nameof(OrganizationSelected));
            } 
        }
        public DelegateCommand SelectedCommand { get; private set; }

        public OrganizationLicenseeLDViewModel()
        {
            db = new ClientsContext();
            Organizations = db.Organizations.ToList();
            SelectedCommand = new DelegateCommand(() =>
              {
                  
              });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

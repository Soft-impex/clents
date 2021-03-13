using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Clients.Models;
using System.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Clients.DataContext;
using Prism.Commands;
using Clients.DataContext;

namespace Clients.ViewModels
{
    class OrganiztionCommonViewModel : INotifyPropertyChanged
    {
        public DelegateCommand OrgEditCommand { get; private set; }
        
        private ClientsContext clientsContext;
        string find;
        public string Find {
            get => find;
            set
            {
                find = value;
                int index = 0;
                foreach (var org in OrganiztionCommons)
                {
                    if (org.Alias.ToLower().IndexOf(find.ToLower()) > -1)
                    {
                        OrgSelected = org;
                        OrgSelectedIndex = index;
                        break;
                    }
                    index++;
                };
                OnPropertyChanged("Find");
            }
        }

        OrganizationCommonModel orgSelected;
        public OrganizationCommonModel OrgSelected
        {
            get => orgSelected;
            set
            {
                orgSelected = value;
                OnPropertyChanged("OrgSelected");
            }
        }

        int orgSelectedIndex;
        public int OrgSelectedIndex
        {
            get => orgSelectedIndex;
            set
            {
                orgSelectedIndex = value;
                OnPropertyChanged("OrgSelectedIndex");
            }
        }

        public ObservableCollection<OrganizationCommonModel> OrganiztionCommons
        {
            get
            {
                var orglist = clientsContext.ViewOrgsummaries.OrderBy(o=>o.Alias).ToList();
                ObservableCollection<OrganizationCommonModel> orgsummaries = new ObservableCollection<OrganizationCommonModel>();
                foreach (var o in orglist)
                    orgsummaries.Add(new OrganizationCommonModel(o));
                return orgsummaries;
            }
        }

        public ObservableCollection<ViewOrgsummary> OrgListSummary
        {
            get
            {
                var orglist = clientsContext.ViewOrgsummaries.ToList();
                ObservableCollection<ViewOrgsummary> orgsummaries = new ObservableCollection<ViewOrgsummary>();
                foreach (var o in orglist)
                    orgsummaries.Add(o);
                return orgsummaries;
            }
        }
        public OrganiztionCommonViewModel()
        {
            clientsContext = new ClientsContext();
            OrgEditCommand = new DelegateCommand(() =>
              {
                  Views.OrganizationEditView fr = new Views.OrganizationEditView();
                  //fr.DataContext = new OrgnizationEditViewModel((int)OrgSelected.Id);
                  (fr.DataContext as OrgnizationEditViewModel).Select((int)OrgSelected.Id);
                  fr.Show();
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

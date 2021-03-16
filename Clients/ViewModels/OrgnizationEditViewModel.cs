using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Clients.DataContext;
using System.Windows;
using Prism.Commands;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Clients.Views;
using System.Windows.Controls;

namespace Clients.ViewModels
{
    public class OrgnizationEditViewModel: INotifyPropertyChanged
    {
        ClientsContext db;
        public Organization Organization_ { get; set; }
        public ContractsEd ContractsEd_ { get; set; }
        public ContractsLd ContractsLd_ { get; set; }
        public List<string> ContractEdAgents { get; set; } = new List<string>() { "Софт-Импэкс", "ИП" };
        public List<string> Operators { get; set; } = new List<string>() { "Инфодек", "НТС" };
        public List<string> SubDillers { get; set; } = new List<string>() { "Курск", "Сабынин" };

        public DelegateCommand CreateContractED { get; private set; }
        public DelegateCommand CreateContractLD { get; private set; }
        public DelegateCommand LicenseeLDChangeCommand { get; private set; }
        public DelegateCommand LicenseeLDEqualCommand { get; private set; }
        public DelegateCommand SaveCommand { get; private set; }
        public OrgnizationEditViewModel()
        {
            db = new ClientsContext();
            
            CreateContractED = new DelegateCommand(() =>
            {
                if (ContractsEd_ == null)
                {
                    var contractsEd = new ContractsEd
                    {
                        IdOrg = Organization_.Id,
                        Agent = ContractEdAgents[0],
                        Operator=Operators[0],
                        Num = db.GetNextContracts(ClientsContext.NextContractType.EDInfodec),
                        Date = DateTime.Now
                    };
                    db.ContractsEds.Add(contractsEd);
                    db.SaveChanges();
                    ContractsEd_ = contractsEd;
                    OnPropertyChanged("ContractsEd_");
                };
            });
            CreateContractLD = new DelegateCommand(() =>
            {
                if (ContractsLd_ == null)
                {
                    var contract = new ContractsLd
                    {
                        IdOrg = Organization_.Id,
                        Agent = ContractEdAgents[0],
                        Num = db.GetNextContracts(ClientsContext.NextContractType.LDCtm),
                        Date = DateTime.Now
                    };
                    db.ContractsLds.Add(contract);
                    db.SaveChanges();
                    ContractsLd_ = contract;
                    OnPropertyChanged("ContractsLd_");
                };
            });
            LicenseeLDChangeCommand = new DelegateCommand( ()=>
              {
                  OrganizationLicenseeLDView fr = new OrganizationLicenseeLDView();
                  fr.Left = System.Windows.Forms.Cursor.Position.X;
                  fr.Top = System.Windows.Forms.Cursor.Position.Y;
                  if (fr.ShowDialog() == true)
                  {
                      var vm = fr.DataContext as OrganizationLicenseeLDViewModel;
                      Organization_.LicenseeLdidOrg = vm.OrganizationSelected.Id;
                      Organization_.LicenseeLdidOrgNavigation = vm.OrganizationSelected;
                      OnPropertyChanged(nameof(Organization_));
                  }
              });
            LicenseeLDEqualCommand = new DelegateCommand(() =>
              {
                  Organization_.LicenseeLdidOrg = Organization_.Id;
                  Organization_.LicenseeLdidOrgNavigation = Organization_;
                  OnPropertyChanged(nameof(Organization_));
              });
            SaveCommand = new DelegateCommand(() =>
              {
                  db.SaveChanges();
              });
        }

        public void Select(int idOrg)
        {
            foreach (var o in db.Organizations)
                if (o.Id == idOrg)
                    Organization_ = o;
            OnPropertyChanged(nameof(Organization_));
            ContractsEd_ = (from c in db.ContractsEds
                            where c.IdOrg == idOrg
                            orderby c.Date descending
                            select c).DefaultIfEmpty().Single();
            OnPropertyChanged(nameof(ContractsEd_));
            ContractsLd_ = (from c in db.ContractsLds
                            where c.IdOrg == idOrg
                            orderby c.Date descending
                            select c).DefaultIfEmpty().Single();
            OnPropertyChanged(nameof(ContractsLd_));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Clients.DataContext;
using System.Windows;
using Prism.Commands;
using System.ComponentModel;
using System.Runtime.CompilerServices;

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

        public DelegateCommand CreateContractED { get; private set; }
        public DelegateCommand CreateContractLD { get; private set; }
        public OrgnizationEditViewModel()
        {
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
        }

        public void Select(int idOrg)
        {
            db = new ClientsContext();
            Organization_ = db.Organizations.Find(idOrg);
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

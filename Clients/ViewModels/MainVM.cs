using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using Clients.Views;
using Clients.FormService;
using System.Linq;
using Clients.Views;
using fr=System.Windows.Forms;

namespace Clients.ViewModels
{
    class MainVM
    {
        FormList formList= FormContainer.FormList;
        public MainVM()
        {
        }
        public DelegateCommand OpenFormOrganiztions { get; } = new DelegateCommand(() =>
          {
              switch(FormContainer.FormList.Forms.Count(f=>f.FormControl.GetType()==typeof( OrgnizationListCommonView)))
              {

                  case 0:
                      FormContainer.FormList.Forms.Add(new Form
                      {
                          id = Guid.NewGuid(),
                          Name = "Организации",
                          FormControl = new OrgnizationListCommonView()
                      });
                      FormContainer.FormList.FormSelected = FormContainer.FormList.Forms[FormContainer.FormList.Forms.Count - 1];
                      break;
                  default:
                      FormContainer.FormList.FormSelected = FormContainer.FormList.Forms.FirstOrDefault(f => f.FormControl.GetType()==typeof(OrgnizationListCommonView));
                      break;
              }

          });
    }
}

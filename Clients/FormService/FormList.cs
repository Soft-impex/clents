using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.Text;

namespace Clients.FormService
{
    class FormList:INotifyPropertyChanged
    {
        public ObservableCollection<Form> Forms { get; set; } = new ObservableCollection<Form>();
        static Form formSelected=new Form {FormControl=new System.Windows.Controls.UserControl() };
        public Form FormSelected
        {
            get => formSelected;
            set
            {
                formSelected = value;
                OnPropertyChanged("FormSelected");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Clients.FormService
{
    class Form
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public UserControl FormControl { get; set; }
        public Form Parent { get; set; }
    }
}

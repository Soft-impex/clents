using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace Clients
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            App.Current.Resources["GlobalFontSize"] = GlobalParam.Setting.FontSizeValue;
            base.OnStartup(e);
        }
        protected override void OnLoadCompleted(NavigationEventArgs e)
        {

            base.OnLoadCompleted(e);
        }
    }
}

using RingCentral;
using System.Configuration;
using System.Data;
using System.Windows;

namespace IntercomViewer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public RestClient? rc;


        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);

            

        }

        public void readConfigJson(string path) {

        }

    }

}

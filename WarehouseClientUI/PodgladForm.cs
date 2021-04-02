using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseLibrary;
using Newtonsoft.Json;
using WarehouseService;
using System.ServiceModel;

namespace WarehouseClientUI
{
    public partial class PodgladForm : Form
    {
        
       
        
        public PodgladForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //uniemozliwienie maksymalizacji okna
            this.MaximizeBox = false;
            // configurating webservice endpoints programmicaly setting binding security mode to transport to support https connection
            var binding = new BasicHttpBinding();
            binding.Security.Mode = BasicHttpSecurityMode.Transport;

            var client = new WarehouseService.WarehouseWebServiceSoapClient(binding, new EndpointAddress("https://localhost:44334/WarehouseWebService.asmx"));         
                        
            towaryGrid.DataSource = JsonConvert.DeserializeObject(client.GetTowary());
        }




    }
}

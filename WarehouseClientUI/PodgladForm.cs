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
using WarehouseWebService;

namespace WarehouseClientUI
{
    public partial class PodgladForm : Form
    {
        
        private List<TowaryDostepneModel> towary = new List<TowaryDostepneModel>();
        
        public PodgladForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //uniemozliwienie maksymalizacji okna
            this.MaximizeBox = false;
            WarehouseWebService.GetTowaryResponseBody res = new WarehouseWebService.GetTowaryResponseBody();
            //WarehouseWebService.WarehouseWebServiceSoapClient client = new WarehouseWebService.WarehouseWebServiceSoapClient();
            //towary = (TowaryDostepneModel)JsonConvert.DeserializeObject(client.GetTowaryAsync().Result);
            //towary.Add((TowaryDostepneModel)JsonConvert.DeserializeObject(res.GetTowaryResult));

            //towaryGrid.DataSource = towary;
        }




    }
}

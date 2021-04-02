using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WarehouseLibrary;
using WarehouseService;

using Newtonsoft.Json;
using System.Net;
using System.Configuration;
using System.ServiceModel;

namespace WarehouseClientUI
{
    public partial class ZamowForm : Form
    {
        public ZamowForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //uniemozliwienie maksymalizacji okna
            this.MaximizeBox = false;

        }

        private void ZamowButton_Click(object sender, EventArgs e)
        {
            fillRequestBody();            
        }

        private void fillRequestBody()
        {
            // configurating webservice endpoints programmicaly setting binding security mode to transport to support https connection
            var binding = new BasicHttpBinding();
            binding.Security.Mode = BasicHttpSecurityMode.Transport;
            var client = new WarehouseService.WarehouseWebServiceSoapClient(binding, new EndpointAddress("https://localhost:44334/WarehouseWebService.asmx"));
                                       
             
            
          

            
            //zamowienie.ilosc = 0;
            //int.TryParse(IloscBox.Text,out zamowienie.ilosc);
            //zamowienie.id = 1;

           
        }
       private bool ValidateForm()
        {
            Validate validate = new Validate();
            bool output = true;
            if (!validate.Number(IloscBox.Text))
            {
                MessageBox.Show("ID must be a positive intiger");
                output = false;
            }
            return output;
        }
    }
}

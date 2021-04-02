using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WarehouseLibrary;
using ServiceReference1;

using Newtonsoft.Json;
using System.Net;
using System.Configuration;

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
            var timout = new TimeSpan(39);

            var client = new ServiceReference1.WarehouseWebServiceSoapClient(timout,"https://localhost:44334/WarehouseWebService.asmx");
            client.GetTowaryAsync();
       

             var res = new GetTowaryResponseBody();
            
            //var req = new WarehouseWebServiceReference.SendZamowienieRequestBody();
            //req.imie = "s";
            //var client = new WarehouseWebServiceReference.WarehouseWebServiceSoapClient();
            //client.GetTowaryAsync();
            //MessageBox.Show(JsonConvert.SerializeObject(res));

            client.SendZamowienieAsync(1, 1, "a","b","c","d");
            //zamowienie.ilosc = 0;
            //int.TryParse(IloscBox.Text,out zamowienie.ilosc);
            //zamowienie.id = 1;
            //SendZamowienieResponse response = new SendZamowienieResponse();
            MessageBox.Show(res.ToString());

        }
       private bool ValidateForm()
        {
            Validate validate = new Validate();
            bool output = true;
            if (!validate.Number(IloscBox.Text))
            {
                MessageBox.Show("ID must be a positive intiger");
            }
            return output;
        }
    }
}

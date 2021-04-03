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
    {   //passing previous form as  a constructor argument, so I am able to use podgladForm.Show();
        private PodgladForm podgladForm;
        public int id;
        public ZamowForm(PodgladForm mypodgladForm)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //uniemozliwienie maksymalizacji okna
            this.MaximizeBox = false;
            podgladForm = mypodgladForm;
        }

        private void ZamowButton_Click(object sender, EventArgs e)
        {
            SendZamowienie();
        }

        private void SendZamowienie()
        {
          
            if (ValidateForm())
            {
                // configurating webservice endpoints programmicaly setting binding security mode to transport to support https connection
                var binding = new BasicHttpBinding();
                binding.Security.Mode = BasicHttpSecurityMode.Transport;
                var client = new WarehouseService.WarehouseWebServiceSoapClient(binding, new EndpointAddress("https://localhost:44334/WarehouseWebService.asmx"));
                int ilosc = 0;
                int.TryParse(IloscBox.Text, out ilosc);
                if (client.SendZamowienie(id, ilosc, ImieBox.Text, NazwiskoBox.Text, AdresBox.Text, DostawaBox.Text)) {
                    MessageBox.Show("Zamowienie zostało wysłane.");
                    this.Hide();
                    podgladForm.Show();
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd przy składaniu zamówienia, prosimy spróbować ponownie.");
                }
                                
            }


        }
       private bool ValidateForm()
        {
            Validate validate = new Validate();
            bool output = true;
          
            if (!validate.Number(IloscBox.Text))
            {
                MessageBox.Show("Ilość must be a positive intiger");
                output = false;
            }
            if (!validate.Text(ImieBox.Text))
            {
                MessageBox.Show("Imie field cannot be empty");
                output = false;
            }
            if (!validate.Text(NazwiskoBox.Text))
            {
                MessageBox.Show("Nazwisko field cannot be empty");
                output = false;
            }
            if (!validate.Text(AdresBox.Text))
            {
                MessageBox.Show("Adres field cannot be empty");
                output = false;
            }
            if (!validate.Text(DostawaBox.Text))
            {
                MessageBox.Show("Dostawa field cannot be empty");
                output = false;
            }

            return output;
        }
    }
}

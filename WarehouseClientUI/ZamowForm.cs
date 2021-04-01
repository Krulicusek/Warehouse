using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WarehouseLibrary;
using WarehouseWebService;
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
            WarehouseWebService.SendZamowienieRequestBody zamowienie = new WarehouseWebService.SendZamowienieRequestBody();
            zamowienie.ilosc = 0;
            int.TryParse(IloscBox.Text,out zamowienie.ilosc);
            zamowienie.id = 1;
            SendZamowienieResponse response = new SendZamowienieResponse();
            MessageBox.Show(response.ToString());
            
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

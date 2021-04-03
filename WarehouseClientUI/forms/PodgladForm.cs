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
        private ZamowForm zamowForm;


        public PodgladForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //uniemozliwienie maksymalizacji okna
            this.MaximizeBox = false;
            zamowForm = new ZamowForm(this);
            InitializeGrid();

        }

        private void InitializeGrid()
        {
            // configurating webservice endpoints programmicaly setting binding security mode to transport to support https connection
            var binding = new BasicHttpBinding();
            binding.Security.Mode = BasicHttpSecurityMode.Transport;

            var client = new WarehouseService.WarehouseWebServiceSoapClient(binding, new EndpointAddress("https://localhost:44334/WarehouseWebService.asmx"));
            // filling dataGridView with database information using webservice method
            towaryGrid.DataSource = JsonConvert.DeserializeObject(client.GetTowary());
            // Adding a button column, and giving it some styling 
            DataGridViewButtonColumn buttonColumn =
                new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Zamów";
            buttonColumn.Name = "Zamow";
            buttonColumn.Text = "Zamów";
            buttonColumn.UseColumnTextForButtonValue = true;
            buttonColumn.FlatStyle = FlatStyle.Popup;
            buttonColumn.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            buttonColumn.DefaultCellStyle.ForeColor = SystemColors.MenuHighlight;
           
            towaryGrid.Columns.Add(buttonColumn);
            //setting datagrid columns names
            towaryGrid.Columns[0].HeaderText = "ID";
            towaryGrid.Columns[1].HeaderText = "Nazwa";
            towaryGrid.Columns[2].HeaderText = "Data Gwarancji";
            towaryGrid.Columns[3].HeaderText = "Ilość";
            //setting datagridview button click action
            towaryGrid.CellClick += new DataGridViewCellEventHandler(towaryGrid_CellClick);
        }

        private void towaryGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not on button cells. 
            if (e.RowIndex < 0 || e.ColumnIndex != towaryGrid.Columns["Zamow"].Index) return;
            var val = towaryGrid[1, e.RowIndex].Value;
            zamowForm.id = Convert.ToInt32(val);              
            this.Hide();
            zamowForm.Show();
            
        }
    }
}

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
        private AnulujForm anulujForm;

        public PodgladForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //uniemozliwienie maksymalizacji okna
            this.MaximizeBox = false;
            zamowForm = new ZamowForm(this);
            anulujForm = new AnulujForm(this);
            InitializeGrid();
            

        }

        private void InitializeGrid()
        {
            // configurating webservice endpoints programmicaly setting binding security mode to transport to support https connection
            var binding = new BasicHttpBinding();
            binding.Security.Mode = BasicHttpSecurityMode.Transport;
            var client = new WarehouseService.WarehouseWebServiceSoapClient(binding, new EndpointAddress("https://localhost:44334/WarehouseWebService.asmx"));
            try
            {
                // filling dataGridView with database information using webservice method
                towaryGrid.DataSource = JsonConvert.DeserializeObject(client.GetTowary());
                // Adding a link column, and giving it some styling 

                DataGridViewLinkColumn links = new DataGridViewLinkColumn();
                links.UseColumnTextForLinkValue = true;
                links.HeaderText = "Zamów";
                links.DataPropertyName = "Zamów";
                links.ActiveLinkColor = Color.LightBlue;
                links.LinkColor = SystemColors.Highlight;
                links.TrackVisitedState = false;
                links.DefaultCellStyle.NullValue = "Zamów";
                links.Name = "Zamów";

               
                //removing the styling for selection
                towaryGrid.DefaultCellStyle.SelectionBackColor = Color.White;
                towaryGrid.DefaultCellStyle.SelectionForeColor = Color.Black;


                towaryGrid.Columns.Add(links);
                //setting datagrid columns names
                towaryGrid.Columns[0].HeaderText = "ID";
                towaryGrid.Columns[1].HeaderText = "Nazwa";
                towaryGrid.Columns[2].HeaderText = "Data Gwarancji";
                towaryGrid.Columns[3].HeaderText = "Ilość";
                //setting datagridview button click action
                towaryGrid.CellClick += new DataGridViewCellEventHandler(towaryGrid_CellClick);
            } catch (Exception)
            {
                MessageBox.Show("Cannot connect to the webservice.");
            }
        }

        private void towaryGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not on button cells. 
            if (e.RowIndex < 0 || e.ColumnIndex != towaryGrid.Columns["Zamów"].Index) return;
            
            zamowForm.id = Convert.ToInt32(towaryGrid[1, e.RowIndex].Value);              
            this.Hide();
            zamowForm.Show();
            
        }

        private void AnulujButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            anulujForm.Show();
        }
    }
}

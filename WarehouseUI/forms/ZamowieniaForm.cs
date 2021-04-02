using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WarehouseLibrary;
namespace WarehouseUI
{

    public partial class ZamowieniaForm : Form
    {
        
        private List<ZamowieniaModel> zamowienia = new List<ZamowieniaModel>();
        private DataAccess db = new DataAccess();
        private MenuForm menuForm;
        public ZamowieniaForm(MenuForm myMenuform)
        {
            InitializeComponent();
            // aby mieć możliwość powrotu do okienka menu (MenuForm), przy tworzeniu nowego okienka przekazuje mu jako argument konstruktora
            // MenuForm myMenuForm, dzięki czemu mogę wewnątrz nowgo okienka używać menuForm.Show();
            menuForm = myMenuform;
            //wyświetlam wszystkie zamówienia
            zamowienia = db.GetZamowieniaModel(null, "", null); 
            ZamowieniaTabela.DataSource = zamowienia;
            //centrowanie okna
            this.StartPosition = FormStartPosition.CenterScreen;
            //uniemozliwienie maksymalizacji okna
            this.MaximizeBox = false;

        }

        private void PodgladButton_Click(object sender, EventArgs e)
        {   // pobiera zamowienia z bazy danych jezeli wprowadzone dane sa poprawne
            GetZamowieniaIfValid();
            // czysci pola
            ClearLeftFields();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //ukrywam aktualne okienko
            this.Hide();
            // pokazuje okno MenuForm
            menuForm.Show();
        }

        private void GetZamowieniaIfValid()
        {
            Validate validate = new Validate();
            bool output = true;
            string id = IDBox.Text;
            string nazwisko = NazwiskoBox.Text;          
            string adres = AdresBox.Text;
            if (id.Length>0)
            {
                if (!validate.Number(id))
                {
                    MessageBox.Show("ID must be a positive intiger");
                    output = false;
                }
            }
            if (!validate.Text(nazwisko))
            {
                nazwisko = null; 
            }
           
            if (!validate.Text(adres))
            {
                adres = null;
            }
            if (output)
            {
                zamowienia = db.GetZamowieniaModel(id, nazwisko, adres);
                ZamowieniaTabela.DataSource = zamowienia;
            }
         }
        
        private bool ValidateRealizacja()
        {
            Validate validate = new Validate();
            bool output = true;
            if (!validate.Number(IDRightBox.Text))
            {
                MessageBox.Show("ID must be a positive intiger");
                output = false;
            }
            return output;
        }

        private void RealizujButton_Click(object sender, EventArgs e)
        {
            if (ValidateRealizacja())
            {
                RealizujModel realizujModel = new RealizujModel(IDRightBox.Text);
                // wykonuje procedure realizacji zamowienia
                db.Realizuj(realizujModel.ID_Zamowienia);
                //czysci pole
                IDRightBox.Clear();
                // wyswietla kominikat
                MessageBox.Show("Zrealizowano zamowienie");
            }
        }

        private void ShowAllButton_Click (object sender, EventArgs e)
        {
            zamowienia = db.GetZamowieniaModel(null, "", null);
            ZamowieniaTabela.DataSource = zamowienia;
        }

        //Po wcisnieciu krzyzyka w prawym górnym rogu, okno ukrywa sie, zamiast zamykać
        //dzięki czemu można pozniej z poziomu menu znowu wrocic do tego okna
        private void HideForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                menuForm.Show();
            }
        }
        // czyszczenie pol tekstowych
        private void ClearLeftFields()
        {
            IDBox.Clear();
            NazwiskoBox.Clear();
            AdresBox.Clear();
        }
        



    }
}

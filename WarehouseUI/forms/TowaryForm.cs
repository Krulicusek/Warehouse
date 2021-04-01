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
   
    public partial class TowaryForm : Form
    {
        
        private List<TowaryModel> towary = new List<TowaryModel>();
        private DataAccess db = new DataAccess();        
        private MenuForm menuForm;
        public TowaryForm(MenuForm myMenuForm)
        {
            InitializeComponent();
            // aby mieć możliwość powrotu do okienka menu (MenuForm), przy tworzeniu nowego okienka przekazuje mu jako argument konstruktora
            // MenuForm myMenuForm, dzięki czemu mogę wewnątrz nowgo okienka używać menuForm.Show();
            menuForm = myMenuForm;
            //wyswietlam wszystkie towary
            towary = db.GetTowaryModel(null, ""); 
            TowaryTabela.DataSource = towary;
            //pozycjonowanie okna, tak aby widać było okno menu, gdyż najwygodniej korzystać z aplikacji mając otwarte okienko podglądu
            //towaru oraz okno (dodaj, edytuj, usun) i odrazu podglądać zmiany wynikajace z dodania, edytowania czy usuwania towaru
            this.StartPosition = FormStartPosition.Manual;
            //uniemozliwienie maksymalizacji okna
            this.MaximizeBox = false;

        }

        private void BackButton_Click(object sender, EventArgs e)
        {   // ukrywa aktualne okno
            this.Hide();
            // pokazuje okno menu
            menuForm.Show();
        }

        private void TowaryButton_Click(object sender, EventArgs e)
        {   // wykonuje procedure i pobiera z bazy danych towary
            GetTowaryIfValid();
            // czysci pola
            ClearFields();
        }
        private void GetTowaryIfValid()
        {            
            bool output = true;
            string id = IDBox.Text;
            string nazwa = NazwaBox.Text;
            Validate validate = new Validate();
            if (id.Length>0)
            {
                if (!validate.Number(id))
                {
                    output = false;
                    MessageBox.Show("ID must be a positive intiger");
                }
               
            }
            if (nazwa.Length==0)
            {
                nazwa = null;
            }
           if (output)
            {
                towary = db.GetTowaryModel(id, nazwa);
                TowaryTabela.DataSource = towary;
            }
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            towary = db.GetTowaryModel(null, "");
            TowaryTabela.DataSource = towary;
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
        private void ClearFields()
        {
            IDBox.Clear();
            NazwaBox.Clear();
        }

    }

}

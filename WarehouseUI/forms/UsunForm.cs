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
    public partial class UsunForm : Form
    {
        private MenuForm menuForm;
        public UsunForm(MenuForm myMenuForm)
        {
            InitializeComponent();
            // aby mieć możliwość powrotu do okienka menu (MenuForm), przy tworzeniu nowego okienka przekazuje mu jako argument konstruktora
            // MenuForm myMenuForm, dzięki czemu mogę wewnątrz nowgo okienka używać menuForm.Show();
            menuForm = myMenuForm;
            //centrowanie okna
            this.StartPosition = FormStartPosition.CenterScreen;
            //uniemozliwienie maksymalizacji okna
            this.MaximizeBox = false;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuForm.Show();
        }

        private void UsunButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                DataAccess db = new DataAccess();
                UsunModel usunModel = new UsunModel(ID_Box.Text);
                // wykonuje procedure usuniecia towaru
                db.UsunTowar(usunModel.ID_Towaru);
                // czysci pole ID
                ID_Box.Clear();
                MessageBox.Show("Usunięto towar");
            }
        }
    
    private bool ValidateForm()
        {
            Validate validate = new Validate();
            bool output = true;
            if (!validate.Number(ID_Box.Text))
            {
                MessageBox.Show("ID must be a positive intiger");
            }
            return output;
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

      
    }
}

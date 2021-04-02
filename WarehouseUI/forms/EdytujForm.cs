using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using WarehouseLibrary;

namespace WarehouseUI
{
    public partial class EdytujForm : Form
    {
        private MenuForm menuForm;
        private DateTime dt;
        public EdytujForm(MenuForm myMenuForm)
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

        private void EdytujButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                DataAccess db = new DataAccess();
                EdytujModel edytujModel = new EdytujModel(IDBox.Text, NazwaBox.Text, dt, TypBox.Text, IloscBox.Text);
                // wykonuje procedure edycji towaru
                if(db.Edytuj(edytujModel.ID_Towaru, edytujModel.Nazwa_Towaru, edytujModel.Data_Gwarancji, edytujModel.Typ_Towaru, edytujModel.Ilosc))
                {
                    // czysci pola
                    ClearFields();
                    //wyswietlanie komunikatu
                    MessageBox.Show("Edytowano towar.");
                }
                else
                {
                    MessageBox.Show("Brak Towaru o podanym ID_Towaru");
                }
               
            }
        }

        private bool ValidateForm()
        {
            Validate validate = new Validate();
            bool output = true;
            if (!validate.Number(IDBox.Text))
            {
                MessageBox.Show("ID must be a positive intiger");
                output = false;
            }
            if (!validate.Text(NazwaBox.Text))
            {
                MessageBox.Show("Nazwa Towaru cannot be empty");
                output = false;
            }
            if (!validate.Text(DataBox.Text))
            {
                MessageBox.Show("Data Gwarancji cannot be empty");
                output = false;
            }
            if (!validate.Text(TypBox.Text))
            {
                MessageBox.Show("Typ Towaru cannot be empty");
                output = false;
            }
            if (!validate.Number(IloscBox.Text))
            {
                MessageBox.Show("Ilosc must be a positive intiger");
                output = false;
            }
            try
            {
                dt = DateTime.ParseExact(DataBox.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                output = false;
                // Informacja o sposobie podania daty.
                // UWAGA "MM" w niekorych zrodlach
                // traktowane jest jako slowne podanie miesiaca, natomiast tutaj "mm" zarezerwowane
                // jest dla minut, a wiec "MM" oznacza miesiace jako 2 cyfry
                // ponieważ w kontekscie "dd/mm/yyyy" wiadomo, że  "mm" odnosi się do miesiaca zapisuje je z malych liter
                // w komunikacie wyświetlam dokladna informacje, jak nalezy wprowdzic date              
                MessageBox.Show($"Data gwarancji musi zostac podana w formacie 'dd/mm/yyyy', gdzie wszystkie wartosci podajemy jako cyfry i odzielamy znakiem '/'.");
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
        private void ClearFields()
        {
            IDBox.Clear();
            NazwaBox.Clear();
            DataBox.Clear();
            TypBox.Clear();
            IloscBox.Clear();

        }

    }

}

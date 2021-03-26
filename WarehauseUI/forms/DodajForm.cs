using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WarehouseLibrary;
using WarehouseLibrary.Properties;
using System.Globalization;

namespace WarehouseUI
{
    public partial class DodajForm : Form
    {
        private DataAccess db = new DataAccess();
        private MenuForm menuForm;
        private DateTime dt;
        public DodajForm(MenuForm myMenuForm)
        {
            InitializeComponent();
            // aby mieć możliwość powrotu do okienka menu (MenuForm), przy tworzeniu nowego okienka przekazuje mu jako argument konstruktora
            // MenuForm myMenuForm, dzięki czemu mogę wewnątrz nowgo okienka używać menuForm.Show();
            menuForm = myMenuForm;
            //automatycznie zaznaczam pierwsze pole do wypelnienia
            NazwaBox.Select();
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

        private void DodajButton_Click(object sender, EventArgs e)
        {
            if (ValidateOuterForm())
            {
                NowyModel nowyModel = new NowyModel(NazwaBox.Text, dt, TypBox.Text, IloscBox.Text);
                // wykonuje precedure dodania nowego towaru
                db.DodajNowy(nowyModel.NazwaTowaru, nowyModel.DataGwarancji, nowyModel.TypTowaru, nowyModel.Ilosc);
                // czysci pola
                ClearOuterFields();
                //wyswietla kominikat o pomyslnym dodaniu towaru
                MessageBox.Show("Dodano nowy towar");

            }
        }    

        private void DodajIloscButton_Click(object sender, EventArgs e)
        {
           if ( ValidateInnerForm() ) 
            {
                
                IloscModel iloscModel = new IloscModel(ID_Box.Text, IloscInnerBox.Text);
                // wykonuje procedure dodania dostepnych towarow
                db.DodajIlosc(iloscModel.ID_Towaru, iloscModel.Ilosc);
                // czysci pola
                ClearInnerFields();
                // wyswietla kominikat o pomyslym dodaniu towarow
                MessageBox.Show("Liczba dostepnych towarow wzrosla");
            }
           
        }
      

      

        private bool ValidateInnerForm()
        {
            bool output = true;
            Validate validate = new Validate();
            if (!validate.Number(ID_Box.Text))
            {
                MessageBox.Show("ID must be a positive intiger");
                output = false;
            }
            if (!validate.Number(IloscInnerBox.Text))
            {
                MessageBox.Show("Ilosc must be a positive intiger");
                output = false;
            }
            return output;
        }
        private bool ValidateOuterForm()
        {
            bool output = true;
            Validate validate = new Validate();
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

        private void ClearOuterFields()
        {
            NazwaBox.Clear();
            DataBox.Clear();
            TypBox.Clear();
            IloscBox.Clear();
        }
        private void ClearInnerFields()
        {
            ID_Box.Clear();
            IloscInnerBox.Clear();
        }

    }
}

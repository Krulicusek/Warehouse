using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WarehouseLibrary;

namespace WarehouseUI
{
    public class FormsInfoBox

    {
        private string idString;       
        private string iloscString;
        private string imie;
        private string nazwisko;
        private string adres;
        private string dostawa;
        public FormsInfoBox()
        {

        }/// <summary>
        /// want to take away all the code for checking forms to a one place this is currently not working
        /// </summary>
        /// <returns></returns>
        private bool ValidateForm()
        {
            Validate validate = new Validate();
            bool output = true;

            if (!validate.Number(idString))
            {
                MessageBox.Show("ID must be a positive intiger");
                output = false;
            }
            if (!validate.Number(iloscString))
            {
                MessageBox.Show("Ilość must be a positive intiger");
                output = false;
            }
            if (!validate.Text(imie))
            {
                MessageBox.Show("Imie field cannot be empty");
                output = false;
            }
            if (!validate.Text(nazwisko))
            {
                MessageBox.Show("Nazwisko field cannot be empty");
                output = false;
            }
            if (!validate.Text(adres))
            {
                MessageBox.Show("Adres field cannot be empty");
                output = false;
            }
            if (!validate.Text(dostawa))
            {
                MessageBox.Show("Dostawa field cannot be empty");
                output = false;
            }

            return output;
        }
    }
}

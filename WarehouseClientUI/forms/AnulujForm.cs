using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WarehouseClientUI
{
    public partial class AnulujForm : Form
       
    {
        private PodgladForm podgladForm;
        public AnulujForm(PodgladForm mypodgladForm)
        {
            InitializeComponent();
            podgladForm = mypodgladForm;
        }

        private void AnulujButton_Click(object sender, EventArgs e)
        {

        }
        //Po wcisnieciu krzyzyka w prawym górnym rogu, okno ukrywa sie, zamiast zamykać
        //dzięki czemu można pozniej z poziomu menu znowu wrocic do tego okna
        private void HideForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                podgladForm.Show();
            }
        }

    }
}

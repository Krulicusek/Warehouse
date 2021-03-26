using System;
using System.Drawing;
using System.Windows.Forms;

namespace WarehouseUI
{
    public partial class MenuForm : Form
    {
        private DodajForm dodajForm;
        private EdytujForm edytujForm;
        private UsunForm usunForm;
        private TowaryForm towaryForm;
        private ZamowieniaForm zamowieniaForm;
        public MenuForm()
        {
            InitializeComponent();
            // aby mieć możliwość powrotu do okienka menu (MenuForm) z poziomu nastepnego okna (dodaj, edytuj, usun, podgladTowaru, podglad Zamowienia)
            // jako instance variables klasy menu form dodaje klasy okienek podrzednych, dzieki czemu moge wewnatrz menu form uzywać
            // na przyklad dodajForm.show()
            // dlatego w konstruktorze Menuform inicjuje wszystkie potrzebne okienka
            dodajForm = new DodajForm(this);
            edytujForm = new EdytujForm(this);
            usunForm = new UsunForm(this);
            towaryForm = new TowaryForm(this);
            zamowieniaForm = new ZamowieniaForm(this);
            //centrowanie okna
            this.StartPosition = FormStartPosition.CenterScreen;
            //uniemozliwienie maksymalizacji okna
            this.MaximizeBox = false;
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
        private void DodajButton_Click (object sender, EventArgs e)
        {
            //ukrywa aktualne okno oraz pokazuje okno podrzedne
            this.Hide();
            dodajForm.Show();            
        }
   
        private void EdytujButton_Click(object sender, EventArgs e)
        {
            //ukrywa aktualne okno oraz pokazuje okno podrzedne
            this.Hide();
            edytujForm.Show();
        }
 
        private void UsunButton_Click(object sender, EventArgs e)
        {
            //ukrywa aktualne okno oraz pokazuje okno podrzedne
            this.Hide();
            usunForm.Show();
        }

        private void TowaryButton_Click(object sender, EventArgs e)
        {
            //ukrywa aktualne okno oraz pokazuje okno podrzedne
            towaryForm.Show();         
        }

        private void ZamowieniaButton_Click(object sender, EventArgs e)
        {
            //ukrywa aktualne okno oraz pokazuje okno podrzedne
            this.Hide();
            zamowieniaForm.Show();
         }
 

    }
}


namespace WarehouseUI
{
    partial class ZamowieniaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZamowieniaForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PodgladButton = new WarehouseUI.MyButton();
            this.BackButton = new WarehouseUI.MyButton();
            this.BackLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.NazwiskoLabel = new System.Windows.Forms.Label();
            this.NazwiskoBox = new System.Windows.Forms.TextBox();
            this.EdytujLabel = new System.Windows.Forms.Label();
            this.ZamowieniaTabela = new System.Windows.Forms.DataGridView();
            this.RealizujButton = new WarehouseUI.MyButton();
            this.IDRealizujLabel = new System.Windows.Forms.Label();
            this.IDRightBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AdresLabel = new System.Windows.Forms.Label();
            this.AdresBox = new System.Windows.Forms.TextBox();
            this.ShowAllButton = new WarehouseUI.MyButton();
            ((System.ComponentModel.ISupportInitialize)(this.ZamowieniaTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // PodgladButton
            // 
            this.PodgladButton.BackColor = System.Drawing.Color.White;
            this.PodgladButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.PodgladButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.PodgladButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PodgladButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PodgladButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PodgladButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PodgladButton.Location = new System.Drawing.Point(60, 414);
            this.PodgladButton.Name = "PodgladButton";
            this.PodgladButton.Size = new System.Drawing.Size(297, 89);
            this.PodgladButton.TabIndex = 4;
            this.PodgladButton.Text = "Podgląd zamowień";
            this.PodgladButton.UseVisualStyleBackColor = false;
            this.PodgladButton.Click += new System.EventHandler(this.PodgladButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.White;
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(14, 12);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(55, 47);
            this.BackButton.TabIndex = 8;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackLabel.Location = new System.Drawing.Point(77, 12);
            this.BackLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(280, 50);
            this.BackLabel.TabIndex = 9;
            this.BackLabel.Text = "Powrót do menu";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.IDLabel.Location = new System.Drawing.Point(12, 240);
            this.IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(49, 45);
            this.IDLabel.TabIndex = 33;
            this.IDLabel.Text = "ID";
            // 
            // IDBox
            // 
            this.IDBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDBox.Location = new System.Drawing.Point(277, 253);
            this.IDBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(195, 33);
            this.IDBox.TabIndex = 1;
            // 
            // NazwiskoLabel
            // 
            this.NazwiskoLabel.AutoSize = true;
            this.NazwiskoLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NazwiskoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NazwiskoLabel.Location = new System.Drawing.Point(13, 284);
            this.NazwiskoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NazwiskoLabel.Name = "NazwiskoLabel";
            this.NazwiskoLabel.Size = new System.Drawing.Size(147, 45);
            this.NazwiskoLabel.TabIndex = 29;
            this.NazwiskoLabel.Text = "Nazwisko";
            // 
            // NazwiskoBox
            // 
            this.NazwiskoBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NazwiskoBox.Location = new System.Drawing.Point(277, 297);
            this.NazwiskoBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NazwiskoBox.Name = "NazwiskoBox";
            this.NazwiskoBox.Size = new System.Drawing.Size(195, 33);
            this.NazwiskoBox.TabIndex = 2;
            // 
            // EdytujLabel
            // 
            this.EdytujLabel.AutoSize = true;
            this.EdytujLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EdytujLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.EdytujLabel.Location = new System.Drawing.Point(14, 113);
            this.EdytujLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EdytujLabel.Name = "EdytujLabel";
            this.EdytujLabel.Size = new System.Drawing.Size(318, 50);
            this.EdytujLabel.TabIndex = 36;
            this.EdytujLabel.Text = "Podgląd zamowien";
            // 
            // ZamowieniaTabela
            // 
            this.ZamowieniaTabela.AllowUserToOrderColumns = true;
            this.ZamowieniaTabela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.ZamowieniaTabela.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ZamowieniaTabela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ZamowieniaTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ZamowieniaTabela.Location = new System.Drawing.Point(534, 73);
            this.ZamowieniaTabela.Name = "ZamowieniaTabela";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ZamowieniaTabela.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ZamowieniaTabela.RowTemplate.Height = 25;
            this.ZamowieniaTabela.Size = new System.Drawing.Size(808, 430);
            this.ZamowieniaTabela.TabIndex = 37;
            // 
            // RealizujButton
            // 
            this.RealizujButton.BackColor = System.Drawing.Color.White;
            this.RealizujButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.RealizujButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.RealizujButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.RealizujButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RealizujButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RealizujButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RealizujButton.Location = new System.Drawing.Point(923, 531);
            this.RealizujButton.Name = "RealizujButton";
            this.RealizujButton.Size = new System.Drawing.Size(297, 89);
            this.RealizujButton.TabIndex = 7;
            this.RealizujButton.Text = "Realizuj zamowienie";
            this.RealizujButton.UseVisualStyleBackColor = false;
            this.RealizujButton.Click += new System.EventHandler(this.RealizujButton_Click);
            // 
            // IDRealizujLabel
            // 
            this.IDRealizujLabel.AutoSize = true;
            this.IDRealizujLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDRealizujLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.IDRealizujLabel.Location = new System.Drawing.Point(655, 549);
            this.IDRealizujLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDRealizujLabel.Name = "IDRealizujLabel";
            this.IDRealizujLabel.Size = new System.Drawing.Size(49, 45);
            this.IDRealizujLabel.TabIndex = 41;
            this.IDRealizujLabel.Text = "ID";
            // 
            // IDRightBox
            // 
            this.IDRightBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDRightBox.Location = new System.Drawing.Point(712, 561);
            this.IDRightBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IDRightBox.Name = "IDRightBox";
            this.IDRightBox.Size = new System.Drawing.Size(195, 33);
            this.IDRightBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(14, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 21);
            this.label1.TabIndex = 49;
            this.label1.Text = "Fill  fields that should be included in SELECT statment";
            // 
            // AdresLabel
            // 
            this.AdresLabel.AutoSize = true;
            this.AdresLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdresLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AdresLabel.Location = new System.Drawing.Point(14, 329);
            this.AdresLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdresLabel.Name = "AdresLabel";
            this.AdresLabel.Size = new System.Drawing.Size(96, 45);
            this.AdresLabel.TabIndex = 51;
            this.AdresLabel.Text = "Adres";
            // 
            // AdresBox
            // 
            this.AdresBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdresBox.Location = new System.Drawing.Point(278, 342);
            this.AdresBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AdresBox.Name = "AdresBox";
            this.AdresBox.Size = new System.Drawing.Size(195, 33);
            this.AdresBox.TabIndex = 3;
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.BackColor = System.Drawing.Color.White;
            this.ShowAllButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ShowAllButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ShowAllButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ShowAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowAllButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShowAllButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ShowAllButton.Location = new System.Drawing.Point(60, 531);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(297, 89);
            this.ShowAllButton.TabIndex = 5;
            this.ShowAllButton.Text = "Pokaż wszystkie zamowienia";
            this.ShowAllButton.UseVisualStyleBackColor = false;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // ZamowieniaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1393, 658);
            this.Controls.Add(this.ShowAllButton);
            this.Controls.Add(this.AdresLabel);
            this.Controls.Add(this.AdresBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDRightBox);
            this.Controls.Add(this.IDRealizujLabel);
            this.Controls.Add(this.RealizujButton);
            this.Controls.Add(this.ZamowieniaTabela);
            this.Controls.Add(this.EdytujLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.NazwiskoLabel);
            this.Controls.Add(this.NazwiskoBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.BackLabel);
            this.Controls.Add(this.PodgladButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZamowieniaForm";
            this.Text = "Podglad zamowien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HideForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ZamowieniaTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyButton PodgladButton;
        private MyButton BackButton;
        private System.Windows.Forms.Label BackLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.Label NazwiskoLabel;
        private System.Windows.Forms.TextBox NazwaBox;
        private System.Windows.Forms.Label EdytujLabel;
        private System.Windows.Forms.DataGridView ZamowieniaTabela;
        private System.Windows.Forms.TextBox NazwiskoBox;
        private MyButton Realizuj;
        private MyButton RealizujButton;
        private System.Windows.Forms.Label IDRealizuj;
        private System.Windows.Forms.Label IDRealizujLabel;
        private System.Windows.Forms.TextBox IDRightBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AdresLabel;
        private System.Windows.Forms.TextBox AdresBox;
        private MyButton ShowAllButton;
    }
}
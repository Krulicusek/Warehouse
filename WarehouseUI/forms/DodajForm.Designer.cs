
namespace WarehouseUI
{
    partial class DodajForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajForm));
            this.NowyLabel = new System.Windows.Forms.Label();
            this.DodajIloscButton = new WarehouseUI.MyButton();
            this.BackLabel = new System.Windows.Forms.Label();
            this.BackButton = new WarehouseUI.MyButton();
            this.DodajIloscBox = new System.Windows.Forms.GroupBox();
            this.IloscInnerLabel = new System.Windows.Forms.Label();
            this.IloscInnerBox = new System.Windows.Forms.TextBox();
            this.IDInnerLabel = new System.Windows.Forms.Label();
            this.ID_Box = new System.Windows.Forms.TextBox();
            this.TypLabel = new System.Windows.Forms.Label();
            this.IloscBox = new System.Windows.Forms.TextBox();
            this.IloscOuterLabel = new System.Windows.Forms.Label();
            this.NazwaBox = new System.Windows.Forms.TextBox();
            this.NazwaLabel = new System.Windows.Forms.Label();
            this.DataBox = new System.Windows.Forms.TextBox();
            this.DataLabel = new System.Windows.Forms.Label();
            this.DodajButton = new WarehouseUI.MyButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TypBox = new System.Windows.Forms.ComboBox();
            this.DodajIloscBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NowyLabel
            // 
            this.NowyLabel.AutoSize = true;
            this.NowyLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NowyLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NowyLabel.Location = new System.Drawing.Point(610, 46);
            this.NowyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NowyLabel.Name = "NowyLabel";
            this.NowyLabel.Size = new System.Drawing.Size(305, 50);
            this.NowyLabel.TabIndex = 3;
            this.NowyLabel.Text = "Dodaj nowy towar";
            // 
            // DodajIloscButton
            // 
            this.DodajIloscButton.BackColor = System.Drawing.Color.White;
            this.DodajIloscButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DodajIloscButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.DodajIloscButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DodajIloscButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DodajIloscButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DodajIloscButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DodajIloscButton.Location = new System.Drawing.Point(95, 182);
            this.DodajIloscButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DodajIloscButton.Name = "DodajIloscButton";
            this.DodajIloscButton.Size = new System.Drawing.Size(195, 51);
            this.DodajIloscButton.TabIndex = 8;
            this.DodajIloscButton.Text = "Dodaj ilość";
            this.DodajIloscButton.UseVisualStyleBackColor = false;
            this.DodajIloscButton.Click += new System.EventHandler(this.DodajIloscButton_Click);
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackLabel.Location = new System.Drawing.Point(74, 9);
            this.BackLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(280, 50);
            this.BackLabel.TabIndex = 5;
            this.BackLabel.Text = "Powrót do menu";
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
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(55, 47);
            this.BackButton.TabIndex = 9;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DodajIloscBox
            // 
            this.DodajIloscBox.Controls.Add(this.IloscInnerLabel);
            this.DodajIloscBox.Controls.Add(this.IloscInnerBox);
            this.DodajIloscBox.Controls.Add(this.IDInnerLabel);
            this.DodajIloscBox.Controls.Add(this.ID_Box);
            this.DodajIloscBox.Controls.Add(this.DodajIloscButton);
            this.DodajIloscBox.Font = new System.Drawing.Font("Segoe UI Light", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DodajIloscBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.DodajIloscBox.Location = new System.Drawing.Point(54, 230);
            this.DodajIloscBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DodajIloscBox.Name = "DodajIloscBox";
            this.DodajIloscBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DodajIloscBox.Size = new System.Drawing.Size(384, 265);
            this.DodajIloscBox.TabIndex = 7;
            this.DodajIloscBox.TabStop = false;
            this.DodajIloscBox.Text = "Dodaj ilość dostępnych towarów";
            // 
            // IloscInnerLabel
            // 
            this.IloscInnerLabel.AutoSize = true;
            this.IloscInnerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IloscInnerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.IloscInnerLabel.Location = new System.Drawing.Point(61, 102);
            this.IloscInnerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IloscInnerLabel.Name = "IloscInnerLabel";
            this.IloscInnerLabel.Size = new System.Drawing.Size(89, 50);
            this.IloscInnerLabel.TabIndex = 14;
            this.IloscInnerLabel.Text = "Ilość";
            // 
            // IloscInnerBox
            // 
            this.IloscInnerBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IloscInnerBox.Location = new System.Drawing.Point(158, 119);
            this.IloscInnerBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IloscInnerBox.Name = "IloscInnerBox";
            this.IloscInnerBox.Size = new System.Drawing.Size(124, 33);
            this.IloscInnerBox.TabIndex = 7;
            // 
            // IDInnerLabel
            // 
            this.IDInnerLabel.AutoSize = true;
            this.IDInnerLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDInnerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.IDInnerLabel.Location = new System.Drawing.Point(95, 57);
            this.IDInnerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDInnerLabel.Name = "IDInnerLabel";
            this.IDInnerLabel.Size = new System.Drawing.Size(49, 45);
            this.IDInnerLabel.TabIndex = 12;
            this.IDInnerLabel.Text = "ID";
            // 
            // ID_Box
            // 
            this.ID_Box.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ID_Box.Location = new System.Drawing.Point(158, 69);
            this.ID_Box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Size = new System.Drawing.Size(124, 33);
            this.ID_Box.TabIndex = 6;
            // 
            // TypLabel
            // 
            this.TypLabel.AutoSize = true;
            this.TypLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TypLabel.Location = new System.Drawing.Point(509, 218);
            this.TypLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TypLabel.Name = "TypLabel";
            this.TypLabel.Size = new System.Drawing.Size(169, 45);
            this.TypLabel.TabIndex = 8;
            this.TypLabel.Text = "Typ towaru";
            this.TypLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IloscBox
            // 
            this.IloscBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IloscBox.Location = new System.Drawing.Point(774, 282);
            this.IloscBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IloscBox.Name = "IloscBox";
            this.IloscBox.Size = new System.Drawing.Size(195, 33);
            this.IloscBox.TabIndex = 4;
            // 
            // IloscOuterLabel
            // 
            this.IloscOuterLabel.AutoSize = true;
            this.IloscOuterLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IloscOuterLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.IloscOuterLabel.Location = new System.Drawing.Point(509, 269);
            this.IloscOuterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IloscOuterLabel.Name = "IloscOuterLabel";
            this.IloscOuterLabel.Size = new System.Drawing.Size(78, 45);
            this.IloscOuterLabel.TabIndex = 10;
            this.IloscOuterLabel.Text = "Ilość";
            // 
            // NazwaBox
            // 
            this.NazwaBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NazwaBox.Location = new System.Drawing.Point(774, 135);
            this.NazwaBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NazwaBox.Name = "NazwaBox";
            this.NazwaBox.Size = new System.Drawing.Size(195, 33);
            this.NazwaBox.TabIndex = 1;
            // 
            // NazwaLabel
            // 
            this.NazwaLabel.AutoSize = true;
            this.NazwaLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NazwaLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NazwaLabel.Location = new System.Drawing.Point(509, 123);
            this.NazwaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NazwaLabel.Name = "NazwaLabel";
            this.NazwaLabel.Size = new System.Drawing.Size(215, 45);
            this.NazwaLabel.TabIndex = 12;
            this.NazwaLabel.Text = "Nazwa towaru";
            // 
            // DataBox
            // 
            this.DataBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataBox.Location = new System.Drawing.Point(774, 183);
            this.DataBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DataBox.Name = "DataBox";
            this.DataBox.Size = new System.Drawing.Size(195, 33);
            this.DataBox.TabIndex = 2;
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DataLabel.Location = new System.Drawing.Point(509, 171);
            this.DataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(221, 45);
            this.DataLabel.TabIndex = 14;
            this.DataLabel.Text = "Data gwarancji";
            // 
            // DodajButton
            // 
            this.DodajButton.BackColor = System.Drawing.Color.White;
            this.DodajButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DodajButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.DodajButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DodajButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DodajButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DodajButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DodajButton.Location = new System.Drawing.Point(599, 374);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(297, 89);
            this.DodajButton.TabIndex = 5;
            this.DodajButton.Text = "Dodaj towar";
            this.DodajButton.UseVisualStyleBackColor = false;
            this.DodajButton.Click += new System.EventHandler(this.DodajButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(252, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 21);
            this.label2.TabIndex = 53;
            this.label2.Text = "in \"dd/mm/yyyy\" format";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(249, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 21);
            this.label1.TabIndex = 52;
            this.label1.Text = "* Data gwarancji should be filled";
            // 
            // TypBox
            // 
            this.TypBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypBox.FormattingEnabled = true;
            this.TypBox.Items.AddRange(new object[] {
            "narzędzia",
            "słodycze",
            "zabawki",
            "warzywa",
            "owoce",
            "nabiał"});
            this.TypBox.Location = new System.Drawing.Point(774, 231);
            this.TypBox.Name = "TypBox";
            this.TypBox.Size = new System.Drawing.Size(195, 33);
            this.TypBox.TabIndex = 54;
            // 
            // DodajForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 526);
            this.Controls.Add(this.TypBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DodajButton);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.DataBox);
            this.Controls.Add(this.NazwaLabel);
            this.Controls.Add(this.NazwaBox);
            this.Controls.Add(this.IloscOuterLabel);
            this.Controls.Add(this.IloscBox);
            this.Controls.Add(this.TypLabel);
            this.Controls.Add(this.DodajIloscBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.BackLabel);
            this.Controls.Add(this.NowyLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajForm";
            this.Text = "Dodaj towary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HideForm_FormClosing);
            this.DodajIloscBox.ResumeLayout(false);
            this.DodajIloscBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NowyLabel;
        private WarehouseUI.MyButton DodajIloscButton;
        private System.Windows.Forms.Label IDInnerLabel;
        
        private System.Windows.Forms.Label BackLabel;
        private WarehouseUI.MyButton BackButton;
        private System.Windows.Forms.GroupBox DodajIloscBox;

        private System.Windows.Forms.Label TypLabel;
        private System.Windows.Forms.TextBox IloscBox;
        private System.Windows.Forms.Label IloscOuterLabel;
        private System.Windows.Forms.Label IloscInnerLabel;
        private System.Windows.Forms.TextBox IloscInnerBox;
        private System.Windows.Forms.TextBox NazwaBox;
        private System.Windows.Forms.Label NazwaLabel;
        private System.Windows.Forms.TextBox DataBox;
        private System.Windows.Forms.Label DataLabel;
        private WarehouseUI.MyButton DodajButton;
        private System.Windows.Forms.TextBox ID_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TypBox;
    }
}
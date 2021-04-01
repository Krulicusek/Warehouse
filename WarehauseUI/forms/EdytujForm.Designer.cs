
namespace WarehouseUI
{
    partial class EdytujForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdytujForm));
            this.BackButton = new WarehouseUI.MyButton();
            this.BackLabel = new System.Windows.Forms.Label();
            this.EdytujButton = new WarehouseUI.MyButton();
            this.DataLabel = new System.Windows.Forms.Label();
            this.DataBox = new System.Windows.Forms.TextBox();
            this.NazwaLabel = new System.Windows.Forms.Label();
            this.NazwaBox = new System.Windows.Forms.TextBox();
            this.IloscLabel = new System.Windows.Forms.Label();
            this.IloscBox = new System.Windows.Forms.TextBox();
            this.TypLabel = new System.Windows.Forms.Label();
            this.TypBox = new System.Windows.Forms.TextBox();
            this.EdytujLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.BackButton.TabIndex = 7;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackLabel.Location = new System.Drawing.Point(76, 9);
            this.BackLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(280, 50);
            this.BackLabel.TabIndex = 7;
            this.BackLabel.Text = "Powrót do menu";
            // 
            // EdytujButton
            // 
            this.EdytujButton.BackColor = System.Drawing.Color.White;
            this.EdytujButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.EdytujButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.EdytujButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.EdytujButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EdytujButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EdytujButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.EdytujButton.Location = new System.Drawing.Point(115, 498);
            this.EdytujButton.Name = "EdytujButton";
            this.EdytujButton.Size = new System.Drawing.Size(297, 89);
            this.EdytujButton.TabIndex = 6;
            this.EdytujButton.Text = "Edytuj towar";
            this.EdytujButton.UseVisualStyleBackColor = false;
            this.EdytujButton.Click += new System.EventHandler(this.EdytujButton_Click);
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DataLabel.Location = new System.Drawing.Point(26, 313);
            this.DataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(221, 45);
            this.DataLabel.TabIndex = 24;
            this.DataLabel.Text = "Data gwarancji";
            // 
            // DataBox
            // 
            this.DataBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataBox.Location = new System.Drawing.Point(291, 325);
            this.DataBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DataBox.Name = "DataBox";
            this.DataBox.Size = new System.Drawing.Size(195, 33);
            this.DataBox.TabIndex = 3;
            // 
            // NazwaLabel
            // 
            this.NazwaLabel.AutoSize = true;
            this.NazwaLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NazwaLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NazwaLabel.Location = new System.Drawing.Point(26, 265);
            this.NazwaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NazwaLabel.Name = "NazwaLabel";
            this.NazwaLabel.Size = new System.Drawing.Size(215, 45);
            this.NazwaLabel.TabIndex = 22;
            this.NazwaLabel.Text = "Nazwa towaru";
            // 
            // NazwaBox
            // 
            this.NazwaBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NazwaBox.Location = new System.Drawing.Point(291, 277);
            this.NazwaBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NazwaBox.Name = "NazwaBox";
            this.NazwaBox.Size = new System.Drawing.Size(195, 33);
            this.NazwaBox.TabIndex = 2;
            // 
            // IloscLabel
            // 
            this.IloscLabel.AutoSize = true;
            this.IloscLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IloscLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.IloscLabel.Location = new System.Drawing.Point(26, 411);
            this.IloscLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IloscLabel.Name = "IloscLabel";
            this.IloscLabel.Size = new System.Drawing.Size(78, 45);
            this.IloscLabel.TabIndex = 20;
            this.IloscLabel.Text = "Ilość";
            // 
            // IloscBox
            // 
            this.IloscBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IloscBox.Location = new System.Drawing.Point(291, 424);
            this.IloscBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IloscBox.Name = "IloscBox";
            this.IloscBox.Size = new System.Drawing.Size(195, 33);
            this.IloscBox.TabIndex = 5;
            // 
            // TypLabel
            // 
            this.TypLabel.AutoSize = true;
            this.TypLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TypLabel.Location = new System.Drawing.Point(26, 360);
            this.TypLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TypLabel.Name = "TypLabel";
            this.TypLabel.Size = new System.Drawing.Size(169, 45);
            this.TypLabel.TabIndex = 18;
            this.TypLabel.Text = "Typ towaru";
            this.TypLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TypBox
            // 
            this.TypBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypBox.Location = new System.Drawing.Point(291, 372);
            this.TypBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TypBox.Name = "TypBox";
            this.TypBox.Size = new System.Drawing.Size(195, 33);
            this.TypBox.TabIndex = 4;
            // 
            // EdytujLabel
            // 
            this.EdytujLabel.AutoSize = true;
            this.EdytujLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EdytujLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.EdytujLabel.Location = new System.Drawing.Point(160, 104);
            this.EdytujLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EdytujLabel.Name = "EdytujLabel";
            this.EdytujLabel.Size = new System.Drawing.Size(215, 50);
            this.EdytujLabel.TabIndex = 16;
            this.EdytujLabel.Text = "Edytuj towar";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.IDLabel.Location = new System.Drawing.Point(26, 220);
            this.IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(49, 45);
            this.IDLabel.TabIndex = 27;
            this.IDLabel.Text = "ID";
            // 
            // IDBox
            // 
            this.IDBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDBox.Location = new System.Drawing.Point(291, 233);
            this.IDBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(195, 33);
            this.IDBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(245, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 21);
            this.label2.TabIndex = 55;
            this.label2.Text = "in \"dd/mm/yyyy\" format";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(26, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 21);
            this.label1.TabIndex = 54;
            this.label1.Text = "* Data gwarancji should be filled";
            // 
            // EdytujForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 628);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.EdytujButton);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.DataBox);
            this.Controls.Add(this.NazwaLabel);
            this.Controls.Add(this.NazwaBox);
            this.Controls.Add(this.IloscLabel);
            this.Controls.Add(this.IloscBox);
            this.Controls.Add(this.TypLabel);
            this.Controls.Add(this.TypBox);
            this.Controls.Add(this.EdytujLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.BackLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EdytujForm";
            this.Text = "Edytuj wprowadzone towary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HideForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WarehouseUI.MyButton BackButton;
        private System.Windows.Forms.Label BackLabel;
        private WarehouseUI.MyButton EdytujButton;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.TextBox DataBox;
        private System.Windows.Forms.Label NazwaLabel;
        private System.Windows.Forms.TextBox NazwaBox;
        private System.Windows.Forms.Label IloscLabel;
        private System.Windows.Forms.TextBox IloscBox;
        private System.Windows.Forms.Label TypLabel;
        private System.Windows.Forms.TextBox TypBox;
        private System.Windows.Forms.Label EdytujLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

namespace WarehouseUI
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.UsunButton = new WarehouseUI.MyButton();
            this.DodajButton = new WarehouseUI.MyButton();
            this.EdytujButton = new WarehouseUI.MyButton();
            this.ZamowieniaButton = new WarehouseUI.MyButton();
            this.TowaryButton = new WarehouseUI.MyButton();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(181, 37);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(112, 50);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Menu";
            // 
            // UsunButton
            // 
            this.UsunButton.BackColor = System.Drawing.Color.White;
            this.UsunButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsunButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UsunButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UsunButton.Location = new System.Drawing.Point(89, 312);
            this.UsunButton.Name = "UsunButton";
            this.UsunButton.Size = new System.Drawing.Size(297, 89);
            this.UsunButton.TabIndex = 3;
            this.UsunButton.Text = "Usuń towary";
            this.UsunButton.UseVisualStyleBackColor = false;
            this.UsunButton.Click += new System.EventHandler(this.UsunButton_Click);
            // 
            // DodajButton
            // 
            this.DodajButton.BackColor = System.Drawing.Color.White;
            this.DodajButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DodajButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DodajButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DodajButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DodajButton.Location = new System.Drawing.Point(89, 122);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(297, 89);
            this.DodajButton.TabIndex = 1;
            this.DodajButton.Text = "Dodaj towary";
            this.DodajButton.UseVisualStyleBackColor = false;
            this.DodajButton.Click += new System.EventHandler(this.DodajButton_Click);
            // 
            // EdytujButton
            // 
            this.EdytujButton.BackColor = System.Drawing.Color.White;
            this.EdytujButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.EdytujButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.EdytujButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.EdytujButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EdytujButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EdytujButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.EdytujButton.Location = new System.Drawing.Point(89, 217);
            this.EdytujButton.Name = "EdytujButton";
            this.EdytujButton.Size = new System.Drawing.Size(297, 89);
            this.EdytujButton.TabIndex = 2;
            this.EdytujButton.Text = "Edytuj towary";
            this.EdytujButton.UseVisualStyleBackColor = false;
            this.EdytujButton.Click += new System.EventHandler(this.EdytujButton_Click);
            // 
            // ZamowieniaButton
            // 
            this.ZamowieniaButton.BackColor = System.Drawing.Color.White;
            this.ZamowieniaButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ZamowieniaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ZamowieniaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ZamowieniaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZamowieniaButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ZamowieniaButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ZamowieniaButton.Location = new System.Drawing.Point(89, 502);
            this.ZamowieniaButton.Name = "ZamowieniaButton";
            this.ZamowieniaButton.Size = new System.Drawing.Size(297, 89);
            this.ZamowieniaButton.TabIndex = 5;
            this.ZamowieniaButton.Text = "Podgląd zamowień";
            this.ZamowieniaButton.UseVisualStyleBackColor = false;
            this.ZamowieniaButton.Click += new System.EventHandler(this.ZamowieniaButton_Click);
            // 
            // TowaryButton
            // 
            this.TowaryButton.BackColor = System.Drawing.Color.White;
            this.TowaryButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.TowaryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.TowaryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TowaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TowaryButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TowaryButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TowaryButton.Location = new System.Drawing.Point(89, 407);
            this.TowaryButton.Name = "TowaryButton";
            this.TowaryButton.Size = new System.Drawing.Size(297, 89);
            this.TowaryButton.TabIndex = 4;
            this.TowaryButton.Text = "Podglad towarów";
            this.TowaryButton.UseVisualStyleBackColor = false;
            this.TowaryButton.Click += new System.EventHandler(this.TowaryButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(476, 641);
            this.Controls.Add(this.TowaryButton);
            this.Controls.Add(this.ZamowieniaButton);
            this.Controls.Add(this.UsunButton);
            this.Controls.Add(this.EdytujButton);
            this.Controls.Add(this.DodajButton);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Beige;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.Text = "Warehouse Managment System";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private WarehouseUI.MyButton DodajButton;
        private MyButton UsunButton;
        private MyButton EdytujButton;
        private MyButton ZamowieniaButton;
        private MyButton TowaryButton;
    }
}

    
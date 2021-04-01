
namespace WarehouseUI
{
    partial class UsunForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsunForm));
            this.UsunButton = new WarehouseUI.MyButton();
            this.IDInnerLabel = new System.Windows.Forms.Label();
            this.ID_Box = new System.Windows.Forms.TextBox();
            this.UsunLabel = new System.Windows.Forms.Label();
            this.BackButton = new WarehouseUI.MyButton();
            this.BackLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsunButton
            // 
            this.UsunButton.BackColor = System.Drawing.Color.White;
            this.UsunButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.UsunButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.UsunButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.UsunButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsunButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UsunButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UsunButton.Location = new System.Drawing.Point(46, 330);
            this.UsunButton.Name = "UsunButton";
            this.UsunButton.Size = new System.Drawing.Size(297, 89);
            this.UsunButton.TabIndex = 2;
            this.UsunButton.Text = "Usuń towar";
            this.UsunButton.UseVisualStyleBackColor = false;
            this.UsunButton.Click += new System.EventHandler(this.UsunButton_Click);
            // 
            // IDInnerLabel
            // 
            this.IDInnerLabel.AutoSize = true;
            this.IDInnerLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDInnerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.IDInnerLabel.Location = new System.Drawing.Point(91, 217);
            this.IDInnerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDInnerLabel.Name = "IDInnerLabel";
            this.IDInnerLabel.Size = new System.Drawing.Size(49, 45);
            this.IDInnerLabel.TabIndex = 17;
            this.IDInnerLabel.Text = "ID";
            // 
            // ID_Box
            // 
            this.ID_Box.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ID_Box.Location = new System.Drawing.Point(148, 229);
            this.ID_Box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Size = new System.Drawing.Size(124, 33);
            this.ID_Box.TabIndex = 1;
            // 
            // UsunLabel
            // 
            this.UsunLabel.AutoSize = true;
            this.UsunLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsunLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UsunLabel.Location = new System.Drawing.Point(91, 121);
            this.UsunLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsunLabel.Name = "UsunLabel";
            this.UsunLabel.Size = new System.Drawing.Size(197, 50);
            this.UsunLabel.TabIndex = 18;
            this.UsunLabel.Text = "Usuń towar";
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
            this.BackButton.Location = new System.Drawing.Point(13, 12);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(55, 47);
            this.BackButton.TabIndex = 3;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackLabel.Location = new System.Drawing.Point(63, 9);
            this.BackLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(280, 50);
            this.BackLabel.TabIndex = 19;
            this.BackLabel.Text = "Powrót do menu";
            // 
            // UsunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 456);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.BackLabel);
            this.Controls.Add(this.UsunLabel);
            this.Controls.Add(this.IDInnerLabel);
            this.Controls.Add(this.ID_Box);
            this.Controls.Add(this.UsunButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsunForm";
            this.Text = "Usuń towary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HideForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WarehouseUI.MyButton UsunButton;
        private System.Windows.Forms.Label IDInnerLabel;
        private System.Windows.Forms.TextBox ID_Box;
        private System.Windows.Forms.Label UsunLabel;
        private WarehouseUI.MyButton BackButton;
        private System.Windows.Forms.Label BackLabel;
    }
}
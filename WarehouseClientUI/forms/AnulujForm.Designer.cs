
namespace WarehouseClientUI
{
    partial class AnulujForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnulujForm));
            this.AnulujButton = new WarehouseClientUI.MyButton();
            this.zamowieniaGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AnulujButton
            // 
            this.AnulujButton.BackColor = System.Drawing.Color.White;
            this.AnulujButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AnulujButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.AnulujButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnulujButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AnulujButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AnulujButton.Location = new System.Drawing.Point(247, 396);
            this.AnulujButton.Name = "AnulujButton";
            this.AnulujButton.Size = new System.Drawing.Size(308, 83);
            this.AnulujButton.TabIndex = 0;
            this.AnulujButton.Text = "Anuluj zamówienie";
            this.AnulujButton.UseVisualStyleBackColor = false;
            this.AnulujButton.Click += new System.EventHandler(this.AnulujButton_Click);
            // 
            // zamowieniaGrid
            // 
            this.zamowieniaGrid.BackgroundColor = System.Drawing.Color.White;
            this.zamowieniaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zamowieniaGrid.GridColor = System.Drawing.Color.White;
            this.zamowieniaGrid.Location = new System.Drawing.Point(79, 82);
            this.zamowieniaGrid.Name = "zamowieniaGrid";
            this.zamowieniaGrid.RowTemplate.Height = 25;
            this.zamowieniaGrid.Size = new System.Drawing.Size(655, 275);
            this.zamowieniaGrid.TabIndex = 1;
            // 
            // AnulujForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 528);
            this.Controls.Add(this.zamowieniaGrid);
            this.Controls.Add(this.AnulujButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnulujForm";
            this.Text = "Anuluj zamówienie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HideForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyButton AnulujButton;
        private System.Windows.Forms.DataGridView zamowieniaGrid;
    }
}
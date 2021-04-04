
namespace WarehouseClientUI
{
    partial class PodgladForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PodgladForm));
            this.PodgladLabel = new System.Windows.Forms.Label();
            this.towaryGrid = new System.Windows.Forms.DataGridView();
            this.AnulujButton = new WarehouseClientUI.MyButton();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.towaryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PodgladLabel
            // 
            this.PodgladLabel.AutoSize = true;
            this.PodgladLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PodgladLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PodgladLabel.Location = new System.Drawing.Point(363, 74);
            this.PodgladLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PodgladLabel.Name = "PodgladLabel";
            this.PodgladLabel.Size = new System.Drawing.Size(292, 50);
            this.PodgladLabel.TabIndex = 38;
            this.PodgladLabel.Text = "Podgląd towarów";
            // 
            // towaryGrid
            // 
            this.towaryGrid.AllowUserToAddRows = false;
            this.towaryGrid.AllowUserToDeleteRows = false;
            this.towaryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.towaryGrid.BackgroundColor = System.Drawing.Color.White;
            this.towaryGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.towaryGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.towaryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.towaryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.towaryGrid.GridColor = System.Drawing.Color.LightGray;
            this.towaryGrid.Location = new System.Drawing.Point(42, 146);
            this.towaryGrid.Name = "towaryGrid";
            this.towaryGrid.RowTemplate.Height = 25;
            this.towaryGrid.Size = new System.Drawing.Size(926, 351);
            this.towaryGrid.TabIndex = 0;
            // 
            // AnulujButton
            // 
            this.AnulujButton.BackColor = System.Drawing.Color.White;
            this.AnulujButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AnulujButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.AnulujButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnulujButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AnulujButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AnulujButton.Location = new System.Drawing.Point(340, 555);
            this.AnulujButton.Name = "AnulujButton";
            this.AnulujButton.Size = new System.Drawing.Size(315, 82);
            this.AnulujButton.TabIndex = 39;
            this.AnulujButton.Text = "Anuluj zamówienie";
            this.AnulujButton.UseVisualStyleBackColor = false;
            this.AnulujButton.Click += new System.EventHandler(this.AnulujButton_Click);
            // 
            // LogoBox
            // 
            this.LogoBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoBox.Image")));
            this.LogoBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("LogoBox.InitialImage")));
            this.LogoBox.Location = new System.Drawing.Point(492, 26);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(35, 35);
            this.LogoBox.TabIndex = 40;
            this.LogoBox.TabStop = false;
            // 
            // PodgladForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 680);
            this.Controls.Add(this.LogoBox);
            this.Controls.Add(this.AnulujButton);
            this.Controls.Add(this.PodgladLabel);
            this.Controls.Add(this.towaryGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PodgladForm";
            this.Text = "Przegląd towarów";
            ((System.ComponentModel.ISupportInitialize)(this.towaryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Label PodgladLabel;
        private System.Windows.Forms.DataGridView towaryGrid;       
        private MyButton AnulujButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox LogoBox;
    }
}


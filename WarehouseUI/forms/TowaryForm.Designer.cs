
namespace WarehouseUI
{
    partial class TowaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TowaryForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BackButton = new WarehouseUI.MyButton();
            this.BackLabel = new System.Windows.Forms.Label();
            this.TowaryTabela = new System.Windows.Forms.DataGridView();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.NazwaLabel = new System.Windows.Forms.Label();
            this.NazwaBox = new System.Windows.Forms.TextBox();
            this.TowaryButton = new WarehouseUI.MyButton();
            this.EdytujLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowAllButton = new WarehouseUI.MyButton();
            ((System.ComponentModel.ISupportInitialize)(this.TowaryTabela)).BeginInit();
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
            this.BackButton.Location = new System.Drawing.Point(13, 12);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(55, 47);
            this.BackButton.TabIndex = 5;
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
            this.BackLabel.TabIndex = 21;
            this.BackLabel.Text = "Powrót do menu";
            // 
            // TowaryTabela
            // 
            this.TowaryTabela.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.TowaryTabela.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TowaryTabela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.TowaryTabela.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TowaryTabela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TowaryTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TowaryTabela.GridColor = System.Drawing.Color.LightGray;
            this.TowaryTabela.Location = new System.Drawing.Point(377, 55);
            this.TowaryTabela.Name = "TowaryTabela";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TowaryTabela.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TowaryTabela.RowTemplate.Height = 25;
            this.TowaryTabela.Size = new System.Drawing.Size(723, 519);
            this.TowaryTabela.TabIndex = 23;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.IDLabel.Location = new System.Drawing.Point(46, 278);
            this.IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(49, 45);
            this.IDLabel.TabIndex = 31;
            this.IDLabel.Text = "ID";
            // 
            // IDBox
            // 
            this.IDBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDBox.Location = new System.Drawing.Point(46, 326);
            this.IDBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(195, 33);
            this.IDBox.TabIndex = 1;
            // 
            // NazwaLabel
            // 
            this.NazwaLabel.AutoSize = true;
            this.NazwaLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NazwaLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NazwaLabel.Location = new System.Drawing.Point(46, 362);
            this.NazwaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NazwaLabel.Name = "NazwaLabel";
            this.NazwaLabel.Size = new System.Drawing.Size(215, 45);
            this.NazwaLabel.TabIndex = 29;
            this.NazwaLabel.Text = "Nazwa towaru";
            // 
            // NazwaBox
            // 
            this.NazwaBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NazwaBox.Location = new System.Drawing.Point(46, 410);
            this.NazwaBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NazwaBox.Name = "NazwaBox";
            this.NazwaBox.Size = new System.Drawing.Size(195, 33);
            this.NazwaBox.TabIndex = 2;
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
            this.TowaryButton.Location = new System.Drawing.Point(46, 485);
            this.TowaryButton.Name = "TowaryButton";
            this.TowaryButton.Size = new System.Drawing.Size(297, 89);
            this.TowaryButton.TabIndex = 3;
            this.TowaryButton.Text = "Podglad towarów";
            this.TowaryButton.UseVisualStyleBackColor = false;
            this.TowaryButton.Click += new System.EventHandler(this.TowaryButton_Click);
            // 
            // EdytujLabel
            // 
            this.EdytujLabel.AutoSize = true;
            this.EdytujLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EdytujLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.EdytujLabel.Location = new System.Drawing.Point(46, 122);
            this.EdytujLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EdytujLabel.Name = "EdytujLabel";
            this.EdytujLabel.Size = new System.Drawing.Size(292, 50);
            this.EdytujLabel.TabIndex = 37;
            this.EdytujLabel.Text = "Podgląd towarów";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(46, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 21);
            this.label1.TabIndex = 50;
            this.label1.Text = "Fill  fields that should be included";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(46, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 51;
            this.label2.Text = " in SELECT statment";
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
            this.ShowAllButton.Location = new System.Drawing.Point(587, 600);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(297, 89);
            this.ShowAllButton.TabIndex = 4;
            this.ShowAllButton.Text = "Pokaż wszystkie towary";
            this.ShowAllButton.UseVisualStyleBackColor = false;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // TowaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1145, 706);
            this.Controls.Add(this.ShowAllButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EdytujLabel);
            this.Controls.Add(this.TowaryButton);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.NazwaLabel);
            this.Controls.Add(this.NazwaBox);
            this.Controls.Add(this.TowaryTabela);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.BackLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TowaryForm";
            this.Text = "Podglad towarow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HideForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.TowaryTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WarehouseUI.MyButton BackButton;
        private System.Windows.Forms.Label BackLabel;
        private System.Windows.Forms.DataGridView TowaryTabela;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label NazwaLabel;
        private System.Windows.Forms.TextBox NazwaBox;
        private WarehouseUI.MyButton TowaryButton;
        private System.Windows.Forms.Label EdytujLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MyButton ShowAllButton;
    }
}
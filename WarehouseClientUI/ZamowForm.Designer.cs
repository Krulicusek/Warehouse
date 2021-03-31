
namespace WarehouseClientUI
{
    partial class ZamowForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Kurier");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Paczkomat");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZamowForm));
            this.ImieLabel = new System.Windows.Forms.Label();
            this.AdresBox = new System.Windows.Forms.TextBox();
            this.IloscLabel = new System.Windows.Forms.Label();
            this.NazwiskoBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ImieLabel
            // 
            this.ImieLabel.AutoSize = true;
            this.ImieLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImieLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ImieLabel.Location = new System.Drawing.Point(111, 212);
            this.ImieLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImieLabel.Name = "ImieLabel";
            this.ImieLabel.Size = new System.Drawing.Size(76, 45);
            this.ImieLabel.TabIndex = 55;
            this.ImieLabel.Text = "Imie";
            // 
            // AdresBox
            // 
            this.AdresBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdresBox.Location = new System.Drawing.Point(375, 225);
            this.AdresBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AdresBox.Name = "AdresBox";
            this.AdresBox.Size = new System.Drawing.Size(195, 33);
            this.AdresBox.TabIndex = 54;
            // 
            // IloscLabel
            // 
            this.IloscLabel.AutoSize = true;
            this.IloscLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IloscLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.IloscLabel.Location = new System.Drawing.Point(110, 167);
            this.IloscLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IloscLabel.Name = "IloscLabel";
            this.IloscLabel.Size = new System.Drawing.Size(78, 45);
            this.IloscLabel.TabIndex = 53;
            this.IloscLabel.Text = "Ilość";
            // 
            // NazwiskoBox
            // 
            this.NazwiskoBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NazwiskoBox.Location = new System.Drawing.Point(374, 180);
            this.NazwiskoBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NazwiskoBox.Name = "NazwiskoBox";
            this.NazwiskoBox.Size = new System.Drawing.Size(195, 33);
            this.NazwiskoBox.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(112, 302);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 45);
            this.label1.TabIndex = 59;
            this.label1.Text = "Adres";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(376, 315);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 33);
            this.textBox1.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(111, 257);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 45);
            this.label2.TabIndex = 57;
            this.label2.Text = "Nazwisko";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(375, 270);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 33);
            this.textBox2.TabIndex = 56;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(374, 372);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(8, 8);
            this.listView1.TabIndex = 60;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // ZamowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(701, 702);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ImieLabel);
            this.Controls.Add(this.AdresBox);
            this.Controls.Add(this.IloscLabel);
            this.Controls.Add(this.NazwiskoBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZamowForm";
            this.Text = "ZamowForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ImieLabel;
        private System.Windows.Forms.TextBox AdresBox;
        private System.Windows.Forms.Label IloscLabel;
        private System.Windows.Forms.TextBox NazwiskoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListView listView1;
    }
}
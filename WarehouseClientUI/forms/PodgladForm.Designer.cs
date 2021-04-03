
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
            ((System.ComponentModel.ISupportInitialize)(this.towaryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PodgladLabel
            // 
            this.PodgladLabel.AutoSize = true;
            this.PodgladLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PodgladLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PodgladLabel.Location = new System.Drawing.Point(363, 9);
            this.PodgladLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PodgladLabel.Name = "PodgladLabel";
            this.PodgladLabel.Size = new System.Drawing.Size(292, 50);
            this.PodgladLabel.TabIndex = 38;
            this.PodgladLabel.Text = "Podgląd towarów";
            // 
            // towaryGrid
            // 
            this.towaryGrid.AllowUserToAddRows = false;
            this.towaryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.towaryGrid.BackgroundColor = System.Drawing.Color.White;
            this.towaryGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.towaryGrid.GridColor = System.Drawing.Color.White;
            this.towaryGrid.Location = new System.Drawing.Point(40, 74);
            this.towaryGrid.Name = "towaryGrid";
            this.towaryGrid.RowTemplate.Height = 25;
            this.towaryGrid.Size = new System.Drawing.Size(941, 542);
            this.towaryGrid.TabIndex = 0;
            // 
            // PodgladForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 680);
            this.Controls.Add(this.PodgladLabel);
            this.Controls.Add(this.towaryGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PodgladForm";
            this.Text = "Przegląd towarów";
            ((System.ComponentModel.ISupportInitialize)(this.towaryGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Label PodgladLabel;
        private System.Windows.Forms.DataGridView towaryGrid;
    }
}


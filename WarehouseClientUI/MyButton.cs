using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace WarehouseClientUI
{
    class MyButton : Button
    {   // wlasny button aby aplikować zmiany w jednym miejscu
        
        public MyButton()
        {   
            FlatStyle = FlatStyle.Flat;
            Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.MenuHighlight;
            BackColor = Color.White;
            FlatAppearance.BorderColor = Color.Silver;
            FlatAppearance.MouseDownBackColor = Color.FromArgb(110, 110, 110);
                    
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            base.ForeColor = Color.FromArgb(81, 154, 255);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            base.ForeColor = SystemColors.MenuHighlight;

        }
         
       
    }
}

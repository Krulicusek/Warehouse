using System;
using System.Collections.Generic;
using System.Text;


namespace WarehouseLibrary
{
   public  class Validate
    {
        public bool Number (string numberString)
            
        {   
            bool output = true;            
            int number = 0;
            bool ValidNumber = int.TryParse(numberString, out number);
           if (!ValidNumber)
            {
                output = false;
            }
           if (number <= 0)
            {               
                output = false;
            }

            return output;
        }
       
         public bool Text (string text)
        {
            bool output = true;
            if (text.Length == 0)
            {
                output = false;
            }
            return output;
        }




    }
}

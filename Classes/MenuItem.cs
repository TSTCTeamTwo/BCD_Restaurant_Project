using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCD_Restaurant_Project.Classes
{
    class MenuItem
    {

        public MenuItem()
        {
        }

        public MenuItem(int itemID, int quantity, decimal pricePerUnit, int indexOfDataGridViewRow)
        {
            ItemID = itemID;
            Quantity = quantity;
            PricePerUnit = pricePerUnit;
            IndexOfDataGridViewRow = indexOfDataGridViewRow;
        }

        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public decimal PricePerUnit { get; set; }
        public decimal LineItemPrice => Quantity * PricePerUnit;
        public int IndexOfDataGridViewRow { get; set; }

    }
}

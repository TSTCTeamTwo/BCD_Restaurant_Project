using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BCD_Restaurant_Project.Classes
{
    class MenuItem
    {

        public MenuItem()
        {
        }

        public MenuItem(int quantity, decimal individualPrice, int indexOfDataGridViewRow)
        {
            Quantity = quantity;
            IndividualPrice = individualPrice;
            IndexOfDataGridViewRow = indexOfDataGridViewRow;
        }

        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public decimal IndividualPrice { get; set; }
        public decimal LineItemPrice => Quantity * IndividualPrice;
        public int IndexOfDataGridViewRow { get; set; }

    }
}

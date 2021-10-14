using System;
using System.Collections.Generic;
using System.Drawing;
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

        public MenuItem(string itemName, int quantity, decimal individualPrice)
        {
            ItemName = itemName;
            Quantity = quantity;
            IndividualPrice = individualPrice;
        }

        public string ItemName { get; set; }

        public int Quantity { get; set; }
        public decimal IndividualPrice { get; set; }
        public decimal TotalPrice => Quantity * IndividualPrice;

    }
}

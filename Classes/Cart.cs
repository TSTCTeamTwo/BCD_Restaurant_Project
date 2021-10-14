using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BCD_Restaurant_Project.Classes
{
    class OrderManagement
    {

        //Dictionary for the primary key of the menuitem, and the values associated with the item
        public static Dictionary<int, MenuItem> myCart = new Dictionary<int, MenuItem>();

        // Dictionary for the primary key of the menuitem, and the int is the qty removed
        public static Dictionary<int, int> removedItems = new Dictionary<int, int>();

        //datagridview positions
        public const int _MENU_ITEMID = 0;
        public const int _MENU_NAME = 1;
        public const int _MENU_PRICE = 2;
        public const int _MENU_QUANTITY = 3;

        private static decimal SubTotal { get; set; }
        private static decimal TaxTotal { get; set; }
        private static decimal Total { get; set; }
        public static int CustomerID { get; set; } = -1;
        public static string CustomerFirstName { get; set; } = string.Empty;
        public static string CustomerLastName { get; set; } = string.Empty;
        public static int OrderID { get; set; }

        private static bool searchForItemInCart(int itemID)
        {
            //search the dictionary for the specific itemID
            return myCart.ContainsKey(itemID);
        }

        private static void addToCartFromFood(DataGridView dgvMenu)
        {
            //verify there is a current row selected
            if (dgvMenu.CurrentRow != null)
            {
                string itemName;
                int quantity;
                decimal price;

                itemName = dgvMenu.CurrentRow.Cells[_MENU_NAME].Value.ToString();
                quantity = Convert.ToInt32(dgvMenu.CurrentRow.Cells[_MENU_QUANTITY].Value);
                price = Convert.ToDecimal(dgvMenu.CurrentRow.Cells[_MENU_PRICE].Value);
                int itemID = Convert.ToInt32(dgvMenu.CurrentRow.Cells[_MENU_ITEMID].Value);
                
                if (searchForItemInCart(itemID))
                {
                    myCart[itemID].Quantity++;
                }
                else
                {
                    myCart.Add(itemID, new MenuItem(itemName, quantity, price));
                }  
            }

        }

        public static void removeFromCart(DataGridView dgvItems)
        {
            if(dgvItems.CurrentRow != null)
            {
                int itemID = Convert.ToInt32(dgvItems.CurrentRow.Cells[0].Value);

                myCart[itemID].Quantity--;

                if(myCart[itemID].Quantity == 0)
                {
                    dgvItems.CurrentRow.Cells.RemoveAt(dgvItems.CurrentRow.Index);
                }
            }
        }

        public static void clearCart(DataGridView dgvItems)
        {
            dgvItems.Rows.Clear();
            myCart.Clear();
        }

        public static void buttonCalculate(System.Windows.Forms.Button btnCheckout)
        {
            btnCheckout.Enabled = true;
            decimal totalPrice =0;
            for(int i =0; i<myCart.Count; i++)
            {
                totalPrice += myCart[i].TotalPrice;
            }
            btnCheckout.Text = "Checkout   $" + totalPrice.ToString();
        }

    }
}

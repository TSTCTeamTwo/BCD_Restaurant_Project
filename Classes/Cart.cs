using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCD_Restaurant_Project.Classes
{
    class Cart
    {
        
        //Dictionary for the primary key of the menuitem, and the values associated with the item
        public static Dictionary<int, MenuItem> myCart = new Dictionary<int, MenuItem>();

        // Dictionary for the primary key of the menuitem, and the int is the qty removed
      

        //datagridview positions
        public const int _MENU_ITEMID = 0;
        public const int _MENU_NAME = 1;
        public const int _MENU_PRICE = 3;

        private static decimal SubTotal { get; set; }
        private static decimal TaxTotal { get; set; }
        private static decimal Total { get; set; }
        public static int CustomerID { get; set; } = -1;
        public static string CustomerFirstName { get; set; } = string.Empty;
        public static string CustomerLastName { get; set; } = string.Empty;
        public static int OrderID { get; set; }

       
        public static void addToCartFromFood(DataGridView dgvMenu)
        {
            //verify there is a current row selected
            if (dgvMenu.CurrentRow != null)
            {
                string itemName;
                decimal price;

                //assigning the variables to respected cell positions using variables declared at the top
                itemName = dgvMenu.CurrentRow.Cells[_MENU_NAME].Value.ToString();
                //quantity = Convert.ToInt32(dgvMenu.CurrentRow.Cells[_MENU_QUANTITY].Value);
                price = Convert.ToDecimal(dgvMenu.CurrentRow.Cells[_MENU_PRICE].Value.ToString().Substring(1));
                int itemID = Convert.ToInt32(dgvMenu.CurrentRow.Cells[_MENU_ITEMID].Value);
                
                //pass in the itemID if it is found in the cart datagrid
                if (myCart.ContainsKey(itemID))
                {
                    //add one to the quantity
                    myCart[itemID].Quantity++;
                }
                else
                {
                    //if it isn't found it means they haven't ordered yet so pass in 
                    myCart.Add(itemID, new MenuItem(itemName, 1, price));
                }  
            }

        }

        public static void removeFromCart(DataGridView dgvItems)
        {
            if(dgvItems.CurrentRow != null)
            {
                int itemID = Convert.ToInt32(dgvItems.CurrentRow.Cells[_MENU_ITEMID].Value);


                if (myCart.ContainsKey(itemID))
                {
                    myCart[itemID].Quantity--;
                    if (myCart[itemID].Quantity == 0)
                    {
                        dgvItems.Rows.RemoveAt(dgvItems.CurrentRow.Index);
                        myCart.Remove(itemID);
                    }

                }
                

            }
        }

        public static void clearCart(DataGridView dgvItems)
        {
            dgvItems.Rows.Clear();
            myCart.Clear();
        }

        public static void buttonCalculate(Button btnCheckout)
        {
            btnCheckout.Enabled = true;
            decimal totalPrice = 0;
            for (int i = 0; i < myCart.Count; i++)
            {
                totalPrice += myCart[i].TotalPrice;
            }
            btnCheckout.Text = "Checkout   $" + totalPrice.ToString();
        }

        //public static void buttonCalculate(Button btnCheckout, object dgvClick)
        //{
        //    decimal totalPrice =0;
        //    for(int i =0; i<myCart.Count; i++)
        //    {
        //        totalPrice += myCart[i].TotalPrice;
        //    }  
        //    if (activeButton != null)
        //    {
        //        activeButton.Hide();
        //        activeButton.Dispose();
        //    }
        //    activeButton = btnCheckout;
        //    btnCheckout.BringToFront();
        //    btnCheckout.Show();
        //    btnCheckout.Text = "Checkout   $" + totalPrice.ToString();
        //}
    }
}

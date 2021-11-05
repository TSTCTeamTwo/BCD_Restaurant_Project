#region Imports

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

#endregion

namespace BCD_Restaurant_Project.Classes {
    internal static class Cart {
        //DataGridView column positions
        public const int _MENU_ITEM_ID = 0;
        public const int _MENU_NAME = 1;

        public const int _MENU_PRICE = 3;

        //Dictionary for the primary key of the menuitem, and the values associated with the item
        public static Dictionary<int, MenuItem> myCart = new Dictionary<int, MenuItem>();

        public static decimal Tax => SubTotal * (decimal)0.0625;

        //uses a linq expression to calculate sum of a KeyValuePair -> using the values in the KeyValuePair's Value.TotalPrice property
        public static decimal SubTotal => myCart.Sum(price => price.Value.TotalPrice);

        public static decimal Total => SubTotal + Tax + Tip;

        public static decimal Tip {
            get;
            set;
        } = 0;

        public static int OrderID {
            get;
            set;
        }

        public static void addToCartFromFood(DataGridView dgvMenu) {
            //verify there is a current row selected
            if (dgvMenu.CurrentRow == null)
                return;
            //assigning the variables to respected cell positions using variables declared at the top
            string itemName = dgvMenu.CurrentRow.Cells[_MENU_NAME].Value.ToString();
            //using substring to ignore the $ sign
            decimal price = Convert.ToDecimal(dgvMenu.CurrentRow.Cells[_MENU_PRICE].Value.ToString().Substring(1)
                                                  .Trim(' ', ',', '$'));
            int itemID = Convert.ToInt32(dgvMenu.CurrentRow.Cells[_MENU_ITEM_ID].Value);

            //pass in the itemID if it is found in the cart data grid
            if (myCart.ContainsKey(itemID)) //add one to the quantity
                myCart[itemID].Quantity++;
            else //if it isn't found it means they haven't ordered yet so pass in
                myCart.Add(itemID, new MenuItem(itemName, 1, price));
        }

        public static void addToCartFromDrinks(DataGridView dgvDrinks) {
            if ((dgvDrinks != null) && (dgvDrinks.CurrentRow != null)) {
                int itemID = Convert.ToInt32(dgvDrinks.CurrentRow.Cells[_MENU_ITEM_ID].Value);
                decimal price
                    = Convert.ToDecimal(dgvDrinks.CurrentRow.Cells[_MENU_PRICE].Value.ToString().Substring(1));
                string itemName = dgvDrinks.CurrentRow.Cells[_MENU_NAME].Value.ToString();

                if (myCart.ContainsKey(itemID))
                    myCart[itemID].Quantity++;
                else
                    myCart.Add(itemID, new MenuItem(itemName, 1, price));
            }
        }

        public static void addToCartFromDesserts(DataGridView dgvDesserts) {
            if ((dgvDesserts != null) && (dgvDesserts.CurrentRow != null)) {
                int itemID = Convert.ToInt32(dgvDesserts.CurrentRow.Cells[_MENU_ITEM_ID].Value);
                decimal price
                    = Convert.ToDecimal(dgvDesserts.CurrentRow.Cells[_MENU_PRICE].Value.ToString().Substring(1));
                string itemName = dgvDesserts.CurrentRow.Cells[_MENU_NAME].Value.ToString();

                if (myCart.ContainsKey(itemID))
                    myCart[itemID].Quantity++;
                else
                    myCart.Add(itemID, new MenuItem(itemName, 1, price));
            }
        }

        public static void removeFromCart(DataGridView dgvItems) {
            if ((dgvItems != null) && (dgvItems.CurrentRow != null)) {
                int itemID = Convert.ToInt32(dgvItems.CurrentRow.Cells[_MENU_ITEM_ID].Value);

                if (myCart.ContainsKey(itemID)) {
                    myCart[itemID].Quantity--;
                    if (myCart[itemID].Quantity == 0) {
                        dgvItems.Rows.RemoveAt(dgvItems.CurrentRow.Index);
                        myCart.Remove(itemID);
                    }
                }
            }
        }

        public static void clearCart(DataGridView dgvItems) {
            dgvItems.Rows.Clear();
            myCart.Clear();
        }

        public static void fillBtnCheckoutText(Button btnCheckout) {
            btnCheckout.Text = $"Checkout  {SubTotal + Tax:C}";
        }
    }
}
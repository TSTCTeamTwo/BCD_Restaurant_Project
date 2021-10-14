using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BCD_Restaurant_Project.Classes
{
    class Cart
    {
        public static int AccountID { get; set; } = 0;
        public static string OTP { get; set; } = string.Empty;
        
        //Dictionary for the primary key of the menuitem, and the values associated with the item
        public static Dictionary<int, MenuItem> myCart = new Dictionary<int, MenuItem>();

        // Dictionary for the primary key of the menuitem, and the int is the qty removed
        public static Dictionary<int, int> removedItems = new Dictionary<int, int>();
        
        public const int _MENU_NAME = 0;
        public const int _MENU_DESCRIPTION = 1;
        public const int _MENU_FORMAT = 3;
        public const int _MENU_QUANTITY = 4;

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

        private static void addToCart(DataGridView dgvMenu)
        {

            //verify there is a current row selected
            if (dgvMenu.CurrentRow != null)
            {
                string itemName;
                int quantity;
                decimal price;

                itemName = dgvMenu.CurrentRow.Cells[]

            }

        }


    }
}

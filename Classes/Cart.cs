using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace BCD_Restaurant_Project.Classes
{
    class OrderManagement
    {
        public static int AccountID { get; set; } = 0;
        public static string OTP { get; set; } = string.Empty;

        public static Dictionary<string, MenuItem> myCart = new Dictionary<string, MenuItem>();

        //check the db for the itemID

        public static Dictionary<string, int> removedItems = new Dictionary<string, int>();
        //ItemName AS 'Item', ItemDescription AS 'Description', FORMAT(Price, 'C') AS Price, Image
        public const int _MENU_NAME = 0;
        public const int _MENU_DESCRIPTION = 1;
        public const int _MENU_FORMAT = 3;
        public const int _MENU_QUANTITY = 4;

    }
}

namespace BCD_Restaurant_Project.Classes {
    internal class MenuItem {
        public MenuItem(string itemName, int quantity, decimal individualPrice) {
            ItemName = itemName;
            Quantity = quantity;
            IndividualPrice = individualPrice;
        }

        public string ItemName {
            get;
        }

        public int Quantity {
            get;
            set;
        }

        public decimal IndividualPrice {
            get;
        }

        public decimal TotalPrice => Quantity * IndividualPrice;
    }
}
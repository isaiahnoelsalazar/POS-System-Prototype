using System;
using System.Linq;
using System.Windows.Forms;
using static POS_System_Prototype.GlobalValues;

namespace POS_System_Prototype
{
    public class CustomValues
    {
        public class DataForm : Form
        {
            public virtual void RefreshData() { }
        }

        public static bool IsThereEnoughStock(Item Item)
        {
            if (CustomerCart.Count(a => a == Item) == StoreStock[StoreStock.IndexOf(Item)].GetStock())
            {
                MessageBox.Show($"There is not enough stock for {Item.GetName()}.", "Not Enough Stock", MessageBoxButtons.OK, MessageBoxIcon.None);
                return false;
            }
            return true;
        }

        public static bool DoesItemExist(string ItemName)
        {
            foreach (Item Item in StoreStock)
            {
                if (Item.GetName().ToUpper().Equals(ItemName.ToUpper()))
                {
                    return true;
                }
            }
            return false;
        }

        public class ReceiptItem
        {
            string ReceiptIdentifier;
            string[] Name, Amount, Price;

            public ReceiptItem(string ReceiptIdentifier, string[] Name, string[] Amount, string[] Price)
            {
                this.ReceiptIdentifier = ReceiptIdentifier;
                this.Name = Name;
                this.Amount = Amount;
                this.Price = Price;
            }

            public string GetReceiptIdentifier()
            {
                return ReceiptIdentifier;
            }

            public string GetReceipt()
            {
                string All = $"- - - - - - - - - - - - - - - -\n\nPOS SYSTEM PROTOTYPE\n\n{ReceiptIdentifier}\n\nItems:\n";
                double Total = 0;
                for (int a = 0; a < Name.Length; a++)
                {
                    All += Amount[a] + "x " + Name[a] + " @ " + Price[a] + Environment.NewLine;
                    Total += Convert.ToDouble(Price[a]);
                }
                All += $"\nTotal: ₱{Total}\n";
                All += "\n- - - - - - - - - - - - - - - -\n";
                return All;
            }
        }

        public class Item
        {
            string Name;
            double Price;
            int Stock;

            public Item(string Name, double Price, int Stock)
            {
                this.Name = Name;
                this.Price = Price;
                this.Stock = Stock;
            }

            public string GetName()
            {
                return Name;
            }

            public double GetPrice()
            {
                return Price;
            }

            public int GetStock()
            {
                return Stock;
            }

            public void AddStock(int Amount)
            {
                Stock += Amount;
            }

            public void ChangePrice(double NewPrice)
            {
                Price = NewPrice;
            }

            public void RemoveStock(int Amount)
            {
                Stock -= Amount;
            }
        }
    }
}

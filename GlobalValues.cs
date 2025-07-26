using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static POS_System_Prototype.CustomValues;

namespace POS_System_Prototype
{
    public class GlobalValues
    {
        public static List<Item> StoreStock = new List<Item>();
        public static List<Item> CustomerCart = new List<Item>();
        public static List<ReceiptItem> ReceiptList = new List<ReceiptItem>();

        public static MainForm MainFormInstance;
        public static DataForm CurrentTab;

        public static List<Button> Buttons = new List<Button>();

        public static DataForm[] Tabs =
        {
            new SalesForm(),
            new ReceiptsForm(),
            new ItemsForm()
        };

        public static Color DefaultBackgroundColor, DefaultForegroundColor;
    }
}

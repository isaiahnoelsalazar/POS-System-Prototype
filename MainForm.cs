using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static POS_System_Prototype.CustomValues;
using static POS_System_Prototype.GlobalValues;

namespace POS_System_Prototype
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            MainFormInstance = this;

            DefaultBackgroundColor = Color.White;
            DefaultForegroundColor = SubmitButton.ForeColor;

            Buttons.Add(SalesButton);
            Buttons.Add(ReceiptsButton);
            Buttons.Add(ItemsButton);
        }

        void SelectTab(int Index)
        {
            foreach (DataForm Form in Tabs)
            {
                Form.Hide();
            }
            foreach (Button Button in Buttons)
            {
                Button.BackColor = DefaultBackgroundColor;
                Button.ForeColor = DefaultForegroundColor;
            }

            Buttons[Index].BackColor = SystemColors.Highlight;
            Buttons[Index].ForeColor = Color.White;

            CurrentTab = Tabs[Index];
            Tabs[Index].MdiParent = this;
            Tabs[Index].Dock = DockStyle.Fill;
            Tabs[Index].RefreshData();
            Tabs[Index].Show();
        }

        public void RefreshCart()
        {
            CustomerTotal.Items.Clear();

            List<string> ItemNames = new List<string>();

            foreach (Item Item in CustomerCart)
            {
                if (!ItemNames.Contains(Item.GetName()))
                {
                    ItemNames.Add(Item.GetName());
                }
            }

            foreach (string Name in ItemNames)
            {
                int AmountTotal = 0;
                double PriceTotal = 0;

                foreach (Item Item in CustomerCart)
                {
                    if (Item.GetName().Equals(Name))
                    {
                        AmountTotal++;
                        PriceTotal += Item.GetPrice();
                    }
                }

                CustomerTotal.Items.Add(new ListViewItem(new string[]
                {
                    Name,
                    AmountTotal.ToString(),
                    PriceTotal.ToString()
                }));
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SelectTab(0);
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            SelectTab(0);
        }

        private void ReceiptsButton_Click(object sender, EventArgs e)
        {
            SelectTab(1);
        }

        private void ItemsButton_Click(object sender, EventArgs e)
        {
            SelectTab(2);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string[] Names = new string[CustomerTotal.Items.Count], Amounts = new string[CustomerTotal.Items.Count], Prices = new string[CustomerTotal.Items.Count];

            for (int a = 0; a < CustomerTotal.Items.Count; a++)
            {
                Names[a] = CustomerTotal.Items[a].Text;
                Amounts[a] = CustomerTotal.Items[a].SubItems[1].Text;
                Prices[a] = CustomerTotal.Items[a].SubItems[2].Text;

                foreach (Item Item in StoreStock)
                {
                    if (Item.GetName().Equals(CustomerTotal.Items[a].Text))
                    {
                        Item.RemoveStock(Convert.ToInt32(CustomerTotal.Items[a].SubItems[1].Text));
                    }
                }
            }

            ReceiptList.Add(new ReceiptItem($"Receipt #{ReceiptList.Count + 1} - {DateTime.Now}", Names, Amounts, Prices));

            SelectTab(0);

            CustomerCart.Clear();
            CustomerTotal.Items.Clear();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CustomerCart.Clear();
            CustomerTotal.Items.Clear();
        }
    }
}

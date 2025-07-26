using System;
using System.Drawing;
using static POS_System_Prototype.CustomValues;
using static POS_System_Prototype.GlobalValues;

namespace POS_System_Prototype
{
    public partial class ItemsForm : DataForm
    {

        public ItemsForm()
        {
            InitializeComponent();

            AddItemButton.BackColor = SystemColors.Highlight;
            AddItemButton.ForeColor = Color.White;
            RemoveItemButton.BackColor = Color.White;
            RemoveItemButton.ForeColor = DefaultForegroundColor;
            AddingPanel.Visible = true;
            RemovingPanel.Visible = false;

            RefreshStock();
        }

        void RefreshStock()
        {
            ItemAddName.Items.Clear();
            ItemRemoveName.Items.Clear();
            foreach (Item Item in StoreStock)
            {
                ItemAddName.Items.Add(Item.GetName());
                ItemRemoveName.Items.Add(Item.GetName());
            }
        }

        private void ItemAddSubmit_Click(object sender, EventArgs e)
        {
            if (DoesItemExist(ItemAddName.Text.ToUpper()))
            {
                foreach (Item Item in StoreStock)
                {
                    if (Item.GetName().ToUpper().Equals(ItemAddName.Text.ToUpper()))
                    {
                        Item.AddStock(Convert.ToInt32(ItemAddAmount.Value));
                        Item.ChangePrice(Convert.ToDouble(ItemAddPrice.Value.ToString("F2")));
                        break;
                    }
                }
                ItemAddName.Text = string.Empty;
                ItemAddPrice.Value = 0;
                ItemAddAmount.Value = 0;
            }
            else
            {
                StoreStock.Add(new Item(ItemAddName.Text.ToUpper(), Convert.ToDouble(ItemAddPrice.Value.ToString("F2")), Convert.ToInt32(ItemAddAmount.Value)));
                ItemAddName.Text = string.Empty;
                ItemAddPrice.Value = 0;
                ItemAddAmount.Value = 0;
            }
            RefreshStock();
        }

        private void ItemRemoveSubmit_Click(object sender, EventArgs e)
        {
            foreach (Item Item in StoreStock)
            {
                if (Item.GetName().ToUpper().Equals(ItemRemoveName.Text.ToUpper()))
                {
                    StoreStock.Remove(Item);
                    break;
                }
            }
            ItemAddName.Text = string.Empty;
            ItemAddPrice.Value = 0;
            ItemAddAmount.Value = 0;
            RefreshStock();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            AddItemButton.BackColor = SystemColors.Highlight;
            AddItemButton.ForeColor = Color.White;
            RemoveItemButton.BackColor = DefaultBackgroundColor;
            RemoveItemButton.ForeColor = DefaultForegroundColor;
            AddingPanel.Visible = true;
            RemovingPanel.Visible = false;
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            AddItemButton.BackColor = DefaultBackgroundColor;
            AddItemButton.ForeColor = DefaultForegroundColor;
            RemoveItemButton.BackColor = SystemColors.Highlight;
            RemoveItemButton.ForeColor = Color.White;
            AddingPanel.Visible = false;
            RemovingPanel.Visible = true;
        }
    }
}

using System.Drawing;
using System.Windows.Forms;
using static POS_System_Prototype.CustomValues;
using static POS_System_Prototype.GlobalValues;

namespace POS_System_Prototype
{
    public partial class SalesForm : DataForm
    {
        public SalesForm()
        {
            InitializeComponent();
        }

        public override void RefreshData()
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            int RowCounter = 0;

            for (int a = 0; a < StoreStock.Count; a++)
            {
                RowCounter++;

                if (RowCounter == 5)
                {
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100f));
                    RowCounter = 0;
                }
            }

            for (int a = 0; a < StoreStock.Count; a++)
            {
                int f_a = a;

                Panel Panel = new Panel();
                Panel.Size = new Size(100, 100);
                Panel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                Panel.BackColor = Color.FromArgb(200, 200, 200);
                Panel.Margin = new Padding(8, 8, 8, 8);

                Label Name = new Label();
                Label Price = new Label();
                Label Stock = new Label();

                Name.Dock = DockStyle.Top;
                Price.Dock = DockStyle.Top;
                Stock.Dock = DockStyle.Top;

                Name.Text = StoreStock[a].GetName();
                Price.Text = $"₱{StoreStock[a].GetPrice()}";
                Stock.Text = $"{StoreStock[a].GetStock()} in stock";

                Panel.Click += (s, e) =>
                {
                    if (IsThereEnoughStock(StoreStock[f_a]))
                    {
                        CustomerCart.Add(StoreStock[f_a]);
                        MainFormInstance.RefreshCart();
                    }
                };
                Name.Click += (s, e) =>
                {
                    if (IsThereEnoughStock(StoreStock[f_a]))
                    {
                        CustomerCart.Add(StoreStock[f_a]);
                        MainFormInstance.RefreshCart();
                    }
                };
                Price.Click += (s, e) =>
                {
                    if (IsThereEnoughStock(StoreStock[f_a]))
                    {
                        CustomerCart.Add(StoreStock[f_a]);
                        MainFormInstance.RefreshCart();
                    }
                };
                Stock.Click += (s, e) =>
                {
                    if (IsThereEnoughStock(StoreStock[f_a]))
                    {
                        CustomerCart.Add(StoreStock[f_a]);
                        MainFormInstance.RefreshCart();
                    }
                };

                Panel.Controls.Add(Stock);
                Panel.Controls.Add(Price);
                Panel.Controls.Add(Name);

                tableLayoutPanel1.Controls.Add(Panel);
            }
        }
    }
}

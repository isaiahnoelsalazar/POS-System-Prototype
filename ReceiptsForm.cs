using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static POS_System_Prototype.CustomValues;
using static POS_System_Prototype.GlobalValues;

namespace POS_System_Prototype
{
    public partial class ReceiptsForm : DataForm
    {
        public ReceiptsForm()
        {
            InitializeComponent();
        }

        public override void RefreshData()
        {
            ReceiptListView.Controls.Clear();
            ReceiptListView.RowStyles.Clear();

            List<ReceiptItem> temp = new List<ReceiptItem>();
            foreach (ReceiptItem Item in ReceiptList)
            {
                temp.Add(Item);
            }
            temp.Reverse();

            for (int a = 0; a < temp.Count; a++)
            {
                int f_a = a;

                RowStyle Row = new RowStyle(SizeType.Absolute, 50f);

                Label Name = new Label();
                Name.Size = new Size(ReceiptListView.Width, 50);
                Name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                Name.Text = temp[a].GetReceiptIdentifier();
                Name.TextAlign = ContentAlignment.MiddleLeft;
                Name.Padding = new Padding(8, 0, 8, 0);
                Name.Margin = new Padding(0, 0, 0, 0);
                Name.BackColor = Color.FromArgb(200, 200, 200);

                Name.Click += (s, e) =>
                {
                    MessageBox.Show(temp[f_a].GetReceipt(), "Receipt", MessageBoxButtons.OK, MessageBoxIcon.None);
                };

                ReceiptListView.RowStyles.Add(Row);
                ReceiptListView.Controls.Add(Name);
            }
        }
    }
}

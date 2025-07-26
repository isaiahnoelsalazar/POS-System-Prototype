namespace POS_System_Prototype
{
    partial class ReceiptsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReceiptListView = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // ReceiptListView
            // 
            this.ReceiptListView.ColumnCount = 1;
            this.ReceiptListView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ReceiptListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReceiptListView.Location = new System.Drawing.Point(0, 0);
            this.ReceiptListView.Margin = new System.Windows.Forms.Padding(0);
            this.ReceiptListView.Name = "ReceiptListView";
            this.ReceiptListView.RowCount = 1;
            this.ReceiptListView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ReceiptListView.Size = new System.Drawing.Size(800, 450);
            this.ReceiptListView.TabIndex = 0;
            // 
            // ReceiptsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReceiptListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReceiptsForm";
            this.Text = "ReceiptsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ReceiptListView;
    }
}
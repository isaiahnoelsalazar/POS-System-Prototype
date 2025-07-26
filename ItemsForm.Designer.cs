namespace POS_System_Prototype
{
    partial class ItemsForm
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
            this.AddItemButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.AddingPanel = new System.Windows.Forms.Panel();
            this.ItemAddSubmit = new System.Windows.Forms.Button();
            this.ItemAddPrice = new System.Windows.Forms.NumericUpDown();
            this.ItemAddAmount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemAddName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RemovingPanel = new System.Windows.Forms.Panel();
            this.ItemRemoveSubmit = new System.Windows.Forms.Button();
            this.ItemRemoveName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemAddPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemAddAmount)).BeginInit();
            this.RemovingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(17, 17);
            this.AddItemButton.Margin = new System.Windows.Forms.Padding(8);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(200, 50);
            this.AddItemButton.TabIndex = 0;
            this.AddItemButton.Text = "Add Item to Stock";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Location = new System.Drawing.Point(225, 17);
            this.RemoveItemButton.Margin = new System.Windows.Forms.Padding(0, 8, 8, 8);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(200, 50);
            this.RemoveItemButton.TabIndex = 1;
            this.RemoveItemButton.Text = "Remove Item from Stock";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // AddingPanel
            // 
            this.AddingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddingPanel.Controls.Add(this.ItemAddSubmit);
            this.AddingPanel.Controls.Add(this.ItemAddPrice);
            this.AddingPanel.Controls.Add(this.ItemAddAmount);
            this.AddingPanel.Controls.Add(this.label3);
            this.AddingPanel.Controls.Add(this.label2);
            this.AddingPanel.Controls.Add(this.ItemAddName);
            this.AddingPanel.Controls.Add(this.label1);
            this.AddingPanel.Location = new System.Drawing.Point(17, 83);
            this.AddingPanel.Margin = new System.Windows.Forms.Padding(8);
            this.AddingPanel.Name = "AddingPanel";
            this.AddingPanel.Size = new System.Drawing.Size(766, 350);
            this.AddingPanel.TabIndex = 2;
            this.AddingPanel.Visible = false;
            // 
            // ItemAddSubmit
            // 
            this.ItemAddSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemAddSubmit.Location = new System.Drawing.Point(556, 290);
            this.ItemAddSubmit.Margin = new System.Windows.Forms.Padding(8);
            this.ItemAddSubmit.Name = "ItemAddSubmit";
            this.ItemAddSubmit.Size = new System.Drawing.Size(200, 50);
            this.ItemAddSubmit.TabIndex = 6;
            this.ItemAddSubmit.Text = "Submit";
            this.ItemAddSubmit.UseVisualStyleBackColor = true;
            this.ItemAddSubmit.Click += new System.EventHandler(this.ItemAddSubmit_Click);
            // 
            // ItemAddPrice
            // 
            this.ItemAddPrice.DecimalPlaces = 2;
            this.ItemAddPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemAddPrice.Location = new System.Drawing.Point(8, 115);
            this.ItemAddPrice.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.ItemAddPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ItemAddPrice.Name = "ItemAddPrice";
            this.ItemAddPrice.Size = new System.Drawing.Size(200, 30);
            this.ItemAddPrice.TabIndex = 3;
            // 
            // ItemAddAmount
            // 
            this.ItemAddAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemAddAmount.Location = new System.Drawing.Point(224, 115);
            this.ItemAddAmount.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.ItemAddAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ItemAddAmount.Name = "ItemAddAmount";
            this.ItemAddAmount.Size = new System.Drawing.Size(200, 30);
            this.ItemAddAmount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price (₱)";
            // 
            // ItemAddName
            // 
            this.ItemAddName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemAddName.FormattingEnabled = true;
            this.ItemAddName.Location = new System.Drawing.Point(8, 41);
            this.ItemAddName.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.ItemAddName.Name = "ItemAddName";
            this.ItemAddName.Size = new System.Drawing.Size(748, 33);
            this.ItemAddName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // RemovingPanel
            // 
            this.RemovingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemovingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RemovingPanel.Controls.Add(this.ItemRemoveSubmit);
            this.RemovingPanel.Controls.Add(this.ItemRemoveName);
            this.RemovingPanel.Controls.Add(this.label4);
            this.RemovingPanel.Location = new System.Drawing.Point(17, 83);
            this.RemovingPanel.Margin = new System.Windows.Forms.Padding(8);
            this.RemovingPanel.Name = "RemovingPanel";
            this.RemovingPanel.Size = new System.Drawing.Size(766, 350);
            this.RemovingPanel.TabIndex = 3;
            this.RemovingPanel.Visible = false;
            // 
            // ItemRemoveSubmit
            // 
            this.ItemRemoveSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemRemoveSubmit.Location = new System.Drawing.Point(556, 290);
            this.ItemRemoveSubmit.Margin = new System.Windows.Forms.Padding(8);
            this.ItemRemoveSubmit.Name = "ItemRemoveSubmit";
            this.ItemRemoveSubmit.Size = new System.Drawing.Size(200, 50);
            this.ItemRemoveSubmit.TabIndex = 2;
            this.ItemRemoveSubmit.Text = "Submit";
            this.ItemRemoveSubmit.UseVisualStyleBackColor = true;
            this.ItemRemoveSubmit.Click += new System.EventHandler(this.ItemRemoveSubmit_Click);
            // 
            // ItemRemoveName
            // 
            this.ItemRemoveName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemRemoveName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemRemoveName.FormattingEnabled = true;
            this.ItemRemoveName.Location = new System.Drawing.Point(8, 41);
            this.ItemRemoveName.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.ItemRemoveName.Name = "ItemRemoveName";
            this.ItemRemoveName.Size = new System.Drawing.Size(748, 33);
            this.ItemRemoveName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name";
            // 
            // ItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.AddingPanel);
            this.Controls.Add(this.RemovingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemsForm";
            this.Text = "ItemsForm";
            this.AddingPanel.ResumeLayout(false);
            this.AddingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemAddPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemAddAmount)).EndInit();
            this.RemovingPanel.ResumeLayout(false);
            this.RemovingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Panel AddingPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ItemAddName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ItemAddPrice;
        private System.Windows.Forms.NumericUpDown ItemAddAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ItemAddSubmit;
        private System.Windows.Forms.Panel RemovingPanel;
        private System.Windows.Forms.Button ItemRemoveSubmit;
        private System.Windows.Forms.ComboBox ItemRemoveName;
        private System.Windows.Forms.Label label4;
    }
}
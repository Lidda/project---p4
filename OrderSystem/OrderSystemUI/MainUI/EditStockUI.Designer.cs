namespace OrderSystemUI.MainUI
{
    partial class EditStockUI
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
            this.PNL_ManageStock = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.EditItem = new System.Windows.Forms.Button();
            this.DeleteItem = new System.Windows.Forms.Button();
            this.AddItem = new System.Windows.Forms.Button();
            this.ListView_Stock = new System.Windows.Forms.ListView();
            this.ItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemTAX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PNL_ManageStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_ManageStock
            // 
            this.PNL_ManageStock.Controls.Add(this.BackButton);
            this.PNL_ManageStock.Controls.Add(this.EditItem);
            this.PNL_ManageStock.Controls.Add(this.DeleteItem);
            this.PNL_ManageStock.Controls.Add(this.AddItem);
            this.PNL_ManageStock.Controls.Add(this.ListView_Stock);
            this.PNL_ManageStock.Location = new System.Drawing.Point(0, 0);
            this.PNL_ManageStock.Name = "PNL_ManageStock";
            this.PNL_ManageStock.Size = new System.Drawing.Size(465, 681);
            this.PNL_ManageStock.TabIndex = 17;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.Window;
            this.BackButton.Location = new System.Drawing.Point(12, 586);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(93, 44);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "<";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // EditItem
            // 
            this.EditItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.EditItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditItem.ForeColor = System.Drawing.SystemColors.Window;
            this.EditItem.Location = new System.Drawing.Point(162, 478);
            this.EditItem.Name = "EditItem";
            this.EditItem.Size = new System.Drawing.Size(135, 69);
            this.EditItem.TabIndex = 3;
            this.EditItem.Text = "Edit";
            this.EditItem.UseVisualStyleBackColor = false;
            // 
            // DeleteItem
            // 
            this.DeleteItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DeleteItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteItem.ForeColor = System.Drawing.SystemColors.Window;
            this.DeleteItem.Location = new System.Drawing.Point(311, 478);
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Size = new System.Drawing.Size(135, 69);
            this.DeleteItem.TabIndex = 2;
            this.DeleteItem.Text = "Delete";
            this.DeleteItem.UseVisualStyleBackColor = false;
            // 
            // AddItem
            // 
            this.AddItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItem.ForeColor = System.Drawing.SystemColors.Window;
            this.AddItem.Location = new System.Drawing.Point(12, 478);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(135, 69);
            this.AddItem.TabIndex = 1;
            this.AddItem.Text = "Add";
            this.AddItem.UseVisualStyleBackColor = false;
            // 
            // ListView_Stock
            // 
            this.ListView_Stock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemID,
            this.ItemName,
            this.ItemStock,
            this.ItemPrice,
            this.ItemTAX});
            this.ListView_Stock.FullRowSelect = true;
            this.ListView_Stock.GridLines = true;
            this.ListView_Stock.Location = new System.Drawing.Point(12, 10);
            this.ListView_Stock.Name = "ListView_Stock";
            this.ListView_Stock.Size = new System.Drawing.Size(437, 446);
            this.ListView_Stock.TabIndex = 0;
            this.ListView_Stock.UseCompatibleStateImageBehavior = false;
            this.ListView_Stock.View = System.Windows.Forms.View.Details;
            // 
            // ItemID
            // 
            this.ItemID.Text = "ID";
            this.ItemID.Width = 0;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Item name";
            this.ItemName.Width = 253;
            // 
            // ItemStock
            // 
            this.ItemStock.Text = "Stock";
            this.ItemStock.Width = 53;
            // 
            // ItemPrice
            // 
            this.ItemPrice.Text = "Price";
            this.ItemPrice.Width = 75;
            // 
            // ItemTAX
            // 
            this.ItemTAX.Text = "TAX (%)";
            this.ItemTAX.Width = 50;
            // 
            // EditStockUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 681);
            this.Controls.Add(this.PNL_ManageStock);
            this.Name = "EditStockUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditStock";
            this.PNL_ManageStock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_ManageStock;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button EditItem;
        private System.Windows.Forms.Button DeleteItem;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.ListView ListView_Stock;
        private System.Windows.Forms.ColumnHeader ItemID;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader ItemStock;
        private System.Windows.Forms.ColumnHeader ItemPrice;
        private System.Windows.Forms.ColumnHeader ItemTAX;
    }
}
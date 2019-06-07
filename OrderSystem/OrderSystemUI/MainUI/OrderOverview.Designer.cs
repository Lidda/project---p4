namespace OrderSystemUI.MainUI
{
    partial class OrderOverview
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
            this.ListView_Stock = new System.Windows.Forms.ListView();
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ListView_Stock
            // 
            this.ListView_Stock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.ItemPrice,
            this.Amount});
            this.ListView_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView_Stock.FullRowSelect = true;
            this.ListView_Stock.GridLines = true;
            this.ListView_Stock.Location = new System.Drawing.Point(15, 12);
            this.ListView_Stock.Name = "ListView_Stock";
            this.ListView_Stock.Size = new System.Drawing.Size(437, 454);
            this.ListView_Stock.TabIndex = 1;
            this.ListView_Stock.UseCompatibleStateImageBehavior = false;
            this.ListView_Stock.View = System.Windows.Forms.View.Details;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Product naam";
            this.ItemName.Width = 341;
            // 
            // ItemPrice
            // 
            this.ItemPrice.Text = "Prijs";
            this.ItemPrice.Width = 56;
            // 
            // Amount
            // 
            this.Amount.Text = "#";
            this.Amount.Width = 35;
            // 
            // OrderOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 681);
            this.Controls.Add(this.ListView_Stock);
            this.Name = "OrderOverview";
            this.Text = "OrderOverview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListView_Stock;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader ItemPrice;
        private System.Windows.Forms.ColumnHeader Amount;
    }
}
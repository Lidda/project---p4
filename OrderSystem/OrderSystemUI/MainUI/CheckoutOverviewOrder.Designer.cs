namespace OrderSystemUI.MainUI
{
    partial class CheckoutOverviewOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutOverviewOrder));
            this.lblTipAmount = new System.Windows.Forms.Label();
            this.lblTaxAmount = new System.Windows.Forms.Label();
            this.lblOrderPriceWithoutTax = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewOrderItems = new System.Windows.Forms.ListView();
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddTip = new System.Windows.Forms.Button();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblCheckoutOverviewHeader = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlError = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlError.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTipAmount
            // 
            this.lblTipAmount.AutoSize = true;
            this.lblTipAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTipAmount.Location = new System.Drawing.Point(483, 553);
            this.lblTipAmount.Name = "lblTipAmount";
            this.lblTipAmount.Size = new System.Drawing.Size(117, 31);
            this.lblTipAmount.TabIndex = 65;
            this.lblTipAmount.Text = "insert tip";
            // 
            // lblTaxAmount
            // 
            this.lblTaxAmount.AutoSize = true;
            this.lblTaxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTaxAmount.Location = new System.Drawing.Point(483, 508);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.Size = new System.Drawing.Size(117, 31);
            this.lblTaxAmount.TabIndex = 66;
            this.lblTaxAmount.Text = "inserttax";
            // 
            // lblOrderPriceWithoutTax
            // 
            this.lblOrderPriceWithoutTax.AutoSize = true;
            this.lblOrderPriceWithoutTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblOrderPriceWithoutTax.Location = new System.Drawing.Point(483, 468);
            this.lblOrderPriceWithoutTax.Name = "lblOrderPriceWithoutTax";
            this.lblOrderPriceWithoutTax.Size = new System.Drawing.Size(211, 31);
            this.lblOrderPriceWithoutTax.TabIndex = 67;
            this.lblOrderPriceWithoutTax.Text = "insertpricewotax";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTotalAmount.Location = new System.Drawing.Point(483, 615);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(0, 31);
            this.lblTotalAmount.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(21, 583);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(569, 31);
            this.label4.TabIndex = 63;
            this.label4.Text = "_____________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(21, 615);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 31);
            this.label3.TabIndex = 62;
            this.label3.Text = "Totaal:";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTip.Location = new System.Drawing.Point(21, 553);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(75, 31);
            this.lblTip.TabIndex = 61;
            this.lblTip.Text = "Fooi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(21, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 31);
            this.label2.TabIndex = 60;
            this.label2.Text = "Order (excl. btw):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(21, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 31);
            this.label1.TabIndex = 59;
            this.label1.Text = "BTW:";
            // 
            // listViewOrderItems
            // 
            this.listViewOrderItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.amount,
            this.Price});
            this.listViewOrderItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.listViewOrderItems.GridLines = true;
            this.listViewOrderItems.Location = new System.Drawing.Point(29, 54);
            this.listViewOrderItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewOrderItems.Name = "listViewOrderItems";
            this.listViewOrderItems.Size = new System.Drawing.Size(559, 390);
            this.listViewOrderItems.TabIndex = 58;
            this.listViewOrderItems.UseCompatibleStateImageBehavior = false;
            this.listViewOrderItems.View = System.Windows.Forms.View.Details;
            this.listViewOrderItems.SelectedIndexChanged += new System.EventHandler(this.listViewOrderItems_SelectedIndexChanged);
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 275;
            // 
            // amount
            // 
            this.amount.Text = "X";
            this.amount.Width = 75;
            // 
            // Price
            // 
            this.Price.Text = "€";
            this.Price.Width = 75;
            // 
            // btnAddTip
            // 
            this.btnAddTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAddTip.Location = new System.Drawing.Point(484, 674);
            this.btnAddTip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTip.Name = "btnAddTip";
            this.btnAddTip.Size = new System.Drawing.Size(104, 73);
            this.btnAddTip.TabIndex = 57;
            this.btnAddTip.Text = "Fooi";
            this.btnAddTip.UseVisualStyleBackColor = true;
            this.btnAddTip.Click += new System.EventHandler(this.btnAddTip_Click);
            // 
            // btnAddComment
            // 
            this.btnAddComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAddComment.Image = ((System.Drawing.Image)(resources.GetObject("btnAddComment.Image")));
            this.btnAddComment.Location = new System.Drawing.Point(361, 674);
            this.btnAddComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(104, 73);
            this.btnAddComment.TabIndex = 56;
            this.btnAddComment.UseVisualStyleBackColor = true;
            this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnPay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPay.Location = new System.Drawing.Point(29, 674);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(311, 73);
            this.btnPay.TabIndex = 55;
            this.btnPay.Text = "Betaal";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblCheckoutOverviewHeader
            // 
            this.lblCheckoutOverviewHeader.AutoSize = true;
            this.lblCheckoutOverviewHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCheckoutOverviewHeader.Location = new System.Drawing.Point(133, 9);
            this.lblCheckoutOverviewHeader.Name = "lblCheckoutOverviewHeader";
            this.lblCheckoutOverviewHeader.Size = new System.Drawing.Size(386, 39);
            this.lblCheckoutOverviewHeader.TabIndex = 54;
            this.lblCheckoutOverviewHeader.Text = "Overview bestelling tafel";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(-1, 779);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 58);
            this.btnBack.TabIndex = 68;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlError
            // 
            this.pnlError.BackColor = System.Drawing.Color.Red;
            this.pnlError.Controls.Add(this.button1);
            this.pnlError.Controls.Add(this.label5);
            this.pnlError.Location = new System.Drawing.Point(-1, 0);
            this.pnlError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlError.Name = "pnlError";
            this.pnlError.Size = new System.Drawing.Size(617, 837);
            this.pnlError.TabIndex = 69;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(149, 512);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(327, 113);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(3, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(581, 46);
            this.label5.TabIndex = 0;
            this.label5.Text = "Geen openstaande bestellingen";
            // 
            // CheckoutOverviewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(619, 838);
            this.Controls.Add(this.pnlError);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTipAmount);
            this.Controls.Add(this.lblTaxAmount);
            this.Controls.Add(this.lblOrderPriceWithoutTax);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewOrderItems);
            this.Controls.Add(this.btnAddTip);
            this.Controls.Add(this.btnAddComment);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblCheckoutOverviewHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CheckoutOverviewOrder";
            this.Text = "CheckoutOverviewOrder";
            this.pnlError.ResumeLayout(false);
            this.pnlError.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipAmount;
        private System.Windows.Forms.Label lblTaxAmount;
        private System.Windows.Forms.Label lblOrderPriceWithoutTax;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewOrderItems;
        private System.Windows.Forms.Button btnAddTip;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblCheckoutOverviewHeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlError;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader Price;
    }
}
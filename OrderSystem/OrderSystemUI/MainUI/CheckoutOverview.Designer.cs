namespace OrderSystemUI
{
    partial class CheckoutOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutOverview));
            this.pnlNoOrdersFound = new System.Windows.Forms.Panel();
            this.btnBackNoOrders = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlOverview = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTipAmount = new System.Windows.Forms.Label();
            this.lblTaxAmount = new System.Windows.Forms.Label();
            this.lblOrderPriceWithoutTax = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewOrderItems = new System.Windows.Forms.ListView();
            this.btnAddTip = new System.Windows.Forms.Button();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblCheckoutOverviewHeader = new System.Windows.Forms.Label();
            this.pnlNoOrdersFound.SuspendLayout();
            this.pnlOverview.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNoOrdersFound
            // 
            this.pnlNoOrdersFound.BackColor = System.Drawing.Color.Red;
            this.pnlNoOrdersFound.Controls.Add(this.pnlOverview);
            this.pnlNoOrdersFound.Controls.Add(this.btnBackNoOrders);
            this.pnlNoOrdersFound.Controls.Add(this.label7);
            this.pnlNoOrdersFound.Location = new System.Drawing.Point(0, -8);
            this.pnlNoOrdersFound.Name = "pnlNoOrdersFound";
            this.pnlNoOrdersFound.Size = new System.Drawing.Size(637, 880);
            this.pnlNoOrdersFound.TabIndex = 42;
            // 
            // btnBackNoOrders
            // 
            this.btnBackNoOrders.BackColor = System.Drawing.Color.Snow;
            this.btnBackNoOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackNoOrders.Location = new System.Drawing.Point(183, 365);
            this.btnBackNoOrders.Name = "btnBackNoOrders";
            this.btnBackNoOrders.Size = new System.Drawing.Size(226, 64);
            this.btnBackNoOrders.TabIndex = 42;
            this.btnBackNoOrders.Text = "Back";
            this.btnBackNoOrders.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(126, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(384, 58);
            this.label7.TabIndex = 0;
            this.label7.Text = "No orders found";
            // 
            // pnlOverview
            // 
            this.pnlOverview.BackColor = System.Drawing.Color.White;
            this.pnlOverview.Controls.Add(this.btnBack);
            this.pnlOverview.Controls.Add(this.lblTotalAmount);
            this.pnlOverview.Controls.Add(this.lblTipAmount);
            this.pnlOverview.Controls.Add(this.lblTaxAmount);
            this.pnlOverview.Controls.Add(this.lblOrderPriceWithoutTax);
            this.pnlOverview.Controls.Add(this.label4);
            this.pnlOverview.Controls.Add(this.label3);
            this.pnlOverview.Controls.Add(this.lblTip);
            this.pnlOverview.Controls.Add(this.label2);
            this.pnlOverview.Controls.Add(this.label1);
            this.pnlOverview.Controls.Add(this.listViewOrderItems);
            this.pnlOverview.Controls.Add(this.btnAddTip);
            this.pnlOverview.Controls.Add(this.btnAddComment);
            this.pnlOverview.Controls.Add(this.btnPay);
            this.pnlOverview.Controls.Add(this.lblCheckoutOverviewHeader);
            this.pnlOverview.Location = new System.Drawing.Point(0, 2);
            this.pnlOverview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlOverview.Name = "pnlOverview";
            this.pnlOverview.Size = new System.Drawing.Size(630, 880);
            this.pnlOverview.TabIndex = 51;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(27, 767);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 58);
            this.btnBack.TabIndex = 21;
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTotalAmount.Location = new System.Drawing.Point(481, 614);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(0, 31);
            this.lblTotalAmount.TabIndex = 29;
            // 
            // lblTipAmount
            // 
            this.lblTipAmount.AutoSize = true;
            this.lblTipAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTipAmount.Location = new System.Drawing.Point(481, 551);
            this.lblTipAmount.Name = "lblTipAmount";
            this.lblTipAmount.Size = new System.Drawing.Size(0, 31);
            this.lblTipAmount.TabIndex = 28;
            // 
            // lblTaxAmount
            // 
            this.lblTaxAmount.AutoSize = true;
            this.lblTaxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTaxAmount.Location = new System.Drawing.Point(481, 506);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.Size = new System.Drawing.Size(0, 31);
            this.lblTaxAmount.TabIndex = 27;
            // 
            // lblOrderPriceWithoutTax
            // 
            this.lblOrderPriceWithoutTax.AutoSize = true;
            this.lblOrderPriceWithoutTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblOrderPriceWithoutTax.Location = new System.Drawing.Point(481, 466);
            this.lblOrderPriceWithoutTax.Name = "lblOrderPriceWithoutTax";
            this.lblOrderPriceWithoutTax.Size = new System.Drawing.Size(0, 31);
            this.lblOrderPriceWithoutTax.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(20, 582);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(569, 31);
            this.label4.TabIndex = 25;
            this.label4.Text = "_____________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(21, 613);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 31);
            this.label3.TabIndex = 24;
            this.label3.Text = "Total:";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTip.Location = new System.Drawing.Point(21, 551);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(60, 31);
            this.lblTip.TabIndex = 23;
            this.lblTip.Text = "Tip:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(21, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 31);
            this.label2.TabIndex = 22;
            this.label2.Text = "Order (excl. TAX):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(21, 505);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "TAX:";
            // 
            // listViewOrderItems
            // 
            this.listViewOrderItems.Location = new System.Drawing.Point(28, 52);
            this.listViewOrderItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewOrderItems.Name = "listViewOrderItems";
            this.listViewOrderItems.Size = new System.Drawing.Size(559, 390);
            this.listViewOrderItems.TabIndex = 19;
            this.listViewOrderItems.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddTip
            // 
            this.btnAddTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAddTip.Location = new System.Drawing.Point(483, 672);
            this.btnAddTip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTip.Name = "btnAddTip";
            this.btnAddTip.Size = new System.Drawing.Size(104, 73);
            this.btnAddTip.TabIndex = 18;
            this.btnAddTip.Text = "Tip";
            this.btnAddTip.UseVisualStyleBackColor = true;
            this.btnAddTip.Click += new System.EventHandler(this.btnAddTip_Click_1);
            // 
            // btnAddComment
            // 
            this.btnAddComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAddComment.Image = ((System.Drawing.Image)(resources.GetObject("btnAddComment.Image")));
            this.btnAddComment.Location = new System.Drawing.Point(360, 672);
            this.btnAddComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(104, 73);
            this.btnAddComment.TabIndex = 17;
            this.btnAddComment.UseVisualStyleBackColor = true;
            this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click_1);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnPay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPay.Location = new System.Drawing.Point(28, 672);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(311, 73);
            this.btnPay.TabIndex = 16;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click_1);
            // 
            // lblCheckoutOverviewHeader
            // 
            this.lblCheckoutOverviewHeader.AutoSize = true;
            this.lblCheckoutOverviewHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCheckoutOverviewHeader.Location = new System.Drawing.Point(133, 7);
            this.lblCheckoutOverviewHeader.Name = "lblCheckoutOverviewHeader";
            this.lblCheckoutOverviewHeader.Size = new System.Drawing.Size(330, 39);
            this.lblCheckoutOverviewHeader.TabIndex = 15;
            this.lblCheckoutOverviewHeader.Text = "Order overview table";
            // 
            // CheckoutOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(619, 838);
            this.Controls.Add(this.pnlNoOrdersFound);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CheckoutOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckoutOverview";
            this.pnlNoOrdersFound.ResumeLayout(false);
            this.pnlNoOrdersFound.PerformLayout();
            this.pnlOverview.ResumeLayout(false);
            this.pnlOverview.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlNoOrdersFound;
        private System.Windows.Forms.Button btnBackNoOrders;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlOverview;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTipAmount;
        private System.Windows.Forms.Label lblTaxAmount;
        private System.Windows.Forms.Label lblOrderPriceWithoutTax;
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
    }
}
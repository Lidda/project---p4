namespace OrderSystemUI.MainUI
{
    partial class CheckoutOverviewOrderUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutOverviewOrderUI));
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
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTipEuroSign = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTipAmount = new System.Windows.Forms.Label();
            this.pnlError.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTaxAmount
            // 
            this.lblTaxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTaxAmount.Location = new System.Drawing.Point(474, 507);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.Size = new System.Drawing.Size(114, 31);
            this.lblTaxAmount.TabIndex = 66;
            this.lblTaxAmount.Text = "000,00";
            this.lblTaxAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOrderPriceWithoutTax
            // 
            this.lblOrderPriceWithoutTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblOrderPriceWithoutTax.Location = new System.Drawing.Point(474, 466);
            this.lblOrderPriceWithoutTax.Name = "lblOrderPriceWithoutTax";
            this.lblOrderPriceWithoutTax.Size = new System.Drawing.Size(114, 31);
            this.lblOrderPriceWithoutTax.TabIndex = 67;
            this.lblOrderPriceWithoutTax.Text = "000,00";
            this.lblOrderPriceWithoutTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTotalAmount.Location = new System.Drawing.Point(474, 615);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(114, 31);
            this.lblTotalAmount.TabIndex = 64;
            this.lblTotalAmount.Text = "000,00";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(21, 583);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(586, 31);
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
            this.listViewOrderItems.AutoArrange = false;
            this.listViewOrderItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.amount,
            this.Price});
            this.listViewOrderItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.listViewOrderItems.GridLines = true;
            this.listViewOrderItems.Location = new System.Drawing.Point(27, 54);
            this.listViewOrderItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewOrderItems.Name = "listViewOrderItems";
            this.listViewOrderItems.Size = new System.Drawing.Size(565, 390);
            this.listViewOrderItems.TabIndex = 58;
            this.listViewOrderItems.UseCompatibleStateImageBehavior = false;
            this.listViewOrderItems.View = System.Windows.Forms.View.Details;
            this.listViewOrderItems.SelectedIndexChanged += new System.EventHandler(this.listViewOrderItems_SelectedIndexChanged);
            // 
            // Item
            // 
            this.Item.Text = "Product";
            this.Item.Width = 275;
            // 
            // amount
            // 
            this.amount.Text = "X";
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amount.Width = 52;
            // 
            // Price
            // 
            this.Price.Text = "€";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Price.Width = 85;
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
            this.lblCheckoutOverviewHeader.Location = new System.Drawing.Point(92, 9);
            this.lblCheckoutOverviewHeader.Name = "lblCheckoutOverviewHeader";
            this.lblCheckoutOverviewHeader.Size = new System.Drawing.Size(387, 39);
            this.lblCheckoutOverviewHeader.TabIndex = 54;
            this.lblCheckoutOverviewHeader.Text = "Overzicht bestelling tafel";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(-1, 789);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(136, 49);
            this.btnBack.TabIndex = 68;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlError
            // 
            this.pnlError.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlError.Controls.Add(this.label8);
            this.pnlError.Controls.Add(this.button1);
            this.pnlError.Controls.Add(this.label5);
            this.pnlError.Location = new System.Drawing.Point(38, 244);
            this.pnlError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlError.Name = "pnlError";
            this.pnlError.Size = new System.Drawing.Size(538, 271);
            this.pnlError.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(233, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 113);
            this.label8.TabIndex = 2;
            this.label8.Text = "!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(105, 172);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 81);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(33, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(460, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "Geen openstaande bestelling";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.Location = new System.Drawing.Point(450, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 31);
            this.label6.TabIndex = 70;
            this.label6.Text = "€";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label7.Location = new System.Drawing.Point(450, 507);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 31);
            this.label7.TabIndex = 71;
            this.label7.Text = "€";
            // 
            // lblTipEuroSign
            // 
            this.lblTipEuroSign.AutoSize = true;
            this.lblTipEuroSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTipEuroSign.Location = new System.Drawing.Point(450, 553);
            this.lblTipEuroSign.Name = "lblTipEuroSign";
            this.lblTipEuroSign.Size = new System.Drawing.Size(29, 31);
            this.lblTipEuroSign.TabIndex = 72;
            this.lblTipEuroSign.Text = "€";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label9.Location = new System.Drawing.Point(450, 614);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 31);
            this.label9.TabIndex = 73;
            this.label9.Text = "€";
            // 
            // lblTipAmount
            // 
            this.lblTipAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblTipAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTipAmount.Location = new System.Drawing.Point(474, 552);
            this.lblTipAmount.Name = "lblTipAmount";
            this.lblTipAmount.Size = new System.Drawing.Size(114, 31);
            this.lblTipAmount.TabIndex = 74;
            this.lblTipAmount.Text = "999,00";
            this.lblTipAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CheckoutOverviewOrderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(619, 838);
            this.Controls.Add(this.pnlError);
            this.Controls.Add(this.lblTipAmount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblOrderPriceWithoutTax);
            this.Controls.Add(this.lblTipEuroSign);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTaxAmount);
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
            this.Name = "CheckoutOverviewOrderUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Overzicht bestelling";
            this.pnlError.ResumeLayout(false);
            this.pnlError.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTipEuroSign;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTipAmount;
        private System.Windows.Forms.Label label8;
    }
}
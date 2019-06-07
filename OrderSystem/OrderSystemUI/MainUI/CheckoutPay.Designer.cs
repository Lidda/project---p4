namespace OrderSystemUI.MainUI
{
    partial class CheckoutPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutPay));
            this.pnlChoosePayOption = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlChoosePayOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChoosePayOption
            // 
            this.pnlChoosePayOption.Controls.Add(this.btnBack);
            this.pnlChoosePayOption.Controls.Add(this.button3);
            this.pnlChoosePayOption.Controls.Add(this.btnCreditCard);
            this.pnlChoosePayOption.Controls.Add(this.btnCash);
            this.pnlChoosePayOption.Controls.Add(this.label1);
            this.pnlChoosePayOption.Location = new System.Drawing.Point(0, 1);
            this.pnlChoosePayOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlChoosePayOption.Name = "pnlChoosePayOption";
            this.pnlChoosePayOption.Size = new System.Drawing.Size(635, 880);
            this.pnlChoosePayOption.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(135, 501);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(339, 130);
            this.button3.TabIndex = 3;
            this.button3.Text = "Debitcard";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCreditCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCreditCard.Image = ((System.Drawing.Image)(resources.GetObject("btnCreditCard.Image")));
            this.btnCreditCard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCreditCard.Location = new System.Drawing.Point(135, 319);
            this.btnCreditCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(339, 130);
            this.btnCreditCard.TabIndex = 2;
            this.btnCreditCard.Text = "Creditcard";
            this.btnCreditCard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreditCard.UseVisualStyleBackColor = false;
            this.btnCreditCard.Click += new System.EventHandler(this.btnCreditCard_Click);
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCash.Image = ((System.Drawing.Image)(resources.GetObject("btnCash.Image")));
            this.btnCash.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCash.Location = new System.Drawing.Point(135, 128);
            this.btnCash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(339, 130);
            this.btnCash.TabIndex = 1;
            this.btnCash.Text = "Contant";
            this.btnCash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(147, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kies betaalmethode:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(29, 749);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 59);
            this.btnBack.TabIndex = 23;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CheckoutPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(619, 838);
            this.Controls.Add(this.pnlChoosePayOption);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CheckoutPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Betaal";
            this.pnlChoosePayOption.ResumeLayout(false);
            this.pnlChoosePayOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChoosePayOption;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlConfirmation = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlChoosePayOption.SuspendLayout();
            this.pnlConfirmation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChoosePayOption
            // 
            this.pnlChoosePayOption.Controls.Add(this.pnlConfirmation);
            this.pnlChoosePayOption.Controls.Add(this.btnCancel);
            this.pnlChoosePayOption.Controls.Add(this.button3);
            this.pnlChoosePayOption.Controls.Add(this.btnCreditCard);
            this.pnlChoosePayOption.Controls.Add(this.btnCash);
            this.pnlChoosePayOption.Controls.Add(this.label1);
            this.pnlChoosePayOption.Location = new System.Drawing.Point(0, 1);
            this.pnlChoosePayOption.Name = "pnlChoosePayOption";
            this.pnlChoosePayOption.Size = new System.Drawing.Size(635, 880);
            this.pnlChoosePayOption.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(92, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose payment method:";
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCash.Image = ((System.Drawing.Image)(resources.GetObject("btnCash.Image")));
            this.btnCash.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCash.Location = new System.Drawing.Point(135, 128);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(338, 89);
            this.btnCash.TabIndex = 1;
            this.btnCash.Text = "Cash";
            this.btnCash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCreditCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCreditCard.Image = ((System.Drawing.Image)(resources.GetObject("btnCreditCard.Image")));
            this.btnCreditCard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCreditCard.Location = new System.Drawing.Point(135, 327);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(338, 89);
            this.btnCreditCard.TabIndex = 2;
            this.btnCreditCard.Text = "Creditcard";
            this.btnCreditCard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreditCard.UseVisualStyleBackColor = false;
            this.btnCreditCard.Click += new System.EventHandler(this.btnCreditCard_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(135, 547);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(338, 89);
            this.button3.TabIndex = 3;
            this.button3.Text = "Debitcard";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(223, 700);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 85);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlConfirmation
            // 
            this.pnlConfirmation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlConfirmation.BackgroundImage")));
            this.pnlConfirmation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlConfirmation.Controls.Add(this.label2);
            this.pnlConfirmation.Controls.Add(this.button1);
            this.pnlConfirmation.Location = new System.Drawing.Point(3, 0);
            this.pnlConfirmation.Name = "pnlConfirmation";
            this.pnlConfirmation.Size = new System.Drawing.Size(614, 839);
            this.pnlConfirmation.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(155, 688);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(342, 109);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label2.Location = new System.Drawing.Point(165, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Payment succesful";
            // 
            // CheckoutPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(619, 838);
            this.Controls.Add(this.pnlChoosePayOption);
            this.Name = "CheckoutPay";
            this.Text = "CheckoutPay";
            this.pnlChoosePayOption.ResumeLayout(false);
            this.pnlChoosePayOption.PerformLayout();
            this.pnlConfirmation.ResumeLayout(false);
            this.pnlConfirmation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChoosePayOption;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlConfirmation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}
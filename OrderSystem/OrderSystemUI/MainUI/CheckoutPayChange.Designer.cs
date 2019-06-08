namespace OrderSystemUI.MainUI
{
    partial class CheckoutPayChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutPayChange));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtChangeAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblChangeText = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCalculateChange = new System.Windows.Forms.Button();
            this.lblNotEnough = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wisselgeld berekenen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(29, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Te betalen bedrag:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTotalAmount.Location = new System.Drawing.Point(480, 85);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(104, 31);
            this.lblTotalAmount.TabIndex = 2;
            this.lblTotalAmount.Text = "€ 00,00";
            // 
            // txtChangeAmount
            // 
            this.txtChangeAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtChangeAmount.Location = new System.Drawing.Point(35, 187);
            this.txtChangeAmount.Multiline = true;
            this.txtChangeAmount.Name = "txtChangeAmount";
            this.txtChangeAmount.Size = new System.Drawing.Size(549, 212);
            this.txtChangeAmount.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(29, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bedrag betaald door klant:";
            // 
            // lblChangeText
            // 
            this.lblChangeText.AutoSize = true;
            this.lblChangeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblChangeText.Location = new System.Drawing.Point(58, 554);
            this.lblChangeText.Name = "lblChangeText";
            this.lblChangeText.Size = new System.Drawing.Size(153, 31);
            this.lblChangeText.TabIndex = 5;
            this.lblChangeText.Text = "Wisselgeld:";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblChange.Location = new System.Drawing.Point(480, 554);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(104, 31);
            this.lblChange.TabIndex = 6;
            this.lblChange.Text = "€ 00,00";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnOK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOK.Location = new System.Drawing.Point(144, 693);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(356, 103);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCalculateChange
            // 
            this.btnCalculateChange.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCalculateChange.FlatAppearance.BorderSize = 0;
            this.btnCalculateChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCalculateChange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalculateChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculateChange.Location = new System.Drawing.Point(35, 434);
            this.btnCalculateChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculateChange.Name = "btnCalculateChange";
            this.btnCalculateChange.Size = new System.Drawing.Size(549, 58);
            this.btnCalculateChange.TabIndex = 34;
            this.btnCalculateChange.Text = "Bereken wisselgeld";
            this.btnCalculateChange.UseVisualStyleBackColor = false;
            this.btnCalculateChange.Click += new System.EventHandler(this.btnCalculateChange_Click);
            // 
            // lblNotEnough
            // 
            this.lblNotEnough.AutoSize = true;
            this.lblNotEnough.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblNotEnough.ForeColor = System.Drawing.Color.Red;
            this.lblNotEnough.Location = new System.Drawing.Point(58, 629);
            this.lblNotEnough.Name = "lblNotEnough";
            this.lblNotEnough.Size = new System.Drawing.Size(526, 36);
            this.lblNotEnough.TabIndex = 35;
            this.lblNotEnough.Text = "De klant heeft €bedrag te kort gegeven";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(0, 780);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 59);
            this.btnBack.TabIndex = 36;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CheckoutPayChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(619, 838);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblNotEnough);
            this.Controls.Add(this.btnCalculateChange);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblChangeText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChangeAmount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CheckoutPayChange";
            this.Text = "CheckoutPayChange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtChangeAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblChangeText;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCalculateChange;
        private System.Windows.Forms.Label lblNotEnough;
        private System.Windows.Forms.Button btnBack;
    }
}
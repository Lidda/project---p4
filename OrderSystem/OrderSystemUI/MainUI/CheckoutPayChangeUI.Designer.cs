namespace OrderSystemUI.MainUI
{
    partial class CheckoutPayChangeUI
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEuroSign = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wisselgeld berekenen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(35, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Te betalen bedrag:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTotalAmount.Location = new System.Drawing.Point(421, 154);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(104, 31);
            this.lblTotalAmount.TabIndex = 2;
            this.lblTotalAmount.Text = "000,00";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtChangeAmount
            // 
            this.txtChangeAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtChangeAmount.Location = new System.Drawing.Point(427, 220);
            this.txtChangeAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChangeAmount.Name = "txtChangeAmount";
            this.txtChangeAmount.Size = new System.Drawing.Size(150, 38);
            this.txtChangeAmount.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(35, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bedrag betaald door klant:";
            // 
            // lblChangeText
            // 
            this.lblChangeText.AutoSize = true;
            this.lblChangeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblChangeText.Location = new System.Drawing.Point(35, 516);
            this.lblChangeText.Name = "lblChangeText";
            this.lblChangeText.Size = new System.Drawing.Size(153, 31);
            this.lblChangeText.TabIndex = 5;
            this.lblChangeText.Text = "Wisselgeld:";
            // 
            // lblChange
            // 
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblChange.Location = new System.Drawing.Point(421, 516);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(104, 31);
            this.lblChange.TabIndex = 6;
            this.lblChange.Text = "000,00";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnOK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOK.Location = new System.Drawing.Point(131, 684);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(356, 73);
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
            this.btnCalculateChange.Location = new System.Drawing.Point(41, 337);
            this.btnCalculateChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculateChange.Name = "btnCalculateChange";
            this.btnCalculateChange.Size = new System.Drawing.Size(536, 82);
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
            this.lblNotEnough.Location = new System.Drawing.Point(35, 590);
            this.lblNotEnough.Name = "lblNotEnough";
            this.lblNotEnough.Size = new System.Drawing.Size(526, 36);
            this.lblNotEnough.TabIndex = 35;
            this.lblNotEnough.Text = "De klant heeft €bedrag te kort gegeven";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(0, 789);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 49);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(392, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 31);
            this.label4.TabIndex = 37;
            this.label4.Text = "€";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(392, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 31);
            this.label5.TabIndex = 38;
            this.label5.Text = "€";
            // 
            // lblEuroSign
            // 
            this.lblEuroSign.AutoSize = true;
            this.lblEuroSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblEuroSign.Location = new System.Drawing.Point(392, 516);
            this.lblEuroSign.Name = "lblEuroSign";
            this.lblEuroSign.Size = new System.Drawing.Size(29, 31);
            this.lblEuroSign.TabIndex = 39;
            this.lblEuroSign.Text = "€";
            // 
            // CheckoutPayChangeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(619, 838);
            this.Controls.Add(this.lblEuroSign);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CheckoutPayChangeUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEuroSign;
    }
}
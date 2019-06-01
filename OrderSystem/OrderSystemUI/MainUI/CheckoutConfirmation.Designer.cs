namespace OrderSystemUI.MainUI
{
    partial class CheckoutConfirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutConfirmation));
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.pbConfirmation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmation)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label2.Location = new System.Drawing.Point(143, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Payment succesful";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnOK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOK.Location = new System.Drawing.Point(133, 704);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(342, 109);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pbConfirmation
            // 
            this.pbConfirmation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbConfirmation.BackgroundImage")));
            this.pbConfirmation.Location = new System.Drawing.Point(2, 109);
            this.pbConfirmation.MaximumSize = new System.Drawing.Size(600, 550);
            this.pbConfirmation.Name = "pbConfirmation";
            this.pbConfirmation.Size = new System.Drawing.Size(600, 550);
            this.pbConfirmation.TabIndex = 4;
            this.pbConfirmation.TabStop = false;
            // 
            // CheckoutConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(619, 838);
            this.Controls.Add(this.pbConfirmation);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Name = "CheckoutConfirmation";
            this.Text = "CheckoutConfirmation";
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PictureBox pbConfirmation;
    }
}
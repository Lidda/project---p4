namespace OrderSystemUI.MainUI {
    partial class OrderMenuUI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnFree = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTaken = new System.Windows.Forms.Button();
            this.btnReserved = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFree
            // 
            this.btnFree.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFree.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btnFree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFree.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFree.Location = new System.Drawing.Point(52, 46);
            this.btnFree.Name = "btnFree";
            this.btnFree.Size = new System.Drawing.Size(114, 35);
            this.btnFree.TabIndex = 0;
            this.btnFree.Text = "Free";
            this.btnFree.UseVisualStyleBackColor = false;
            this.btnFree.Click += new System.EventHandler(this.btnFree_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(12, 632);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 37);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTaken
            // 
            this.btnTaken.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTaken.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btnTaken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaken.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaken.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTaken.Location = new System.Drawing.Point(172, 46);
            this.btnTaken.Name = "btnTaken";
            this.btnTaken.Size = new System.Drawing.Size(114, 35);
            this.btnTaken.TabIndex = 4;
            this.btnTaken.Text = "Taken";
            this.btnTaken.UseVisualStyleBackColor = false;
            this.btnTaken.Click += new System.EventHandler(this.btnTaken_Click);
            // 
            // btnReserved
            // 
            this.btnReserved.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnReserved.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btnReserved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserved.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserved.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReserved.Location = new System.Drawing.Point(292, 46);
            this.btnReserved.Name = "btnReserved";
            this.btnReserved.Size = new System.Drawing.Size(114, 35);
            this.btnReserved.TabIndex = 5;
            this.btnReserved.Text = "Reserved";
            this.btnReserved.UseVisualStyleBackColor = false;
            this.btnReserved.Click += new System.EventHandler(this.btnReserved_Click_1);
            // 
            // OrderMenuUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 681);
            this.Controls.Add(this.btnReserved);
            this.Controls.Add(this.btnTaken);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFree);
            this.Name = "OrderMenuUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFree;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTaken;
        private System.Windows.Forms.Button btnReserved;


    }
}
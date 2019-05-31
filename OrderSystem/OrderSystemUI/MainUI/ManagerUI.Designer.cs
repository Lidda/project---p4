namespace OrderSystemUI.MainUI {
    partial class ManagerUI {
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.BTN_Stats = new System.Windows.Forms.Button();
            this.BTN_ManageProducts = new System.Windows.Forms.Button();
            this.BTN_ManageEmployees = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(6, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(60, 23);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // BTN_Stats
            // 
            this.BTN_Stats.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BTN_Stats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Stats.ForeColor = System.Drawing.SystemColors.Window;
            this.BTN_Stats.Location = new System.Drawing.Point(12, 79);
            this.BTN_Stats.Name = "BTN_Stats";
            this.BTN_Stats.Size = new System.Drawing.Size(440, 141);
            this.BTN_Stats.TabIndex = 4;
            this.BTN_Stats.Text = "Buisiness statistics";
            this.BTN_Stats.UseVisualStyleBackColor = false;
            this.BTN_Stats.Click += new System.EventHandler(this.BTN_Stats_Click);
            // 
            // BTN_ManageProducts
            // 
            this.BTN_ManageProducts.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BTN_ManageProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ManageProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ManageProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ManageProducts.ForeColor = System.Drawing.SystemColors.Window;
            this.BTN_ManageProducts.Location = new System.Drawing.Point(12, 275);
            this.BTN_ManageProducts.Name = "BTN_ManageProducts";
            this.BTN_ManageProducts.Size = new System.Drawing.Size(440, 141);
            this.BTN_ManageProducts.TabIndex = 5;
            this.BTN_ManageProducts.Text = "Manage products";
            this.BTN_ManageProducts.UseVisualStyleBackColor = false;
            this.BTN_ManageProducts.Click += new System.EventHandler(this.BTN_ManageProducts_Click);
            // 
            // BTN_ManageEmployees
            // 
            this.BTN_ManageEmployees.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BTN_ManageEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ManageEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ManageEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ManageEmployees.ForeColor = System.Drawing.SystemColors.Window;
            this.BTN_ManageEmployees.Location = new System.Drawing.Point(12, 473);
            this.BTN_ManageEmployees.Name = "BTN_ManageEmployees";
            this.BTN_ManageEmployees.Size = new System.Drawing.Size(440, 141);
            this.BTN_ManageEmployees.TabIndex = 6;
            this.BTN_ManageEmployees.Text = "Manage employees";
            this.BTN_ManageEmployees.UseVisualStyleBackColor = false;
            this.BTN_ManageEmployees.Click += new System.EventHandler(this.BTN_ManageEmployees_Click);
            // 
            // ManagerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(464, 681);
            this.Controls.Add(this.BTN_ManageEmployees);
            this.Controls.Add(this.BTN_ManageProducts);
            this.Controls.Add(this.BTN_Stats);
            this.Controls.Add(this.btnLogout);
            this.Name = "ManagerUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button BTN_Stats;
        private System.Windows.Forms.Button BTN_ManageProducts;
        private System.Windows.Forms.Button BTN_ManageEmployees;
    }
}
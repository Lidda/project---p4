namespace OrderSystemUI {
    partial class OrderSystemUI {
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
            this.PNL_AddItems = new System.Windows.Forms.Panel();
            this.BTN_AddEmployee = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.DB_AddEmployeeType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTB_AddPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTB_AddUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTB_AddEmployeeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PNL_AddItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_AddItems
            // 
            this.PNL_AddItems.Controls.Add(this.BTN_AddEmployee);
            this.PNL_AddItems.Controls.Add(this.label8);
            this.PNL_AddItems.Controls.Add(this.DB_AddEmployeeType);
            this.PNL_AddItems.Controls.Add(this.label7);
            this.PNL_AddItems.Controls.Add(this.TXTB_AddPassword);
            this.PNL_AddItems.Controls.Add(this.label6);
            this.PNL_AddItems.Controls.Add(this.TXTB_AddUsername);
            this.PNL_AddItems.Controls.Add(this.label5);
            this.PNL_AddItems.Controls.Add(this.TXTB_AddEmployeeName);
            this.PNL_AddItems.Controls.Add(this.label1);
            this.PNL_AddItems.Location = new System.Drawing.Point(12, 69);
            this.PNL_AddItems.Name = "PNL_AddItems";
            this.PNL_AddItems.Size = new System.Drawing.Size(506, 562);
            this.PNL_AddItems.TabIndex = 0;
            // 
            // BTN_AddEmployee
            // 
            this.BTN_AddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AddEmployee.Location = new System.Drawing.Point(28, 460);
            this.BTN_AddEmployee.Name = "BTN_AddEmployee";
            this.BTN_AddEmployee.Size = new System.Drawing.Size(450, 62);
            this.BTN_AddEmployee.TabIndex = 15;
            this.BTN_AddEmployee.Text = "Submit";
            this.BTN_AddEmployee.UseVisualStyleBackColor = true;
            this.BTN_AddEmployee.Click += new System.EventHandler(this.BTN_AddEmployee_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(120, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(280, 46);
            this.label8.TabIndex = 14;
            this.label8.Text = "Add Employee";
            // 
            // DB_AddEmployeeType
            // 
            this.DB_AddEmployeeType.FormattingEnabled = true;
            this.DB_AddEmployeeType.Items.AddRange(new object[] {
            "Bartender",
            "Cook",
            "Waiter",
            "Manager"});
            this.DB_AddEmployeeType.Location = new System.Drawing.Point(128, 278);
            this.DB_AddEmployeeType.Name = "DB_AddEmployeeType";
            this.DB_AddEmployeeType.Size = new System.Drawing.Size(105, 21);
            this.DB_AddEmployeeType.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Type:";
            // 
            // TXTB_AddPassword
            // 
            this.TXTB_AddPassword.Location = new System.Drawing.Point(128, 231);
            this.TXTB_AddPassword.Name = "TXTB_AddPassword";
            this.TXTB_AddPassword.Size = new System.Drawing.Size(183, 20);
            this.TXTB_AddPassword.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Password:";
            // 
            // TXTB_AddUsername
            // 
            this.TXTB_AddUsername.Location = new System.Drawing.Point(128, 183);
            this.TXTB_AddUsername.Name = "TXTB_AddUsername";
            this.TXTB_AddUsername.Size = new System.Drawing.Size(183, 20);
            this.TXTB_AddUsername.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Username:";
            // 
            // TXTB_AddEmployeeName
            // 
            this.TXTB_AddEmployeeName.Location = new System.Drawing.Point(128, 136);
            this.TXTB_AddEmployeeName.Name = "TXTB_AddEmployeeName";
            this.TXTB_AddEmployeeName.Size = new System.Drawing.Size(183, 20);
            this.TXTB_AddEmployeeName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // OrderSystemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 643);
            this.Controls.Add(this.PNL_AddItems);
            this.Name = "OrderSystemUI";
            this.Text = "OrderSystemUI";
            this.PNL_AddItems.ResumeLayout(false);
            this.PNL_AddItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_AddItems;
        private System.Windows.Forms.TextBox TXTB_AddEmployeeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTB_AddPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXTB_AddUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_AddEmployee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox DB_AddEmployeeType;
        private System.Windows.Forms.Label label7;
    }
}
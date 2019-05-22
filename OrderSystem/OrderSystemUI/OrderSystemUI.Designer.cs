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
            this.BTN_AddEmployee = new System.Windows.Forms.Button();
            this.PNL_EditEmployee = new System.Windows.Forms.Panel();
            this.BTN_EditEmployee = new System.Windows.Forms.Button();
            this.BTN_DeleteEmployee = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ListView_Employees = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmpoyeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DB_AddEmployeeType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTB_AddPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTB_AddUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTB_AddEmployeeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PNL_EditEmployee.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_AddEmployee
            // 
            this.BTN_AddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AddEmployee.Location = new System.Drawing.Point(329, 423);
            this.BTN_AddEmployee.Name = "BTN_AddEmployee";
            this.BTN_AddEmployee.Size = new System.Drawing.Size(162, 29);
            this.BTN_AddEmployee.TabIndex = 15;
            this.BTN_AddEmployee.Text = "Add employee";
            this.BTN_AddEmployee.UseVisualStyleBackColor = true;
            this.BTN_AddEmployee.Click += new System.EventHandler(this.BTN_AddEmployee_Click);
            // 
            // PNL_EditEmployee
            // 
            this.PNL_EditEmployee.Controls.Add(this.BTN_AddEmployee);
            this.PNL_EditEmployee.Controls.Add(this.DB_AddEmployeeType);
            this.PNL_EditEmployee.Controls.Add(this.label7);
            this.PNL_EditEmployee.Controls.Add(this.TXTB_AddPassword);
            this.PNL_EditEmployee.Controls.Add(this.label6);
            this.PNL_EditEmployee.Controls.Add(this.TXTB_AddUsername);
            this.PNL_EditEmployee.Controls.Add(this.label5);
            this.PNL_EditEmployee.Controls.Add(this.TXTB_AddEmployeeName);
            this.PNL_EditEmployee.Controls.Add(this.label1);
            this.PNL_EditEmployee.Controls.Add(this.BTN_EditEmployee);
            this.PNL_EditEmployee.Controls.Add(this.BTN_DeleteEmployee);
            this.PNL_EditEmployee.Controls.Add(this.label2);
            this.PNL_EditEmployee.Controls.Add(this.ListView_Employees);
            this.PNL_EditEmployee.Location = new System.Drawing.Point(12, 69);
            this.PNL_EditEmployee.Name = "PNL_EditEmployee";
            this.PNL_EditEmployee.Size = new System.Drawing.Size(506, 562);
            this.PNL_EditEmployee.TabIndex = 16;
            // 
            // BTN_EditEmployee
            // 
            this.BTN_EditEmployee.Location = new System.Drawing.Point(329, 458);
            this.BTN_EditEmployee.Name = "BTN_EditEmployee";
            this.BTN_EditEmployee.Size = new System.Drawing.Size(162, 33);
            this.BTN_EditEmployee.TabIndex = 17;
            this.BTN_EditEmployee.Text = "Edit employee";
            this.BTN_EditEmployee.UseVisualStyleBackColor = true;
            this.BTN_EditEmployee.Click += new System.EventHandler(this.BTN_EditEmployee_Click);
            // 
            // BTN_DeleteEmployee
            // 
            this.BTN_DeleteEmployee.Location = new System.Drawing.Point(329, 497);
            this.BTN_DeleteEmployee.Name = "BTN_DeleteEmployee";
            this.BTN_DeleteEmployee.Size = new System.Drawing.Size(162, 31);
            this.BTN_DeleteEmployee.TabIndex = 16;
            this.BTN_DeleteEmployee.Text = "Delete employee";
            this.BTN_DeleteEmployee.UseVisualStyleBackColor = true;
            this.BTN_DeleteEmployee.Click += new System.EventHandler(this.BTN_DeleteEmployee_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 46);
            this.label2.TabIndex = 15;
            this.label2.Text = "Edit employees";
            // 
            // ListView_Employees
            // 
            this.ListView_Employees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.Username,
            this.Password,
            this.Type});
            this.ListView_Employees.FullRowSelect = true;
            this.ListView_Employees.Location = new System.Drawing.Point(3, 93);
            this.ListView_Employees.Name = "ListView_Employees";
            this.ListView_Employees.Size = new System.Drawing.Size(500, 310);
            this.ListView_Employees.TabIndex = 0;
            this.ListView_Employees.UseCompatibleStateImageBehavior = false;
            this.ListView_Employees.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 140;
            // 
            // Username
            // 
            this.Username.Text = "Username";
            this.Username.Width = 146;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.Width = 134;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 75;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(530, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editEmployeesToolStripMenuItem,
            this.addEmpoyeeToolStripMenuItem});
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.employeesToolStripMenuItem.Text = "Employees";
            // 
            // editEmployeesToolStripMenuItem
            // 
            this.editEmployeesToolStripMenuItem.Name = "editEmployeesToolStripMenuItem";
            this.editEmployeesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.editEmployeesToolStripMenuItem.Text = "Edit employee";
            this.editEmployeesToolStripMenuItem.Click += new System.EventHandler(this.editEmployeesToolStripMenuItem_Click);
            // 
            // addEmpoyeeToolStripMenuItem
            // 
            this.addEmpoyeeToolStripMenuItem.Name = "addEmpoyeeToolStripMenuItem";
            this.addEmpoyeeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.addEmpoyeeToolStripMenuItem.Text = "Add employee";
            this.addEmpoyeeToolStripMenuItem.Click += new System.EventHandler(this.addEmpoyeeToolStripMenuItem_Click);
            // 
            // DB_AddEmployeeType
            // 
            this.DB_AddEmployeeType.FormattingEnabled = true;
            this.DB_AddEmployeeType.Items.AddRange(new object[] {
            "Bartender",
            "Cook",
            "Waiter",
            "Manager"});
            this.DB_AddEmployeeType.Location = new System.Drawing.Point(119, 501);
            this.DB_AddEmployeeType.Name = "DB_AddEmployeeType";
            this.DB_AddEmployeeType.Size = new System.Drawing.Size(183, 21);
            this.DB_AddEmployeeType.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 501);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Type:";
            // 
            // TXTB_AddPassword
            // 
            this.TXTB_AddPassword.Location = new System.Drawing.Point(119, 475);
            this.TXTB_AddPassword.Name = "TXTB_AddPassword";
            this.TXTB_AddPassword.Size = new System.Drawing.Size(183, 20);
            this.TXTB_AddPassword.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Password:";
            // 
            // TXTB_AddUsername
            // 
            this.TXTB_AddUsername.Location = new System.Drawing.Point(119, 449);
            this.TXTB_AddUsername.Name = "TXTB_AddUsername";
            this.TXTB_AddUsername.Size = new System.Drawing.Size(183, 20);
            this.TXTB_AddUsername.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Username:";
            // 
            // TXTB_AddEmployeeName
            // 
            this.TXTB_AddEmployeeName.Location = new System.Drawing.Point(119, 423);
            this.TXTB_AddEmployeeName.Name = "TXTB_AddEmployeeName";
            this.TXTB_AddEmployeeName.Size = new System.Drawing.Size(183, 20);
            this.TXTB_AddEmployeeName.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name:";
            // 
            // OrderSystemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 643);
            this.Controls.Add(this.PNL_EditEmployee);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderSystemUI";
            this.Text = "OrderSystemUI";
            this.PNL_EditEmployee.ResumeLayout(false);
            this.PNL_EditEmployee.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_AddEmployee;
        private System.Windows.Forms.Panel PNL_EditEmployee;
        private System.Windows.Forms.ListView ListView_Employees;
        private System.Windows.Forms.Button BTN_EditEmployee;
        private System.Windows.Forms.Button BTN_DeleteEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmpoyeeToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ComboBox DB_AddEmployeeType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXTB_AddPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXTB_AddUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTB_AddEmployeeName;
        private System.Windows.Forms.Label label1;
    }
}
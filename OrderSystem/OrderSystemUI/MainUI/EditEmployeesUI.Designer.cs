namespace OrderSystemUI {
    partial class EditEmployeesUI {
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
            this.PNL_ManageEmployee = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.EditEmployee = new System.Windows.Forms.Button();
            this.DeleteEmployee = new System.Windows.Forms.Button();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.ListView_Employees = new System.Windows.Forms.ListView();
            this.EmployeeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gebruikersnaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Wachtwoord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PNL_AddEmployee = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.DB_AddEmployeeType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_AddEmployee = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTB_AddEmployeeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTB_AddEmployeePassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTB_AddEmployeeUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PNL_EditEmployee = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.DB_EditEmployeeType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BTN_EditEmployee = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTB_EditEmployeeName = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.TXTB_EditEmployeePassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TXTB_EditEmployeeUsername = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PNL_ManageEmployee.SuspendLayout();
            this.PNL_AddEmployee.SuspendLayout();
            this.PNL_EditEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_ManageEmployee
            // 
            this.PNL_ManageEmployee.Controls.Add(this.BackButton);
            this.PNL_ManageEmployee.Controls.Add(this.EditEmployee);
            this.PNL_ManageEmployee.Controls.Add(this.DeleteEmployee);
            this.PNL_ManageEmployee.Controls.Add(this.AddEmployee);
            this.PNL_ManageEmployee.Controls.Add(this.ListView_Employees);
            this.PNL_ManageEmployee.Location = new System.Drawing.Point(0, 0);
            this.PNL_ManageEmployee.Name = "PNL_ManageEmployee";
            this.PNL_ManageEmployee.Size = new System.Drawing.Size(465, 681);
            this.PNL_ManageEmployee.TabIndex = 16;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.Window;
            this.BackButton.Location = new System.Drawing.Point(0, 637);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(105, 44);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "<";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EditEmployee
            // 
            this.EditEmployee.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.EditEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.EditEmployee.ForeColor = System.Drawing.SystemColors.Window;
            this.EditEmployee.Location = new System.Drawing.Point(162, 536);
            this.EditEmployee.Name = "EditEmployee";
            this.EditEmployee.Size = new System.Drawing.Size(135, 69);
            this.EditEmployee.TabIndex = 3;
            this.EditEmployee.Text = "Bewerk";
            this.EditEmployee.UseVisualStyleBackColor = false;
            this.EditEmployee.Click += new System.EventHandler(this.EditEmployee_Click);
            // 
            // DeleteEmployee
            // 
            this.DeleteEmployee.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DeleteEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.DeleteEmployee.ForeColor = System.Drawing.SystemColors.Window;
            this.DeleteEmployee.Location = new System.Drawing.Point(311, 536);
            this.DeleteEmployee.Name = "DeleteEmployee";
            this.DeleteEmployee.Size = new System.Drawing.Size(135, 69);
            this.DeleteEmployee.TabIndex = 2;
            this.DeleteEmployee.Text = "Verwijder";
            this.DeleteEmployee.UseVisualStyleBackColor = false;
            this.DeleteEmployee.Click += new System.EventHandler(this.DeleteEmployee_Click);
            // 
            // AddEmployee
            // 
            this.AddEmployee.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.AddEmployee.ForeColor = System.Drawing.SystemColors.Window;
            this.AddEmployee.Location = new System.Drawing.Point(12, 536);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(135, 69);
            this.AddEmployee.TabIndex = 1;
            this.AddEmployee.Text = "Voeg toe";
            this.AddEmployee.UseVisualStyleBackColor = false;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // ListView_Employees
            // 
            this.ListView_Employees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmployeeID,
            this.Naam,
            this.Gebruikersnaam,
            this.Wachtwoord,
            this.Type});
            this.ListView_Employees.FullRowSelect = true;
            this.ListView_Employees.GridLines = true;
            this.ListView_Employees.Location = new System.Drawing.Point(12, 10);
            this.ListView_Employees.Name = "ListView_Employees";
            this.ListView_Employees.Size = new System.Drawing.Size(437, 497);
            this.ListView_Employees.TabIndex = 0;
            this.ListView_Employees.UseCompatibleStateImageBehavior = false;
            this.ListView_Employees.View = System.Windows.Forms.View.Details;
            this.ListView_Employees.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListView_Employees_ItemSelectionChanged);
            // 
            // EmployeeID
            // 
            this.EmployeeID.Text = "ID";
            this.EmployeeID.Width = 0;
            // 
            // Naam
            // 
            this.Naam.Text = "Naam";
            this.Naam.Width = 120;
            // 
            // Gebruikersnaam
            // 
            this.Gebruikersnaam.Text = "Gebruikersnaam";
            this.Gebruikersnaam.Width = 107;
            // 
            // Wachtwoord
            // 
            this.Wachtwoord.Text = "Wachtwoord";
            this.Wachtwoord.Width = 111;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 75;
            // 
            // PNL_AddEmployee
            // 
            this.PNL_AddEmployee.Controls.Add(this.button3);
            this.PNL_AddEmployee.Controls.Add(this.DB_AddEmployeeType);
            this.PNL_AddEmployee.Controls.Add(this.label5);
            this.PNL_AddEmployee.Controls.Add(this.BTN_AddEmployee);
            this.PNL_AddEmployee.Controls.Add(this.label4);
            this.PNL_AddEmployee.Controls.Add(this.TXTB_AddEmployeeName);
            this.PNL_AddEmployee.Controls.Add(this.label3);
            this.PNL_AddEmployee.Controls.Add(this.TXTB_AddEmployeePassword);
            this.PNL_AddEmployee.Controls.Add(this.label2);
            this.PNL_AddEmployee.Controls.Add(this.TXTB_AddEmployeeUsername);
            this.PNL_AddEmployee.Controls.Add(this.label1);
            this.PNL_AddEmployee.Location = new System.Drawing.Point(0, 0);
            this.PNL_AddEmployee.Name = "PNL_AddEmployee";
            this.PNL_AddEmployee.Size = new System.Drawing.Size(465, 681);
            this.PNL_AddEmployee.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(0, 637);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 44);
            this.button3.TabIndex = 16;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DB_AddEmployeeType
            // 
            this.DB_AddEmployeeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_AddEmployeeType.FormattingEnabled = true;
            this.DB_AddEmployeeType.Items.AddRange(new object[] {
            "Serveerder",
            "Barman",
            "Kok",
            "Manager"});
            this.DB_AddEmployeeType.Location = new System.Drawing.Point(44, 411);
            this.DB_AddEmployeeType.Name = "DB_AddEmployeeType";
            this.DB_AddEmployeeType.Size = new System.Drawing.Size(383, 37);
            this.DB_AddEmployeeType.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(58, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(346, 37);
            this.label5.TabIndex = 14;
            this.label5.Text = "Medewerker toevoegen";
            // 
            // BTN_AddEmployee
            // 
            this.BTN_AddEmployee.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BTN_AddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_AddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AddEmployee.ForeColor = System.Drawing.SystemColors.Window;
            this.BTN_AddEmployee.Location = new System.Drawing.Point(41, 504);
            this.BTN_AddEmployee.Name = "BTN_AddEmployee";
            this.BTN_AddEmployee.Size = new System.Drawing.Size(386, 85);
            this.BTN_AddEmployee.TabIndex = 12;
            this.BTN_AddEmployee.Text = "Voeg toe";
            this.BTN_AddEmployee.UseVisualStyleBackColor = false;
            this.BTN_AddEmployee.Click += new System.EventHandler(this.BTN_AddEmployee_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(39, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Type:";
            // 
            // TXTB_AddEmployeeName
            // 
            this.TXTB_AddEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB_AddEmployeeName.Location = new System.Drawing.Point(41, 166);
            this.TXTB_AddEmployeeName.Name = "TXTB_AddEmployeeName";
            this.TXTB_AddEmployeeName.Size = new System.Drawing.Size(386, 35);
            this.TXTB_AddEmployeeName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(36, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Naam:";
            // 
            // TXTB_AddEmployeePassword
            // 
            this.TXTB_AddEmployeePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB_AddEmployeePassword.Location = new System.Drawing.Point(41, 327);
            this.TXTB_AddEmployeePassword.Name = "TXTB_AddEmployeePassword";
            this.TXTB_AddEmployeePassword.Size = new System.Drawing.Size(386, 35);
            this.TXTB_AddEmployeePassword.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(39, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wachtwoord:";
            // 
            // TXTB_AddEmployeeUsername
            // 
            this.TXTB_AddEmployeeUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB_AddEmployeeUsername.Location = new System.Drawing.Point(41, 247);
            this.TXTB_AddEmployeeUsername.Name = "TXTB_AddEmployeeUsername";
            this.TXTB_AddEmployeeUsername.Size = new System.Drawing.Size(386, 35);
            this.TXTB_AddEmployeeUsername.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(36, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gebruikersnaam:";
            // 
            // PNL_EditEmployee
            // 
            this.PNL_EditEmployee.Controls.Add(this.button1);
            this.PNL_EditEmployee.Controls.Add(this.DB_EditEmployeeType);
            this.PNL_EditEmployee.Controls.Add(this.label6);
            this.PNL_EditEmployee.Controls.Add(this.BTN_EditEmployee);
            this.PNL_EditEmployee.Controls.Add(this.label7);
            this.PNL_EditEmployee.Controls.Add(this.TXTB_EditEmployeeName);
            this.PNL_EditEmployee.Controls.Add(this.label45);
            this.PNL_EditEmployee.Controls.Add(this.TXTB_EditEmployeePassword);
            this.PNL_EditEmployee.Controls.Add(this.label9);
            this.PNL_EditEmployee.Controls.Add(this.TXTB_EditEmployeeUsername);
            this.PNL_EditEmployee.Controls.Add(this.label10);
            this.PNL_EditEmployee.Location = new System.Drawing.Point(0, 0);
            this.PNL_EditEmployee.Name = "PNL_EditEmployee";
            this.PNL_EditEmployee.Size = new System.Drawing.Size(465, 681);
            this.PNL_EditEmployee.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(0, 637);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 44);
            this.button1.TabIndex = 16;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DB_EditEmployeeType
            // 
            this.DB_EditEmployeeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_EditEmployeeType.FormattingEnabled = true;
            this.DB_EditEmployeeType.Items.AddRange(new object[] {
            "Serveerder",
            "Barman",
            "Kok",
            "Manager"});
            this.DB_EditEmployeeType.Location = new System.Drawing.Point(44, 397);
            this.DB_EditEmployeeType.Name = "DB_EditEmployeeType";
            this.DB_EditEmployeeType.Size = new System.Drawing.Size(383, 37);
            this.DB_EditEmployeeType.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(92, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 37);
            this.label6.TabIndex = 14;
            this.label6.Text = "Wijzig medewerker";
            // 
            // BTN_EditEmployee
            // 
            this.BTN_EditEmployee.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BTN_EditEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_EditEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EditEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EditEmployee.ForeColor = System.Drawing.SystemColors.Window;
            this.BTN_EditEmployee.Location = new System.Drawing.Point(41, 496);
            this.BTN_EditEmployee.Name = "BTN_EditEmployee";
            this.BTN_EditEmployee.Size = new System.Drawing.Size(386, 85);
            this.BTN_EditEmployee.TabIndex = 12;
            this.BTN_EditEmployee.Text = "Bewerk";
            this.BTN_EditEmployee.UseVisualStyleBackColor = false;
            this.BTN_EditEmployee.Click += new System.EventHandler(this.BTN_EditEmployee_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(39, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Type:";
            // 
            // TXTB_EditEmployeeName
            // 
            this.TXTB_EditEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB_EditEmployeeName.Location = new System.Drawing.Point(41, 152);
            this.TXTB_EditEmployeeName.Name = "TXTB_EditEmployeeName";
            this.TXTB_EditEmployeeName.Size = new System.Drawing.Size(386, 35);
            this.TXTB_EditEmployeeName.TabIndex = 9;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label45.Location = new System.Drawing.Point(36, 118);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(83, 29);
            this.label45.TabIndex = 8;
            this.label45.Text = "Naam:";
            // 
            // TXTB_EditEmployeePassword
            // 
            this.TXTB_EditEmployeePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB_EditEmployeePassword.Location = new System.Drawing.Point(41, 313);
            this.TXTB_EditEmployeePassword.Name = "TXTB_EditEmployeePassword";
            this.TXTB_EditEmployeePassword.Size = new System.Drawing.Size(386, 35);
            this.TXTB_EditEmployeePassword.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(39, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 29);
            this.label9.TabIndex = 6;
            this.label9.Text = "Wachtwoord:";
            // 
            // TXTB_EditEmployeeUsername
            // 
            this.TXTB_EditEmployeeUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB_EditEmployeeUsername.Location = new System.Drawing.Point(41, 233);
            this.TXTB_EditEmployeeUsername.Name = "TXTB_EditEmployeeUsername";
            this.TXTB_EditEmployeeUsername.Size = new System.Drawing.Size(386, 35);
            this.TXTB_EditEmployeeUsername.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(36, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 29);
            this.label10.TabIndex = 4;
            this.label10.Text = "Gebruikersnaam:";
            // 
            // EditEmployeesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(464, 681);
            this.Controls.Add(this.PNL_ManageEmployee);
            this.Controls.Add(this.PNL_AddEmployee);
            this.Controls.Add(this.PNL_EditEmployee);
            this.Name = "EditEmployeesUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage medewerkers";
            this.PNL_ManageEmployee.ResumeLayout(false);
            this.PNL_AddEmployee.ResumeLayout(false);
            this.PNL_AddEmployee.PerformLayout();
            this.PNL_EditEmployee.ResumeLayout(false);
            this.PNL_EditEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PNL_ManageEmployee;
        private System.Windows.Forms.ListView ListView_Employees;
        private System.Windows.Forms.ColumnHeader Naam;
        private System.Windows.Forms.ColumnHeader Gebruikersnaam;
        private System.Windows.Forms.ColumnHeader Wachtwoord;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button EditEmployee;
        private System.Windows.Forms.Button DeleteEmployee;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Panel PNL_AddEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTB_AddEmployeeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTB_AddEmployeePassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTB_AddEmployeeUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_AddEmployee;
        private System.Windows.Forms.ComboBox DB_AddEmployeeType;
        private System.Windows.Forms.Panel PNL_EditEmployee;
        private System.Windows.Forms.ComboBox DB_EditEmployeeType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_EditEmployee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXTB_EditEmployeeName;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox TXTB_EditEmployeePassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXTB_EditEmployeeUsername;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader EmployeeID;
    }
}
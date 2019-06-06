namespace OrderSystemUI.MainUI
{
    partial class EditStockUI
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
            this.PNL_ManageStock = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.EditItem = new System.Windows.Forms.Button();
            this.DeleteItem = new System.Windows.Forms.Button();
            this.AddItem = new System.Windows.Forms.Button();
            this.ListView_Stock = new System.Windows.Forms.ListView();
            this.ItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemTAX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PNL_AddItem = new System.Windows.Forms.Panel();
            this.TXTB_AddDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DB_AddTAX = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DB_AddType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.DB_AddCourse = new System.Windows.Forms.ComboBox();
            this.BTN_AddItem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTB_AddName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTB_AddPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTB_AddStock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PNL_EditItem = new System.Windows.Forms.Panel();
            this.TXTB_EditDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DB_EditTAX = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DB_EditType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DB_EditCourse = new System.Windows.Forms.ComboBox();
            this.BTN_EditItem = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.TXTB_EditName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TXTB_EditPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TXTB_EditStock = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.PNL_ManageStock.SuspendLayout();
            this.PNL_AddItem.SuspendLayout();
            this.PNL_EditItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_ManageStock
            // 
            this.PNL_ManageStock.Controls.Add(this.BackButton);
            this.PNL_ManageStock.Controls.Add(this.EditItem);
            this.PNL_ManageStock.Controls.Add(this.DeleteItem);
            this.PNL_ManageStock.Controls.Add(this.AddItem);
            this.PNL_ManageStock.Controls.Add(this.ListView_Stock);
            this.PNL_ManageStock.Location = new System.Drawing.Point(0, 0);
            this.PNL_ManageStock.Name = "PNL_ManageStock";
            this.PNL_ManageStock.Size = new System.Drawing.Size(465, 681);
            this.PNL_ManageStock.TabIndex = 17;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.Window;
            this.BackButton.Location = new System.Drawing.Point(12, 625);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(93, 44);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "<";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EditItem
            // 
            this.EditItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.EditItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.EditItem.ForeColor = System.Drawing.SystemColors.Window;
            this.EditItem.Location = new System.Drawing.Point(162, 532);
            this.EditItem.Name = "EditItem";
            this.EditItem.Size = new System.Drawing.Size(135, 69);
            this.EditItem.TabIndex = 3;
            this.EditItem.Text = "Bewerk";
            this.EditItem.UseVisualStyleBackColor = false;
            this.EditItem.Click += new System.EventHandler(this.EditItem_Click);
            // 
            // DeleteItem
            // 
            this.DeleteItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DeleteItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.DeleteItem.ForeColor = System.Drawing.SystemColors.Window;
            this.DeleteItem.Location = new System.Drawing.Point(311, 532);
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Size = new System.Drawing.Size(135, 69);
            this.DeleteItem.TabIndex = 2;
            this.DeleteItem.Text = "Verwijder";
            this.DeleteItem.UseVisualStyleBackColor = false;
            this.DeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // AddItem
            // 
            this.AddItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.AddItem.ForeColor = System.Drawing.SystemColors.Window;
            this.AddItem.Location = new System.Drawing.Point(12, 532);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(135, 69);
            this.AddItem.TabIndex = 1;
            this.AddItem.Text = "Voeg toe";
            this.AddItem.UseVisualStyleBackColor = false;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // ListView_Stock
            // 
            this.ListView_Stock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemID,
            this.ItemName,
            this.ItemStock,
            this.ItemPrice,
            this.ItemTAX});
            this.ListView_Stock.FullRowSelect = true;
            this.ListView_Stock.GridLines = true;
            this.ListView_Stock.Location = new System.Drawing.Point(12, 10);
            this.ListView_Stock.Name = "ListView_Stock";
            this.ListView_Stock.Size = new System.Drawing.Size(437, 494);
            this.ListView_Stock.TabIndex = 0;
            this.ListView_Stock.UseCompatibleStateImageBehavior = false;
            this.ListView_Stock.View = System.Windows.Forms.View.Details;
            this.ListView_Stock.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListView_Stock_ItemSelectionChanged);
            // 
            // ItemID
            // 
            this.ItemID.Text = "ID";
            this.ItemID.Width = 0;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Product naam";
            this.ItemName.Width = 241;
            // 
            // ItemStock
            // 
            this.ItemStock.Text = "Voorraad";
            this.ItemStock.Width = 57;
            // 
            // ItemPrice
            // 
            this.ItemPrice.Text = "Prijs";
            this.ItemPrice.Width = 75;
            // 
            // ItemTAX
            // 
            this.ItemTAX.Text = "BTW (%)";
            this.ItemTAX.Width = 55;
            // 
            // PNL_AddItem
            // 
            this.PNL_AddItem.Controls.Add(this.TXTB_AddDescription);
            this.PNL_AddItem.Controls.Add(this.label8);
            this.PNL_AddItem.Controls.Add(this.DB_AddTAX);
            this.PNL_AddItem.Controls.Add(this.label7);
            this.PNL_AddItem.Controls.Add(this.DB_AddType);
            this.PNL_AddItem.Controls.Add(this.label6);
            this.PNL_AddItem.Controls.Add(this.button3);
            this.PNL_AddItem.Controls.Add(this.DB_AddCourse);
            this.PNL_AddItem.Controls.Add(this.BTN_AddItem);
            this.PNL_AddItem.Controls.Add(this.label4);
            this.PNL_AddItem.Controls.Add(this.TXTB_AddName);
            this.PNL_AddItem.Controls.Add(this.label3);
            this.PNL_AddItem.Controls.Add(this.TXTB_AddPrice);
            this.PNL_AddItem.Controls.Add(this.label2);
            this.PNL_AddItem.Controls.Add(this.TXTB_AddStock);
            this.PNL_AddItem.Controls.Add(this.label1);
            this.PNL_AddItem.Location = new System.Drawing.Point(0, 0);
            this.PNL_AddItem.Name = "PNL_AddItem";
            this.PNL_AddItem.Size = new System.Drawing.Size(465, 681);
            this.PNL_AddItem.TabIndex = 18;
            // 
            // TXTB_AddDescription
            // 
            this.TXTB_AddDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB_AddDescription.Location = new System.Drawing.Point(41, 360);
            this.TXTB_AddDescription.Multiline = true;
            this.TXTB_AddDescription.Name = "TXTB_AddDescription";
            this.TXTB_AddDescription.Size = new System.Drawing.Size(386, 122);
            this.TXTB_AddDescription.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(36, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 29);
            this.label8.TabIndex = 21;
            this.label8.Text = "Beschrijving:";
            // 
            // DB_AddTAX
            // 
            this.DB_AddTAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_AddTAX.FormattingEnabled = true;
            this.DB_AddTAX.Items.AddRange(new object[] {
            "0%",
            "6%",
            "9%",
            "19%",
            "21%"});
            this.DB_AddTAX.Location = new System.Drawing.Point(160, 179);
            this.DB_AddTAX.Name = "DB_AddTAX";
            this.DB_AddTAX.Size = new System.Drawing.Size(267, 37);
            this.DB_AddTAX.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(36, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 29);
            this.label7.TabIndex = 19;
            this.label7.Text = "BTW:";
            // 
            // DB_AddType
            // 
            this.DB_AddType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_AddType.FormattingEnabled = true;
            this.DB_AddType.Items.AddRange(new object[] {
            "Bier",
            "Thee",
            "Koffie",
            "Drank",
            "Lunch",
            "Frisdrank",
            "Wijn",
            "Diner"});
            this.DB_AddType.Location = new System.Drawing.Point(160, 266);
            this.DB_AddType.Name = "DB_AddType";
            this.DB_AddType.Size = new System.Drawing.Size(267, 37);
            this.DB_AddType.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(36, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Type:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(12, 625);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 44);
            this.button3.TabIndex = 16;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DB_AddCourse
            // 
            this.DB_AddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_AddCourse.FormattingEnabled = true;
            this.DB_AddCourse.Items.AddRange(new object[] {
            "Voorgerecht",
            "Hoofdgerecht",
            "Bijgerecht",
            "Toetje",
            "Drankje"});
            this.DB_AddCourse.Location = new System.Drawing.Point(160, 223);
            this.DB_AddCourse.Name = "DB_AddCourse";
            this.DB_AddCourse.Size = new System.Drawing.Size(267, 37);
            this.DB_AddCourse.TabIndex = 15;
            // 
            // BTN_AddItem
            // 
            this.BTN_AddItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BTN_AddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_AddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AddItem.ForeColor = System.Drawing.SystemColors.Window;
            this.BTN_AddItem.Location = new System.Drawing.Point(41, 510);
            this.BTN_AddItem.Name = "BTN_AddItem";
            this.BTN_AddItem.Size = new System.Drawing.Size(386, 85);
            this.BTN_AddItem.TabIndex = 12;
            this.BTN_AddItem.Text = "Voeg toe";
            this.BTN_AddItem.UseVisualStyleBackColor = false;
            this.BTN_AddItem.Click += new System.EventHandler(this.BTN_AddItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(36, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gang:";
            // 
            // TXTB_AddName
            // 
            this.TXTB_AddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB_AddName.Location = new System.Drawing.Point(160, 56);
            this.TXTB_AddName.Name = "TXTB_AddName";
            this.TXTB_AddName.Size = new System.Drawing.Size(267, 35);
            this.TXTB_AddName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(36, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Naam:";
            // 
            // TXTB_AddPrice
            // 
            this.TXTB_AddPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB_AddPrice.Location = new System.Drawing.Point(160, 138);
            this.TXTB_AddPrice.Name = "TXTB_AddPrice";
            this.TXTB_AddPrice.Size = new System.Drawing.Size(267, 35);
            this.TXTB_AddPrice.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(36, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prijs:";
            // 
            // TXTB_AddStock
            // 
            this.TXTB_AddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB_AddStock.Location = new System.Drawing.Point(160, 97);
            this.TXTB_AddStock.Name = "TXTB_AddStock";
            this.TXTB_AddStock.Size = new System.Drawing.Size(267, 35);
            this.TXTB_AddStock.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(36, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Voorraad:";
            // 
            // PNL_EditItem
            // 
            this.PNL_EditItem.Controls.Add(this.TXTB_EditDescription);
            this.PNL_EditItem.Controls.Add(this.label5);
            this.PNL_EditItem.Controls.Add(this.DB_EditTAX);
            this.PNL_EditItem.Controls.Add(this.label9);
            this.PNL_EditItem.Controls.Add(this.DB_EditType);
            this.PNL_EditItem.Controls.Add(this.label10);
            this.PNL_EditItem.Controls.Add(this.button1);
            this.PNL_EditItem.Controls.Add(this.DB_EditCourse);
            this.PNL_EditItem.Controls.Add(this.BTN_EditItem);
            this.PNL_EditItem.Controls.Add(this.label11);
            this.PNL_EditItem.Controls.Add(this.TXTB_EditName);
            this.PNL_EditItem.Controls.Add(this.label12);
            this.PNL_EditItem.Controls.Add(this.TXTB_EditPrice);
            this.PNL_EditItem.Controls.Add(this.label13);
            this.PNL_EditItem.Controls.Add(this.TXTB_EditStock);
            this.PNL_EditItem.Controls.Add(this.label14);
            this.PNL_EditItem.Location = new System.Drawing.Point(0, 0);
            this.PNL_EditItem.Name = "PNL_EditItem";
            this.PNL_EditItem.Size = new System.Drawing.Size(465, 681);
            this.PNL_EditItem.TabIndex = 23;
            // 
            // TXTB_EditDescription
            // 
            this.TXTB_EditDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB_EditDescription.Location = new System.Drawing.Point(40, 360);
            this.TXTB_EditDescription.Multiline = true;
            this.TXTB_EditDescription.Name = "TXTB_EditDescription";
            this.TXTB_EditDescription.Size = new System.Drawing.Size(386, 122);
            this.TXTB_EditDescription.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(35, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Beschrijving:";
            // 
            // DB_EditTAX
            // 
            this.DB_EditTAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_EditTAX.FormattingEnabled = true;
            this.DB_EditTAX.Items.AddRange(new object[] {
            "0%",
            "6%",
            "9%",
            "19%",
            "21%"});
            this.DB_EditTAX.Location = new System.Drawing.Point(160, 179);
            this.DB_EditTAX.Name = "DB_EditTAX";
            this.DB_EditTAX.Size = new System.Drawing.Size(266, 37);
            this.DB_EditTAX.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(35, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 29);
            this.label9.TabIndex = 19;
            this.label9.Text = "BTW:";
            // 
            // DB_EditType
            // 
            this.DB_EditType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_EditType.FormattingEnabled = true;
            this.DB_EditType.Items.AddRange(new object[] {
            "Beer",
            "Tea",
            "Coffee",
            "Liquor",
            "Lunch",
            "Softdrink",
            "Wine",
            "Dinner"});
            this.DB_EditType.Location = new System.Drawing.Point(160, 266);
            this.DB_EditType.Name = "DB_EditType";
            this.DB_EditType.Size = new System.Drawing.Size(266, 37);
            this.DB_EditType.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(35, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 29);
            this.label10.TabIndex = 17;
            this.label10.Text = "Type:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(12, 625);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 44);
            this.button1.TabIndex = 16;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DB_EditCourse
            // 
            this.DB_EditCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_EditCourse.FormattingEnabled = true;
            this.DB_EditCourse.Items.AddRange(new object[] {
            "Voorgerecht",
            "Hoofdgerecht",
            "Bijgerecht",
            "Toetje",
            "Drankje"});
            this.DB_EditCourse.Location = new System.Drawing.Point(160, 223);
            this.DB_EditCourse.Name = "DB_EditCourse";
            this.DB_EditCourse.Size = new System.Drawing.Size(266, 37);
            this.DB_EditCourse.TabIndex = 15;
            // 
            // BTN_EditItem
            // 
            this.BTN_EditItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BTN_EditItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_EditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EditItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EditItem.ForeColor = System.Drawing.SystemColors.Window;
            this.BTN_EditItem.Location = new System.Drawing.Point(40, 516);
            this.BTN_EditItem.Name = "BTN_EditItem";
            this.BTN_EditItem.Size = new System.Drawing.Size(386, 85);
            this.BTN_EditItem.TabIndex = 12;
            this.BTN_EditItem.Text = "Bewerken";
            this.BTN_EditItem.UseVisualStyleBackColor = false;
            this.BTN_EditItem.Click += new System.EventHandler(this.BTN_EditItem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(35, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 29);
            this.label11.TabIndex = 10;
            this.label11.Text = "Gang:";
            // 
            // TXTB_EditName
            // 
            this.TXTB_EditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB_EditName.Location = new System.Drawing.Point(160, 56);
            this.TXTB_EditName.Name = "TXTB_EditName";
            this.TXTB_EditName.Size = new System.Drawing.Size(266, 35);
            this.TXTB_EditName.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(35, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 29);
            this.label12.TabIndex = 8;
            this.label12.Text = "Naam:";
            // 
            // TXTB_EditPrice
            // 
            this.TXTB_EditPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB_EditPrice.Location = new System.Drawing.Point(160, 138);
            this.TXTB_EditPrice.Name = "TXTB_EditPrice";
            this.TXTB_EditPrice.Size = new System.Drawing.Size(266, 35);
            this.TXTB_EditPrice.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(35, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 29);
            this.label13.TabIndex = 6;
            this.label13.Text = "Prijs:";
            // 
            // TXTB_EditStock
            // 
            this.TXTB_EditStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB_EditStock.Location = new System.Drawing.Point(160, 97);
            this.TXTB_EditStock.Name = "TXTB_EditStock";
            this.TXTB_EditStock.Size = new System.Drawing.Size(266, 35);
            this.TXTB_EditStock.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(35, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 29);
            this.label14.TabIndex = 4;
            this.label14.Text = "Voorraad: ";
            // 
            // EditStockUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 681);
            this.Controls.Add(this.PNL_ManageStock);
            this.Controls.Add(this.PNL_AddItem);
            this.Controls.Add(this.PNL_EditItem);
            this.Name = "EditStockUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voorraden";
            this.PNL_ManageStock.ResumeLayout(false);
            this.PNL_AddItem.ResumeLayout(false);
            this.PNL_AddItem.PerformLayout();
            this.PNL_EditItem.ResumeLayout(false);
            this.PNL_EditItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_ManageStock;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button EditItem;
        private System.Windows.Forms.Button DeleteItem;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.ListView ListView_Stock;
        private System.Windows.Forms.ColumnHeader ItemID;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader ItemStock;
        private System.Windows.Forms.ColumnHeader ItemPrice;
        private System.Windows.Forms.ColumnHeader ItemTAX;
        private System.Windows.Forms.Panel PNL_AddItem;
        private System.Windows.Forms.TextBox TXTB_AddDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox DB_AddTAX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox DB_AddType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox DB_AddCourse;
        private System.Windows.Forms.Button BTN_AddItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTB_AddName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTB_AddPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTB_AddStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PNL_EditItem;
        private System.Windows.Forms.TextBox TXTB_EditDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DB_EditTAX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox DB_EditType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox DB_EditCourse;
        private System.Windows.Forms.Button BTN_EditItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TXTB_EditName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TXTB_EditPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TXTB_EditStock;
        private System.Windows.Forms.Label label14;
    }
}
namespace OrderSystemUI.MainUI {
    partial class OrderHomeUI {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderHomeUI));
            this.btnFree = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTaken = new System.Windows.Forms.Button();
            this.btnReserved = new System.Windows.Forms.Button();
            this.Btn_BeverageMenu = new System.Windows.Forms.Button();
            this.btn_OrderOverview = new System.Windows.Forms.Button();
            this.btn_LunchMenu = new System.Windows.Forms.Button();
            this.btn_DinnerMenu = new System.Windows.Forms.Button();
            this.tableNumber = new System.Windows.Forms.Label();
            this.btn_Checkout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFree
            // 
            this.btnFree.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFree.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btnFree.FlatAppearance.BorderSize = 0;
            this.btnFree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFree.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFree.Location = new System.Drawing.Point(77, 74);
            this.btnFree.Margin = new System.Windows.Forms.Padding(4);
            this.btnFree.Name = "btnFree";
            this.btnFree.Size = new System.Drawing.Size(152, 43);
            this.btnFree.TabIndex = 0;
            this.btnFree.Text = "Vrij";
            this.btnFree.UseVisualStyleBackColor = false;
            this.btnFree.Click += new System.EventHandler(this.btnFree_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(0, 774);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(145, 65);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTaken
            // 
            this.btnTaken.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTaken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaken.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btnTaken.FlatAppearance.BorderSize = 0;
            this.btnTaken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaken.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaken.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTaken.Location = new System.Drawing.Point(237, 74);
            this.btnTaken.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaken.Name = "btnTaken";
            this.btnTaken.Size = new System.Drawing.Size(152, 43);
            this.btnTaken.TabIndex = 4;
            this.btnTaken.Text = "Bezet";
            this.btnTaken.UseVisualStyleBackColor = false;
            this.btnTaken.Click += new System.EventHandler(this.btnTaken_Click);
            // 
            // btnReserved
            // 
            this.btnReserved.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnReserved.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReserved.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btnReserved.FlatAppearance.BorderSize = 0;
            this.btnReserved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserved.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserved.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReserved.Location = new System.Drawing.Point(397, 74);
            this.btnReserved.Margin = new System.Windows.Forms.Padding(4);
            this.btnReserved.Name = "btnReserved";
            this.btnReserved.Size = new System.Drawing.Size(152, 43);
            this.btnReserved.TabIndex = 5;
            this.btnReserved.Text = "Gereserveerd";
            this.btnReserved.UseVisualStyleBackColor = false;
            this.btnReserved.Click += new System.EventHandler(this.btnReserved_Click_1);
            // 
            // Btn_BeverageMenu
            // 
            this.Btn_BeverageMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_BeverageMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_BeverageMenu.FlatAppearance.BorderSize = 0;
            this.Btn_BeverageMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BeverageMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BeverageMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_BeverageMenu.Image = ((System.Drawing.Image)(resources.GetObject("Btn_BeverageMenu.Image")));
            this.Btn_BeverageMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_BeverageMenu.Location = new System.Drawing.Point(93, 148);
            this.Btn_BeverageMenu.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_BeverageMenu.Name = "Btn_BeverageMenu";
            this.Btn_BeverageMenu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.Btn_BeverageMenu.Size = new System.Drawing.Size(200, 185);
            this.Btn_BeverageMenu.TabIndex = 6;
            this.Btn_BeverageMenu.Text = "Beverages";
            this.Btn_BeverageMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_BeverageMenu.UseVisualStyleBackColor = false;
            this.Btn_BeverageMenu.Click += new System.EventHandler(this.Btn_BeverageMenu_Click);
            // 
            // btn_OrderOverview
            // 
            this.btn_OrderOverview.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_OrderOverview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OrderOverview.FlatAppearance.BorderSize = 0;
            this.btn_OrderOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OrderOverview.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OrderOverview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_OrderOverview.Image = ((System.Drawing.Image)(resources.GetObject("btn_OrderOverview.Image")));
            this.btn_OrderOverview.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_OrderOverview.Location = new System.Drawing.Point(320, 148);
            this.btn_OrderOverview.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OrderOverview.Name = "btn_OrderOverview";
            this.btn_OrderOverview.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.btn_OrderOverview.Size = new System.Drawing.Size(200, 185);
            this.btn_OrderOverview.TabIndex = 7;
            this.btn_OrderOverview.Text = "Order overview";
            this.btn_OrderOverview.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_OrderOverview.UseVisualStyleBackColor = false;
            this.btn_OrderOverview.Click += new System.EventHandler(this.btn_OrderOverview_Click);
            // 
            // btn_LunchMenu
            // 
            this.btn_LunchMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_LunchMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LunchMenu.FlatAppearance.BorderSize = 0;
            this.btn_LunchMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LunchMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LunchMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_LunchMenu.Image = ((System.Drawing.Image)(resources.GetObject("btn_LunchMenu.Image")));
            this.btn_LunchMenu.Location = new System.Drawing.Point(93, 357);
            this.btn_LunchMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LunchMenu.Name = "btn_LunchMenu";
            this.btn_LunchMenu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.btn_LunchMenu.Size = new System.Drawing.Size(200, 185);
            this.btn_LunchMenu.TabIndex = 8;
            this.btn_LunchMenu.Text = "Lunch";
            this.btn_LunchMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_LunchMenu.UseVisualStyleBackColor = false;
            this.btn_LunchMenu.Click += new System.EventHandler(this.btn_LunchMenu_Click);
            // 
            // btn_DinnerMenu
            // 
            this.btn_DinnerMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_DinnerMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DinnerMenu.FlatAppearance.BorderSize = 0;
            this.btn_DinnerMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DinnerMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DinnerMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DinnerMenu.Image = ((System.Drawing.Image)(resources.GetObject("btn_DinnerMenu.Image")));
            this.btn_DinnerMenu.Location = new System.Drawing.Point(320, 356);
            this.btn_DinnerMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DinnerMenu.Name = "btn_DinnerMenu";
            this.btn_DinnerMenu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.btn_DinnerMenu.Size = new System.Drawing.Size(200, 185);
            this.btn_DinnerMenu.TabIndex = 9;
            this.btn_DinnerMenu.Text = "Dinner";
            this.btn_DinnerMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_DinnerMenu.UseVisualStyleBackColor = false;
            this.btn_DinnerMenu.Click += new System.EventHandler(this.btn_DinnerMenu_Click);
            // 
            // tableNumber
            // 
            this.tableNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNumber.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tableNumber.Location = new System.Drawing.Point(219, 32);
            this.tableNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tableNumber.Name = "tableNumber";
            this.tableNumber.Size = new System.Drawing.Size(189, 38);
            this.tableNumber.TabIndex = 10;
            this.tableNumber.Text = "Table X";
            this.tableNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Checkout
            // 
            this.btn_Checkout.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Checkout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Checkout.FlatAppearance.BorderSize = 0;
            this.btn_Checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Checkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Checkout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Checkout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Checkout.Image")));
            this.btn_Checkout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Checkout.Location = new System.Drawing.Point(207, 567);
            this.btn_Checkout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Checkout.Name = "btn_Checkout";
            this.btn_Checkout.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.btn_Checkout.Size = new System.Drawing.Size(200, 185);
            this.btn_Checkout.TabIndex = 14;
            this.btn_Checkout.Text = "Betalen";
            this.btn_Checkout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Checkout.UseVisualStyleBackColor = false;
            this.btn_Checkout.Click += new System.EventHandler(this.btn_Checkout_Click);
            // 
            // OrderHomeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(619, 838);
            this.Controls.Add(this.btn_Checkout);
            this.Controls.Add(this.tableNumber);
            this.Controls.Add(this.btn_DinnerMenu);
            this.Controls.Add(this.btn_LunchMenu);
            this.Controls.Add(this.btn_OrderOverview);
            this.Controls.Add(this.Btn_BeverageMenu);
            this.Controls.Add(this.btnReserved);
            this.Controls.Add(this.btnTaken);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFree);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderHomeUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFree;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTaken;
        private System.Windows.Forms.Button btnReserved;
        private System.Windows.Forms.Button Btn_BeverageMenu;
        private System.Windows.Forms.Button btn_OrderOverview;
        private System.Windows.Forms.Button btn_LunchMenu;
        private System.Windows.Forms.Button btn_DinnerMenu;
        private System.Windows.Forms.Label tableNumber;
        private System.Windows.Forms.Button btn_Checkout;
    }
}
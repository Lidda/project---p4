namespace OrderSystemUI.MainUI
{
    partial class OrderLunchUI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.btnBack = new System.Windows.Forms.Button();
            this.lbl_DessertHeader = new System.Windows.Forms.Label();
            this.lbl_MainCourseHeader = new System.Windows.Forms.Label();
            this.lbl_StartersHeader = new System.Windows.Forms.Label();
            this.btn_ConfirmOrder = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lView_Desserts = new System.Windows.Forms.ListView();
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lView_MainCourses = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lView_Starters = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // lbl_DessertHeader
            // 
            this.lbl_DessertHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DessertHeader.BackColor = System.Drawing.Color.Silver;
            this.lbl_DessertHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_DessertHeader.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DessertHeader.Location = new System.Drawing.Point(26, 386);
            this.lbl_DessertHeader.Name = "lbl_DessertHeader";
            this.lbl_DessertHeader.Size = new System.Drawing.Size(411, 37);
            this.lbl_DessertHeader.TabIndex = 11;
            this.lbl_DessertHeader.Text = "Desserts";
            this.lbl_DessertHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_DessertHeader.UseWaitCursor = true;
            // 
            // lbl_MainCourseHeader
            // 
            this.lbl_MainCourseHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_MainCourseHeader.BackColor = System.Drawing.Color.Silver;
            this.lbl_MainCourseHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_MainCourseHeader.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MainCourseHeader.Location = new System.Drawing.Point(26, 211);
            this.lbl_MainCourseHeader.Name = "lbl_MainCourseHeader";
            this.lbl_MainCourseHeader.Size = new System.Drawing.Size(411, 37);
            this.lbl_MainCourseHeader.TabIndex = 24;
            this.lbl_MainCourseHeader.Text = "Main Course";
            this.lbl_MainCourseHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_MainCourseHeader.UseWaitCursor = true;
            // 
            // lbl_StartersHeader
            // 
            this.lbl_StartersHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_StartersHeader.BackColor = System.Drawing.Color.Silver;
            this.lbl_StartersHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_StartersHeader.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StartersHeader.Location = new System.Drawing.Point(26, 36);
            this.lbl_StartersHeader.Name = "lbl_StartersHeader";
            this.lbl_StartersHeader.Size = new System.Drawing.Size(411, 37);
            this.lbl_StartersHeader.TabIndex = 37;
            this.lbl_StartersHeader.Text = "Starters";
            this.lbl_StartersHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_StartersHeader.UseWaitCursor = true;
            // 
            // btn_ConfirmOrder
            // 
            this.btn_ConfirmOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ConfirmOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ConfirmOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConfirmOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfirmOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ConfirmOrder.Location = new System.Drawing.Point(357, 632);
            this.btn_ConfirmOrder.Name = "btn_ConfirmOrder";
            this.btn_ConfirmOrder.Size = new System.Drawing.Size(95, 37);
            this.btn_ConfirmOrder.TabIndex = 50;
            this.btn_ConfirmOrder.Text = "Confirm";
            this.btn_ConfirmOrder.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lView_Desserts
            // 
            this.lView_Desserts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.Quantity});
            this.lView_Desserts.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lView_Desserts.FullRowSelect = true;
            this.lView_Desserts.GridLines = true;
            this.lView_Desserts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lView_Desserts.HideSelection = false;
            this.lView_Desserts.Location = new System.Drawing.Point(26, 423);
            this.lView_Desserts.Name = "lView_Desserts";
            this.lView_Desserts.Size = new System.Drawing.Size(411, 103);
            this.lView_Desserts.TabIndex = 51;
            this.lView_Desserts.UseCompatibleStateImageBehavior = false;
            this.lView_Desserts.View = System.Windows.Forms.View.Details;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Name";
            this.ItemName.Width = 372;
            // 
            // Quantity
            // 
            this.Quantity.Text = "#";
            this.Quantity.Width = 30;
            // 
            // lView_MainCourses
            // 
            this.lView_MainCourses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lView_MainCourses.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lView_MainCourses.FullRowSelect = true;
            this.lView_MainCourses.GridLines = true;
            this.lView_MainCourses.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lView_MainCourses.HideSelection = false;
            this.lView_MainCourses.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.lView_MainCourses.Location = new System.Drawing.Point(26, 248);
            this.lView_MainCourses.Name = "lView_MainCourses";
            this.lView_MainCourses.Size = new System.Drawing.Size(411, 103);
            this.lView_MainCourses.TabIndex = 52;
            this.lView_MainCourses.UseCompatibleStateImageBehavior = false;
            this.lView_MainCourses.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 373;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "#";
            this.columnHeader2.Width = 30;
            // 
            // lView_Starters
            // 
            this.lView_Starters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lView_Starters.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lView_Starters.FullRowSelect = true;
            this.lView_Starters.GridLines = true;
            this.lView_Starters.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lView_Starters.HideSelection = false;
            this.lView_Starters.Location = new System.Drawing.Point(26, 73);
            this.lView_Starters.Name = "lView_Starters";
            this.lView_Starters.Size = new System.Drawing.Size(411, 103);
            this.lView_Starters.TabIndex = 53;
            this.lView_Starters.UseCompatibleStateImageBehavior = false;
            this.lView_Starters.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 372;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "#";
            this.columnHeader4.Width = 30;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(131, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 54;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 560);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 55;
            this.button2.Text = "comment";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(271, 560);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 56;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // OrderLunchUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 681);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lView_Starters);
            this.Controls.Add(this.lView_MainCourses);
            this.Controls.Add(this.lView_Desserts);
            this.Controls.Add(this.btn_ConfirmOrder);
            this.Controls.Add(this.lbl_StartersHeader);
            this.Controls.Add(this.lbl_MainCourseHeader);
            this.Controls.Add(this.lbl_DessertHeader);
            this.Controls.Add(this.btnBack);
            this.Name = "OrderLunchUI";
            this.Text = "Lunch menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbl_DessertHeader;
        private System.Windows.Forms.Label lbl_MainCourseHeader;
        private System.Windows.Forms.Label lbl_StartersHeader;
        private System.Windows.Forms.Button btn_ConfirmOrder;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView lView_Desserts;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ListView lView_MainCourses;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lView_Starters;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
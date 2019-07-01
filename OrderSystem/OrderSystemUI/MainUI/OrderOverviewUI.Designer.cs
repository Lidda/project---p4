namespace OrderSystemUI.MainUI
{
    partial class OrderOverviewUI
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
            this.listView_Overview = new System.Windows.Forms.ListView();
            this.itemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_EditItem = new System.Windows.Forms.Button();
            this.btn_DeleteItem = new System.Windows.Forms.Button();
            this.pnl_EditItem = new System.Windows.Forms.Panel();
            this.btn_SubtractAmount = new System.Windows.Forms.Button();
            this.btn_AddAmount = new System.Windows.Forms.Button();
            this.btn_CancelEdit = new System.Windows.Forms.Button();
            this.btn_ConfirmEdit = new System.Windows.Forms.Button();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.lbl_DisplayItemName = new System.Windows.Forms.Label();
            this.txt_Comment = new System.Windows.Forms.TextBox();
            this.lbl_ItemComment = new System.Windows.Forms.Label();
            this.lbl_ItemAmount = new System.Windows.Forms.Label();
            this.lbl_ItemName = new System.Windows.Forms.Label();
            this.btn_Home = new System.Windows.Forms.Button();
            this.pnl_EditItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_Overview
            // 
            this.listView_Overview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemName,
            this.itemAmount,
            this.itemPrice,
            this.itemStatus,
            this.itemID,
            this.itemComment});
            this.listView_Overview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Overview.FullRowSelect = true;
            this.listView_Overview.GridLines = true;
            this.listView_Overview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_Overview.HideSelection = false;
            this.listView_Overview.Location = new System.Drawing.Point(14, 12);
            this.listView_Overview.MultiSelect = false;
            this.listView_Overview.Name = "listView_Overview";
            this.listView_Overview.Size = new System.Drawing.Size(437, 484);
            this.listView_Overview.TabIndex = 1;
            this.listView_Overview.UseCompatibleStateImageBehavior = false;
            this.listView_Overview.View = System.Windows.Forms.View.Details;
            // 
            // itemName
            // 
            this.itemName.Text = "Product naam";
            this.itemName.Width = 299;
            // 
            // itemAmount
            // 
            this.itemAmount.Text = "#";
            this.itemAmount.Width = 40;
            // 
            // itemPrice
            // 
            this.itemPrice.Text = "€";
            this.itemPrice.Width = 55;
            // 
            // itemStatus
            // 
            this.itemStatus.Text = "S";
            this.itemStatus.Width = 40;
            // 
            // itemID
            // 
            this.itemID.Text = "ID";
            this.itemID.Width = 0;
            // 
            // itemComment
            // 
            this.itemComment.Text = "";
            this.itemComment.Width = 0;
            // 
            // btn_EditItem
            // 
            this.btn_EditItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_EditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditItem.ForeColor = System.Drawing.Color.White;
            this.btn_EditItem.Location = new System.Drawing.Point(35, 513);
            this.btn_EditItem.Name = "btn_EditItem";
            this.btn_EditItem.Size = new System.Drawing.Size(141, 51);
            this.btn_EditItem.TabIndex = 2;
            this.btn_EditItem.Text = "EDIT ITEM";
            this.btn_EditItem.UseVisualStyleBackColor = false;
            this.btn_EditItem.Click += new System.EventHandler(this.btn_EditItem_Click);
            // 
            // btn_DeleteItem
            // 
            this.btn_DeleteItem.BackColor = System.Drawing.Color.Red;
            this.btn_DeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteItem.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteItem.Location = new System.Drawing.Point(283, 513);
            this.btn_DeleteItem.Name = "btn_DeleteItem";
            this.btn_DeleteItem.Size = new System.Drawing.Size(132, 51);
            this.btn_DeleteItem.TabIndex = 3;
            this.btn_DeleteItem.Text = "VERWIJDER ITEM";
            this.btn_DeleteItem.UseVisualStyleBackColor = false;
            this.btn_DeleteItem.Click += new System.EventHandler(this.btn_DeleteItem_Click);
            // 
            // pnl_EditItem
            // 
            this.pnl_EditItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_EditItem.Controls.Add(this.btn_SubtractAmount);
            this.pnl_EditItem.Controls.Add(this.btn_AddAmount);
            this.pnl_EditItem.Controls.Add(this.btn_CancelEdit);
            this.pnl_EditItem.Controls.Add(this.btn_ConfirmEdit);
            this.pnl_EditItem.Controls.Add(this.txt_Amount);
            this.pnl_EditItem.Controls.Add(this.lbl_DisplayItemName);
            this.pnl_EditItem.Controls.Add(this.txt_Comment);
            this.pnl_EditItem.Controls.Add(this.lbl_ItemComment);
            this.pnl_EditItem.Controls.Add(this.lbl_ItemAmount);
            this.pnl_EditItem.Controls.Add(this.lbl_ItemName);
            this.pnl_EditItem.Location = new System.Drawing.Point(14, 12);
            this.pnl_EditItem.Name = "pnl_EditItem";
            this.pnl_EditItem.Size = new System.Drawing.Size(437, 552);
            this.pnl_EditItem.TabIndex = 4;
            this.pnl_EditItem.Visible = false;
            // 
            // btn_SubtractAmount
            // 
            this.btn_SubtractAmount.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_SubtractAmount.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_SubtractAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SubtractAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SubtractAmount.Location = new System.Drawing.Point(189, 146);
            this.btn_SubtractAmount.Name = "btn_SubtractAmount";
            this.btn_SubtractAmount.Size = new System.Drawing.Size(33, 33);
            this.btn_SubtractAmount.TabIndex = 33;
            this.btn_SubtractAmount.Text = "-";
            this.btn_SubtractAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_SubtractAmount.UseVisualStyleBackColor = false;
            this.btn_SubtractAmount.Click += new System.EventHandler(this.btn_SubtractAmount_Click);
            // 
            // btn_AddAmount
            // 
            this.btn_AddAmount.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_AddAmount.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_AddAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddAmount.Location = new System.Drawing.Point(150, 146);
            this.btn_AddAmount.Name = "btn_AddAmount";
            this.btn_AddAmount.Size = new System.Drawing.Size(33, 33);
            this.btn_AddAmount.TabIndex = 32;
            this.btn_AddAmount.Text = "+";
            this.btn_AddAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_AddAmount.UseVisualStyleBackColor = false;
            this.btn_AddAmount.Click += new System.EventHandler(this.btn_AddAmount_Click);
            // 
            // btn_CancelEdit
            // 
            this.btn_CancelEdit.BackColor = System.Drawing.Color.Red;
            this.btn_CancelEdit.FlatAppearance.BorderSize = 0;
            this.btn_CancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelEdit.ForeColor = System.Drawing.Color.White;
            this.btn_CancelEdit.Location = new System.Drawing.Point(243, 437);
            this.btn_CancelEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CancelEdit.Name = "btn_CancelEdit";
            this.btn_CancelEdit.Size = new System.Drawing.Size(143, 59);
            this.btn_CancelEdit.TabIndex = 31;
            this.btn_CancelEdit.Text = "ANNULEER";
            this.btn_CancelEdit.UseVisualStyleBackColor = false;
            this.btn_CancelEdit.Click += new System.EventHandler(this.btn_CancelEdit_Click);
            // 
            // btn_ConfirmEdit
            // 
            this.btn_ConfirmEdit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_ConfirmEdit.FlatAppearance.BorderSize = 0;
            this.btn_ConfirmEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConfirmEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfirmEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ConfirmEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ConfirmEdit.Location = new System.Drawing.Point(52, 437);
            this.btn_ConfirmEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ConfirmEdit.Name = "btn_ConfirmEdit";
            this.btn_ConfirmEdit.Size = new System.Drawing.Size(143, 59);
            this.btn_ConfirmEdit.TabIndex = 30;
            this.btn_ConfirmEdit.Text = "BEVESTIG";
            this.btn_ConfirmEdit.UseVisualStyleBackColor = false;
            this.btn_ConfirmEdit.Click += new System.EventHandler(this.btn_ConfirmEdit_Click);
            // 
            // txt_Amount
            // 
            this.txt_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Amount.Location = new System.Drawing.Point(80, 148);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.ReadOnly = true;
            this.txt_Amount.Size = new System.Drawing.Size(44, 26);
            this.txt_Amount.TabIndex = 5;
            // 
            // lbl_DisplayItemName
            // 
            this.lbl_DisplayItemName.AutoSize = true;
            this.lbl_DisplayItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DisplayItemName.Location = new System.Drawing.Point(105, 95);
            this.lbl_DisplayItemName.Name = "lbl_DisplayItemName";
            this.lbl_DisplayItemName.Size = new System.Drawing.Size(0, 20);
            this.lbl_DisplayItemName.TabIndex = 4;
            // 
            // txt_Comment
            // 
            this.txt_Comment.Location = new System.Drawing.Point(22, 236);
            this.txt_Comment.Multiline = true;
            this.txt_Comment.Name = "txt_Comment";
            this.txt_Comment.Size = new System.Drawing.Size(395, 148);
            this.txt_Comment.TabIndex = 3;
            // 
            // lbl_ItemComment
            // 
            this.lbl_ItemComment.AutoSize = true;
            this.lbl_ItemComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemComment.Location = new System.Drawing.Point(19, 213);
            this.lbl_ItemComment.Name = "lbl_ItemComment";
            this.lbl_ItemComment.Size = new System.Drawing.Size(105, 20);
            this.lbl_ItemComment.TabIndex = 2;
            this.lbl_ItemComment.Text = "Commentaar:";
            // 
            // lbl_ItemAmount
            // 
            this.lbl_ItemAmount.AutoSize = true;
            this.lbl_ItemAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemAmount.Location = new System.Drawing.Point(18, 148);
            this.lbl_ItemAmount.Name = "lbl_ItemAmount";
            this.lbl_ItemAmount.Size = new System.Drawing.Size(59, 20);
            this.lbl_ItemAmount.TabIndex = 1;
            this.lbl_ItemAmount.Text = "Aantal:";
            // 
            // lbl_ItemName
            // 
            this.lbl_ItemName.AutoSize = true;
            this.lbl_ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemName.Location = new System.Drawing.Point(18, 95);
            this.lbl_ItemName.Name = "lbl_ItemName";
            this.lbl_ItemName.Size = new System.Drawing.Size(71, 20);
            this.lbl_ItemName.TabIndex = 0;
            this.lbl_ItemName.Text = "Gerecht:";
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Home.Location = new System.Drawing.Point(-4, 638);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(107, 43);
            this.btn_Home.TabIndex = 5;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // OrderOverviewUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 681);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.pnl_EditItem);
            this.Controls.Add(this.btn_DeleteItem);
            this.Controls.Add(this.btn_EditItem);
            this.Controls.Add(this.listView_Overview);
            this.Name = "OrderOverviewUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderOverview";
            this.pnl_EditItem.ResumeLayout(false);
            this.pnl_EditItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Overview;
        private System.Windows.Forms.ColumnHeader itemName;
        private System.Windows.Forms.ColumnHeader itemAmount;
        private System.Windows.Forms.ColumnHeader itemPrice;
        private System.Windows.Forms.Button btn_EditItem;
        private System.Windows.Forms.Button btn_DeleteItem;
        private System.Windows.Forms.Panel pnl_EditItem;
        private System.Windows.Forms.TextBox txt_Comment;
        private System.Windows.Forms.Label lbl_ItemComment;
        private System.Windows.Forms.Label lbl_ItemAmount;
        private System.Windows.Forms.Label lbl_ItemName;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label lbl_DisplayItemName;
        private System.Windows.Forms.Button btn_CancelEdit;
        private System.Windows.Forms.Button btn_ConfirmEdit;
        private System.Windows.Forms.ColumnHeader itemStatus;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_AddAmount;
        private System.Windows.Forms.Button btn_SubtractAmount;
        private System.Windows.Forms.ColumnHeader itemID;
        private System.Windows.Forms.ColumnHeader itemComment;
    }
}
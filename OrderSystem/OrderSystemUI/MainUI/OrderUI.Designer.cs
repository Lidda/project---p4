﻿namespace OrderSystemUI.MainUI
{
    partial class OrderUI
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lbl_DessertHeader = new System.Windows.Forms.Label();
            this.lbl_MainCourseHeader = new System.Windows.Forms.Label();
            this.lbl_StartersHeader = new System.Windows.Forms.Label();
            this.btn_OrderOverview = new System.Windows.Forms.Button();
            this.listView_Starters = new System.Windows.Forms.ListView();
            this.nameStartersLunch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityStartersLunch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceStartersLunch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stockStartersLunch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.commentStartersLunch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_AddStarter = new System.Windows.Forms.Button();
            this.btn_CommentStarter = new System.Windows.Forms.Button();
            this.btn_SubtractStarter = new System.Windows.Forms.Button();
            this.btn_SubtractMainCourse = new System.Windows.Forms.Button();
            this.btn_CommentMainCourse = new System.Windows.Forms.Button();
            this.btn_AddMainCourse = new System.Windows.Forms.Button();
            this.btn_SubtractDessert = new System.Windows.Forms.Button();
            this.btn_CommentDessert = new System.Windows.Forms.Button();
            this.btn_AddDessert = new System.Windows.Forms.Button();
            this.listView_MainCourses = new System.Windows.Forms.ListView();
            this.nameMainCoursesLunch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityMainCoursesLunch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceMainCoursesLunch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stockMainCoursesLunch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.commentMainCoursesLunch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Desserts = new System.Windows.Forms.ListView();
            this.nameDessertsLunch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityDessertsLunch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceDessertsLunch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stockDessertsLunch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.commentDessertLunch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_Comment = new System.Windows.Forms.Panel();
            this.btn_CancelComment = new System.Windows.Forms.Button();
            this.btn_AddCommentToItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_AddCommentToItem = new System.Windows.Forms.TextBox();
            this.pnl_Comment.SuspendLayout();
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
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbl_DessertHeader
            // 
            this.lbl_DessertHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DessertHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_DessertHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_DessertHeader.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DessertHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.lbl_MainCourseHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_MainCourseHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_MainCourseHeader.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MainCourseHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_MainCourseHeader.Location = new System.Drawing.Point(26, 211);
            this.lbl_MainCourseHeader.Name = "lbl_MainCourseHeader";
            this.lbl_MainCourseHeader.Size = new System.Drawing.Size(411, 37);
            this.lbl_MainCourseHeader.TabIndex = 24;
            this.lbl_MainCourseHeader.Text = "Hoofdgerechten";
            this.lbl_MainCourseHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_MainCourseHeader.UseWaitCursor = true;
            // 
            // lbl_StartersHeader
            // 
            this.lbl_StartersHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_StartersHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_StartersHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_StartersHeader.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StartersHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_StartersHeader.Location = new System.Drawing.Point(26, 36);
            this.lbl_StartersHeader.Name = "lbl_StartersHeader";
            this.lbl_StartersHeader.Size = new System.Drawing.Size(411, 37);
            this.lbl_StartersHeader.TabIndex = 37;
            this.lbl_StartersHeader.Text = "Voorgerechten";
            this.lbl_StartersHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_StartersHeader.UseWaitCursor = true;
            // 
            // btn_OrderOverview
            // 
            this.btn_OrderOverview.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_OrderOverview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OrderOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OrderOverview.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OrderOverview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_OrderOverview.Location = new System.Drawing.Point(357, 632);
            this.btn_OrderOverview.Name = "btn_OrderOverview";
            this.btn_OrderOverview.Size = new System.Drawing.Size(95, 37);
            this.btn_OrderOverview.TabIndex = 50;
            this.btn_OrderOverview.Text = "CONFIRM";
            this.btn_OrderOverview.UseVisualStyleBackColor = false;
            this.btn_OrderOverview.Click += new System.EventHandler(this.btn_ConfirmOrder_Click);
            // 
            // listView_Starters
            // 
            this.listView_Starters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameStartersLunch,
            this.quantityStartersLunch,
            this.priceStartersLunch,
            this.stockStartersLunch,
            this.commentStartersLunch});
            this.listView_Starters.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Starters.FullRowSelect = true;
            this.listView_Starters.GridLines = true;
            this.listView_Starters.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView_Starters.HideSelection = false;
            this.listView_Starters.Location = new System.Drawing.Point(26, 72);
            this.listView_Starters.MultiSelect = false;
            this.listView_Starters.Name = "listView_Starters";
            this.listView_Starters.Scrollable = false;
            this.listView_Starters.Size = new System.Drawing.Size(376, 103);
            this.listView_Starters.TabIndex = 53;
            this.listView_Starters.UseCompatibleStateImageBehavior = false;
            this.listView_Starters.View = System.Windows.Forms.View.Details;
            // 
            // nameStartersLunch
            // 
            this.nameStartersLunch.Text = "Name";
            this.nameStartersLunch.Width = 289;
            // 
            // quantityStartersLunch
            // 
            this.quantityStartersLunch.Text = "#";
            this.quantityStartersLunch.Width = 43;
            // 
            // priceStartersLunch
            // 
            this.priceStartersLunch.Text = "€";
            this.priceStartersLunch.Width = 40;
            // 
            // stockStartersLunch
            // 
            this.stockStartersLunch.Text = "S";
            this.stockStartersLunch.Width = 0;
            // 
            // commentStartersLunch
            // 
            this.commentStartersLunch.Text = "C";
            this.commentStartersLunch.Width = 0;
            // 
            // btn_AddStarter
            // 
            this.btn_AddStarter.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_AddStarter.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_AddStarter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddStarter.Location = new System.Drawing.Point(404, 72);
            this.btn_AddStarter.Name = "btn_AddStarter";
            this.btn_AddStarter.Size = new System.Drawing.Size(33, 33);
            this.btn_AddStarter.TabIndex = 58;
            this.btn_AddStarter.Text = "+";
            this.btn_AddStarter.UseVisualStyleBackColor = false;
            this.btn_AddStarter.Click += new System.EventHandler(this.btn_AddStarter_Click);
            // 
            // btn_CommentStarter
            // 
            this.btn_CommentStarter.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_CommentStarter.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_CommentStarter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CommentStarter.Location = new System.Drawing.Point(404, 107);
            this.btn_CommentStarter.Name = "btn_CommentStarter";
            this.btn_CommentStarter.Size = new System.Drawing.Size(33, 33);
            this.btn_CommentStarter.TabIndex = 60;
            this.btn_CommentStarter.Text = "C";
            this.btn_CommentStarter.UseVisualStyleBackColor = false;
            this.btn_CommentStarter.Click += new System.EventHandler(this.btn_CommentStarter_Click);
            // 
            // btn_SubtractStarter
            // 
            this.btn_SubtractStarter.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_SubtractStarter.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_SubtractStarter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SubtractStarter.Location = new System.Drawing.Point(404, 142);
            this.btn_SubtractStarter.Name = "btn_SubtractStarter";
            this.btn_SubtractStarter.Size = new System.Drawing.Size(33, 33);
            this.btn_SubtractStarter.TabIndex = 62;
            this.btn_SubtractStarter.Text = "-";
            this.btn_SubtractStarter.UseVisualStyleBackColor = false;
            this.btn_SubtractStarter.Click += new System.EventHandler(this.btn_SubtractStarter_Click);
            // 
            // btn_SubtractMainCourse
            // 
            this.btn_SubtractMainCourse.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_SubtractMainCourse.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_SubtractMainCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SubtractMainCourse.Location = new System.Drawing.Point(404, 317);
            this.btn_SubtractMainCourse.Name = "btn_SubtractMainCourse";
            this.btn_SubtractMainCourse.Size = new System.Drawing.Size(33, 33);
            this.btn_SubtractMainCourse.TabIndex = 81;
            this.btn_SubtractMainCourse.Text = "-";
            this.btn_SubtractMainCourse.UseVisualStyleBackColor = false;
            this.btn_SubtractMainCourse.Click += new System.EventHandler(this.btn_SubtractMainCourse_Click);
            // 
            // btn_CommentMainCourse
            // 
            this.btn_CommentMainCourse.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_CommentMainCourse.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_CommentMainCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CommentMainCourse.Location = new System.Drawing.Point(404, 282);
            this.btn_CommentMainCourse.Name = "btn_CommentMainCourse";
            this.btn_CommentMainCourse.Size = new System.Drawing.Size(33, 33);
            this.btn_CommentMainCourse.TabIndex = 80;
            this.btn_CommentMainCourse.Text = "C";
            this.btn_CommentMainCourse.UseVisualStyleBackColor = false;
            this.btn_CommentMainCourse.Click += new System.EventHandler(this.btn_CommentMainCourse_Click);
            // 
            // btn_AddMainCourse
            // 
            this.btn_AddMainCourse.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_AddMainCourse.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_AddMainCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddMainCourse.Location = new System.Drawing.Point(404, 247);
            this.btn_AddMainCourse.Name = "btn_AddMainCourse";
            this.btn_AddMainCourse.Size = new System.Drawing.Size(33, 33);
            this.btn_AddMainCourse.TabIndex = 79;
            this.btn_AddMainCourse.Text = "+";
            this.btn_AddMainCourse.UseVisualStyleBackColor = false;
            this.btn_AddMainCourse.Click += new System.EventHandler(this.btn_AddMainCourse_Click);
            // 
            // btn_SubtractDessert
            // 
            this.btn_SubtractDessert.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_SubtractDessert.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_SubtractDessert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SubtractDessert.Location = new System.Drawing.Point(404, 492);
            this.btn_SubtractDessert.Name = "btn_SubtractDessert";
            this.btn_SubtractDessert.Size = new System.Drawing.Size(33, 33);
            this.btn_SubtractDessert.TabIndex = 85;
            this.btn_SubtractDessert.Text = "-";
            this.btn_SubtractDessert.UseVisualStyleBackColor = false;
            this.btn_SubtractDessert.Click += new System.EventHandler(this.btn_SubtractDessert_Click);
            // 
            // btn_CommentDessert
            // 
            this.btn_CommentDessert.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_CommentDessert.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_CommentDessert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CommentDessert.Location = new System.Drawing.Point(404, 457);
            this.btn_CommentDessert.Name = "btn_CommentDessert";
            this.btn_CommentDessert.Size = new System.Drawing.Size(33, 33);
            this.btn_CommentDessert.TabIndex = 84;
            this.btn_CommentDessert.Text = "C";
            this.btn_CommentDessert.UseVisualStyleBackColor = false;
            this.btn_CommentDessert.Click += new System.EventHandler(this.btn_CommentDessert_Click);
            // 
            // btn_AddDessert
            // 
            this.btn_AddDessert.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_AddDessert.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_AddDessert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddDessert.Location = new System.Drawing.Point(404, 422);
            this.btn_AddDessert.Name = "btn_AddDessert";
            this.btn_AddDessert.Size = new System.Drawing.Size(33, 33);
            this.btn_AddDessert.TabIndex = 83;
            this.btn_AddDessert.Text = "+";
            this.btn_AddDessert.UseVisualStyleBackColor = false;
            this.btn_AddDessert.Click += new System.EventHandler(this.btn_AddDessert_Click);
            // 
            // listView_MainCourses
            // 
            this.listView_MainCourses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameMainCoursesLunch,
            this.quantityMainCoursesLunch,
            this.priceMainCoursesLunch,
            this.stockMainCoursesLunch,
            this.commentMainCoursesLunch});
            this.listView_MainCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_MainCourses.FullRowSelect = true;
            this.listView_MainCourses.GridLines = true;
            this.listView_MainCourses.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView_MainCourses.HideSelection = false;
            this.listView_MainCourses.Location = new System.Drawing.Point(26, 247);
            this.listView_MainCourses.MultiSelect = false;
            this.listView_MainCourses.Name = "listView_MainCourses";
            this.listView_MainCourses.Scrollable = false;
            this.listView_MainCourses.Size = new System.Drawing.Size(376, 103);
            this.listView_MainCourses.TabIndex = 86;
            this.listView_MainCourses.UseCompatibleStateImageBehavior = false;
            this.listView_MainCourses.View = System.Windows.Forms.View.Details;
            // 
            // nameMainCoursesLunch
            // 
            this.nameMainCoursesLunch.Text = "Name";
            this.nameMainCoursesLunch.Width = 289;
            // 
            // quantityMainCoursesLunch
            // 
            this.quantityMainCoursesLunch.Text = "#";
            this.quantityMainCoursesLunch.Width = 43;
            // 
            // priceMainCoursesLunch
            // 
            this.priceMainCoursesLunch.Text = "€";
            this.priceMainCoursesLunch.Width = 40;
            // 
            // stockMainCoursesLunch
            // 
            this.stockMainCoursesLunch.Text = "S";
            this.stockMainCoursesLunch.Width = 0;
            // 
            // commentMainCoursesLunch
            // 
            this.commentMainCoursesLunch.Text = "C";
            this.commentMainCoursesLunch.Width = 0;
            // 
            // listView_Desserts
            // 
            this.listView_Desserts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameDessertsLunch,
            this.quantityDessertsLunch,
            this.priceDessertsLunch,
            this.stockDessertsLunch,
            this.commentDessertLunch});
            this.listView_Desserts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Desserts.FullRowSelect = true;
            this.listView_Desserts.GridLines = true;
            this.listView_Desserts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView_Desserts.HideSelection = false;
            this.listView_Desserts.Location = new System.Drawing.Point(26, 422);
            this.listView_Desserts.MultiSelect = false;
            this.listView_Desserts.Name = "listView_Desserts";
            this.listView_Desserts.Scrollable = false;
            this.listView_Desserts.Size = new System.Drawing.Size(376, 103);
            this.listView_Desserts.TabIndex = 87;
            this.listView_Desserts.UseCompatibleStateImageBehavior = false;
            this.listView_Desserts.View = System.Windows.Forms.View.Details;
            // 
            // nameDessertsLunch
            // 
            this.nameDessertsLunch.Text = "Name";
            this.nameDessertsLunch.Width = 289;
            // 
            // quantityDessertsLunch
            // 
            this.quantityDessertsLunch.Text = "#";
            this.quantityDessertsLunch.Width = 43;
            // 
            // priceDessertsLunch
            // 
            this.priceDessertsLunch.Text = "€";
            this.priceDessertsLunch.Width = 40;
            // 
            // stockDessertsLunch
            // 
            this.stockDessertsLunch.Text = "S";
            this.stockDessertsLunch.Width = 0;
            // 
            // commentDessertLunch
            // 
            this.commentDessertLunch.Text = "C";
            this.commentDessertLunch.Width = 0;
            // 
            // pnl_Comment
            // 
            this.pnl_Comment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_Comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Comment.Controls.Add(this.btn_CancelComment);
            this.pnl_Comment.Controls.Add(this.btn_AddCommentToItem);
            this.pnl_Comment.Controls.Add(this.label1);
            this.pnl_Comment.Controls.Add(this.txt_AddCommentToItem);
            this.pnl_Comment.Location = new System.Drawing.Point(12, 176);
            this.pnl_Comment.Name = "pnl_Comment";
            this.pnl_Comment.Size = new System.Drawing.Size(440, 247);
            this.pnl_Comment.TabIndex = 88;
            this.pnl_Comment.Visible = false;
            // 
            // btn_CancelComment
            // 
            this.btn_CancelComment.BackColor = System.Drawing.Color.Red;
            this.btn_CancelComment.FlatAppearance.BorderSize = 0;
            this.btn_CancelComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelComment.ForeColor = System.Drawing.Color.White;
            this.btn_CancelComment.Location = new System.Drawing.Point(242, 155);
            this.btn_CancelComment.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CancelComment.Name = "btn_CancelComment";
            this.btn_CancelComment.Size = new System.Drawing.Size(143, 59);
            this.btn_CancelComment.TabIndex = 29;
            this.btn_CancelComment.Text = "ANNULEER";
            this.btn_CancelComment.UseVisualStyleBackColor = false;
            this.btn_CancelComment.Click += new System.EventHandler(this.btn_CancelComment_Click);
            // 
            // btn_AddCommentToItem
            // 
            this.btn_AddCommentToItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_AddCommentToItem.FlatAppearance.BorderSize = 0;
            this.btn_AddCommentToItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddCommentToItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCommentToItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AddCommentToItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddCommentToItem.Location = new System.Drawing.Point(51, 155);
            this.btn_AddCommentToItem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddCommentToItem.Name = "btn_AddCommentToItem";
            this.btn_AddCommentToItem.Size = new System.Drawing.Size(143, 59);
            this.btn_AddCommentToItem.TabIndex = 28;
            this.btn_AddCommentToItem.Text = "BEVESTIG";
            this.btn_AddCommentToItem.UseVisualStyleBackColor = false;
            this.btn_AddCommentToItem.Click += new System.EventHandler(this.btn_AddCommentToItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voer uw commentaar in";
            // 
            // txt_AddCommentToItem
            // 
            this.txt_AddCommentToItem.Location = new System.Drawing.Point(51, 51);
            this.txt_AddCommentToItem.Multiline = true;
            this.txt_AddCommentToItem.Name = "txt_AddCommentToItem";
            this.txt_AddCommentToItem.Size = new System.Drawing.Size(334, 74);
            this.txt_AddCommentToItem.TabIndex = 0;
            // 
            // OrderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 681);
            this.Controls.Add(this.pnl_Comment);
            this.Controls.Add(this.listView_Desserts);
            this.Controls.Add(this.listView_MainCourses);
            this.Controls.Add(this.btn_SubtractDessert);
            this.Controls.Add(this.btn_CommentDessert);
            this.Controls.Add(this.btn_AddDessert);
            this.Controls.Add(this.btn_SubtractMainCourse);
            this.Controls.Add(this.btn_CommentMainCourse);
            this.Controls.Add(this.btn_AddMainCourse);
            this.Controls.Add(this.btn_SubtractStarter);
            this.Controls.Add(this.btn_CommentStarter);
            this.Controls.Add(this.btn_AddStarter);
            this.Controls.Add(this.listView_Starters);
            this.Controls.Add(this.btn_OrderOverview);
            this.Controls.Add(this.lbl_StartersHeader);
            this.Controls.Add(this.lbl_MainCourseHeader);
            this.Controls.Add(this.lbl_DessertHeader);
            this.Controls.Add(this.btnBack);
            this.Name = "OrderUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.pnl_Comment.ResumeLayout(false);
            this.pnl_Comment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbl_DessertHeader;
        private System.Windows.Forms.Label lbl_MainCourseHeader;
        private System.Windows.Forms.Label lbl_StartersHeader;
        private System.Windows.Forms.Button btn_OrderOverview;
        private System.Windows.Forms.ListView listView_Starters;
        private System.Windows.Forms.ColumnHeader nameStartersLunch;
        private System.Windows.Forms.ColumnHeader quantityStartersLunch;
        private System.Windows.Forms.Button btn_AddStarter;
        private System.Windows.Forms.Button btn_CommentStarter;
        private System.Windows.Forms.Button btn_SubtractStarter;
        private System.Windows.Forms.ColumnHeader priceStartersLunch;
        private System.Windows.Forms.Button btn_SubtractMainCourse;
        private System.Windows.Forms.Button btn_CommentMainCourse;
        private System.Windows.Forms.Button btn_AddMainCourse;
        private System.Windows.Forms.Button btn_SubtractDessert;
        private System.Windows.Forms.Button btn_CommentDessert;
        private System.Windows.Forms.Button btn_AddDessert;
        private System.Windows.Forms.ColumnHeader stockStartersLunch;
        private System.Windows.Forms.ColumnHeader commentStartersLunch;
        private System.Windows.Forms.ListView listView_MainCourses;
        private System.Windows.Forms.ColumnHeader nameMainCoursesLunch;
        private System.Windows.Forms.ColumnHeader quantityMainCoursesLunch;
        private System.Windows.Forms.ColumnHeader priceMainCoursesLunch;
        private System.Windows.Forms.ColumnHeader stockMainCoursesLunch;
        private System.Windows.Forms.ColumnHeader commentMainCoursesLunch;
        private System.Windows.Forms.ListView listView_Desserts;
        private System.Windows.Forms.ColumnHeader nameDessertsLunch;
        private System.Windows.Forms.ColumnHeader quantityDessertsLunch;
        private System.Windows.Forms.ColumnHeader priceDessertsLunch;
        private System.Windows.Forms.ColumnHeader stockDessertsLunch;
        private System.Windows.Forms.ColumnHeader commentDessertLunch;
        private System.Windows.Forms.Panel pnl_Comment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_AddCommentToItem;
        private System.Windows.Forms.Button btn_CancelComment;
        private System.Windows.Forms.Button btn_AddCommentToItem;
    }
}
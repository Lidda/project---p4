namespace OrderSystemUI.MainUI
{
    partial class CheckoutCommentsUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutCommentsUI));
            this.pnlAddComment = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnDeleteComment = new System.Windows.Forms.Button();
            this.btnAddCommentToOrder = new System.Windows.Forms.Button();
            this.lblCurrentComment = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCommentHeader = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlAddComment.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddComment
            // 
            this.pnlAddComment.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlAddComment.Controls.Add(this.label6);
            this.pnlAddComment.Controls.Add(this.txtComment);
            this.pnlAddComment.Controls.Add(this.btnDeleteComment);
            this.pnlAddComment.Controls.Add(this.btnAddCommentToOrder);
            this.pnlAddComment.Controls.Add(this.lblCurrentComment);
            this.pnlAddComment.Controls.Add(this.label5);
            this.pnlAddComment.Controls.Add(this.lblCommentHeader);
            this.pnlAddComment.Controls.Add(this.button1);
            this.pnlAddComment.Location = new System.Drawing.Point(2, 2);
            this.pnlAddComment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlAddComment.Name = "pnlAddComment";
            this.pnlAddComment.Size = new System.Drawing.Size(460, 678);
            this.pnlAddComment.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.Location = new System.Drawing.Point(21, 163);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 26);
            this.label6.TabIndex = 29;
            this.label6.Text = "Voeg commentaar toe:";
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtComment.Location = new System.Drawing.Point(21, 210);
            this.txtComment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(422, 244);
            this.txtComment.TabIndex = 28;
            // 
            // btnDeleteComment
            // 
            this.btnDeleteComment.BackColor = System.Drawing.Color.Red;
            this.btnDeleteComment.FlatAppearance.BorderSize = 0;
            this.btnDeleteComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteComment.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteComment.Image")));
            this.btnDeleteComment.Location = new System.Drawing.Point(20, 526);
            this.btnDeleteComment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteComment.Name = "btnDeleteComment";
            this.btnDeleteComment.Size = new System.Drawing.Size(74, 59);
            this.btnDeleteComment.TabIndex = 27;
            this.btnDeleteComment.UseVisualStyleBackColor = false;
            this.btnDeleteComment.Click += new System.EventHandler(this.btnDeleteComment_Click);
            // 
            // btnAddCommentToOrder
            // 
            this.btnAddCommentToOrder.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddCommentToOrder.FlatAppearance.BorderSize = 0;
            this.btnAddCommentToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCommentToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAddCommentToOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCommentToOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCommentToOrder.Location = new System.Drawing.Point(105, 526);
            this.btnAddCommentToOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddCommentToOrder.Name = "btnAddCommentToOrder";
            this.btnAddCommentToOrder.Size = new System.Drawing.Size(335, 59);
            this.btnAddCommentToOrder.TabIndex = 26;
            this.btnAddCommentToOrder.Text = "Voeg commentaar toe";
            this.btnAddCommentToOrder.UseVisualStyleBackColor = false;
            this.btnAddCommentToOrder.Click += new System.EventHandler(this.btnAddCommentToOrder_Click);
            // 
            // lblCurrentComment
            // 
            this.lblCurrentComment.AutoSize = true;
            this.lblCurrentComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic);
            this.lblCurrentComment.Location = new System.Drawing.Point(21, 89);
            this.lblCurrentComment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentComment.MaximumSize = new System.Drawing.Size(375, 0);
            this.lblCurrentComment.Name = "lblCurrentComment";
            this.lblCurrentComment.Size = new System.Drawing.Size(170, 26);
            this.lblCurrentComment.TabIndex = 25;
            this.lblCurrentComment.Text = "currentcomment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(21, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 26);
            this.label5.TabIndex = 24;
            this.label5.Text = "Huidig commentaar:";
            // 
            // lblCommentHeader
            // 
            this.lblCommentHeader.AutoSize = true;
            this.lblCommentHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCommentHeader.Location = new System.Drawing.Point(20, 6);
            this.lblCommentHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCommentHeader.Name = "lblCommentHeader";
            this.lblCommentHeader.Size = new System.Drawing.Size(268, 31);
            this.lblCommentHeader.TabIndex = 23;
            this.lblCommentHeader.Text = "Order x: commentaar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 630);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 48);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckoutCommentsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 681);
            this.Controls.Add(this.pnlAddComment);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CheckoutCommentsUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commentaar";
            this.pnlAddComment.ResumeLayout(false);
            this.pnlAddComment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddComment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnDeleteComment;
        private System.Windows.Forms.Button btnAddCommentToOrder;
        private System.Windows.Forms.Label lblCurrentComment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCommentHeader;
        private System.Windows.Forms.Button button1;
    }
}
namespace OrderSystemUI.MainUI
{
    partial class CheckoutComments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutComments));
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
            this.pnlAddComment.Name = "pnlAddComment";
            this.pnlAddComment.Size = new System.Drawing.Size(614, 835);
            this.pnlAddComment.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.Location = new System.Drawing.Point(28, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 31);
            this.label6.TabIndex = 29;
            this.label6.Text = "Add comment:";
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtComment.Location = new System.Drawing.Point(28, 258);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(561, 300);
            this.txtComment.TabIndex = 28;
            // 
            // btnDeleteComment
            // 
            this.btnDeleteComment.BackColor = System.Drawing.Color.Red;
            this.btnDeleteComment.FlatAppearance.BorderSize = 0;
            this.btnDeleteComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteComment.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteComment.Image")));
            this.btnDeleteComment.Location = new System.Drawing.Point(27, 647);
            this.btnDeleteComment.Name = "btnDeleteComment";
            this.btnDeleteComment.Size = new System.Drawing.Size(98, 73);
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
            this.btnAddCommentToOrder.Location = new System.Drawing.Point(140, 647);
            this.btnAddCommentToOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCommentToOrder.Name = "btnAddCommentToOrder";
            this.btnAddCommentToOrder.Size = new System.Drawing.Size(447, 73);
            this.btnAddCommentToOrder.TabIndex = 26;
            this.btnAddCommentToOrder.Text = "Add comment";
            this.btnAddCommentToOrder.UseVisualStyleBackColor = false;
            this.btnAddCommentToOrder.Click += new System.EventHandler(this.btnAddCommentToOrder_Click);
            // 
            // lblCurrentComment
            // 
            this.lblCurrentComment.AutoSize = true;
            this.lblCurrentComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic);
            this.lblCurrentComment.Location = new System.Drawing.Point(28, 110);
            this.lblCurrentComment.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblCurrentComment.Name = "lblCurrentComment";
            this.lblCurrentComment.Size = new System.Drawing.Size(210, 31);
            this.lblCurrentComment.TabIndex = 25;
            this.lblCurrentComment.Text = "currentcomment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(28, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 31);
            this.label5.TabIndex = 24;
            this.label5.Text = "Current comment: ";
            // 
            // lblCommentHeader
            // 
            this.lblCommentHeader.AutoSize = true;
            this.lblCommentHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCommentHeader.Location = new System.Drawing.Point(96, 7);
            this.lblCommentHeader.Name = "lblCommentHeader";
            this.lblCommentHeader.Size = new System.Drawing.Size(303, 39);
            this.lblCommentHeader.TabIndex = 23;
            this.lblCommentHeader.Text = "Order x: comments";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(26, 749);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 59);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckoutComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 838);
            this.Controls.Add(this.pnlAddComment);
            this.Name = "CheckoutComments";
            this.Text = "ChechkoutComments";
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
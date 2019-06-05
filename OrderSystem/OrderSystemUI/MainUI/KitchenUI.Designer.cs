namespace OrderSystemUI.MainUI {
    partial class KitchenUI {
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
            this.components = new System.ComponentModel.Container();
            this.btnLogout = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.listView4 = new System.Windows.Forms.ListView();
            this.listView5 = new System.Windows.Forms.ListView();
            this.listView6 = new System.Windows.Forms.ListView();
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.btn_markReady1 = new System.Windows.Forms.Button();
            this.btn_markReady2 = new System.Windows.Forms.Button();
            this.btn_markReady3 = new System.Windows.Forms.Button();
            this.btn_markReady4 = new System.Windows.Forms.Button();
            this.btn_markReady5 = new System.Windows.Forms.Button();
            this.btn_markReady6 = new System.Windows.Forms.Button();
            this.listView7 = new System.Windows.Forms.ListView();
            this.listView8 = new System.Windows.Forms.ListView();
            this.listView9 = new System.Windows.Forms.ListView();
            this.listView10 = new System.Windows.Forms.ListView();
            this.btn_markReady7 = new System.Windows.Forms.Button();
            this.btn_markReady8 = new System.Windows.Forms.Button();
            this.btn_markReady9 = new System.Windows.Forms.Button();
            this.btn_markReady10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.TimeLabel = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(6, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(60, 23);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox2.Location = new System.Drawing.Point(752, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 19);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Kitchen Overview";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Green;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 112);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(330, 197);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.VirtualListSize = 5;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.Green;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(441, 112);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(330, 197);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // listView3
            // 
            this.listView3.BackColor = System.Drawing.Color.Green;
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(874, 112);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(330, 197);
            this.listView3.TabIndex = 8;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // listView4
            // 
            this.listView4.BackColor = System.Drawing.Color.Green;
            this.listView4.GridLines = true;
            this.listView4.Location = new System.Drawing.Point(1264, 112);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(330, 197);
            this.listView4.TabIndex = 9;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // listView5
            // 
            this.listView5.BackColor = System.Drawing.Color.Green;
            this.listView5.GridLines = true;
            this.listView5.Location = new System.Drawing.Point(12, 404);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(330, 197);
            this.listView5.TabIndex = 10;
            this.listView5.UseCompatibleStateImageBehavior = false;
            this.listView5.View = System.Windows.Forms.View.Details;
            // 
            // listView6
            // 
            this.listView6.BackColor = System.Drawing.Color.Green;
            this.listView6.GridLines = true;
            this.listView6.Location = new System.Drawing.Point(441, 404);
            this.listView6.Name = "listView6";
            this.listView6.Size = new System.Drawing.Size(330, 197);
            this.listView6.TabIndex = 11;
            this.listView6.UseCompatibleStateImageBehavior = false;
            this.listView6.View = System.Windows.Forms.View.Details;
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Refresh_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Refresh_btn.Location = new System.Drawing.Point(1410, 33);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(60, 23);
            this.Refresh_btn.TabIndex = 12;
            this.Refresh_btn.Text = "Refresh";
            this.Refresh_btn.UseVisualStyleBackColor = false;
            this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // btn_markReady1
            // 
            this.btn_markReady1.Location = new System.Drawing.Point(125, 326);
            this.btn_markReady1.Name = "btn_markReady1";
            this.btn_markReady1.Size = new System.Drawing.Size(94, 23);
            this.btn_markReady1.TabIndex = 13;
            this.btn_markReady1.Text = "Mark as ready";
            this.btn_markReady1.UseVisualStyleBackColor = true;
            this.btn_markReady1.Click += new System.EventHandler(this.btn_markReady1_Click);
            // 
            // btn_markReady2
            // 
            this.btn_markReady2.Location = new System.Drawing.Point(558, 326);
            this.btn_markReady2.Name = "btn_markReady2";
            this.btn_markReady2.Size = new System.Drawing.Size(94, 23);
            this.btn_markReady2.TabIndex = 14;
            this.btn_markReady2.Text = "Mark as ready";
            this.btn_markReady2.UseVisualStyleBackColor = true;
            this.btn_markReady2.Click += new System.EventHandler(this.btn_markReady2_Click);
            // 
            // btn_markReady3
            // 
            this.btn_markReady3.Location = new System.Drawing.Point(997, 326);
            this.btn_markReady3.Name = "btn_markReady3";
            this.btn_markReady3.Size = new System.Drawing.Size(94, 23);
            this.btn_markReady3.TabIndex = 15;
            this.btn_markReady3.Text = "Mark as ready";
            this.btn_markReady3.UseVisualStyleBackColor = true;
            this.btn_markReady3.Click += new System.EventHandler(this.btn_markReady3_Click);
            // 
            // btn_markReady4
            // 
            this.btn_markReady4.Location = new System.Drawing.Point(1376, 326);
            this.btn_markReady4.Name = "btn_markReady4";
            this.btn_markReady4.Size = new System.Drawing.Size(94, 23);
            this.btn_markReady4.TabIndex = 16;
            this.btn_markReady4.Text = "Mark as ready";
            this.btn_markReady4.UseVisualStyleBackColor = true;
            this.btn_markReady4.Click += new System.EventHandler(this.btn_markReady4_Click);
            // 
            // btn_markReady5
            // 
            this.btn_markReady5.Location = new System.Drawing.Point(125, 625);
            this.btn_markReady5.Name = "btn_markReady5";
            this.btn_markReady5.Size = new System.Drawing.Size(94, 23);
            this.btn_markReady5.TabIndex = 17;
            this.btn_markReady5.Text = "Mark as ready";
            this.btn_markReady5.UseVisualStyleBackColor = true;
            this.btn_markReady5.Click += new System.EventHandler(this.btn_markReady5_Click);
            // 
            // btn_markReady6
            // 
            this.btn_markReady6.Location = new System.Drawing.Point(567, 625);
            this.btn_markReady6.Name = "btn_markReady6";
            this.btn_markReady6.Size = new System.Drawing.Size(94, 23);
            this.btn_markReady6.TabIndex = 18;
            this.btn_markReady6.Text = "Mark as ready";
            this.btn_markReady6.UseVisualStyleBackColor = true;
            this.btn_markReady6.Click += new System.EventHandler(this.btn_markReady6_Click);
            // 
            // listView7
            // 
            this.listView7.BackColor = System.Drawing.Color.Green;
            this.listView7.GridLines = true;
            this.listView7.Location = new System.Drawing.Point(883, 404);
            this.listView7.Name = "listView7";
            this.listView7.Size = new System.Drawing.Size(330, 197);
            this.listView7.TabIndex = 19;
            this.listView7.UseCompatibleStateImageBehavior = false;
            this.listView7.View = System.Windows.Forms.View.Details;
            // 
            // listView8
            // 
            this.listView8.BackColor = System.Drawing.Color.Green;
            this.listView8.GridLines = true;
            this.listView8.Location = new System.Drawing.Point(1264, 404);
            this.listView8.Name = "listView8";
            this.listView8.Size = new System.Drawing.Size(330, 197);
            this.listView8.TabIndex = 20;
            this.listView8.UseCompatibleStateImageBehavior = false;
            this.listView8.View = System.Windows.Forms.View.Details;
            // 
            // listView9
            // 
            this.listView9.BackColor = System.Drawing.Color.Green;
            this.listView9.GridLines = true;
            this.listView9.Location = new System.Drawing.Point(12, 710);
            this.listView9.Name = "listView9";
            this.listView9.Size = new System.Drawing.Size(330, 197);
            this.listView9.TabIndex = 21;
            this.listView9.UseCompatibleStateImageBehavior = false;
            this.listView9.View = System.Windows.Forms.View.Details;
            // 
            // listView10
            // 
            this.listView10.BackColor = System.Drawing.Color.Green;
            this.listView10.GridLines = true;
            this.listView10.Location = new System.Drawing.Point(441, 710);
            this.listView10.Name = "listView10";
            this.listView10.Size = new System.Drawing.Size(330, 197);
            this.listView10.TabIndex = 22;
            this.listView10.UseCompatibleStateImageBehavior = false;
            this.listView10.View = System.Windows.Forms.View.Details;
            // 
            // btn_markReady7
            // 
            this.btn_markReady7.Location = new System.Drawing.Point(997, 625);
            this.btn_markReady7.Name = "btn_markReady7";
            this.btn_markReady7.Size = new System.Drawing.Size(94, 23);
            this.btn_markReady7.TabIndex = 23;
            this.btn_markReady7.Text = "Mark as ready";
            this.btn_markReady7.UseVisualStyleBackColor = true;
            this.btn_markReady7.Click += new System.EventHandler(this.btn_markReady7_Click);
            // 
            // btn_markReady8
            // 
            this.btn_markReady8.Location = new System.Drawing.Point(1365, 625);
            this.btn_markReady8.Name = "btn_markReady8";
            this.btn_markReady8.Size = new System.Drawing.Size(94, 23);
            this.btn_markReady8.TabIndex = 24;
            this.btn_markReady8.Text = "Mark as ready";
            this.btn_markReady8.UseVisualStyleBackColor = true;
            this.btn_markReady8.Click += new System.EventHandler(this.btn_markReady8_Click);
            // 
            // btn_markReady9
            // 
            this.btn_markReady9.Location = new System.Drawing.Point(125, 960);
            this.btn_markReady9.Name = "btn_markReady9";
            this.btn_markReady9.Size = new System.Drawing.Size(94, 23);
            this.btn_markReady9.TabIndex = 25;
            this.btn_markReady9.Text = "Mark as ready";
            this.btn_markReady9.UseVisualStyleBackColor = true;
            this.btn_markReady9.Click += new System.EventHandler(this.btn_markReady9_Click);
            // 
            // btn_markReady10
            // 
            this.btn_markReady10.Location = new System.Drawing.Point(567, 960);
            this.btn_markReady10.Name = "btn_markReady10";
            this.btn_markReady10.Size = new System.Drawing.Size(94, 23);
            this.btn_markReady10.TabIndex = 26;
            this.btn_markReady10.Text = "Mark as ready";
            this.btn_markReady10.UseVisualStyleBackColor = true;
            this.btn_markReady10.Click += new System.EventHandler(this.btn_markReady10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Table 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(596, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Table 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1014, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Table 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1407, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Table 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Table 5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(596, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Table 6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1014, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Table 7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1407, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Table 8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 680);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Table 9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(590, 680);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Table 10";
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 60000;
            this.timerRefresh.Tick += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(1171, 17);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(56, 13);
            this.TimeLabel.TabIndex = 37;
            this.TimeLabel.Text = "TimeLabel";
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // KitchenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1631, 1061);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_markReady10);
            this.Controls.Add(this.btn_markReady9);
            this.Controls.Add(this.btn_markReady8);
            this.Controls.Add(this.btn_markReady7);
            this.Controls.Add(this.listView10);
            this.Controls.Add(this.listView9);
            this.Controls.Add(this.listView8);
            this.Controls.Add(this.listView7);
            this.Controls.Add(this.btn_markReady6);
            this.Controls.Add(this.btn_markReady5);
            this.Controls.Add(this.btn_markReady4);
            this.Controls.Add(this.btn_markReady3);
            this.Controls.Add(this.btn_markReady2);
            this.Controls.Add(this.btn_markReady1);
            this.Controls.Add(this.Refresh_btn);
            this.Controls.Add(this.listView6);
            this.Controls.Add(this.listView5);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnLogout);
            this.Name = "KitchenUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitchenUI";
            this.Load += new System.EventHandler(this.KitchenUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.ListView listView6;
        private System.Windows.Forms.Button Refresh_btn;
        private System.Windows.Forms.Button btn_markReady1;
        private System.Windows.Forms.Button btn_markReady2;
        private System.Windows.Forms.Button btn_markReady3;
        private System.Windows.Forms.Button btn_markReady4;
        private System.Windows.Forms.Button btn_markReady5;
        private System.Windows.Forms.Button btn_markReady6;
        private System.Windows.Forms.ListView listView7;
        private System.Windows.Forms.ListView listView8;
        private System.Windows.Forms.ListView listView9;
        private System.Windows.Forms.ListView listView10;
        private System.Windows.Forms.Button btn_markReady7;
        private System.Windows.Forms.Button btn_markReady8;
        private System.Windows.Forms.Button btn_markReady9;
        private System.Windows.Forms.Button btn_markReady10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer timerTime;
    }
}
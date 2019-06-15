﻿namespace OrderSystemUI.MainUI
{
    partial class KitchenUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitchenUI));
            this.label1 = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.Time8 = new System.Windows.Forms.Label();
            this.Time7 = new System.Windows.Forms.Label();
            this.Time6 = new System.Windows.Forms.Label();
            this.Time5 = new System.Windows.Forms.Label();
            this.Time4 = new System.Windows.Forms.Label();
            this.Time3 = new System.Windows.Forms.Label();
            this.Time2 = new System.Windows.Forms.Label();
            this.Time1 = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.btn_markReady1 = new System.Windows.Forms.Button();
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_FilterNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(643, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Bestellingen";
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // Time8
            // 
            this.Time8.AutoSize = true;
            this.Time8.Location = new System.Drawing.Point(1291, 384);
            this.Time8.Name = "Time8";
            this.Time8.Size = new System.Drawing.Size(0, 13);
            this.Time8.TabIndex = 89;
            // 
            // Time7
            // 
            this.Time7.AutoSize = true;
            this.Time7.Location = new System.Drawing.Point(892, 374);
            this.Time7.Name = "Time7";
            this.Time7.Size = new System.Drawing.Size(0, 13);
            this.Time7.TabIndex = 88;
            // 
            // Time6
            // 
            this.Time6.AutoSize = true;
            this.Time6.Location = new System.Drawing.Point(464, 384);
            this.Time6.Name = "Time6";
            this.Time6.Size = new System.Drawing.Size(0, 13);
            this.Time6.TabIndex = 87;
            // 
            // Time5
            // 
            this.Time5.AutoSize = true;
            this.Time5.Location = new System.Drawing.Point(37, 374);
            this.Time5.Name = "Time5";
            this.Time5.Size = new System.Drawing.Size(0, 13);
            this.Time5.TabIndex = 86;
            // 
            // Time4
            // 
            this.Time4.AutoSize = true;
            this.Time4.Location = new System.Drawing.Point(1291, 89);
            this.Time4.Name = "Time4";
            this.Time4.Size = new System.Drawing.Size(0, 13);
            this.Time4.TabIndex = 85;
            // 
            // Time3
            // 
            this.Time3.AutoSize = true;
            this.Time3.Location = new System.Drawing.Point(892, 89);
            this.Time3.Name = "Time3";
            this.Time3.Size = new System.Drawing.Size(0, 13);
            this.Time3.TabIndex = 84;
            // 
            // Time2
            // 
            this.Time2.AutoSize = true;
            this.Time2.Location = new System.Drawing.Point(464, 89);
            this.Time2.Name = "Time2";
            this.Time2.Size = new System.Drawing.Size(0, 13);
            this.Time2.TabIndex = 83;
            // 
            // Time1
            // 
            this.Time1.AutoSize = true;
            this.Time1.Location = new System.Drawing.Point(37, 89);
            this.Time1.Name = "Time1";
            this.Time1.Size = new System.Drawing.Size(0, 13);
            this.Time1.TabIndex = 82;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(1146, 12);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(85, 18);
            this.TimeLabel.TabIndex = 81;
            this.TimeLabel.Text = "TimeLabel";
            // 
            // btn_markReady1
            // 
            this.btn_markReady1.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_markReady1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_markReady1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_markReady1.Location = new System.Drawing.Point(614, 595);
            this.btn_markReady1.Name = "btn_markReady1";
            this.btn_markReady1.Size = new System.Drawing.Size(133, 42);
            this.btn_markReady1.TabIndex = 57;
            this.btn_markReady1.Text = "Meld gereed";
            this.btn_markReady1.UseVisualStyleBackColor = false;
            this.btn_markReady1.Click += new System.EventHandler(this.btn_markReady1_Click);
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Refresh_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Refresh_btn.Location = new System.Drawing.Point(1270, 12);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(60, 23);
            this.Refresh_btn.TabIndex = 56;
            this.Refresh_btn.Text = "Refresh";
            this.Refresh_btn.UseVisualStyleBackColor = false;
            this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(205, 138);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(969, 435);
            this.listView1.TabIndex = 50;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.VirtualListSize = 5;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dag";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tijd";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Naam";
            this.columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Aantal";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tafel";
            this.columnHeader9.Width = 74;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Comment";
            this.columnHeader10.Width = 200;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Status";
            this.columnHeader11.Width = 120;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(627, 11);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 19);
            this.textBox2.TabIndex = 49;
            this.textBox2.Text = "Keuken Overzicht";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(18, 11);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(71, 23);
            this.btnLogout.TabIndex = 48;
            this.btnLogout.Text = "Uitloggen";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1115, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 107;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(486, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(387, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 108;
            this.pictureBox2.TabStop = false;
            // 
            // btn_FilterNew
            // 
            this.btn_FilterNew.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_FilterNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FilterNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_FilterNew.Location = new System.Drawing.Point(1030, 89);
            this.btn_FilterNew.Name = "btn_FilterNew";
            this.btn_FilterNew.Size = new System.Drawing.Size(133, 42);
            this.btn_FilterNew.TabIndex = 109;
            this.btn_FilterNew.Text = "Filter nieuwe orders";
            this.btn_FilterNew.UseVisualStyleBackColor = false;
            this.btn_FilterNew.Click += new System.EventHandler(this.btn_FilterNew_Click);
            // 
            // KitchenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 681);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_FilterNew);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Time8);
            this.Controls.Add(this.Time7);
            this.Controls.Add(this.Time6);
            this.Controls.Add(this.Time5);
            this.Controls.Add(this.Time4);
            this.Controls.Add(this.Time3);
            this.Controls.Add(this.Time2);
            this.Controls.Add(this.Time1);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.btn_markReady1);
            this.Controls.Add(this.Refresh_btn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pictureBox2);
            this.Name = "KitchenUI";
            this.Text = "KitchenUI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Label Time8;
        private System.Windows.Forms.Label Time7;
        private System.Windows.Forms.Label Time6;
        private System.Windows.Forms.Label Time5;
        private System.Windows.Forms.Label Time4;
        private System.Windows.Forms.Label Time3;
        private System.Windows.Forms.Label Time2;
        private System.Windows.Forms.Label Time1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button btn_markReady1;
        private System.Windows.Forms.Button Refresh_btn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btn_FilterNew;
    }
}
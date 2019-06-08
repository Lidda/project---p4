namespace OrderSystemUI.MainUI
{
    partial class FinancesUI
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
            this.ListView_Finances = new System.Windows.Forms.ListView();
            this.FinancesDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FinancesIncome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BackButton = new System.Windows.Forms.Button();
            this.BTN_Monthly = new System.Windows.Forms.Button();
            this.BTN_Yearly = new System.Windows.Forms.Button();
            this.BTN_Daily = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListView_Finances
            // 
            this.ListView_Finances.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FinancesDate,
            this.FinancesIncome});
            this.ListView_Finances.GridLines = true;
            this.ListView_Finances.Location = new System.Drawing.Point(12, 12);
            this.ListView_Finances.Name = "ListView_Finances";
            this.ListView_Finances.Size = new System.Drawing.Size(440, 488);
            this.ListView_Finances.TabIndex = 0;
            this.ListView_Finances.UseCompatibleStateImageBehavior = false;
            this.ListView_Finances.View = System.Windows.Forms.View.Details;
            // 
            // FinancesDate
            // 
            this.FinancesDate.Text = "Datum";
            this.FinancesDate.Width = 335;
            // 
            // FinancesIncome
            // 
            this.FinancesIncome.Text = "Inkomsten";
            this.FinancesIncome.Width = 94;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.Window;
            this.BackButton.Location = new System.Drawing.Point(12, 624);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(93, 44);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "<";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BTN_Monthly
            // 
            this.BTN_Monthly.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BTN_Monthly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Monthly.FlatAppearance.BorderSize = 0;
            this.BTN_Monthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Monthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Monthly.ForeColor = System.Drawing.SystemColors.Window;
            this.BTN_Monthly.Location = new System.Drawing.Point(162, 516);
            this.BTN_Monthly.Name = "BTN_Monthly";
            this.BTN_Monthly.Size = new System.Drawing.Size(135, 69);
            this.BTN_Monthly.TabIndex = 7;
            this.BTN_Monthly.Text = "Maand";
            this.BTN_Monthly.UseVisualStyleBackColor = false;
            this.BTN_Monthly.Click += new System.EventHandler(this.BTN_Monthly_Click);
            // 
            // BTN_Yearly
            // 
            this.BTN_Yearly.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BTN_Yearly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Yearly.FlatAppearance.BorderSize = 0;
            this.BTN_Yearly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Yearly.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Yearly.ForeColor = System.Drawing.SystemColors.Window;
            this.BTN_Yearly.Location = new System.Drawing.Point(311, 516);
            this.BTN_Yearly.Name = "BTN_Yearly";
            this.BTN_Yearly.Size = new System.Drawing.Size(135, 69);
            this.BTN_Yearly.TabIndex = 6;
            this.BTN_Yearly.Text = "Jaar";
            this.BTN_Yearly.UseVisualStyleBackColor = false;
            this.BTN_Yearly.Click += new System.EventHandler(this.BTN_Yearly_Click);
            // 
            // BTN_Daily
            // 
            this.BTN_Daily.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BTN_Daily.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Daily.FlatAppearance.BorderSize = 0;
            this.BTN_Daily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Daily.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Daily.ForeColor = System.Drawing.SystemColors.Window;
            this.BTN_Daily.Location = new System.Drawing.Point(12, 516);
            this.BTN_Daily.Name = "BTN_Daily";
            this.BTN_Daily.Size = new System.Drawing.Size(135, 69);
            this.BTN_Daily.TabIndex = 5;
            this.BTN_Daily.Text = "Dag";
            this.BTN_Daily.UseVisualStyleBackColor = false;
            this.BTN_Daily.Click += new System.EventHandler(this.BTN_Daily_Click);
            // 
            // FinancesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 681);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.BTN_Monthly);
            this.Controls.Add(this.BTN_Yearly);
            this.Controls.Add(this.BTN_Daily);
            this.Controls.Add(this.ListView_Finances);
            this.Name = "FinancesUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financiën";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListView_Finances;
        private System.Windows.Forms.ColumnHeader FinancesDate;
        private System.Windows.Forms.ColumnHeader FinancesIncome;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button BTN_Monthly;
        private System.Windows.Forms.Button BTN_Yearly;
        private System.Windows.Forms.Button BTN_Daily;
    }
}
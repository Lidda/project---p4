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
            this.FinancesDate.Text = "Date";
            this.FinancesDate.Width = 335;
            // 
            // FinancesIncome
            // 
            this.FinancesIncome.Text = "Income";
            this.FinancesIncome.Width = 94;
            // 
            // FinancesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 681);
            this.Controls.Add(this.ListView_Finances);
            this.Name = "FinancesUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinancesUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListView_Finances;
        private System.Windows.Forms.ColumnHeader FinancesDate;
        private System.Windows.Forms.ColumnHeader FinancesIncome;
    }
}
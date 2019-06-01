using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderSystemModel;
using OrderSystemLogic;

namespace OrderSystemUI.MainUI
{
    public partial class FinancesUI : Form
    {
        FinancesLogic financesLogic = new FinancesLogic();

        public FinancesUI()
        {
            InitializeComponent();
            LoadDailyProfit();
        }

        private void LoadDailyProfit()
        {
            List<Profit> FinanceListView = financesLogic.GetAllFinances();

            ListView_Finances.Items.Clear();

            foreach (Profit day in FinanceListView)
            {
                ListViewItem li = new ListViewItem(day.date.ToString("dd/MM/yyyy"));
                li.SubItems.Add(string.Format("€{0:N2}", day.DayIncome));
                ListView_Finances.Items.Add(li);
            }
        }

        private void LoadMonthlyProfit()
        {
            List<Profit> FinanceListView = financesLogic.MonthlyProfit();

            ListView_Finances.Items.Clear();

            foreach (Profit day in FinanceListView)
            {
                ListViewItem li = new ListViewItem(day.date.ToString("MM/yyyy"));
                li.SubItems.Add(string.Format("€{0:N2}", day.DayIncome));
                ListView_Finances.Items.Add(li);
            }
        }

        private void LoadYearlyProfit()
        {
            List<Profit> FinanceListView = financesLogic.YearlyProfit();

            ListView_Finances.Items.Clear();

            foreach (Profit day in FinanceListView)
            {
                ListViewItem li = new ListViewItem(day.date.ToString("yyyy"));
                li.SubItems.Add(string.Format("€{0:N2}", day.DayIncome));
                ListView_Finances.Items.Add(li);
            }
        }

        private void BTN_Monthly_Click(object sender, EventArgs e)
        {
            LoadMonthlyProfit();
        }

        private void BTN_Yearly_Click(object sender, EventArgs e)
        {
            LoadYearlyProfit();
        }
    }
}

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
        OrderLogic orderLogic = new OrderLogic();
        Employee loggedInEmployee;

        public FinancesUI(Employee loggedInEmployee)
        {
            this.loggedInEmployee = loggedInEmployee;
            InitializeComponent();
            LoadDailyProfit();
            BTN_Daily.BackColor = Color.FromArgb(6, 69, 170);
        }

        //Shows all order income per day
        private void LoadDailyProfit()
        {
            List<Profit> FinanceListView = orderLogic.DailyProfit();

            ListView_Finances.Items.Clear();

            foreach (Profit day in FinanceListView)
            {
                ListViewItem li = new ListViewItem(day.date.ToString("dd/MM/yyyy"));
                li.SubItems.Add(string.Format("€{0:N2}", day.DayIncome));
                ListView_Finances.Items.Add(li);
            }
        }

        //Shows all order income per month
        private void LoadMonthlyProfit()
        {
            List<Profit> FinanceListView = orderLogic.MonthlyProfit();

            ListView_Finances.Items.Clear();

            foreach (Profit month in FinanceListView)
            {
                ListViewItem li = new ListViewItem(month.date.ToString("MM/yyyy"));
                li.SubItems.Add(string.Format("€{0:N2}", month.DayIncome));
                ListView_Finances.Items.Add(li);
            }
        }

        //Shows all order income per year
        private void LoadYearlyProfit()
        {
            List<Profit> FinanceListView = orderLogic.YearlyProfit();

            ListView_Finances.Items.Clear();

            foreach (Profit year in FinanceListView)
            {
                ListViewItem li = new ListViewItem(year.date.ToString("yyyy"));
                li.SubItems.Add(string.Format("€{0:N2}", year.DayIncome));
                ListView_Finances.Items.Add(li);
            }
        }

        private void ResetButtonColour()
        {
            BTN_Monthly.BackColor = SystemColors.MenuHighlight;
            BTN_Daily.BackColor = SystemColors.MenuHighlight;
            BTN_Yearly.BackColor = SystemColors.MenuHighlight;
        }

        private void BTN_Monthly_Click(object sender, EventArgs e)
        {
            ResetButtonColour();
            BTN_Monthly.BackColor = Color.FromArgb(6, 69, 170);
            LoadMonthlyProfit();
        }

        private void BTN_Yearly_Click(object sender, EventArgs e)
        {
            ResetButtonColour();
            BTN_Yearly.BackColor = Color.FromArgb(6, 69, 170);
            LoadYearlyProfit();
        }

        private void BTN_Daily_Click(object sender, EventArgs e)
        {
            ResetButtonColour();
            BTN_Daily.BackColor = Color.FromArgb(6, 69, 170);
            LoadDailyProfit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerUI managerUI = new ManagerUI(loggedInEmployee);
            managerUI.ShowDialog();
        }
    }
}

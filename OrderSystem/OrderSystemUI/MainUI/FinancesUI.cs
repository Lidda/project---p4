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
            LoadListView();
        }

        private void LoadListView()
        {
            List<DailyProfit> FinanceListView = financesLogic.GetAllFinances();

            ListView_Finances.Items.Clear();

            foreach (DailyProfit day in FinanceListView)
            {
                ListViewItem li = new ListViewItem(day.date.ToString("dd/MM/yyyy"));
                li.SubItems.Add(string.Format("€{0:N2}", day.DayIncome));
                ListView_Finances.Items.Add(li);
            }
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class OfflineTransactionRecorderForm : Form
    {

        TransactionMain transaction = new TransactionMain();
        public OfflineTransactionRecorderForm()
        {
            InitializeComponent();
            this.transaction_grid.Visible = false;
            this.input_sms_textbox.TextChanged += Input_sms_textbox_TextChanged;
        }

        private void Input_sms_textbox_TextChanged(object sender, EventArgs e)
        {
            this.add_notification_label.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.transaction_grid.DataSource = this.notifyModelClassBindingSource1;
            transaction_grid = transaction.ShowTransaction(transaction_grid);
            if (transaction_grid.RowCount > 0 && transaction_grid.Rows[0].Cells[0].Value == null || transaction_grid.RowCount == 0)
            {
                this.showdata_notification_label.Visible = true;
                this.showdata_notification_label.Text = "*No Data Added";
                this.showdata_notification_label.ForeColor = Color.DarkRed;
            }
            else
            {
                this.showdata_notification_label.Visible = false;
                this.transaction_grid.Visible = true;
            }
            this.transaction_grid.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var val = input_sms_textbox.Text;
            if (!string.IsNullOrEmpty(val))
            {
                transaction.ParseAndAddTransaction(val);
                input_sms_textbox.Clear();
                this.add_notification_label.Text = "*Data Added Successfully!!";
                this.add_notification_label.Visible = true;
                this.add_notification_label.ForeColor = Color.DarkGreen;
            }
            else
            {
                this.add_notification_label.Text = "*Please add transaction message and hit Add";
                this.add_notification_label.Visible = true;
                this.add_notification_label.ForeColor = Color.DarkRed;
            }
        }

        private void delete_transaction_button_Click(object sender, EventArgs e)
        {
            transaction_grid = transaction.ShowTransaction(transaction_grid);
            if (transaction_grid.RowCount > 0 && transaction_grid.Rows[0].Cells[0].Value != null)
            {
                transaction.DeleteTransactionHistory();
                transaction_grid.Hide();
                this.transaction_grid.DataSource = null;
                this.showdata_notification_label.Text = "*Transaction has been deleted successfully!!";
            }
            else
            {
                this.showdata_notification_label.Text = "*No Transaction data to delete";
            }
            this.showdata_notification_label.Visible = true;
            this.showdata_notification_label.ForeColor = Color.DarkRed;
            this.transaction_grid.Refresh();
        }
    }
}

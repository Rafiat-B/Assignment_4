using Ass_4.Models.Entities;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass_4
{
    public partial class Account_Details_Form : Form
    {
        private int _userId;
        ASSN4DBContext _context = new ASSN4DBContext();
        public Account_Details_Form( int Id)
        {
            InitializeComponent();
            _userId = Id;
        }

        private void Account_Details_Form_Load(object sender, EventArgs e)
        {
            GetAccountDetails(_userId);
        }
        public void GetAccountDetails(int userId)
        {
            Account userAccount = null;
            using (var context = new ASSN4DBContext())
            {
                userAccount = context.Accounts.SingleOrDefault(a => a.UserId == userId);
            }

            if (userAccount != null)
            {
                // Update UI elements with account details
                txt_UserId.Text = userAccount.UserId.ToString();
                txt_AccountId.Text = userAccount.AccountId.ToString();
                txt_AcctType.Text = userAccount.AccountType.ToString();
                txt_CurBal.Text = userAccount.CurrentBalance.ToString();
                DateTime dateTime = DateTime.Now;
            }
            else
            {
                MessageBox.Show("No account found for the given user ID.");
            }
        }

        private void Btn_TransH_Click(object sender, EventArgs e)
        {
            int accountId = GetAccountIdFromUI();
            TransactionForm transactionForm = new TransactionForm(accountId);
            transactionForm.ShowDialog();
        }
        public int GetAccountIdFromUI()
        {
            // Assuming accountIdTextBox is the TextBox control displaying the Account ID
            int accountId;
            if (int.TryParse(txt_AccountId.Text, out accountId))
            {
                return accountId;
            }
            else
            {
                // Handle the case where the Account ID is not a valid integer
                // For example, display an error message or return a default value
                MessageBox.Show("Invalid Account ID.");
                return -1; // or any other default value indicating an error
            }
        }
        public void UpdateCurrentBalanceTextBox(double currentBalance)
        {
            // Update current balance with new value
            txt_CurBal.Text = currentBalance.ToString();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }
    }
}

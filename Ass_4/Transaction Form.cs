using Ass_4.Models.Entities;
using Microsoft.Identity.Client.NativeInterop;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;
using Microsoft.EntityFrameworkCore;

namespace Ass_4
{
    public partial class TransactionForm : Form
    {
        private int _accountId;
        ASSN4DBContext _context = new ASSN4DBContext(); //this object is used for update only
        public TransactionForm(int accountId)
        {
            _accountId = accountId;
            InitializeComponent();
            txt_AcctId2.Text = accountId.ToString();
            RefreshTransactionHistory(accountId);
        }
        public void RefreshTransactionHistory(int accountId)
        {
            using (var context = new ASSN4DBContext())
            {
                var transactions = context.TransactionHistories.Where(t => t.AccountId == accountId).ToList();
                dvgTransH.DataSource = transactions;
            }
            //int accountId1 = _accountId;
            //dvgTransH.DataSource = GetTransactionHistory(accountId1);
            //ASSN4DBContext _context = new ASSN4DBContext();
            //var account = _context.TransactionHistories.ToList();
            //dvgTransH.DataSource = account;
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {

        }
        public List<TransactionHistory> GetTransactionHistory(int accountId)
        {
            using (var context = new ASSN4DBContext())
            {
                return context.TransactionHistories.Where(t => t.AccountId == accountId).ToList();
            }
        }

        public void btn_AddTrans_Click(object sender, EventArgs e)
        {
            int accountId = _accountId;
            
            decimal amount; decimal.TryParse(txt_Amount.Text, out amount);
            string description = txt_Desc.Text;
            DateTime date = DateTime.Now;
            AddTransaction(accountId, amount, description, date);
            RefreshTransactionHistory(accountId);
            _context.SaveChanges();

            MessageBox.Show("Added Successfully!");
        }
        public void AddTransaction(int accountId, decimal amount, string description, DateTime date)
        {
            using (var context = new ASSN4DBContext())
            {
                var transaction = new TransactionHistory
                {
                    AccountId = accountId,
                    Amount = amount,
                    Description = description,
                    TransactionDate = DateTime.Now
                };

                context.TransactionHistories.Add(transaction);

                // Update account balance
                var account = context.Accounts.Find(accountId);
                account.CurrentBalance += (double)amount;

                context.SaveChanges();
                DisplayUpdateddetails((double)account.CurrentBalance);
                RefreshTransactionHistory(accountId);
            }
        }
        private void DisplayUpdateddetails(double currentBalance)
        {
            Account_Details_Form accountDetails = Application.OpenForms.OfType<Account_Details_Form>().FirstOrDefault();
            if (accountDetails != null)
            {
                accountDetails.UpdateCurrentBalanceTextBox(currentBalance);

            }
        }

        private void btn_UpdateTrans_Click(object sender, EventArgs e)
        {
            // Check if any row is selected in the DataGridView
            if (dvgTransH.SelectedRows.Count > 0)
            {
                var selectedTransaction = dvgTransH.SelectedRows[0].DataBoundItem as TransactionHistory;
                decimal oldAmount = (decimal)selectedTransaction.Amount;
                decimal newAmount;
                if (!decimal.TryParse(txt_Amount.Text, out newAmount))
                {
                    MessageBox.Show("Invalid amount");
                    return;
                }
                //string descriprion = txt_Desc.Text;
                //DateTime transDate = DateTime.Now;
                decimal difference = newAmount - oldAmount;
                selectedTransaction.TransactionDate = DateTime.Now;
                selectedTransaction.Amount = newAmount;
                selectedTransaction.Description = txt_Desc.Text;

                try
                {
                    _context.SaveChanges(); //Save changes to database
                    
                    var account = _context.Accounts.Find(_accountId);
                    if (account != null)
                    {
                        account.CurrentBalance += (double)difference;
                        _context.SaveChanges();
                        DisplayUpdateddetails((double)account.CurrentBalance);
                        _context.TransactionHistories.Update(selectedTransaction);
                        _context.SaveChanges(true);
                    }
                    RefreshTransactionHistory(_accountId);
                    MessageBox.Show("Updated Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a transaction to update", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        private void btn_DelTrans_Click(object sender, EventArgs e)
        {
            int accountId = _accountId;
            decimal amount; decimal.TryParse(txt_Amount.Text, out amount);
            string description = txt_Desc.Text;
            DateTime date = DateTime.Now;
            DeleteTransaction(accountId, amount, description, date);
            RefreshTransactionHistory(accountId);
        }
        public void DeleteTransaction(int accountId, decimal amount, string description, DateTime date)
        {
            using (var context = new ASSN4DBContext())
            {
                var transaction = new TransactionHistory
                {
                    AccountId = accountId,
                    Amount = amount,
                    Description = description,
                    TransactionDate = DateTime.Now
                };

                context.TransactionHistories.Add(transaction);

                // Update account balance
                var account = context.Accounts.Find(accountId);
                account.CurrentBalance -= (double)amount;

                context.SaveChanges();
                DisplayUpdateddetails((double)account.CurrentBalance);
                RefreshTransactionHistory(accountId);
                MessageBox.Show("Deleted Successfully!");
            }
        }

        private void btn_Ex_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

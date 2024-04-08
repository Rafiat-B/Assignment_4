using Ass_4.Models.Entities;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            int Id; int.TryParse(txt_UserId.Text, out Id);
            string Email = txt_UserId.Text;
            string Password = txt_Password.Text;

            ASSN4DBContext _context = new ASSN4DBContext();
            var checkUser = _context.Users.FirstOrDefault(x => (x.Id == Id || x.Email == Email));
            if (checkUser == null)
            {
                MessageBox.Show("User does not exist", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if  (checkUser.Password != Password )
            {
                MessageBox.Show("Incorrect password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                this.Hide();
                DialogResult result = MessageBox.Show("Login Successful", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(result == DialogResult.OK)
                {
                    Account_Details_Form acctDet = new Account_Details_Form(Id);
                    acctDet.Show();

                }

            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}

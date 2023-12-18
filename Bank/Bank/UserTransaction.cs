using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class UserTransaction : Form
    {
        private string personalNumberSelected;
        public UserTransaction(string personalNumberSelected)
        {
            InitializeComponent();
            this.personalNumberSelected = personalNumberSelected;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserTransaction_Load(object sender, EventArgs e)
        {
            string jsonUsers = File.ReadAllText("User.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonUsers);

            dataGridView1.Columns.Add("UserName", "User Name");
            dataGridView1.Columns.Add("PersonalNumber", "Personal Number");
            dataGridView1.Columns.Add("AccountNumber", "Account Number");
            dataGridView1.Columns.Add("Balance", "Balance");
            dataGridView1.Columns.Add("TransactionType", "Type");
            dataGridView1.Columns.Add("Amount", "Amount Transfer");
            dataGridView1.Columns.Add("Transaction", "Reciever");
            dataGridView1.Columns.Add("OperationDate", "Operation Date");

            foreach (var user in users)
            {
                
                if (user.PersonalNumber == personalNumberSelected)
                {
                    foreach (var account in user.Accounts)
                    {
                        foreach (var transaction in account.Transactions)
                        {
                            
                            dataGridView1.Rows.Add(user.Name, user.PersonalNumber, account.AccountNumber, account.Balance, transaction.Type, transaction.Amount, transaction.ReceiverAccountNumber, transaction.OperationDate);
                        }
                    }
                }
            }
        }
    }
}

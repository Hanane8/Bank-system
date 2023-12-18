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
    public partial class AdminAccount : Form
    {
        private List<User> users = new List<User>();
        private List<Account> accounts;
        public AdminAccount()
        {
            InitializeComponent();

        }

        private void AdminAccount_Load(object sender, EventArgs e)
        {
            string jsonUsers = File.ReadAllText("User.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonUsers);
            users = users.OrderBy(u => u.PersonalNumber).ToList();

            dataGridView1.Columns.Add("UserName", "User Name");
            dataGridView1.Columns.Add("PersonalNumber", "Personal Number");
            dataGridView1.Columns.Add("AccountNumber", "Account Number");
            dataGridView1.Columns.Add("Balance", "Balance");
            dataGridView1.Rows.Clear();

            foreach (var user in users)
            {
                foreach (var account in user.Accounts)
                {

                    dataGridView1.Rows.Add(user.Name, user.PersonalNumber, account.AccountNumber, account.Balance);
                    
                }
            }

        }

        private void btnsChange_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string personalNumberToUpdate = selectedRow.Cells["PersonalNumber"].Value.ToString();

                Change_information changeInformation = new Change_information(personalNumberToUpdate);
                changeInformation.ShowDialog();

            }
            else
            {
                Console.WriteLine("Ingen användare är vald för ändringar.");
            }
        }

        private void btntransak_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string personalNumberSelected = selectedRow.Cells["PersonalNumber"].Value.ToString();

                UserTransaction userTransactionForm = new UserTransaction(personalNumberSelected);
                userTransactionForm.ShowDialog();

            }
            else
            {
                Console.WriteLine("Please select a row in the DataGridView first.");
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string personalNumberToDelete = selectedRow.Cells["PersonalNumber"].Value.ToString();


                string jsonUsers = File.ReadAllText("User.json");
                List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonUsers);

                User userToRemove = users.FirstOrDefault(u => u.PersonalNumber == personalNumberToDelete);


                if (userToRemove != null)
                {
                    users.Remove(userToRemove);
                    Console.WriteLine($"Användaren med personnummer {personalNumberToDelete} har tagits bort.");

                    string updatedJsonUsers = JsonConvert.SerializeObject(users, Formatting.Indented);
                    File.WriteAllText("User.json", updatedJsonUsers);

                    dataGridView1.Rows.Remove(selectedRow);
                }
                else
                {
                    Console.WriteLine($"Kunde inte hitta användaren med personnummer {personalNumberToDelete}.");
                }
            }
            else
            {
                Console.WriteLine("Ingen användare är vald för borttagning.");
            }

        }
    }


}

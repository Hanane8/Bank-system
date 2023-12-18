using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bank
{
    public partial class UserAccount : Form
    {
        private List<User> users = new List<User>();
        private User loggedInUser;
        private List<Account> accounts;
        public UserAccount(User loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
            LoadUsers();
            DisplayUsers();

        }

        private void LoadUsers()
        {
            if (File.Exists("User.json"))
            {
                string jsonUsers = File.ReadAllText("User.json");
                users = System.Text.Json.JsonSerializer.Deserialize<List<User>>(jsonUsers);
            }
        }
        private void UpdateUserFile()
        {
            try
            {                
                string jsonUsers = JsonConvert.SerializeObject(users, Formatting.Indented);
                File.WriteAllText("User.json", jsonUsers);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user data file: {ex.Message}");
            }
        }

        public void DisplayUsers()
        {
            try
            {

                var userinloggad = users.Where(user => user.PersonalNumber == loggedInUser.PersonalNumber);

                List<Account> accounts = new List<Account>();

                foreach (var user in userinloggad)
                {
                    accounts.AddRange(user.Accounts);
                }


                dataGridView1.DataSource = accounts;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fel vid uppdatering av DataGridView: {ex.Message}");
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedAccountNumber = comboBox1.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(selectedAccountNumber))
                {
                    decimal depositAmount = decimal.Parse(textBox2.Text);

                    loggedInUser = users.FirstOrDefault(user => user.PersonalNumber == loggedInUser.PersonalNumber && user.Password == loggedInUser.Password);

                    if (loggedInUser != null)
                    {
                        foreach (var user in users)
                        {
                            if (user.PersonalNumber == loggedInUser.PersonalNumber)
                            {
                                foreach (var account in user.Accounts)
                                {
                                    if (account.AccountNumber == selectedAccountNumber)
                                    {
                                        account.Balance += depositAmount;
                                        Transaction newDeposit = new Transaction("Deposit", depositAmount, DateTime.Now, null, null, null);
                                        account.Transactions.Add(newDeposit);
                                        break; 
                                    }
                                }
                            }
                        }
                        UpdateUserFile();
                        DisplayUsers();

                        MessageBox.Show($" Deposit to Account {selectedAccountNumber} done.");
                    }
                    else
                    {
                        MessageBox.Show("Inloggade användaren hittades inte.");
                    }
                }
                else
                {
                    MessageBox.Show("Välj ett kontonummer från listan.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel inträffade: {ex.Message}");
            }
        }
        private void accountBindingSource_CurrentChanged(string? valtKonto)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string valtKonto = comboBox1.SelectedValue.ToString();

                accountBindingSource_CurrentChanged(valtKonto);
            }
        }
        private void LoadComboBoxes()
        {
            try
            {
                string jsonUsers = File.ReadAllText("User.json");
                List<User> allUsers = JsonConvert.DeserializeObject<List<User>>(jsonUsers);

                var usersWithSamePersonalNumber = allUsers.Where(user => user.PersonalNumber == loggedInUser.PersonalNumber);

                List<string> accountNumbers = new List<string>();
                foreach (var user in usersWithSamePersonalNumber)
                {
                    accountNumbers.AddRange(user.Accounts.Select(account => account.AccountNumber));
                }

                comboBox1.DataSource = accountNumbers;
                comboBox2.DataSource = accountNumbers;
                comboBox3.DataSource = accountNumbers;

                comboBox1.DisplayMember = "AccountNumber";
                comboBox2.DisplayMember = "AccountNumber";
                comboBox3.DisplayMember = "AccountNumber";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading account numbers: {ex.Message}");
            }
        }

        
        private void UserAccount_Load(object sender, EventArgs e)
        {

            LoadComboBoxes();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedAccountNumber = comboBox2.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedAccountNumber))
                {
                    MessageBox.Show("Välj ett kontonummer från listan.");
                    return;
                }

                if (!decimal.TryParse(textBox1.Text, out decimal withdrawAmount))
                {
                    MessageBox.Show("Ange en giltig summa.");
                    return;
                }

                loggedInUser = users.FirstOrDefault(user => user.PersonalNumber == loggedInUser.PersonalNumber && user.Password == loggedInUser.Password);

                if (loggedInUser == null)
                {
                    MessageBox.Show("Inloggade användaren hittades inte.");
                    return;
                }

                var userAccounts = users.Where(user => user.PersonalNumber == loggedInUser.PersonalNumber)
                                        .SelectMany(user => user.Accounts);

                var accountToWithdraw = userAccounts.FirstOrDefault(account => account.AccountNumber == selectedAccountNumber);

                if (accountToWithdraw != null)
                {
                    accountToWithdraw.Balance -= withdrawAmount;


                    Transaction newWithdrawal = new Transaction("Withdrawal", withdrawAmount, DateTime.Now, null, null, null);
                    accountToWithdraw.Transactions.Add(newWithdrawal);


                    UpdateUserFile();
                    DisplayUsers();
                    MessageBox.Show($"Uttag från konto {selectedAccountNumber} genomfört.");
                }
                else
                {
                    MessageBox.Show($"Kontonummer {selectedAccountNumber} hittades inte för användaren.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel inträffade: {ex.Message}");
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                string valtKonto = comboBox2.SelectedValue.ToString();
                accountBindingSource_CurrentChanged(valtKonto);
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedAccountNumber = comboBox3.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(selectedAccountNumber))
                {
                    string receiverAccountNumber = textBox3.Text;
                    string ocrNumber = textBox4.Text;
                    decimal paymentAmount = decimal.Parse(textBox5.Text);
                    DateTime paymentOperationDate = dateTimePicker1.Value;


                    loggedInUser = users.FirstOrDefault(user => user.PersonalNumber == loggedInUser.PersonalNumber && user.Password == loggedInUser.Password);

                    if (loggedInUser != null)
                    {
                        foreach (var user in users)
                        {
                            if (user.PersonalNumber == loggedInUser.PersonalNumber)
                            {
                                foreach (var account in user.Accounts)
                                {
                                    if (account.AccountNumber == selectedAccountNumber)
                                    {

                                        account.MakePayment(receiverAccountNumber, ocrNumber, paymentAmount, paymentOperationDate);
                                        break;
                                    }
                                }
                            }
                        }

                        UpdateUserFile();
                        DisplayUsers();
                        MessageBox.Show($"Payment of {paymentAmount} made to {receiverAccountNumber} with OCR: {ocrNumber}");

                    }
                    else
                    {
                        MessageBox.Show("Inloggade användaren hittades inte.");
                    }

                }
                else
                {
                    MessageBox.Show("Välj ett kontonummer från listan.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel inträffade: {ex.Message}");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem != null)
            {
                string valtKonto = comboBox3.SelectedValue.ToString();
                accountBindingSource_CurrentChanged(valtKonto);
            }
        }

    }
}

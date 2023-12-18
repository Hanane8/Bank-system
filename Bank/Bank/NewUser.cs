using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bank
{
    public partial class NewUser : Form
    {
        List<User> users = new List<User>();

        public NewUser()
        {
            InitializeComponent();

            LoadUsersFromFile();

        }

        private void LoadUsersFromFile()
        {
            if (!File.Exists("User.json"))
            {
                MessageBox.Show("JSON-filen finns inte. En ny fil kommer skapas.");
                File.Create("User.json").Close();
            }
            else
            {
                try
                {
                    string jsonUsers = File.ReadAllText("User.json");

                    users = JsonSerializer.Deserialize<List<User>>(jsonUsers);
                    MessageBox.Show("Användare inlästa från fil.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fel vid inläsning av användare från fil: {ex.Message}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                string password = textBox2.Text;
                string email = textBox3.Text;
                string personalNumber = textBox4.Text;
                UserRole userRole = (UserRole)Enum.Parse(typeof(UserRole), comboBox1.Text);

                User newUser = new User(name, password, email, personalNumber, userRole);

                if (userRole == UserRole.User)
                {
                   
                    string accountNumber = Account.GenerateAccountNumber(users);
                    decimal initialBalance = 0;

                    Account newAccount = new Account(accountNumber, initialBalance);

                    newUser.Accounts.Add(newAccount);
                }
                else
                {
                    MessageBox.Show("Admin users cannot have accounts.");
                }

                users.Add(newUser);
                string jsonUsers = JsonSerializer.Serialize(users);
                File.WriteAllText("User.json", jsonUsers);
                MessageBox.Show("Användare sparade till fil.");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                comboBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel inträffade: {ex.Message}");
            }
        }
    }
}

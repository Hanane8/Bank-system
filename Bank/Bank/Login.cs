using Microsoft.VisualBasic.ApplicationServices;
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
using Newtonsoft.Json;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bank
{

    public partial class Login : Form
    {
        private List<User> users = new List<User>();

        public Login()
        {
            InitializeComponent();
            LoadUsers();
        }
        private void LoadUsers()
        {
            try
            {

                string jsonFile = "user.json";
                string jsonContent = File.ReadAllText(jsonFile);
                users = JsonConvert.DeserializeObject<List<User>>(jsonContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel inträffade vid inläsning av användardata: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewUser newUser = new NewUser();
            newUser.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string personalNumber = textBox1.Text.Trim();
                string password = textBox2.Text.Trim();


                User loggedInUser = users.FirstOrDefault(user => user.PersonalNumber == personalNumber && user.Password == password);

                if (loggedInUser != null)
                {

                    MessageBox.Show($"Inloggning lyckades för {loggedInUser.Name}");

                    if (loggedInUser.Role == UserRole.Admin)
                    {
                        AdminAccount adminAccount = new AdminAccount();
                        adminAccount.ShowDialog();
                       
                    }
                    else
                    {

                        UserAccount userAccount = new UserAccount(loggedInUser);
                        userAccount.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Felaktigt användarnamn eller lösenord. Försök igen.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel inträffade: {ex.Message}");
            }

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }
    }

}

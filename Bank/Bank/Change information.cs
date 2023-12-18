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
    public partial class Change_information : Form
    {
        private string personalNumber;
        public Change_information(string personalNumber)
        {
            InitializeComponent();
            this.personalNumber = personalNumber;

            LoadUserData();
        }
        private void LoadUserData()
        {
            string jsonUsers = File.ReadAllText("User.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonUsers);

            User userToUpdate = users.FirstOrDefault(u => u.PersonalNumber == personalNumber);

            if (userToUpdate != null)
            {
                textBox1.Text = userToUpdate.Password;
                textBox2.Text = userToUpdate.Email;
            }
            else
            {
                Console.WriteLine($"Kunde inte hitta användaren med personnummer {personalNumber}.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newPassword = textBox1.Text;
            string newEmail = textBox2.Text;

            string jsonUsers = File.ReadAllText("User.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonUsers);

            User userToUpdate = users.FirstOrDefault(u => u.PersonalNumber == personalNumber);

            if (userToUpdate != null)
            {
                userToUpdate.Password = newPassword;
                userToUpdate.Email = newEmail;

                string updatedJsonUsers = JsonConvert.SerializeObject(users, Formatting.Indented);
                File.WriteAllText("User.json", updatedJsonUsers);

                this.Close();
            }
            else
            {
                Console.WriteLine($"Kunde inte hitta användaren med personnummer {personalNumber}.");
            }
        }
    }
    
}

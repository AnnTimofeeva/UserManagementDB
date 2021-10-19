using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UserManagementDB;

namespace UserManagementDB
{
    public partial class LoginForm : Form
    {
        public LoginForm()

        {

            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // Create database connection
            DBConnection db = new DBConnection("localhost", "usermanagement", "csharp", "password");

            if (!db.OpenConnection())
                return;

            // Get list of users
            UsersDB usersDB = new UsersDB();

            List<User> userList = usersDB.GetUsers(db);

            bool foundEmail = false;
            bool passwordCorrect = false;
            User userFound = null;

            // Check email address and password

            foreach (User user in userList)
            {
                // Check email address exists

                if (this.textBoxEmail.Text == user.Email)
                {
                    foundEmail = true;

                    // Check password
                    if (this.textBoxPassword.Text == user.Password)
                    {
                        passwordCorrect = true;
                        userFound = user;
                    }

                    break;
                }
            }

            if (foundEmail == true && passwordCorrect == true)
            {
                this.Visible = false;

                ViewUsersForm viewUsersForm = new ViewUsersForm(db, userFound);
                viewUsersForm.ShowDialog();

                this.Visible = true;
            }
            else if (foundEmail == true && passwordCorrect == false)
            {
                // Case 2
                MessageBox.Show("Incorrect password. Please try again.\n\n(Your password can be reset by contacting the I.T. department.)", "Password incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Case 3
                MessageBox.Show($"The user: {this.textBoxEmail.Text} does not exist. Please try again.\n\n(If problems persist, please contact the I.T. department.)", "User not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            db.CloseConnection();

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClearEmail_Click(object sender, EventArgs e)
        {
            this.textBoxEmail.Text = "";
        }

        private void buttonClearPassword_Click(object sender, EventArgs e)
        {
            this.textBoxPassword.Text = "";
        }

        //reveal password (show hidden password)
        private void checkBoxRevealPassword_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxRevealPassword.Checked == true)
            {
                textBoxPassword.PasswordChar = char.MinValue;
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.SetToolTip(this.textBoxEmail, "Please, enter your email");
            toolTip.SetToolTip(this.textBoxPassword, "Please, enter your password");
            toolTip.SetToolTip(this.checkBoxRevealPassword, "Click to reveal password");
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to User Management Application! Please provide your credentials and press Login button to start working","Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }    
}
using System;
using System.IO;
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
    public partial class ViewUsersForm : Form
    {
        User currentUser = null;
        DBConnection db = null;

        public ViewUsersForm(DBConnection db, User currentUser)
        {
            InitializeComponent();

            this.currentUser = currentUser;
            this.db = db;
        }
        //when Form loads, list box populates with users from DB, loggedin user marks as selected and user details displays on the right side
        private void ViewUsersForm_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.SetToolTip(this.textBoxEmail, "Please, enter user email");
            toolTip.SetToolTip(this.textBoxName, "Please, enter user name");
            toolTip.SetToolTip(this.buttonExit, "Please, press to exit");
            toolTip.SetToolTip(this.buttonLogout, "Please, press to log out");
            toolTip.SetToolTip(this.buttonEdit, "Please, press to edit user's details");
            toolTip.SetToolTip(this.buttonDelete, "Please, press to delete selected user");
            toolTip.SetToolTip(this.buttonAdd, "Please, press to add new user");

            RefreshList();

            // Select the currently logged in user listbox and highlight details 
            this.listBoxUsersList.SelectedIndex = IndexOfUser(this.currentUser);

            RefreshUserDetails(this.listBoxUsersList.SelectedItem as User);
            RefreshControls(this.listBoxUsersList.SelectedItem as User);
            RefreshLoggedInUserDetails();
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            User user = this.listBoxUsersList.SelectedItem as User;
            string mode="";
            //User can edit his own details except admin checkbox, thats why we need separete modes foe editing
            if (this.currentUser.IsAdmin) 
            {
                mode = "editAdmin"; 
            }
            else
            {
                mode = "editUser"; 
            }
             AddEditUserForm editUserForm = new AddEditUserForm(this.db, user, mode);
            
            editUserForm.ShowDialog();
            RefreshList();
            this.listBoxUsersList.SelectedIndex = IndexOfUser(editUserForm.editUser);
            //if user updated his own info we need to refresh logged in user details on th top of the screen 
            if (editUserForm.editUser.Email == currentUser.Email)
            {
                currentUser = editUserForm.editUser;
                RefreshLoggedInUserDetails();
            }
            



        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddEditUserForm editUserForm = new AddEditUserForm(this.db, "add");
            editUserForm.ShowDialog();
            
            if (editUserForm.addedUser != null)
            {
                RefreshList();
                this.listBoxUsersList.SelectedIndex = IndexOfUser(editUserForm.addedUser);
            }

            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            User user = this.listBoxUsersList.SelectedItem as User;

            DialogResult result = MessageBox.Show($"You are about to delete the user:\n\n{user.Name}\n{user.Email}\n\nAre you sure?",
                                                   "Email address exists",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                UsersDB usersDB = new UsersDB();
                usersDB.Delete(this.db, user.Email);

                RefreshList();

                if (this.listBoxUsersList.Items.Count > 0)
                {
                    this.listBoxUsersList.SelectedIndex = 0;
                }
            }
        }

        private int IndexOfUser(User user)
        {
            bool emailMatches = false;
            int index = this.listBoxUsersList.FindString(user.Name);

            while (emailMatches == false)
            {
                if (index >= 0)
                {
                    User candidate = this.listBoxUsersList.Items[index] as User;
                    if (user.Email == candidate.Email)
                    {
                        emailMatches = true;
                    }
                    else
                    {
                        index = this.listBoxUsersList.FindString(user.Name, index);
                    }
                }
                else
                {
                    return -1;
                }
            }

            return index;

        }

        private void RefreshList()
        {
            // Get list of users
            UsersDB usersDB = new UsersDB();

            List<User> userList = usersDB.GetUsers(db);

            this.listBoxUsersList.Items.Clear();
            this.listBoxUsersList.Items.AddRange(userList.ToArray());
        }

        // Populate the User Details fields given a User object.

        private void RefreshUserDetails(User user)
        {
            // Update fields on form with data from user
            this.textBoxEmail.Text = user.Email;
            this.textBoxName.Text = user.Name;
            this.textBoxPhone.Text = user.Phone;
            this.textboxgroups.Text = user.Group;
            this.checkBoxAdministrator.Checked = user.IsAdmin;

            string imageFilePath = user.Image;

            if (!File.Exists(imageFilePath))
            {
                imageFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "default_user_image.jpg");
            }
            Image userImage = Image.FromFile(imageFilePath);
            this.pictureBoxUserImage.Image = userImage;

            // If user image is larger than PictureBox, then Zoom out,
            // otherwise, center the image in the frame
            if (userImage.Width > pictureBoxUserImage.ClientSize.Width ||
                userImage.Height > pictureBoxUserImage.ClientSize.Height)
            {
                this.pictureBoxUserImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                this.pictureBoxUserImage.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }
         
        private void RefreshControls(User selectedUser)
        {
            if (this.currentUser.IsAdmin)
            {
                this.buttonAdd.Enabled = true;
                this.buttonDelete.Enabled = true;
                this.buttonEdit.Enabled = true;
            }
            else
            {
                this.buttonAdd.Enabled = false;
                this.buttonDelete.Enabled = false;
                this.buttonEdit.Enabled = false;
            }

            // User can always edit their own details, but not delete their own profile

            if (selectedUser.Email == this.currentUser.Email)
            {
                this.buttonEdit.Enabled = true;
                this.buttonDelete.Enabled = false;
            }
        }

        private void RefreshLoggedInUserDetails()
        {
            string admin = " (User)";
            if (this.currentUser.IsAdmin)
            {
                admin = " (Admin)";
            }

            this.labelCurrentUser.Text = $"You are logged in as  {this.currentUser.Name}{admin}";
           
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            User selectedUser = this.listBoxUsersList.SelectedItem as User;

            RefreshUserDetails(selectedUser);
            RefreshControls(selectedUser);

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Would you like to logout?",
                                                   "Logout",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {        
            MessageBox.Show("Please select a user from the Users list to display that user's details in the panel of the main screen.Delete user option allows to delete selected user from database.After pressing Edit or  Add user button app will display  Add / Edit user screen.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
        }
    }
}
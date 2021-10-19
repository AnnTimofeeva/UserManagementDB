using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using UserManagementDB;

namespace UserManagementDB
{
    public partial class AddEditUserForm : Form
    {
        DBConnection db = null;
        string mode = String.Empty;
        public User editUser = null; //user object being edited and then selected in the ViewUser Form
        public User addedUser = null;//user object being added and then selected in the ViewUser Form

        public AddEditUserForm(DBConnection db, string mode)
        {
            InitializeComponent();

            this.db = db;
            // mode may be "add" or "editAdmin" or "editUser" - for user editing Admin option is not available, for Admin all fields are available
            this.mode = mode;
        }

        public AddEditUserForm(DBConnection db, User editUser, string mode) : this(db, mode)
        {
            this.editUser = editUser;
        }

        private void AddEditUserForm_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.SetToolTip(this.textBoxEmail, "Please, enter user email");
            toolTip.SetToolTip(this.textBoxName, "Please, enter user name");
            toolTip.SetToolTip(this.textBoxPhone, "Please, enter user phone number");
            toolTip.SetToolTip(this.textBoxPassword, "Please, enter your password");
            toolTip.SetToolTip(this.textBoxPassword2, "Please, confirm your password");
            toolTip.SetToolTip(this.comboBoxGroups, "Please, choose a user group");
            toolTip.SetToolTip(this.buttonChangeImage, "Please, select user profile picture");

            //display user profile picture or default image form project folder
            refreshProfileImage(editUser);
            this.comboBoxGroups.DropDownStyle = ComboBoxStyle.DropDownList;
            if (mode == "add")
            {
                this.comboBoxGroups.SelectedIndex = 0;
            }
            else if (mode == "editAdmin")
            {
                // Update form fields/controls with information for user being edited
                this.textBoxEmail.Text = this.editUser.Email;
                //editing email is disabled
                this.textBoxEmail.Enabled = false;
                this.textBoxName.Text = this.editUser.Name;
                this.textBoxPhone.Text = this.editUser.Phone;
                this.textBoxPassword.Text = this.editUser.Password;
                this.textBoxPassword2.Text = this.editUser.Password;
                this.comboBoxGroups.Text = this.editUser.Group;
                this.checkBoxAdministrator.Checked = this.editUser.IsAdmin;
                this.textBoxImageLocation.Text = this.editUser.Image;

            }
            else if (mode == "editUser")
            {
                // Update form fields/controls with information for user being edited
                this.textBoxEmail.Text = this.editUser.Email;
                //editing email is disabled
                this.textBoxEmail.Enabled = false;
                this.textBoxName.Text = this.editUser.Name;
                this.textBoxPhone.Text = this.editUser.Phone;
                this.textBoxPassword.Text = this.editUser.Password;
                this.textBoxPassword2.Text = this.editUser.Password;
                this.comboBoxGroups.Text = this.editUser.Group;
                this.checkBoxAdministrator.Checked = this.editUser.IsAdmin;
                //edit admin status available only for admin users
                this.checkBoxAdministrator.Enabled = false;

                this.textBoxImageLocation.Text = this.editUser.Image;
            }
        }

        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Validation - check formats of email, phone and password

            if (ValidateEmailAddressFormat() == false)
            {
                // Email is not valid - return without doing anything else
                return;
            }
            // Validate Email uniqueness
            if (ValidateEmailAddressUnique() == false)
            {
                // Email address already exists in database - return without doing anything else
                return;
            }

            if (ValidatePhone() == false)
            {
                // Phone number is not valid - return without doing anything else
                return;
            }

            if (ValidatePassword() == false)
            {
                // Password is not valid - return without doing anything else
                return;
            }

            if (this.mode == "add")
            {
                
                User newUser = CreateNewUser();

                UsersDB usersDB = new UsersDB();
                if (usersDB.Insert(this.db, newUser))
                {
                    addedUser = newUser;

                    this.Close();
                }
            }
            else
            {
                User updatedUser = CreateNewUser();

                UsersDB usersDB = new UsersDB();
                if (usersDB.Update(this.db, editUser.Email, updatedUser))
                {
                    editUser = updatedUser;
                    this.Close();
                }
            }
            
        }


        private bool IsUniqueEmailAddress(string currentEmail, string newEmail)
        {
            bool isUnique = true;

            // Get list of all users from database
            UsersDB usersDB = new UsersDB();
            List<User> users = usersDB.GetUsers(this.db);

            foreach (User user in users)
            {
                if (user.Email != currentEmail && user.Email == newEmail)
                {
                    isUnique = false;
                    break;
                }
            }

            return isUnique;
        }

        private bool ValidateEmailAddressUnique()
        {
            string currentEmail = String.Empty;

            if ((mode == "editAdmin") || (mode=="editUser"))
            {
                currentEmail = this.editUser.Email;
            }

            if (IsUniqueEmailAddress(currentEmail, this.textBoxEmail.Text) == false)
            {
                MessageBox.Show($"A user with the email address {this.textBoxEmail.Text} already exists.\n\nEmail addresses must be unique.",
                                "Email address exists",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        private bool ValidateEmailAddressFormat()
        {
            bool isValid = true;
            string message = $"There's a problem with your email address: {this.textBoxEmail.Text}\n\nEmail addresses...\n\n";

            if (this.textBoxEmail.Text.Contains("@") == false)
            {
                isValid = false;
                message += $" - must contain the @ symbol.\n";
            }

            if (this.textBoxEmail.Text.Contains(".") == false)
            {
                isValid = false;
                message += $" - must contain a '.' character.\n";
            }

            if (isValid == false)
            {
                MessageBox.Show(message,
                                "Invalid email address",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }

            return isValid;
        }

        private bool IsValidPhoneNumberCharacter(char ch)
        {
            if (Char.IsDigit(ch) == true ||
               ch == '+' ||
               ch == ' ' ||
               ch == '(' ||
               ch == ')' ||
               ch == '-')
            {
                return true;
            }

            return false;
        }

        private bool ValidatePhone()
        {
            foreach (char ch in this.textBoxPhone.Text)
            {
                if (IsValidPhoneNumberCharacter(ch) == false)
                {
                    MessageBox.Show("Phone numbers must be composed of digits, spaces and/or the characters: + ( ) -",
                                    "Invalid phone number",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private bool ValidatePassword()
        {
            if (this.textBoxPassword.Text != this.textBoxPassword2.Text)
            {
                MessageBox.Show("The verify password does not match. Please ensure both password fields are the same and try again...",
                                "Password mismatch",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            if (Password.IsPassword(this.textBoxPassword.Text) == false)
            {
                string message = Password.GetLastErrorMessage();

                MessageBox.Show($"Your password is not strong enough.\n\n{message}",
                                "Incorrect format",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            // If we get to here the password is valid
            return true;
        }

        private User CreateNewUser()
        {
            // Take the current information from the form fields and create and return a User object
            User user = new User(this.textBoxEmail.Text,
                                 this.textBoxName.Text,
                                 this.textBoxPhone.Text,
                                 this.checkBoxAdministrator.Checked,
                                 this.textBoxPassword.Text,
                                 this.comboBoxGroups.Text,
                                 this.textBoxImageLocation.Text);

            return user;
        }

        private void buttonChangeImage_Click(object sender, EventArgs e)
        {
            // Select new ImageFile using OpenFileDialog

            string picturesPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            OpenFileDialog browseImageFileDialog = new OpenFileDialog();

            browseImageFileDialog.Title = "Select Image File";
            browseImageFileDialog.InitialDirectory = picturesPath;
            browseImageFileDialog.Filter = "Image files (*.png, *.gif, *.jpg, *.bmp)|*.png;*.gif;*.jpg;*.bmp";

            browseImageFileDialog.ShowDialog();

            // TODO: Move the following out into its own method (RefreshProfileImage)

            // Get the filename of the selected image file
            string pictureFilename = browseImageFileDialog.FileName;

            if (File.Exists(pictureFilename))
            {
                // Update PictureBox to display new Image
                Image userImage = Image.FromFile(pictureFilename);
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

            this.textBoxImageLocation.Text = pictureFilename;
        }

        //Refresh user profile image
        private void refreshProfileImage(User user)
        {
            string imageFilePath;
            if (user == null)
            {
                imageFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "default_user_image.jpg");
            }
            else
            {
                imageFilePath = user.Image;

                if (!File.Exists(imageFilePath))
                {
                    imageFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "default_user_image.jpg");
                }
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

            private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //reveal password (show password)
        private void checkBoxRevealPassword_CheckedChanged(object sender, EventArgs e)
         
        {
                if (checkBoxRevealPassword.Checked == true)
                {
                    textBoxPassword.PasswordChar = char.MinValue;
                    textBoxPassword2.PasswordChar = char.MinValue;
                }
                else
                {
                    textBoxPassword.PasswordChar = '*';
                    textBoxPassword2.PasswordChar = '*';
                }
            
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For every new user created in the app email should be unique, phone numbers must be composed of digits, spaces and/or the characters: + ( ) -, password and verify must be identical. The password must meet the following strength requirements:1. Minimum 8 characters 2. Maximum 16 characters 3. Have at least one upper case (A - Z) character 4. Have at least one lower case (a - z) character 5. Have at least one number(0 - 9)6. Have at least one symbol or special character from this list: 7.  ~! @ # $ % ^ & * ( ) _ + - = { } | [ ]  :  ; ' < > ? , . /  8. Must not contain whitespace such as spaces or tabs 9. Must be free of consecutive identical characters", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
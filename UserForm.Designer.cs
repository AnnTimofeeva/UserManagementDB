
namespace UserManagementDB
{
    partial class ViewUsersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelCurrentUser = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelUserList = new System.Windows.Forms.Label();
            this.listBoxUsersList = new System.Windows.Forms.ListBox();
            this.pictureBoxUserImage = new System.Windows.Forms.PictureBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.checkBoxAdministrator = new System.Windows.Forms.CheckBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textboxgroups = new System.Windows.Forms.TextBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(829, 489);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(150, 46);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "&Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(209, 500);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(150, 46);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(37, 500);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 46);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "&Add user";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(379, 500);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(150, 46);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelCurrentUser
            // 
            this.labelCurrentUser.AutoSize = true;
            this.labelCurrentUser.Location = new System.Drawing.Point(28, 35);
            this.labelCurrentUser.Name = "labelCurrentUser";
            this.labelCurrentUser.Size = new System.Drawing.Size(257, 32);
            this.labelCurrentUser.TabIndex = 4;
            this.labelCurrentUser.Text = "You are logged in as a ";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Enabled = false;
            this.textBoxEmail.Location = new System.Drawing.Point(951, 131);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(396, 39);
            this.textBoxEmail.TabIndex = 5;
            // 
            // labelUserList
            // 
            this.labelUserList.AutoSize = true;
            this.labelUserList.Location = new System.Drawing.Point(28, 100);
            this.labelUserList.Name = "labelUserList";
            this.labelUserList.Size = new System.Drawing.Size(108, 32);
            this.labelUserList.TabIndex = 6;
            this.labelUserList.Text = "Users list";
            // 
            // listBoxUsersList
            // 
            this.listBoxUsersList.FormattingEnabled = true;
            this.listBoxUsersList.ItemHeight = 32;
            this.listBoxUsersList.Location = new System.Drawing.Point(28, 161);
            this.listBoxUsersList.Name = "listBoxUsersList";
            this.listBoxUsersList.Size = new System.Drawing.Size(486, 292);
            this.listBoxUsersList.TabIndex = 7;
            this.listBoxUsersList.SelectedIndexChanged += new System.EventHandler(this.listBoxUsers_SelectedIndexChanged);
            // 
            // pictureBoxUserImage
            // 
            this.pictureBoxUserImage.InitialImage = global::UserManagementDB.Properties.Resources.default_user_image;
            this.pictureBoxUserImage.Location = new System.Drawing.Point(574, 142);
            this.pictureBoxUserImage.Name = "pictureBoxUserImage";
            this.pictureBoxUserImage.Size = new System.Drawing.Size(268, 294);
            this.pictureBoxUserImage.TabIndex = 8;
            this.pictureBoxUserImage.TabStop = false;
            // 
            // textBoxName
            // 
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(951, 200);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(396, 39);
            this.textBoxName.TabIndex = 9;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Enabled = false;
            this.textBoxPhone.Location = new System.Drawing.Point(951, 269);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(396, 39);
            this.textBoxPhone.TabIndex = 10;
            // 
            // checkBoxAdministrator
            // 
            this.checkBoxAdministrator.AutoSize = true;
            this.checkBoxAdministrator.Enabled = false;
            this.checkBoxAdministrator.Location = new System.Drawing.Point(951, 337);
            this.checkBoxAdministrator.Name = "checkBoxAdministrator";
            this.checkBoxAdministrator.Size = new System.Drawing.Size(190, 36);
            this.checkBoxAdministrator.TabIndex = 11;
            this.checkBoxAdministrator.Text = "Administrator";
            this.checkBoxAdministrator.UseVisualStyleBackColor = true;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(867, 393);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(80, 32);
            this.labelGroup.TabIndex = 13;
            this.labelGroup.Text = "Group";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(865, 272);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(82, 32);
            this.labelPhone.TabIndex = 14;
            this.labelPhone.Text = "Phone";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(865, 200);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(78, 32);
            this.labelN.TabIndex = 15;
            this.labelN.Text = "Name";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(865, 131);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(71, 32);
            this.labelEmail.TabIndex = 16;
            this.labelEmail.Text = "Email";
            // 
            // textboxgroups
            // 
            this.textboxgroups.Enabled = false;
            this.textboxgroups.Location = new System.Drawing.Point(953, 397);
            this.textboxgroups.Name = "textboxgroups";
            this.textboxgroups.Size = new System.Drawing.Size(394, 39);
            this.textboxgroups.TabIndex = 17;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(574, 21);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(150, 46);
            this.buttonLogout.TabIndex = 18;
            this.buttonLogout.Text = "&Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHelp.Location = new System.Drawing.Point(1208, 489);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(139, 43);
            this.buttonHelp.TabIndex = 4;
            this.buttonHelp.Text = "&Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // ViewUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 580);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.textboxgroups);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.checkBoxAdministrator);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.pictureBoxUserImage);
            this.Controls.Add(this.listBoxUsersList);
            this.Controls.Add(this.labelUserList);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelCurrentUser);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Name = "ViewUsersForm";
            this.Text = "View Users Form";
            this.Load += new System.EventHandler(this.ViewUsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelCurrentUser;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelUserList;
        private System.Windows.Forms.ListBox listBoxUsersList;
        private System.Windows.Forms.PictureBox pictureBoxUserImage;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.CheckBox checkBoxAdministrator;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textboxgroups;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonHelp;
    }
}
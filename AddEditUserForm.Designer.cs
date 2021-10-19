
namespace UserManagementDB
{
    partial class AddEditUserForm
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
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.checkBoxAdministrator = new System.Windows.Forms.CheckBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.pictureBoxUserImage = new System.Windows.Forms.PictureBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelVerify = new System.Windows.Forms.Label();
            this.textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.buttonChangeImage = new System.Windows.Forms.Button();
            this.textBoxImageLocation = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.checkBoxRevealPassword = new System.Windows.Forms.CheckBox();
            this.labelImage = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Items.AddRange(new object[] {
            "I.T.",
            "Development",
            "Sales",
            "Marketing",
            "Human Resources",
            "Quality Assurance",
            "Accounts",
            "Operations"});
            this.comboBoxGroups.Location = new System.Drawing.Point(444, 253);
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Size = new System.Drawing.Size(396, 40);
            this.comboBoxGroups.TabIndex = 29;
            this.comboBoxGroups.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroups_SelectedIndexChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(318, 86);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(71, 32);
            this.labelEmail.TabIndex = 28;
            this.labelEmail.Text = "Email";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(318, 148);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(78, 32);
            this.labelN.TabIndex = 27;
            this.labelN.Text = "Name";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(318, 200);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(82, 32);
            this.labelPhone.TabIndex = 26;
            this.labelPhone.Text = "Phone";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(318, 256);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(80, 32);
            this.labelGroup.TabIndex = 25;
            this.labelGroup.Text = "Group";
            // 
            // checkBoxAdministrator
            // 
            this.checkBoxAdministrator.AutoSize = true;
            this.checkBoxAdministrator.Location = new System.Drawing.Point(444, 308);
            this.checkBoxAdministrator.Name = "checkBoxAdministrator";
            this.checkBoxAdministrator.Size = new System.Drawing.Size(190, 36);
            this.checkBoxAdministrator.TabIndex = 24;
            this.checkBoxAdministrator.Text = "Administrator";
            this.checkBoxAdministrator.UseVisualStyleBackColor = true;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(444, 197);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(396, 39);
            this.textBoxPhone.TabIndex = 23;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(444, 141);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(396, 39);
            this.textBoxName.TabIndex = 22;
            // 
            // pictureBoxUserImage
            // 
            this.pictureBoxUserImage.InitialImage = null;
            this.pictureBoxUserImage.Location = new System.Drawing.Point(39, 136);
            this.pictureBoxUserImage.Name = "pictureBoxUserImage";
            this.pictureBoxUserImage.Size = new System.Drawing.Size(244, 368);
            this.pictureBoxUserImage.TabIndex = 21;
            this.pictureBoxUserImage.TabStop = false;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(444, 86);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(396, 39);
            this.textBoxEmail.TabIndex = 20;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(690, 614);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(150, 46);
            this.buttonExit.TabIndex = 19;
            this.buttonExit.Text = "&Cancel";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(504, 614);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(150, 46);
            this.buttonSave.TabIndex = 18;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(318, 357);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(111, 32);
            this.labelPassword.TabIndex = 31;
            this.labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(444, 350);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(396, 39);
            this.textBoxPassword.TabIndex = 30;
            // 
            // labelVerify
            // 
            this.labelVerify.AutoSize = true;
            this.labelVerify.Location = new System.Drawing.Point(318, 412);
            this.labelVerify.Name = "labelVerify";
            this.labelVerify.Size = new System.Drawing.Size(74, 32);
            this.labelVerify.TabIndex = 33;
            this.labelVerify.Text = "Verify";
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.Location = new System.Drawing.Point(444, 405);
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.PasswordChar = '*';
            this.textBoxPassword2.Size = new System.Drawing.Size(396, 39);
            this.textBoxPassword2.TabIndex = 32;
            // 
            // buttonChangeImage
            // 
            this.buttonChangeImage.Location = new System.Drawing.Point(631, 543);
            this.buttonChangeImage.Name = "buttonChangeImage";
            this.buttonChangeImage.Size = new System.Drawing.Size(209, 46);
            this.buttonChangeImage.TabIndex = 34;
            this.buttonChangeImage.Text = "&Change image";
            this.buttonChangeImage.UseVisualStyleBackColor = true;
            this.buttonChangeImage.Click += new System.EventHandler(this.buttonChangeImage_Click);
            // 
            // textBoxImageLocation
            // 
            this.textBoxImageLocation.Location = new System.Drawing.Point(25, 550);
            this.textBoxImageLocation.Name = "textBoxImageLocation";
            this.textBoxImageLocation.Size = new System.Drawing.Size(575, 39);
            this.textBoxImageLocation.TabIndex = 35;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(234, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(334, 45);
            this.labelTitle.TabIndex = 36;
            this.labelTitle.Text = "Add/edit user details";
            // 
            // checkBoxRevealPassword
            // 
            this.checkBoxRevealPassword.AutoSize = true;
            this.checkBoxRevealPassword.Location = new System.Drawing.Point(444, 468);
            this.checkBoxRevealPassword.Name = "checkBoxRevealPassword";
            this.checkBoxRevealPassword.Size = new System.Drawing.Size(221, 36);
            this.checkBoxRevealPassword.TabIndex = 37;
            this.checkBoxRevealPassword.Text = "Reveal password";
            this.checkBoxRevealPassword.UseVisualStyleBackColor = true;
            this.checkBoxRevealPassword.CheckedChanged += new System.EventHandler(this.checkBoxRevealPassword_CheckedChanged);
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(81, 86);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(134, 32);
            this.labelImage.TabIndex = 38;
            this.labelImage.Text = "User image";
            // 
            // buttonHelp
            // 
            this.buttonHelp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHelp.Location = new System.Drawing.Point(25, 614);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(139, 46);
            this.buttonHelp.TabIndex = 40;
            this.buttonHelp.Text = "&Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // AddEditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 672);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.checkBoxRevealPassword);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxImageLocation);
            this.Controls.Add(this.buttonChangeImage);
            this.Controls.Add(this.labelVerify);
            this.Controls.Add(this.textBoxPassword2);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.comboBoxGroups);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.checkBoxAdministrator);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.pictureBoxUserImage);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Name = "AddEditUserForm";
            this.Text = "Add or Edit User";
            this.Load += new System.EventHandler(this.AddEditUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxGroups;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.CheckBox checkBoxAdministrator;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.PictureBox pictureBoxUserImage;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelVerify;
        private System.Windows.Forms.Button buttonChangeImage;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxPassword2;
        private System.Windows.Forms.TextBox textBoxImageLocation;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.CheckBox checkBoxRevealPassword;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.Button buttonHelp;
    }
}
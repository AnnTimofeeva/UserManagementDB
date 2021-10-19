
namespace UserManagementDB
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonClearEmail = new System.Windows.Forms.Button();
            this.buttonClearPassword = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.checkBoxRevealPassword = new System.Windows.Forms.CheckBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(240, 114);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(423, 39);
            this.textBoxEmail.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(240, 193);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(423, 39);
            this.textBoxPassword.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(106, 192);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(128, 37);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password";
            // 
            // buttonClearEmail
            // 
            this.buttonClearEmail.Location = new System.Drawing.Point(690, 114);
            this.buttonClearEmail.Name = "buttonClearEmail";
            this.buttonClearEmail.Size = new System.Drawing.Size(69, 37);
            this.buttonClearEmail.TabIndex = 6;
            this.buttonClearEmail.Text = "X";
            this.buttonClearEmail.UseVisualStyleBackColor = true;
            this.buttonClearEmail.Click += new System.EventHandler(this.buttonClearEmail_Click);
            // 
            // buttonClearPassword
            // 
            this.buttonClearPassword.Location = new System.Drawing.Point(690, 193);
            this.buttonClearPassword.Name = "buttonClearPassword";
            this.buttonClearPassword.Size = new System.Drawing.Size(69, 45);
            this.buttonClearPassword.TabIndex = 7;
            this.buttonClearPassword.Text = "X";
            this.buttonClearPassword.UseVisualStyleBackColor = true;
            this.buttonClearPassword.Click += new System.EventHandler(this.buttonClearPassword_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSubmit.Location = new System.Drawing.Point(8, 364);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(216, 54);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "&Login";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.Location = new System.Drawing.Point(252, 364);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(216, 54);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "&Exit";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(128, 36);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(593, 45);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "User Management Database Application";
            // 
            // checkBoxRevealPassword
            // 
            this.checkBoxRevealPassword.AutoSize = true;
            this.checkBoxRevealPassword.Location = new System.Drawing.Point(83, 285);
            this.checkBoxRevealPassword.Name = "checkBoxRevealPassword";
            this.checkBoxRevealPassword.Size = new System.Drawing.Size(221, 36);
            this.checkBoxRevealPassword.TabIndex = 38;
            this.checkBoxRevealPassword.Text = "Reveal password";
            this.checkBoxRevealPassword.UseVisualStyleBackColor = true;
            this.checkBoxRevealPassword.CheckedChanged += new System.EventHandler(this.checkBoxRevealPassword_CheckedChanged);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHelp.Location = new System.Drawing.Point(649, 364);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(139, 54);
            this.buttonHelp.TabIndex = 39;
            this.buttonHelp.Text = "&Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.checkBoxRevealPassword);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonClearPassword);
            this.Controls.Add(this.buttonClearEmail);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "User Management Database App";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonClearEmail;
        private System.Windows.Forms.Button buttonClearPassword;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.CheckBox checkBoxRevealPassword;
        private System.Windows.Forms.Button buttonHelp;
    }
}
namespace SimpleCRM.View._forms
{
    partial class LogInFormView
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
            txt_username = new TextBox();
            txt_password = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSignup = new Button();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.Anchor = AnchorStyles.Right;
            txt_username.Location = new Point(198, 344);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(329, 27);
            txt_username.TabIndex = 0;
            // 
            // txt_password
            // 
            txt_password.Anchor = AnchorStyles.Right;
            txt_password.Location = new Point(196, 432);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(329, 27);
            txt_password.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Right;
            btnLogin.Location = new Point(122, 582);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(195, 40);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(91, 344);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(97, 432);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(231, 152);
            label3.Name = "label3";
            label3.Size = new Size(263, 54);
            label3.TabIndex = 5;
            label3.Text = "Login Admin";
            // 
            // btnSignup
            // 
            btnSignup.Anchor = AnchorStyles.Right;
            btnSignup.Location = new Point(332, 582);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(195, 40);
            btnSignup.TabIndex = 6;
            btnSignup.Text = "Signup";
            btnSignup.UseVisualStyleBackColor = true;
            // 
            // LogInFormView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 794);
            Controls.Add(btnSignup);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            MaximizeBox = false;
            Name = "LogInFormView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogInFormView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_username;
        private TextBox txt_password;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSignup;
    }
}
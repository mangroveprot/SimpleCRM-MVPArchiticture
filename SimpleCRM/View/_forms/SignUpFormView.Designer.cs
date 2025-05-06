namespace SimpleCRM.View._forms
{
    partial class SignUpFormView
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
            txt_fullname = new TextBox();
            txt_email = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnSignup = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.Location = new Point(168, 252);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(251, 27);
            txt_username.TabIndex = 0;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(168, 311);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(251, 27);
            txt_password.TabIndex = 1;
            // 
            // txt_fullname
            // 
            txt_fullname.Location = new Point(168, 380);
            txt_fullname.Name = "txt_fullname";
            txt_fullname.Size = new Size(251, 27);
            txt_fullname.TabIndex = 2;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(168, 449);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(251, 27);
            txt_email.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(216, 59);
            label1.Name = "label1";
            label1.Size = new Size(203, 72);
            label1.TabIndex = 4;
            label1.Text = "Signup";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 255);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 314);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 383);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 7;
            label4.Text = "Full Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(107, 456);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 8;
            label5.Text = "Email";
            // 
            // btnSignup
            // 
            btnSignup.Location = new Point(168, 549);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(251, 36);
            btnSignup.TabIndex = 9;
            btnSignup.Text = "Sign-Up Now";
            btnSignup.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(168, 621);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(251, 36);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Go back to Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // SignUpFormView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 777);
            Controls.Add(btnLogin);
            Controls.Add(btnSignup);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_email);
            Controls.Add(txt_fullname);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Name = "SignUpFormView";
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_username;
        private TextBox txt_password;
        private TextBox txt_fullname;
        private TextBox txt_email;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSignup;
        private Button btnLogin;
    }
}
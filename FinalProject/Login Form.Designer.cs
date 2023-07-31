namespace FinalProject
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
            label1 = new Label();
            usernameTextBox = new TextBox();
            loginBtn = new Button();
            checkBox1 = new CheckBox();
            passwordTextBox = new TextBox();
            label2 = new Label();
            button2 = new Button();
            usernameValidationLabel = new Label();
            backtohomeBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 34);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 31);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.AcceptsReturn = true;
            usernameTextBox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(233, 34);
            usernameTextBox.Margin = new Padding(6, 7, 6, 7);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(442, 37);
            usernameTextBox.TabIndex = 1;
            usernameTextBox.TextChanged += usernameText_changed;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = SystemColors.MenuHighlight;
            loginBtn.Location = new Point(453, 238);
            loginBtn.Margin = new Padding(6, 7, 6, 7);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(222, 85);
            loginBtn.TabIndex = 1;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(493, 177);
            checkBox1.Margin = new Padding(6, 7, 6, 7);
            checkBox1.Name = "checkBox1";
            checkBox1.RightToLeft = RightToLeft.Yes;
            checkBox1.Size = new Size(182, 34);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Show password";
            checkBox1.TextAlign = ContentAlignment.MiddleCenter;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += showPassword_checked;
            // 
            // passwordTextBox
            // 
            passwordTextBox.AcceptsReturn = true;
            passwordTextBox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(233, 130);
            passwordTextBox.Margin = new Padding(6, 7, 6, 7);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(442, 37);
            passwordTextBox.TabIndex = 5;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 130);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 31);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Window;
            button2.Location = new Point(40, 238);
            button2.Margin = new Padding(6, 7, 6, 7);
            button2.Name = "button2";
            button2.Size = new Size(222, 85);
            button2.TabIndex = 6;
            button2.Text = "Create New Account";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // usernameValidationLabel
            // 
            usernameValidationLabel.AutoSize = true;
            usernameValidationLabel.ForeColor = Color.Red;
            usernameValidationLabel.Location = new Point(233, 78);
            usernameValidationLabel.Name = "usernameValidationLabel";
            usernameValidationLabel.Size = new Size(246, 30);
            usernameValidationLabel.TabIndex = 17;
            usernameValidationLabel.Text = "Username does not exist.";
            // 
            // backtohomeBtn
            // 
            backtohomeBtn.BackColor = SystemColors.ActiveCaption;
            backtohomeBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            backtohomeBtn.Location = new Point(439, 358);
            backtohomeBtn.Name = "backtohomeBtn";
            backtohomeBtn.Size = new Size(236, 62);
            backtohomeBtn.TabIndex = 21;
            backtohomeBtn.Text = "Go back to home feed";
            backtohomeBtn.UseVisualStyleBackColor = false;
            backtohomeBtn.Click += backtohomeBtn_Click;
            // 
            // LoginForm
            // 
            AcceptButton = loginBtn;
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 461);
            Controls.Add(backtohomeBtn);
            Controls.Add(usernameValidationLabel);
            Controls.Add(button2);
            Controls.Add(passwordTextBox);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(loginBtn);
            Controls.Add(usernameTextBox);
            Controls.Add(label1);
            Margin = new Padding(6, 7, 6, 7);
            Name = "LoginForm";
            Text = "Login Form";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private TextBox passwordTextBox;
        private Label label2;
        private Button button2;
        private Label usernameValidationLabel;
        private Button backtohomeBtn;
    }
}
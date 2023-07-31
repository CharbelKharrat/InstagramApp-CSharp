namespace FinalProject
{
    partial class Create_New_Account_Form
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
            passwordTextBox = new TextBox();
            label2 = new Label();
            showPassCheckBox = new CheckBox();
            usernameTextBox = new TextBox();
            label1 = new Label();
            emailTextBox = new TextBox();
            label3 = new Label();
            button2 = new Button();
            passValidationLabel = new Label();
            emailValidationLabel = new Label();
            usernameValidationLabel = new Label();
            SuspendLayout();
            // 
            // passwordTextBox
            // 
            passwordTextBox.AcceptsReturn = true;
            passwordTextBox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(246, 307);
            passwordTextBox.Margin = new Padding(6, 7, 6, 7);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(442, 37);
            passwordTextBox.TabIndex = 10;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 313);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 31);
            label2.TabIndex = 9;
            label2.Text = "Password:";
            // 
            // showPassCheckBox
            // 
            showPassCheckBox.AutoSize = true;
            showPassCheckBox.Location = new Point(506, 466);
            showPassCheckBox.Margin = new Padding(6, 7, 6, 7);
            showPassCheckBox.Name = "showPassCheckBox";
            showPassCheckBox.RightToLeft = RightToLeft.Yes;
            showPassCheckBox.Size = new Size(182, 34);
            showPassCheckBox.TabIndex = 8;
            showPassCheckBox.Text = "Show password";
            showPassCheckBox.TextAlign = ContentAlignment.MiddleCenter;
            showPassCheckBox.UseVisualStyleBackColor = true;
            showPassCheckBox.CheckedChanged += passwordCheckBox_CheckedChanged;
            // 
            // usernameTextBox
            // 
            usernameTextBox.AcceptsReturn = true;
            usernameTextBox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(246, 59);
            usernameTextBox.Margin = new Padding(6, 7, 6, 7);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(442, 37);
            usernameTextBox.TabIndex = 7;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 62);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 31);
            label1.TabIndex = 6;
            label1.Text = "Username:";
            // 
            // emailTextBox
            // 
            emailTextBox.AcceptsReturn = true;
            emailTextBox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.Location = new Point(246, 164);
            emailTextBox.Margin = new Padding(6, 7, 6, 7);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(442, 37);
            emailTextBox.TabIndex = 12;
            emailTextBox.TextChanged += emailTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(44, 167);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 31);
            label3.TabIndex = 11;
            label3.Text = "Email:";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Window;
            button2.Location = new Point(246, 549);
            button2.Margin = new Padding(6, 7, 6, 7);
            button2.Name = "button2";
            button2.Size = new Size(222, 85);
            button2.TabIndex = 13;
            button2.Text = "Create New Account";
            button2.UseVisualStyleBackColor = false;
            button2.Click += createAccBtn_Click;
            // 
            // passValidationLabel
            // 
            passValidationLabel.ForeColor = Color.Red;
            passValidationLabel.Location = new Point(246, 350);
            passValidationLabel.Name = "passValidationLabel";
            passValidationLabel.Size = new Size(442, 109);
            passValidationLabel.TabIndex = 14;
            passValidationLabel.Text = "Please enter a valid password";
            // 
            // emailValidationLabel
            // 
            emailValidationLabel.ForeColor = Color.Red;
            emailValidationLabel.Location = new Point(246, 208);
            emailValidationLabel.Name = "emailValidationLabel";
            emailValidationLabel.Size = new Size(442, 82);
            emailValidationLabel.TabIndex = 15;
            emailValidationLabel.Text = "Please enter a valid email";
            // 
            // usernameValidationLabel
            // 
            usernameValidationLabel.AutoSize = true;
            usernameValidationLabel.ForeColor = Color.Red;
            usernameValidationLabel.Location = new Point(246, 97);
            usernameValidationLabel.Name = "usernameValidationLabel";
            usernameValidationLabel.Size = new Size(460, 30);
            usernameValidationLabel.TabIndex = 16;
            usernameValidationLabel.Text = "Username already exists. Please try another one.";
            // 
            // Create_New_Account_Form
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 666);
            Controls.Add(usernameValidationLabel);
            Controls.Add(emailValidationLabel);
            Controls.Add(passValidationLabel);
            Controls.Add(button2);
            Controls.Add(emailTextBox);
            Controls.Add(label3);
            Controls.Add(passwordTextBox);
            Controls.Add(label2);
            Controls.Add(showPassCheckBox);
            Controls.Add(usernameTextBox);
            Controls.Add(label1);
            Name = "Create_New_Account_Form";
            Text = "Create New Account";
            Load += Create_New_Account_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passwordTextBox;
        private Label label2;
        private CheckBox showPassCheckBox;
        private TextBox usernameTextBox;
        private Label label1;
        private TextBox emailTextBox;
        private Label label3;
        private Button button2;
        private Label passValidationLabel;
        private Label emailValidationLabel;
        private Label usernameValidationLabel;
    }
}
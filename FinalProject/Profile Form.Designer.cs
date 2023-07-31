namespace FinalProject
{
    partial class Profile_Form
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
            CreatePostBtn = new Button();
            postgv = new DataGridView();
            updateBtn = new Button();
            deleteBtn = new Button();
            label1 = new Label();
            imageurlTxtBox = new TextBox();
            captionTextBox = new TextBox();
            label2 = new Label();
            usernameTxtBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            emailTxtBox = new TextBox();
            label5 = new Label();
            changeUsernameBtn = new Button();
            changeEmailBtn = new Button();
            backtohomeBtn = new Button();
            usernameValidationLabel = new Label();
            emailValidationLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)postgv).BeginInit();
            SuspendLayout();
            // 
            // CreatePostBtn
            // 
            CreatePostBtn.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            CreatePostBtn.Location = new Point(506, 654);
            CreatePostBtn.Name = "CreatePostBtn";
            CreatePostBtn.Size = new Size(252, 80);
            CreatePostBtn.TabIndex = 6;
            CreatePostBtn.Text = "Create New Post";
            CreatePostBtn.UseVisualStyleBackColor = true;
            CreatePostBtn.Click += CreatePostBtn_Click;
            // 
            // postgv
            // 
            postgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            postgv.Location = new Point(279, 221);
            postgv.Name = "postgv";
            postgv.RowHeadersWidth = 72;
            postgv.RowTemplate.Height = 37;
            postgv.Size = new Size(1399, 413);
            postgv.TabIndex = 5;
            postgv.SelectionChanged += postgv_SelectionChanged;
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            updateBtn.Location = new Point(839, 654);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(252, 80);
            updateBtn.TabIndex = 7;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            deleteBtn.Location = new Point(1185, 654);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(252, 80);
            deleteBtn.TabIndex = 8;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 295);
            label1.Name = "label1";
            label1.Size = new Size(103, 30);
            label1.TabIndex = 9;
            label1.Text = "Image Url";
            // 
            // imageurlTxtBox
            // 
            imageurlTxtBox.Location = new Point(22, 335);
            imageurlTxtBox.Name = "imageurlTxtBox";
            imageurlTxtBox.Size = new Size(230, 35);
            imageurlTxtBox.TabIndex = 10;
            // 
            // captionTextBox
            // 
            captionTextBox.Location = new Point(22, 463);
            captionTextBox.Name = "captionTextBox";
            captionTextBox.Size = new Size(230, 35);
            captionTextBox.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 423);
            label2.Name = "label2";
            label2.Size = new Size(85, 30);
            label2.TabIndex = 11;
            label2.Text = "Caption";
            // 
            // usernameTxtBox
            // 
            usernameTxtBox.Location = new Point(147, 54);
            usernameTxtBox.Name = "usernameTxtBox";
            usernameTxtBox.Size = new Size(230, 35);
            usernameTxtBox.TabIndex = 14;
            usernameTxtBox.TextChanged += usernameTxtBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 57);
            label3.Name = "label3";
            label3.Size = new Size(106, 30);
            label3.TabIndex = 13;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(279, 188);
            label4.Name = "label4";
            label4.Size = new Size(108, 30);
            label4.TabIndex = 15;
            label4.Text = "Your Posts";
            // 
            // emailTxtBox
            // 
            emailTxtBox.Location = new Point(147, 122);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.Size = new Size(230, 35);
            emailTxtBox.TabIndex = 17;
            emailTxtBox.TextChanged += emailTxtBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 125);
            label5.Name = "label5";
            label5.Size = new Size(63, 30);
            label5.TabIndex = 16;
            label5.Text = "Email";
            // 
            // changeUsernameBtn
            // 
            changeUsernameBtn.BackColor = SystemColors.ControlLight;
            changeUsernameBtn.Location = new Point(416, 52);
            changeUsernameBtn.Name = "changeUsernameBtn";
            changeUsernameBtn.Size = new Size(224, 40);
            changeUsernameBtn.TabIndex = 18;
            changeUsernameBtn.Text = "Change Username";
            changeUsernameBtn.UseVisualStyleBackColor = false;
            changeUsernameBtn.Click += changeUsernameBtn_Click;
            // 
            // changeEmailBtn
            // 
            changeEmailBtn.BackColor = SystemColors.ControlLight;
            changeEmailBtn.Location = new Point(416, 125);
            changeEmailBtn.Name = "changeEmailBtn";
            changeEmailBtn.Size = new Size(224, 40);
            changeEmailBtn.TabIndex = 19;
            changeEmailBtn.Text = "Change Email";
            changeEmailBtn.UseVisualStyleBackColor = false;
            changeEmailBtn.Click += changeEmailBtn_Click;
            // 
            // backtohomeBtn
            // 
            backtohomeBtn.BackColor = SystemColors.ActiveCaption;
            backtohomeBtn.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            backtohomeBtn.Location = new Point(22, 749);
            backtohomeBtn.Name = "backtohomeBtn";
            backtohomeBtn.Size = new Size(330, 96);
            backtohomeBtn.TabIndex = 20;
            backtohomeBtn.Text = "Go back to home feed";
            backtohomeBtn.UseVisualStyleBackColor = false;
            backtohomeBtn.Click += backtohomeBtn_Click;
            // 
            // usernameValidationLabel
            // 
            usernameValidationLabel.AutoSize = true;
            usernameValidationLabel.ForeColor = Color.Red;
            usernameValidationLabel.Location = new Point(679, 59);
            usernameValidationLabel.Name = "usernameValidationLabel";
            usernameValidationLabel.Size = new Size(460, 30);
            usernameValidationLabel.TabIndex = 21;
            usernameValidationLabel.Text = "Username already exists. Please try another one.";
            // 
            // emailValidationLabel
            // 
            emailValidationLabel.ForeColor = Color.Red;
            emailValidationLabel.Location = new Point(679, 130);
            emailValidationLabel.Name = "emailValidationLabel";
            emailValidationLabel.Size = new Size(460, 77);
            emailValidationLabel.TabIndex = 22;
            emailValidationLabel.Text = "Please enter a valid email";
            // 
            // Profile_Form
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1701, 857);
            Controls.Add(emailValidationLabel);
            Controls.Add(usernameValidationLabel);
            Controls.Add(backtohomeBtn);
            Controls.Add(changeEmailBtn);
            Controls.Add(changeUsernameBtn);
            Controls.Add(emailTxtBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(usernameTxtBox);
            Controls.Add(label3);
            Controls.Add(captionTextBox);
            Controls.Add(label2);
            Controls.Add(imageurlTxtBox);
            Controls.Add(label1);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(CreatePostBtn);
            Controls.Add(postgv);
            Name = "Profile_Form";
            Text = "Profile Form";
            Load += Profile_Form_Load;
            Leave += Profile_Form_Leave;
            ((System.ComponentModel.ISupportInitialize)postgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreatePostBtn;
        private DataGridView postgv;
        private Button updateBtn;
        private Button deleteBtn;
        private Label label1;
        private TextBox imageurlTxtBox;
        private TextBox captionTextBox;
        private Label label2;
        private TextBox usernameTxtBox;
        private Label label3;
        private Label label4;
        private TextBox emailTxtBox;
        private Label label5;
        private Button changeUsernameBtn;
        private Button changeEmailBtn;
        private Button backtohomeBtn;
        private Label usernameValidationLabel;
        private Label emailValidationLabel;
    }
}
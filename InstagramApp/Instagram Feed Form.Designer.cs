namespace InstagramApp
{
    partial class Instagram_Feed_Form
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
            statusLabel = new Label();
            loginBtn = new Button();
            postgv = new DataGridView();
            label1 = new Label();
            CreatePostBtn = new Button();
            ProfileBtn = new Button();
            label2 = new Label();
            searchTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)postgv).BeginInit();
            SuspendLayout();
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            statusLabel.Location = new Point(1075, 37);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(183, 37);
            statusLabel.TabIndex = 0;
            statusLabel.Text = "Not logged in";
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.Location = new Point(1277, 93);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(170, 56);
            loginBtn.TabIndex = 1;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // postgv
            // 
            postgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            postgv.Location = new Point(25, 176);
            postgv.Name = "postgv";
            postgv.RowHeadersWidth = 72;
            postgv.RowTemplate.Height = 37;
            postgv.Size = new Size(1422, 576);
            postgv.TabIndex = 2;
            postgv.MouseClick += postgv_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 112);
            label1.Name = "label1";
            label1.Size = new Size(163, 37);
            label1.TabIndex = 3;
            label1.Text = "Latest posts:";
            // 
            // CreatePostBtn
            // 
            CreatePostBtn.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            CreatePostBtn.Location = new Point(272, 787);
            CreatePostBtn.Name = "CreatePostBtn";
            CreatePostBtn.Size = new Size(274, 80);
            CreatePostBtn.TabIndex = 4;
            CreatePostBtn.Text = "Create New Post";
            CreatePostBtn.UseVisualStyleBackColor = true;
            CreatePostBtn.Click += CreatePostBtn_Click;
            // 
            // ProfileBtn
            // 
            ProfileBtn.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            ProfileBtn.Location = new Point(1052, 93);
            ProfileBtn.Name = "ProfileBtn";
            ProfileBtn.Size = new Size(206, 56);
            ProfileBtn.TabIndex = 5;
            ProfileBtn.Text = "Profile";
            ProfileBtn.UseVisualStyleBackColor = true;
            ProfileBtn.Click += ProfileBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(853, 809);
            label2.Name = "label2";
            label2.Size = new Size(101, 37);
            label2.TabIndex = 6;
            label2.Text = "Search:";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(973, 811);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(251, 35);
            searchTextBox.TabIndex = 7;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // Instagram_Feed_Form
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 905);
            Controls.Add(searchTextBox);
            Controls.Add(label2);
            Controls.Add(ProfileBtn);
            Controls.Add(CreatePostBtn);
            Controls.Add(label1);
            Controls.Add(postgv);
            Controls.Add(loginBtn);
            Controls.Add(statusLabel);
            Name = "Instagram_Feed_Form";
            Text = "Instagram Feed";
            Activated += Instagram_Feed_Form_Activated;
            Load += Instagram_Feed_Form_Load;
            ((System.ComponentModel.ISupportInitialize)postgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label statusLabel;
        private Button loginBtn;
        private DataGridView postgv;
        private Label label1;
        private Button CreatePostBtn;
        private Button ProfileBtn;
        private Label label2;
        private TextBox searchTextBox;
    }
}
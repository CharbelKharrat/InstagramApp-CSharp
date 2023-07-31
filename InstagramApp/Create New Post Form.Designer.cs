namespace InstagramApp
{
    partial class Create_New_Post_Form
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
            imageurlTextBox = new TextBox();
            label1 = new Label();
            captionTextBox = new TextBox();
            label2 = new Label();
            CreatePostBtn = new Button();
            cancelBtn = new Button();
            comboBox1 = new ComboBox();
            dateLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            backtohomeBtn = new Button();
            SuspendLayout();
            // 
            // imageurlTextBox
            // 
            imageurlTextBox.AcceptsReturn = true;
            imageurlTextBox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            imageurlTextBox.Location = new Point(264, 45);
            imageurlTextBox.Margin = new Padding(6, 7, 6, 7);
            imageurlTextBox.Name = "imageurlTextBox";
            imageurlTextBox.Size = new Size(442, 37);
            imageurlTextBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(62, 48);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 31);
            label1.TabIndex = 8;
            label1.Text = "Image Url:";
            // 
            // captionTextBox
            // 
            captionTextBox.AcceptsReturn = true;
            captionTextBox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            captionTextBox.Location = new Point(264, 117);
            captionTextBox.Margin = new Padding(6, 7, 6, 7);
            captionTextBox.Name = "captionTextBox";
            captionTextBox.Size = new Size(442, 37);
            captionTextBox.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(62, 120);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 31);
            label2.TabIndex = 10;
            label2.Text = "Caption:";
            // 
            // CreatePostBtn
            // 
            CreatePostBtn.BackColor = SystemColors.Highlight;
            CreatePostBtn.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            CreatePostBtn.Location = new Point(124, 354);
            CreatePostBtn.Name = "CreatePostBtn";
            CreatePostBtn.Size = new Size(274, 80);
            CreatePostBtn.TabIndex = 12;
            CreatePostBtn.Text = "Create New Post";
            CreatePostBtn.UseVisualStyleBackColor = false;
            CreatePostBtn.Click += CreatePostBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            cancelBtn.Location = new Point(431, 354);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(166, 80);
            cancelBtn.TabIndex = 13;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Post Now", "Schedule" });
            comboBox1.Location = new Point(465, 189);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(241, 38);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(101, 274);
            dateLabel.Margin = new Padding(6, 0, 6, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(200, 31);
            dateLabel.TabIndex = 15;
            dateLabel.Text = "Schedule Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(339, 274);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(367, 35);
            dateTimePicker1.TabIndex = 16;
            // 
            // backtohomeBtn
            // 
            backtohomeBtn.BackColor = SystemColors.ActiveCaption;
            backtohomeBtn.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            backtohomeBtn.Location = new Point(216, 475);
            backtohomeBtn.Name = "backtohomeBtn";
            backtohomeBtn.Size = new Size(295, 82);
            backtohomeBtn.TabIndex = 21;
            backtohomeBtn.Text = "Go back to home feed";
            backtohomeBtn.UseVisualStyleBackColor = false;
            backtohomeBtn.Click += backtohomeBtn_Click;
            // 
            // Create_New_Post_Form
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 590);
            Controls.Add(backtohomeBtn);
            Controls.Add(dateTimePicker1);
            Controls.Add(dateLabel);
            Controls.Add(comboBox1);
            Controls.Add(cancelBtn);
            Controls.Add(CreatePostBtn);
            Controls.Add(captionTextBox);
            Controls.Add(label2);
            Controls.Add(imageurlTextBox);
            Controls.Add(label1);
            Name = "Create_New_Post_Form";
            Text = "Create_New_Post_Form";
            Load += Create_New_Post_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox imageurlTextBox;
        private Label label1;
        private TextBox captionTextBox;
        private Label label2;
        private Button CreatePostBtn;
        private Button cancelBtn;
        private ComboBox comboBox1;
        private Label dateLabel;
        private DateTimePicker dateTimePicker1;
        private Button backtohomeBtn;
    }
}
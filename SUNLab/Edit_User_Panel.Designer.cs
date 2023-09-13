namespace SUNLab
{
    partial class Edit_User_Panel
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
            label90 = new Label();
            exitButton = new Button();
            editButton = new Button();
            sunLabAccessBox = new CheckBox();
            nameTextBox = new TextBox();
            label2 = new Label();
            editUserResultLabel = new Label();
            editingIdLabel = new Label();
            roleTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label90
            // 
            label90.AutoSize = true;
            label90.Location = new Point(36, 28);
            label90.Name = "label90";
            label90.Size = new Size(87, 15);
            label90.TabIndex = 0;
            label90.Text = "Editing User ID:";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(124, 220);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(87, 23);
            exitButton.TabIndex = 16;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(26, 220);
            editButton.Name = "editButton";
            editButton.Size = new Size(86, 23);
            editButton.TabIndex = 15;
            editButton.Text = "Confirm Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // sunLabAccessBox
            // 
            sunLabAccessBox.AutoSize = true;
            sunLabAccessBox.Location = new Point(41, 167);
            sunLabAccessBox.Name = "sunLabAccessBox";
            sunLabAccessBox.Size = new Size(110, 19);
            sunLabAccessBox.TabIndex = 14;
            sunLabAccessBox.Text = "SUN Lab Access";
            sunLabAccessBox.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(40, 92);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(159, 23);
            nameTextBox.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 74);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 11;
            label2.Text = "Name";
            // 
            // editUserResultLabel
            // 
            editUserResultLabel.AutoSize = true;
            editUserResultLabel.Location = new Point(28, 194);
            editUserResultLabel.Name = "editUserResultLabel";
            editUserResultLabel.Size = new Size(0, 15);
            editUserResultLabel.TabIndex = 17;
            // 
            // editingIdLabel
            // 
            editingIdLabel.AutoSize = true;
            editingIdLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            editingIdLabel.Location = new Point(37, 44);
            editingIdLabel.Name = "editingIdLabel";
            editingIdLabel.Size = new Size(43, 17);
            editingIdLabel.TabIndex = 18;
            editingIdLabel.Text = "label1";
            // 
            // roleTextBox
            // 
            roleTextBox.Location = new Point(40, 138);
            roleTextBox.Name = "roleTextBox";
            roleTextBox.Size = new Size(159, 23);
            roleTextBox.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 120);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 19;
            label1.Text = "Role";
            // 
            // Edit_User_Panel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 266);
            Controls.Add(roleTextBox);
            Controls.Add(label1);
            Controls.Add(editingIdLabel);
            Controls.Add(editUserResultLabel);
            Controls.Add(exitButton);
            Controls.Add(editButton);
            Controls.Add(sunLabAccessBox);
            Controls.Add(nameTextBox);
            Controls.Add(label2);
            Controls.Add(label90);
            Name = "Edit_User_Panel";
            Text = "Edit_User_Panel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label90;
        private Button exitButton;
        private Button editButton;
        private CheckBox sunLabAccessBox;
        private TextBox nameTextBox;
        private Label label2;
        private Label editUserResultLabel;
        private Label editingIdLabel;
        private TextBox roleTextBox;
        private Label label1;
    }
}
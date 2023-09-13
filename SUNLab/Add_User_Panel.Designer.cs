namespace SUNLab
{
    partial class Add_User_Panel
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
            label2 = new Label();
            addButton = new Button();
            exitButton = new Button();
            addUserResultLabel = new Label();
            idUpDown = new NumericUpDown();
            nameTextBox = new TextBox();
            sunLabAccessBox = new CheckBox();
            roleTextBox = new TextBox();
            label3 = new Label();
            passwordTextBox = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)idUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 35);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 86);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // addButton
            // 
            addButton.Location = new Point(40, 276);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 9;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(127, 276);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 10;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // addUserResultLabel
            // 
            addUserResultLabel.AutoSize = true;
            addUserResultLabel.Location = new Point(37, 252);
            addUserResultLabel.Name = "addUserResultLabel";
            addUserResultLabel.Size = new Size(0, 15);
            addUserResultLabel.TabIndex = 11;
            // 
            // idUpDown
            // 
            idUpDown.Location = new Point(43, 58);
            idUpDown.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            idUpDown.Name = "idUpDown";
            idUpDown.Size = new Size(162, 23);
            idUpDown.TabIndex = 12;
            idUpDown.ValueChanged += idUpDown_ValueChanged;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(43, 104);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(159, 23);
            nameTextBox.TabIndex = 3;
            // 
            // sunLabAccessBox
            // 
            sunLabAccessBox.AutoSize = true;
            sunLabAccessBox.Location = new Point(44, 226);
            sunLabAccessBox.Name = "sunLabAccessBox";
            sunLabAccessBox.Size = new Size(110, 19);
            sunLabAccessBox.TabIndex = 8;
            sunLabAccessBox.Text = "SUN Lab Access";
            sunLabAccessBox.UseVisualStyleBackColor = true;
            // 
            // roleTextBox
            // 
            roleTextBox.Location = new Point(44, 151);
            roleTextBox.Name = "roleTextBox";
            roleTextBox.Size = new Size(159, 23);
            roleTextBox.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 133);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 21;
            label3.Text = "Role";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(44, 197);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(159, 23);
            passwordTextBox.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 179);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 23;
            label4.Text = "Password";
            // 
            // Add_User_Panel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(245, 325);
            Controls.Add(passwordTextBox);
            Controls.Add(label4);
            Controls.Add(roleTextBox);
            Controls.Add(label3);
            Controls.Add(idUpDown);
            Controls.Add(addUserResultLabel);
            Controls.Add(exitButton);
            Controls.Add(addButton);
            Controls.Add(sunLabAccessBox);
            Controls.Add(nameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Add_User_Panel";
            Text = "Add_User_Panel";
            ((System.ComponentModel.ISupportInitialize)idUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button addButton;
        private Button exitButton;
        private Label addUserResultLabel;
        private NumericUpDown idUpDown;
        private TextBox nameTextBox;
        private CheckBox sunLabAccessBox;
        private TextBox roleTextBox;
        private Label label3;
        private TextBox passwordTextBox;
        private Label label4;
    }
}
namespace SUNLab
{
    partial class Swipe_Panel
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
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            statusLabel = new Label();
            passwordBox = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(287, 64);
            button2.Name = "button2";
            button2.Size = new Size(92, 35);
            button2.TabIndex = 1;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += login_Click;
            // 
            // button1
            // 
            button1.Location = new Point(287, 18);
            button1.Name = "button1";
            button1.Size = new Size(92, 35);
            button1.TabIndex = 2;
            button1.Text = "Swipe Card";
            button1.UseVisualStyleBackColor = true;
            button1.Click += swipe_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 28);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 3;
            label1.Text = "ID:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 23);
            textBox1.TabIndex = 4;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(24, 106);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(0, 15);
            statusLabel.TabIndex = 5;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(89, 67);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(192, 23);
            passwordBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 72);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 6;
            label2.Text = "Password:";
            // 
            // Swipe_Panel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 139);
            Controls.Add(passwordBox);
            Controls.Add(label2);
            Controls.Add(statusLabel);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button2);
            Name = "Swipe_Panel";
            Text = "Swipe Panel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private Button SwipeButton;
        private Button button2;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label statusLabel;
        private TextBox passwordBox;
        private Label label2;
    }
}
namespace SUNLab
{
    partial class Admin_Panel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loadButton = new Button();
            entriesTable = new DataGridView();
            searchDateButton = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            lastCommand = new Label();
            usersTable = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            editIdUpDown = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            searchIdUpDown = new NumericUpDown();
            searchIdButton = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)entriesTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usersTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editIdUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchIdUpDown).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // loadButton
            // 
            loadButton.Location = new Point(95, 15);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(118, 28);
            loadButton.TabIndex = 0;
            loadButton.Text = "Load All";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadDataButton_Click;
            // 
            // entriesTable
            // 
            entriesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            entriesTable.Location = new Point(12, 169);
            entriesTable.Name = "entriesTable";
            entriesTable.RowTemplate.Height = 25;
            entriesTable.Size = new Size(464, 329);
            entriesTable.TabIndex = 1;
            entriesTable.CellContentClick += searchButton_Click;
            // 
            // searchDateButton
            // 
            searchDateButton.Location = new Point(101, 88);
            searchDateButton.Name = "searchDateButton";
            searchDateButton.Size = new Size(91, 28);
            searchDateButton.TabIndex = 2;
            searchDateButton.Text = "Search";
            searchDateButton.UseVisualStyleBackColor = true;
            searchDateButton.Click += searchButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 33);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 4;
            label1.Text = "Start Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(80, 27);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(80, 57);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 62);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 6;
            label2.Text = "End Date:";
            // 
            // lastCommand
            // 
            lastCommand.AutoSize = true;
            lastCommand.Location = new Point(633, 73);
            lastCommand.Name = "lastCommand";
            lastCommand.Size = new Size(0, 15);
            lastCommand.TabIndex = 8;
            // 
            // usersTable
            // 
            usersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersTable.Location = new Point(482, 169);
            usersTable.Name = "usersTable";
            usersTable.RowTemplate.Height = 25;
            usersTable.Size = new Size(576, 329);
            usersTable.TabIndex = 9;
            usersTable.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 147);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 10;
            label3.Text = "Entries";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(479, 147);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 11;
            label4.Text = "Users";
            // 
            // button1
            // 
            button1.Location = new Point(115, 15);
            button1.Name = "button1";
            button1.Size = new Size(91, 28);
            button1.TabIndex = 12;
            button1.Text = "Add User...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += addUser_Click;
            // 
            // button2
            // 
            button2.Location = new Point(203, 27);
            button2.Name = "button2";
            button2.Size = new Size(91, 28);
            button2.TabIndex = 13;
            button2.Text = "Edit User";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // editIdUpDown
            // 
            editIdUpDown.Location = new Point(79, 30);
            editIdUpDown.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            editIdUpDown.Name = "editIdUpDown";
            editIdUpDown.Size = new Size(118, 23);
            editIdUpDown.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 33);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 15;
            label5.Text = "ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(25, 32);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 16;
            label6.Text = "ID:";
            // 
            // searchIdUpDown
            // 
            searchIdUpDown.Location = new Point(61, 29);
            searchIdUpDown.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            searchIdUpDown.Name = "searchIdUpDown";
            searchIdUpDown.Size = new Size(118, 23);
            searchIdUpDown.TabIndex = 17;
            // 
            // searchIdButton
            // 
            searchIdButton.Location = new Point(188, 26);
            searchIdButton.Name = "searchIdButton";
            searchIdButton.Size = new Size(91, 28);
            searchIdButton.TabIndex = 18;
            searchIdButton.Text = "Search";
            searchIdButton.UseVisualStyleBackColor = true;
            searchIdButton.Click += searchIdButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(searchIdUpDown);
            groupBox1.Controls.Add(searchIdButton);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(367, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(307, 74);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search by ID";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(searchDateButton);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Location = new Point(12, 14);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(303, 130);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filter by Timestamp";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(editIdUpDown);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(739, 14);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(316, 74);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "Edit User";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(loadButton);
            groupBox4.Location = new Point(367, 94);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(307, 50);
            groupBox4.TabIndex = 22;
            groupBox4.TabStop = false;
            groupBox4.Text = "Refresh";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button1);
            groupBox5.Location = new Point(739, 94);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(316, 50);
            groupBox5.TabIndex = 23;
            groupBox5.TabStop = false;
            groupBox5.Text = "Add User";
            // 
            // Admin_Panel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 510);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(usersTable);
            Controls.Add(lastCommand);
            Controls.Add(entriesTable);
            Name = "Admin_Panel";
            Text = "Admin Panel";
            ((System.ComponentModel.ISupportInitialize)entriesTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)usersTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)editIdUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchIdUpDown).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loadButton;
        private DataGridView entriesTable;
        private Button searchDateButton;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Label lastCommand;
        private DataGridView usersTable;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private NumericUpDown editIdUpDown;
        private Label label5;
        private Label label6;
        private NumericUpDown searchIdUpDown;
        private Button searchIdButton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUNLab
{
    public partial class Add_User_Panel : Form
    {
        public Add_User_Panel()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Session session = new Session();
            int linesChanged = session.addUser((Decimal.ToInt32(idUpDown.Value)), nameTextBox.Text, roleTextBox.Text, sunLabAccessBox.Checked, passwordTextBox.Text);
            if (linesChanged == 1)
            {
                addUserResultLabel.Text = "User added.";
            }
            else
            {
                addUserResultLabel.Text = "Error! User not added.";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void idUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

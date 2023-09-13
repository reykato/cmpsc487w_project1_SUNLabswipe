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
    public partial class Edit_User_Panel : Form
    {
        int id;
        public Edit_User_Panel(int id)
        {
            Session session = new Session();
            User user = session.getUser(id);
            InitializeComponent();
            this.id = id;
            editingIdLabel.Text = user.id + "";
            nameTextBox.Text = user.name;
            roleTextBox.Text = user.role;
            sunLabAccessBox.Checked = user.has_access;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Session session = new Session();
            int linesChanged = session.editUser(this.id, nameTextBox.Text, roleTextBox.Text, sunLabAccessBox.Checked);
            if (linesChanged == 1)
            {
                editUserResultLabel.Text = "Edit saved.";
            }
            else
            {
                editUserResultLabel.Text = "Error! Edit not saved.";
            }
        }
    }
}

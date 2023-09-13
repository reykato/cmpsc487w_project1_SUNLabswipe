namespace SUNLab
{
    public partial class Swipe_Panel : Form
    {
        public Swipe_Panel()
        {
            InitializeComponent();
        }

        private void swipe_Click(object sender, EventArgs e)
        {
            Session s = new Session();
            if (textBox1.TextLength != 9)
            {
                statusLabel.Text = "User ID is incorrectly formatted.";
                return;
            }
            if (s.isUser(int.Parse(textBox1.Text)))
            {
                User user = s.getUser(int.Parse(textBox1.Text));
                if (user.has_access)
                {
                    s.addEntry(user.id);
                    statusLabel.Text = "User ID " + user.id + " swiped in successfully.";
                }
                else
                {
                    statusLabel.Text = "User ID " + user.id + " is not authorized to enter.";
                }
            }
            else
            {
                statusLabel.Text = "User ID " + textBox1.Text + " does not exist in the database.";
            }

            textBox1.Text = string.Empty;

        }

        private void login_Click(object sender, EventArgs e)
        {
            Session s = new Session();
            string status = s.isAdmin(int.Parse(textBox1.Text), passwordBox.Text);
            if (status == "accessgranted")
            {
                var adminForm = new Admin_Panel();
                adminForm.Show();
            }
            else if (status == "nouser")
            {
                statusLabel.Text = "User ID " + textBox1.Text + " does not exist";
            }
            else if (status == "accessdenied")
            {
                statusLabel.Text = "User ID " + textBox1.Text + " is not an admin or the password is incorrect";
            }
            else if (status == "invalidid")
            {
                statusLabel.Text = "Invalid ID";
            }
        }
    }
}

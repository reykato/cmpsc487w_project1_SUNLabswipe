namespace SUNLab
{
    public partial class Admin_Panel : Form
    {
        BindingSource entriesBindingSource = new BindingSource();
        BindingSource usersBindingSource = new BindingSource();
        public Admin_Panel()
        {
            InitializeComponent();
            loadDataButton_Click(null, null);
        }

        private void loadDataButton_Click(object sender, EventArgs e)
        {
            EntriesDAO entriesDAO = new EntriesDAO();


            entriesBindingSource.DataSource = entriesDAO.getAllEntries();
            entriesTable.DataSource = entriesBindingSource;

            usersBindingSource.DataSource = entriesDAO.getAllUsers();
            usersTable.DataSource = usersBindingSource;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            EntriesDAO entriesDAO = new EntriesDAO();

            entriesBindingSource.DataSource = entriesDAO.searchEntriesByDate(dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss"), dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            entriesTable.DataSource = entriesBindingSource;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addUser_Click(object sender, EventArgs e)
        {
            var addForm = new Add_User_Panel();
            addForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Session session = new Session();
            if (session.isUser(Decimal.ToInt32(editIdUpDown.Value)))
            {
                var editForm = new Edit_User_Panel(Decimal.ToInt32(editIdUpDown.Value));
                editForm.Show();
            }
        }

        private void searchIdButton_Click(object sender, EventArgs e)
        {
            EntriesDAO entriesDAO = new EntriesDAO();

            entriesBindingSource.DataSource = entriesDAO.searchEntriesByID(Decimal.ToInt32(searchIdUpDown.Value));
            entriesTable.DataSource = entriesBindingSource;
        }
    }
}
using MySql.Data.MySqlClient;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DBAccess.Instance.SelectUsers();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string uid = textUid.Text.ToString();
            string name = textName.Text.ToLower();
            string hp = textHP.Text.ToString();
            decimal age = numericAge.Value;

            DBAccess.Instance.InsertUser(uid, name, hp, age);

            Reset();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            textUid.Text = String.Empty;
            textName.Text = String.Empty;
            textHP.Text = String.Empty;
            numericAge.ResetText();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            textUid.Text = row.Cells[0].Value.ToString();
            textName.Text = row.Cells[1].Value.ToString();
            textHP.Text = row.Cells[2].Value.ToString();
            numericAge.Value = decimal.Parse(row.Cells[3].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string uid = textUid.Text.ToString();
            string name = textName.Text.ToLower();
            string hp = textHP.Text.ToString();
            decimal age = numericAge.Value;

            DBAccess.Instance.UpdateUser(uid, name, hp, age);
            Reset();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DBAccess.Instance.SelectUsers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DBAccess.Instance.DeleteUser(dataGridView1.CurrentCell.RowIndex);
        }
    }
}
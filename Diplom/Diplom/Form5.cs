using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Diplom
{
    public partial class Form5 : Form
    {
        private readonly checkUser _user;

        public Form5(checkUser user)
        {
            _user = user;

            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }
        private void IsAdmin()
        {
            Staff_Butt.Enabled = _user.Is_Admin;
        }

        private void IsSpec()
        {
            Client_Butt.Enabled = _user.Is_Spec;

            Staff_Butt.Enabled = _user.Is_Spec;
        }
        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.система_для_технической_поддержкиDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "система_для_технической_поддержкиDataSet.Staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this.система_для_технической_поддержкиDataSet.Staff);
            userBox.Text = $"{_user.Login}";
            IsSpec();
            IsAdmin();
        }

        private void Add_Butt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_5 add = new Add_5(_user);
            add.ShowDialog();
        }

        private void Save_Butt_Click(object sender, EventArgs e)
        {
            staffBindingSource.EndEdit();
            staffTableAdapter.Update(система_для_технической_поддержкиDataSet);
            MessageBox.Show("Запись сохранена!", "Предупреждение!");
        }

        private void staffDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.staffBindingSource.EndEdit();
                this.staffTableAdapter.Update(this.система_для_технической_поддержкиDataSet);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection(@"Data Source = DESKTOP-PLUK34H; Initial Catalog = Система для технической поддержки; Integrated Security = True");
            string sqlquery = $"select * from Staff where Specialist like '%" + searchText.Text + "%'";
            SqlConnection.Open();
            SqlCommand command = new SqlCommand(sqlquery, SqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            staffDataGridView.DataSource = table;
            SqlConnection.Close();
        }

        private void searchText2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection(@"Data Source = DESKTOP-PLUK34H; Initial Catalog = Система для технической поддержки; Integrated Security = True");
            string sqlquery = $"select * from Staff where Status like '%" + searchText2.Text + "%'";
            SqlConnection.Open();
            SqlCommand command = new SqlCommand(sqlquery, SqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            staffDataGridView.DataSource = table;
            SqlConnection.Close();
        }

        private void Tasks_Butt_Click_1(object sender, EventArgs e)
        {
            Form5.ActiveForm.Hide();
            Form1 MyForm1 = new Form1(_user);
            MyForm1.ShowDialog();
            Close();
        }

        private void Client_Butt_Click(object sender, EventArgs e)
        {
            Form5.ActiveForm.Hide();
            Form2 MyForm2 = new Form2(_user);
            MyForm2.ShowDialog();
            Close();
        }

        private void Incident_Butt_Click(object sender, EventArgs e)
        {
            Form5.ActiveForm.Hide();
            Form3 MyForm3 = new Form3(_user);
            MyForm3.ShowDialog();
            Close();
        }

        private void Crash_Butt_Click(object sender, EventArgs e)
        {
            Form5.ActiveForm.Hide();
            Form4 MyForm4 = new Form4(_user);
            MyForm4.ShowDialog();
            Close();
        }
    }
}

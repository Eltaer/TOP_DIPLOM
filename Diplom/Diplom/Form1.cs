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
    public partial class Form1 : Form
    {
        private readonly checkUser _user;
        public Form1(checkUser user)
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

        private void taskBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.taskBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.система_для_технической_поддержкиDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "система_для_технической_поддержкиDataSet.Task". При необходимости она может быть перемещена или удалена.
            this.taskTableAdapter.Fill(this.система_для_технической_поддержкиDataSet.Task);
            userBox.Text = $"{_user.Login}";
            IsSpec();
            IsAdmin();

        }

        private void Add_Butt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_1 add = new Add_1(_user);
            add.ShowDialog();
        }

        private void Save_Butt_Click(object sender, EventArgs e)
        {
            taskBindingSource.EndEdit();
            taskTableAdapter.Update(система_для_технической_поддержкиDataSet);
            MessageBox.Show("Запись сохранена!", "Предупреждение!");
        }

        private void taskDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
                this.taskBindingSource.EndEdit();
                this.taskTableAdapter.Update(this.система_для_технической_поддержкиDataSet);
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
            string sqlquery = $"select * from Task where F_CName like '%" + searchText.Text + "%'";
            SqlConnection.Open();
            SqlCommand command = new SqlCommand(sqlquery, SqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            taskDataGridView.DataSource = table;
            SqlConnection.Close();
        }

        private void searchText2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection(@"Data Source = DESKTOP-PLUK34H; Initial Catalog = Система для технической поддержки; Integrated Security = True");
            string sqlquery = $"select * from Task where Specialist like '%" + searchText2.Text + "%'";
            SqlConnection.Open();
            SqlCommand command = new SqlCommand(sqlquery, SqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            taskDataGridView.DataSource = table;
            SqlConnection.Close();
        }

        private void searchText3_TextChanged(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection(@"Data Source = DESKTOP-PLUK34H; Initial Catalog = Система для технической поддержки; Integrated Security = True");
            string sqlquery = $"select * from Task where Address like '%" + searchText3.Text + "%'";
            SqlConnection.Open();
            SqlCommand command = new SqlCommand(sqlquery, SqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            taskDataGridView.DataSource = table;
            SqlConnection.Close();
        }

        private void Client_Butt_Click_1(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form2 MyForm2 = new Form2(_user);
            MyForm2.ShowDialog();
            Close();
        }

        private void Incident_Butt_Click_1(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form3 MyForm3 = new Form3(_user);
            MyForm3.ShowDialog();
            Close();
        }

        private void Crash_Butt_Click_1(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form4 MyForm4 = new Form4(_user);
            MyForm4.ShowDialog();
            Close();
        }

        private void Staff_Butt_Click_1(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form5 MyForm5 = new Form5(_user);
            MyForm5.ShowDialog();
            Close();
        }

    }
}

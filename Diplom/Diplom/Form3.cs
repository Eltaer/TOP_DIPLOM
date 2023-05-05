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
    public partial class Form3 : Form
    {
        private readonly checkUser _user;

        public Form3(checkUser user)
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
        private void incidentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.incidentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.система_для_технической_поддержкиDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "система_для_технической_поддержкиDataSet.Incident". При необходимости она может быть перемещена или удалена.
            this.incidentTableAdapter.Fill(this.система_для_технической_поддержкиDataSet.Incident);
            userBox.Text = $"{_user.Login}";
            IsSpec();
            IsAdmin();
        }

        private void Tasks_Butt_Click(object sender, EventArgs e)
        {
            
        }

        private void Client_Butt_Click(object sender, EventArgs e)
        {
            
        }

        private void Crash_Butt_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Staff_Butt_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Add_Butt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_3 add = new Add_3(_user);
            add.ShowDialog();
        }

        private void Save_Butt_Click(object sender, EventArgs e)
        {
            incidentBindingSource.EndEdit();
            incidentTableAdapter.Update(система_для_технической_поддержкиDataSet);
            MessageBox.Show("Запись сохранена!", "Предупреждение!");
        }

        private void incidentDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
                this.incidentBindingSource.EndEdit();
                this.incidentTableAdapter.Update(this.система_для_технической_поддержкиDataSet);
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
            string sqlquery = $"select * from Incident where F_CName like '%" + searchText.Text + "%'";
            SqlConnection.Open();
            SqlCommand command = new SqlCommand(sqlquery, SqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            incidentDataGridView.DataSource = table;
            SqlConnection.Close();
        }

        private void searchText2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection(@"Data Source = DESKTOP-PLUK34H; Initial Catalog = Система для технической поддержки; Integrated Security = True");
            string sqlquery = $"select * from Incident where Contract_Number like '%" + searchText2.Text + "%'";
            SqlConnection.Open();
            SqlCommand command = new SqlCommand(sqlquery, SqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            incidentDataGridView.DataSource = table;
            SqlConnection.Close();
        }

        private void searchText3_TextChanged(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection(@"Data Source = DESKTOP-PLUK34H; Initial Catalog = Система для технической поддержки; Integrated Security = True");
            string sqlquery = $"select * from Incident where Address like '%" + searchText3.Text + "%'";
            SqlConnection.Open();
            SqlCommand command = new SqlCommand(sqlquery, SqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            incidentDataGridView.DataSource = table;
            SqlConnection.Close();
        }

        private void searchText4_TextChanged(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection(@"Data Source = DESKTOP-PLUK34H; Initial Catalog = Система для технической поддержки; Integrated Security = True");
            string sqlquery = $"select * from Incident where Condition like '%" + searchText4.Text + "%'";
            SqlConnection.Open();
            SqlCommand command = new SqlCommand(sqlquery, SqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            incidentDataGridView.DataSource = table;
            SqlConnection.Close();
        }

        private void searchText5_TextChanged(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection(@"Data Source = DESKTOP-PLUK34H; Initial Catalog = Система для технической поддержки; Integrated Security = True");
            string sqlquery = $"select * from Incident where Specialist like '%" + searchText5.Text + "%'";
            SqlConnection.Open();
            SqlCommand command = new SqlCommand(sqlquery, SqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            incidentDataGridView.DataSource = table;
            SqlConnection.Close();
        }

        private void Tasks_Butt_Click_1(object sender, EventArgs e)
        {
            Form3.ActiveForm.Hide();
            Form1 MyForm1 = new Form1(_user);
            MyForm1.ShowDialog();
            Close();
        }

        private void Client_Butt_Click_1(object sender, EventArgs e)
        {
            Form3.ActiveForm.Hide();
            Form2 MyForm2 = new Form2(_user);
            MyForm2.ShowDialog();
            Close();
        }

        private void Crash_Butt_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Hide();
            Form4 MyForm4 = new Form4(_user);
            MyForm4.ShowDialog();
            Close();
        }

        private void Staff_Butt_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Hide();
            Form5 MyForm5 = new Form5(_user);
            MyForm5.ShowDialog();
            Close();
        }
    }
}

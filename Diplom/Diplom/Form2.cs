using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Diplom
{
    public partial class Form2 : Form
    {
        private readonly checkUser _user;

        public Form2(checkUser user)
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

            Add_Butt.Enabled = _user.Is_Spec;

            Save_Butt.Enabled = _user.Is_Spec;

            Delete.Enabled = _user.Is_Spec;

        }
        private void Add_Butt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_2 add = new Add_2(_user);
            add.ShowDialog();
        }

        private void Save_Butt_Click(object sender, EventArgs e)
        {
            clientsBindingSource.EndEdit();
            clientsTableAdapter.Update(система_для_технической_поддержкиDataSet);
            MessageBox.Show("Запись сохранена!", "Предупреждение!");
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.система_для_технической_поддержкиDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "система_для_технической_поддержкиDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.система_для_технической_поддержкиDataSet.Clients);

            userBox.Text = $"{_user.Login}";
            IsSpec();
            IsAdmin();

            SqlConnection SqlConnection = new SqlConnection(@"Data Source = DESKTOP-PLUK34H; Initial Catalog = Система для технической поддержки; Integrated Security = True");
            string sqlquery = "select * from Clients";
            SqlConnection.Open();
            SqlCommand command = new SqlCommand(sqlquery, SqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            clientsDataGridView.DataSource = table;
            SqlConnection.Close();
        }

        private void Tasks_Butt_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Incident_Butt_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Crash_Butt_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Staff_Butt_Click_1(object sender, EventArgs e)
        {
            
        }

        private void clientsDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection(@"Data Source = DESKTOP-PLUK34H; Initial Catalog = Система для технической поддержки; Integrated Security = True");
            string sqlquery = $"select * from Clients where Contract_Number like '%" + searchText.Text + "%'";
            SqlConnection.Open();
            SqlCommand command = new SqlCommand(sqlquery, SqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            clientsDataGridView.DataSource = table;
            SqlConnection.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.clientsBindingSource.EndEdit();
                this.clientsTableAdapter.Update(this.система_для_технической_поддержкиDataSet);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void searchText2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection(@"Data Source = DESKTOP-PLUK34H; Initial Catalog = Система для технической поддержки; Integrated Security = True");
            string sqlquery = $"select * from Clients where Tariff like '%" + searchText2.Text + "%'";
            SqlConnection.Open();
            SqlCommand command = new SqlCommand(sqlquery, SqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            clientsDataGridView.DataSource = table;
            SqlConnection.Close();
        }

        private void searchText3_TextChanged(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection(@"Data Source = DESKTOP-PLUK34H; Initial Catalog = Система для технической поддержки; Integrated Security = True");
            string sqlquery = $"select * from Clients where Address like '%" + searchText3.Text + "%'";
            SqlConnection.Open();
            SqlCommand command = new SqlCommand(sqlquery, SqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            clientsDataGridView.DataSource = table;
            SqlConnection.Close();
        }

        private void Tasks_Butt_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form1 MyForm1 = new Form1(_user);
            MyForm1.ShowDialog();
            Close();
        }

        private void Incident_Butt_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form3 MyForm3 = new Form3(_user);
            MyForm3.ShowDialog();
            Close();
        }

        private void Crash_Butt_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form4 MyForm4 = new Form4(_user);
            MyForm4.ShowDialog();
            Close();
        }

        private void Staff_Butt_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form5 MyForm5 = new Form5(_user);
            MyForm5.ShowDialog();
            Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                SqlConnection SqlConnection = new SqlConnection(@"Data Source = DESKTOP-PLUK34H; Initial Catalog = Система для технической поддержки; Integrated Security = True");
                SqlConnection.Open();
                var selectedRowIndex = clientsDataGridView.CurrentCell.RowIndex;

                var id = Convert.ToInt32(clientsDataGridView.Rows[selectedRowIndex].Cells[0].Value);
                var deleteQuery = $"DELETE FROM Clients WHERE Client_ID = {id}";

                var command = new SqlCommand(deleteQuery, SqlConnection);
                command.ExecuteNonQuery();

                SqlConnection.Close();

                clientsDataGridView.Update();
                clientsDataGridView.Refresh();            
        }
    }
}

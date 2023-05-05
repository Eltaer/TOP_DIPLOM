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
    public partial class Form7 : Form
    {
        DB db = new DB();
        public Form7()
        {

            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private Boolean check_user()
        {
            var loginUser = TextBoxLogin.Text;
            var passUser = TextBoxPassword.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select User_ID, Login, Pass, is_admin, is_spec from Register where Login = '{loginUser}' and Pass = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;

            }
            else
            {
                return false;
            }
        }

        private void Create_Butt_Click(object sender, EventArgs e)
        {            

            var loginUser = TextBoxLogin.Text;
            var passUser = TextBoxPassword.Text;           

            string querystring = $"insert into Register(Login, Pass, is_admin, is_spec) values('{loginUser}', '{passUser}', 0, 0)";

            SqlCommand command = new SqlCommand(querystring, db.getConnection());

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт создан!", "Успешно!");
                Form6 frm6 = new Form6();   
                this.Hide();
                frm6.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан");
            }
        }
    }
}

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

namespace Diplom
{
    public partial class Form6 : Form
    {
        public Form1 ParentForm;

        public Form6()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginUser = TextBoxLogin.Text;
            var passUser = TextBoxPassword.Text;

            DB db = new DB();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select * from Register where Login = '{loginUser}' and Pass = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, db.getConnection());


            adapter.SelectCommand = command;
            adapter.Fill(table);



            if (table.Rows.Count == 1)
            {
                var user = new checkUser(table.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(table.Rows[0].ItemArray[3]), Convert.ToBoolean(table.Rows[0].ItemArray[4]));
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 frm1 = new Form1(user);
                this.Hide();
                frm1.ShowDialog();
                this.Show();

            }
            else
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
        }

        private void Register_Butt_Click(object sender, EventArgs e)
        {
            Form6.ActiveForm.Hide();
            Form7 MyForm7 = new Form7();
            MyForm7.ShowDialog();
            Close();
        }
    }
}

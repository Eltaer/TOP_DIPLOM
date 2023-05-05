using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class Add_1 : Form
    {
        private readonly checkUser _user;

        public Add_1(checkUser user)
        {
            _user = user;

            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            
                taskBindingSource.AddNew();
                taskTableAdapter.Update(система_для_технической_поддержкиDataSet);
            
        }

        private void taskBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.taskBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.система_для_технической_поддержкиDataSet);

        }

        private void Add_1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "система_для_технической_поддержкиDataSet.Task". При необходимости она может быть перемещена или удалена.
            this.taskTableAdapter.Fill(this.система_для_технической_поддержкиDataSet.Task);
            
        }

        private void CloseAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1(_user);
            Form1.ShowDialog();
        }
    }
}

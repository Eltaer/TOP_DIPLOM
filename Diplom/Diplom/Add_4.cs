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
    public partial class Add_4 : Form
    {
        private readonly checkUser _user;

        public Add_4(checkUser user)
        {
            _user = user;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void crashBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.crashBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.система_для_технической_поддержкиDataSet);

        }

        private void Add_4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "система_для_технической_поддержкиDataSet.Crash". При необходимости она может быть перемещена или удалена.
            this.crashTableAdapter.Fill(this.система_для_технической_поддержкиDataSet.Crash);

        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            crashBindingSource.AddNew();
            crashTableAdapter.Update(система_для_технической_поддержкиDataSet);
        }

        private void CloseAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 Form4 = new Form4(_user);
            Form4.ShowDialog();
        }
    }
}

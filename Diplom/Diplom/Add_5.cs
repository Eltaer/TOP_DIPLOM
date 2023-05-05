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
    public partial class Add_5 : Form
    {
        private readonly checkUser _user;

        public Add_5(checkUser user)
        {
            _user = user;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.система_для_технической_поддержкиDataSet);

        }

        private void Add_5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "система_для_технической_поддержкиDataSet.Staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this.система_для_технической_поддержкиDataSet.Staff);

        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            staffBindingSource.AddNew();
            staffTableAdapter.Update(система_для_технической_поддержкиDataSet);
        }

        private void CloseAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 Form5 = new Form5(_user);
            Form5.ShowDialog();
        }

    }
}

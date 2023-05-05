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
    public partial class Add_3 : Form
    {
        private readonly checkUser _user;

        public Add_3(checkUser user)
        {
            _user = user;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void incidentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.incidentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.система_для_технической_поддержкиDataSet);

        }

        private void Add_3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "система_для_технической_поддержкиDataSet.Incident". При необходимости она может быть перемещена или удалена.
            this.incidentTableAdapter.Fill(this.система_для_технической_поддержкиDataSet.Incident);

        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            incidentBindingSource.AddNew();
            incidentTableAdapter.Update(система_для_технической_поддержкиDataSet);
        }

        private void CloseAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 Form3 = new Form3(_user);
            Form3.ShowDialog();
        }
    }
}

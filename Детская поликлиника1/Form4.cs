using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Детская_поликлиника1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void приёмBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.приёмBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.детская_поликлиника_1DataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "детская_поликлиника_1DataSet.Приём". При необходимости она может быть перемещена или удалена.
            this.приёмTableAdapter.Fill(this.детская_поликлиника_1DataSet.Приём);

        }

        private void код_врачаTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        public Form4(Form1 f)
        {
            InitializeComponent();
        }
    }
}

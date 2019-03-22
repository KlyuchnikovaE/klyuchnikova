using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Детская_поликлиника5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void приёмBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.приёмBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.детская_поликлиника_1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "детская_поликлиника_1DataSet.Приём". При необходимости она может быть перемещена или удалена.
            this.приёмTableAdapter.Fill(this.детская_поликлиника_1DataSet.Приём);

        }

      
        private void button4_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4(this);
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5(this);
            newForm.Show();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(this);
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3(this);
            newForm.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beer
{
    public partial class Supliers : Form
    {
        public Supliers()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "Sur";
            column2.HeaderText = "Фамилия";
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "Ima";
            column1.HeaderText = "Имя";
            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.Name = "Pat";
            column3.HeaderText = "Отчество";
            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.Name = "Stat";
            column4.HeaderText = "Согласование";
            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            column4.Name = "Date";
            column4.HeaderText = "Дата";

            DataGridViewCell Sur0 = new DataGridViewTextBoxCell();
            DataGridViewCell Ima0 = new DataGridViewTextBoxCell();
            DataGridViewCell Pat0 = new DataGridViewTextBoxCell();
            DataGridViewCell Stat0 = new DataGridViewTextBoxCell();
            DataGridViewCell Date0 = new DataGridViewTextBoxCell();

            Sur0.Value = "Сандалин";
            Ima0.Value = "Евгений";
            Pat0.Value = "Федорович";
            Stat0.Value = "Согласован";
            Date0.Value = "20.05.2023";

            DataGridViewCell Sur1 = new DataGridViewTextBoxCell();
            DataGridViewCell Ima1 = new DataGridViewTextBoxCell();
            DataGridViewCell Pat1 = new DataGridViewTextBoxCell();
            DataGridViewCell Stat1 = new DataGridViewTextBoxCell();
            DataGridViewCell Date1 = new DataGridViewTextBoxCell();

            Sur1.Value = "Жлобин";
            Ima1.Value = "Севастьян";
            Pat1.Value = "Георгиевич";
            Stat1.Value = "Несогласован";
            Date1.Value = "30.05.2023";


            DataGridViewRow row1 = new DataGridViewRow();
            row1.Cells.AddRange(Sur1, Ima1, Pat1, Stat1,Date1);
            //Table.Rows.Add(row1);
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

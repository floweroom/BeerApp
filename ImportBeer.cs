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
    public partial class ImportBeer : Form
    {
        public ImportBeer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewSupliers viewSupliers = new ViewSupliers();
            viewSupliers.Show();
        }
    }
}

using Beer.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Beer
{

    public partial class Supliers : Form
    {
        //DbBeerApp Db;
        public Supliers()
        {

            InitializeComponent();





            var options = new DbContextOptionsBuilder<DbBeerApp>()
                .UseSqlServer("Server=(localDB)\\MSSQLLOCALDB;DATABASE=SupliersDB")
                .Options;





            //Db.Objs.Load();
            //dataGridView1.DataSource = Db.Objs.Local.ToBindingList();


            dataGridView1.AllowUserToAddRows = false;


            DataGridViewCell Sur0 = new DataGridViewTextBoxCell();
            DataGridViewCell Ima0 = new DataGridViewTextBoxCell();
            DataGridViewCell Pat0 = new DataGridViewTextBoxCell();
            DataGridViewCell Stat0 = new DataGridViewTextBoxCell();
            DataGridViewCell Date0 = new DataGridViewTextBoxCell();

            Sur0.Value = "Володин";
            Ima0.Value = "Евгений";
            Pat0.Value = "Федорович";
            Stat0.Value = "Согласован";
            Date0.Value = "04.06.2023";

            DataGridViewCell Sur1 = new DataGridViewTextBoxCell();
            DataGridViewCell Ima1 = new DataGridViewTextBoxCell();
            DataGridViewCell Pat1 = new DataGridViewTextBoxCell();
            DataGridViewCell Stat1 = new DataGridViewTextBoxCell();
            DataGridViewCell Date1 = new DataGridViewTextBoxCell();

            Sur1.Value = "Иванов";
            Ima1.Value = "Севастьян";
            Pat1.Value = "Георгиевич";
            Stat1.Value = "Несогласован";
            Date1.Value = "04.06.2023";

            DataGridViewRow row = new DataGridViewRow();
            row.Cells.AddRange(Sur0, Ima0, Pat0, Stat0, Date0);



            DataGridViewRow row1 = new DataGridViewRow();
            row1.Cells.AddRange(Sur1, Ima1, Pat1, Stat1, Date1);

            dataGridView1.Rows.Add(row);
            dataGridView1.Rows.Add(row1);

            using (var Db = new DbBeerApp(options))
            {
                Db.Database.EnsureCreated();
                foreach (DataGridViewRow dataRow in dataGridView1.Rows)
                {
                    var surname = dataRow.Cells[0].Value;
                    var name = dataRow.Cells[1].Value;
                    var pat = dataRow.Cells[2].Value;
                    var status = dataRow.Cells[3].Value;
                    var date = dataRow.Cells[4].Value;

                    Agreement agreement = new Agreement()
                    {
                        Surname = surname.ToString(),
                        Name = name.ToString(),
                        Patronimic = pat.ToString(),
                        Status = status.ToString(),
                        Date = date.ToString()
                    };
                    Db.Objs.Add(agreement);


                    //LoadTable(tableName);
                }
                Db.SaveChanges();
            }
        }



    }

    //private void button9_Click(object sender, EventArgs e)
    //{
    //    //DataTable table = new DataTable();
    //    //dataGridView1.DataSource = table;
    //    Agreement agreement = new Agreement()
    //    {
    //        Surname = dataGridView1.Column1
    //        Name =
    //        Patronimic =
    //        Status =
    //        Date =
    //    };

    //    for (int i = 0; i< dataGridView1.Rows.Count; i++)
    //    {
    //        Db.Objs.Add();
    //    }

    //    Db.SaveChanges();
    //    //dataGridView1.Refresh(); // обновляем грид

    //}
}









//    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
//{




//DataColumn column = new DataColumn();
//column.DataType = System.Type.GetType("System.Int32");
//column.AutoIncrement = true;
//column.AutoIncrementSeed = 1000;
//column.AutoIncrementStep = 10;


//DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
//column1.Name = "Sur";
//column1.HeaderText = "Фамилия";
//DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
//column2.Name = "Ima";
//column2.HeaderText = "Имя";
//DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
//column3.Name = "Pat";
//column3.HeaderText = "Отчество";
//DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
//column4.Name = "Stat";
//column4.HeaderText = "Согласование";
//DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
//column5.Name = "Date";
//column5.HeaderText = "Дата";




//table.Columns.Add("Фамилия", typeof(string));
//table.Columns.Add("Имя", typeof(string));
//table.Columns.Add("Отчество", typeof(string));
//table.Columns.Add("Согласование", typeof(string));
//table.Columns.Add("Дата", typeof(DateTime));


//DataGridViewCell Sur0 = new DataGridViewTextBoxCell();
//DataGridViewCell Ima0 = new DataGridViewTextBoxCell();
//DataGridViewCell Pat0 = new DataGridViewTextBoxCell();
//DataGridViewCell Stat0 = new DataGridViewTextBoxCell();
//DataGridViewCell Date0 = new DataGridViewTextBoxCell();

//Sur0.Value = "Володин";
//Ima0.Value = "Евгений";
//Pat0.Value = "Федорович";
//Stat0.Value = "Согласован";
//Date0.Value = "20.05.2023";

//DataGridViewCell Sur1 = new DataGridViewTextBoxCell();
//DataGridViewCell Ima1 = new DataGridViewTextBoxCell();
//DataGridViewCell Pat1 = new DataGridViewTextBoxCell();
//DataGridViewCell Stat1 = new DataGridViewTextBoxCell();
//DataGridViewCell Date1 = new DataGridViewTextBoxCell();

//Sur1.Value = "Иванов";
//Ima1.Value = "Севастьян";
//Pat1.Value = "Георгиевич";
//Stat1.Value = "Несогласован";
//Date1.Value = "30.05.2023";



//DataGridViewRow row = new DataGridViewRow();
//row.Cells.AddRange(Sur0, Ima0, Pat0, Stat0, Date0);



////DataGridViewRow row1 = new DataGridViewRow();
////row1.Cells.AddRange(Sur1, Ima1, Pat1, Stat1, Date1);
////table.Rows.Add(row1, row);
//x;
//}




//        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }



//}

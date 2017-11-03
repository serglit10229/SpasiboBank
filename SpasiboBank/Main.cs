using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpasiboBank
{
    public partial class Main : Form
    {

        //public Form1 form = new Form1();
        
        public Main()
        {
            InitializeComponent();
        }

        private void Usernamelabel_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void ARBUZbutton_CheckedChanged(object sender, EventArgs e)
        {

          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //MySqlCommand commandInsert = new MySqlCommand("INSERT INTO " + form.usermoney + "(SPSamount) VALUES(@SPSamount)", form.con);
            //commandInsert.Parameters.AddWithValue("@SPSamount", textBox2);
            //commandInsert.ExecuteNonQuery();
            //commandInsert.Parameters.Clear();
            //MessageBox.Show("Money were unsuccessfully sent. Pending: 666 Hrs, 666 Min, 666 Sec");
            
        }
    }
}

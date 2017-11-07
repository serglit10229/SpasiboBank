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
        public MySqlConnection con = new MySqlConnection("SERVER=db4free.net;PORT=3307;DATABASE=spasibo_bank;UID=serglit10229;PWD=serglit102;");
        public string usermoney;
        public string nameuser;
        public string senduser;

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
            Usernamelabel.Text = nameuser;
            if (nameuser == "ARBUZ")
            {
                ARBUZbutton.Enabled = false;
                usermoney = "ARBUZMoney";
            }
            if (nameuser == "BobZEHorse")
            {
                BobZEHorsebutton.Enabled = false;
                usermoney = "BOBmoney";
            }
            if (nameuser == "HankZEChmo")
            {
                HankZEChmobutton.Enabled = false;
                usermoney = "HANKMoney";
            }


            if (BobZEHorsebutton.Checked == true)
            {
                senduser = "Bobmoney";
            }
            if (ARBUZbutton.Checked == true)
            {
                senduser = "ARBUZMoney";
            }
            if (HankZEChmobutton.Checked == true)
            {
                senduser = "HankMoney";
            }

            DateTime localDate = DateTime.Now;
            int sendvalue = int.Parse(textBox2.Text);

            con.Open();
            MySqlCommand commandInsert = new MySqlCommand("INSERT INTO `" +senduser+ "`(`SPSamount`) VALUES ("+sendvalue+")", con);
            commandInsert.Parameters.AddWithValue("@SPSamount", textBox2);
            commandInsert.ExecuteNonQuery();
            commandInsert.Parameters.Clear();
            MessageBox.Show("Money were unsuccessfully sent. Pending: 666 Hrs, 666 Min, 666 Sec");

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;


namespace SpasiboBank
{
    public partial class Form1 : Form
    {

        public string usermoney;
        public bool Send = false;

        public string nameuser;
        int tries = 0;
        Main ss = new Main();

        public MySqlConnection con = new MySqlConnection("SERVER=db4free.net;PORT=3307;DATABASE=spasibo_bank;UID=serglit10229;PWD=serglit102;");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MySqlDataAdapter sda = new MySqlDataAdapter(" Select Count(*) From Login where Username ='" + textBox1.Text + "' and Password ='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            Console.WriteLine(textBox1);

            if (dt.Rows[0][0].ToString() == "1")
            {

                this.Hide();

                
                ss.Usernamelabel.Text = nameuser;
                if (nameuser == "ARBUZ")
                {
                    ss.ARBUZbutton.Enabled = false;
                    usermoney = "ARBUZMoney";
                }
                if (nameuser == "BobZEHorse")
                {
                    ss.BobZEHorsebutton.Enabled = false;
                    usermoney = "BOBmoney";
                }
                if (nameuser == "HankZEChmo")
                {
                    ss.HankZEChmobutton.Enabled = false;
                    usermoney = "HANKMoney";
                }


                ss.Show();
            }
            else
            {
                tries++;
                if (tries == 1)
                {
                    MessageBox.Show("It seems that you are having trouble with your memory. Please, see a doctor", "OOPS", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    tries++;
                }
                if (tries > 2)
                {
                    MessageBox.Show("TOO BAD", "Still having trouble?", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
            }

            //("SELECT * FROM BOBmoney", con)
            MySqlDataAdapter sps = new MySqlDataAdapter("SELECT * FROM " + usermoney, con);
            DataTable dataTable = new DataTable();
            sps.Fill(dataTable);
            ss.dataGridView1.DataSource = dataTable;


            




        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nameuser = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}

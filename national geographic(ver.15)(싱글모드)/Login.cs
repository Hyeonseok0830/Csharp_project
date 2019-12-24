using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace national_geographic
{
    public partial class Login : Form
    {

        memberjoin join;        
        Form1 frm1;
        Bitmap login1 = Properties.Resources.Login1;
        Bitmap login2 = Properties.Resources.Login2;
        Bitmap exit1 = Properties.Resources.EXIT1;
        Bitmap exit2 = Properties.Resources.EXIT2;
        Bitmap join1 = Properties.Resources.Join1;
        Bitmap join2 = Properties.Resources.Join2;
        public string m_name, m_score;
        MySqlConnection connection =
     new MySqlConnection("Server=localhost;Database=ng_test_member;Uid=root;Pwd=apple;");
        public Login()
        {
            InitializeComponent();
            pictureBox1.Image = login1;
            pictureBox2.Image = exit1;
            pictureBox3.Image = join1;

        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = login2;
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = login1;
        }

        private void PictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = exit2;

        }

        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = exit1;
        }

        private void Open_mainForm(object sender, MouseEventArgs e)
        {

            string ReadData = "SELECT pass,name,rank_score FROM ng_member where id='" + l_id_text.Text + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(ReadData, connection);
            MySqlDataReader rd = command.ExecuteReader();
            if (rd.Read() && rd["pass"].ToString() == l_pass_text.Text)
            {
                m_name = rd["name"].ToString();
                m_score = rd["rank_score"].ToString();
                frm1 = new Form1();
                frm1.Show();

                
            }
            else
            {
                MessageBox.Show("비밀번호가 맞지 않아요");
            }

            connection.Close();


        }

        private void Close_thisForm(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void PictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Image = join2;
        }

        private void PictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = join1;
        }

        private void Open_joinForm(object sender, MouseEventArgs e)
        {
            join = new memberjoin();
            join.Show();
        }
    }
}
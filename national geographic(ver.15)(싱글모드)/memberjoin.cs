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
    public partial class memberjoin : Form
    {
  
        Bitmap exit1 = Properties.Resources.EXIT1;
        Bitmap exit2 = Properties.Resources.EXIT2;
        Bitmap join1 = Properties.Resources.Join1;
        Bitmap join2 = Properties.Resources.Join2;

        MySqlConnection connection =
        new MySqlConnection("Server=localhost;Database=ng_test_member;Uid=root;Pwd=apple;");
        //서버     //DB이름      // 유저이름  //비밀번호
        public memberjoin()
        {
            
            InitializeComponent();            
            pictureBox1.Image = exit1;
            pictureBox2.Image = join1;
          
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = exit2;
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = exit1;
        }

        private void PictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = join2;
        }

        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = join1;
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void PictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            //디비 등록           
            string insertQuery = "INSERT INTO ng_member(ID,pass,name,rank_score) VALUES('" + id_text.Text + "','" + pass_text.Text + "','" + name_text.Text+ "','" + 0 + "')";
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try//예외 처리
            {
                // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                if (pass_text.ToString() == checkpass_text.ToString())
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("정상적으로 등록 되었습니다.");
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("비밀번호를 확인해주세요");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//다시 확인 , 주키중복 
            }


            connection.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
    
}

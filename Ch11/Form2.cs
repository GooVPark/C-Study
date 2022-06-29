using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            List<string> positions= new List<string>() { "사무원", "대리", "과장", "차장", "부장" };
            cbPosition.DataSource = positions;

            string[] hobbies = { "등산", "운동", "영화", "독서", "게임" };
            cbHobby.DataSource = hobbies;

            string[] country = { "한국", "미국", "일본", "중국", "대만", "호주", "영국", "프랑스", "독일", "스페인" };

            lstCountry.DataSource = country;

            List<Member> members = new List<Member>();
            members.Add(new Member("a101", "김유신", "010-1000-1234", 24));
            members.Add(new Member("a102", "김춘추", "010-2000-1234", 21));
            members.Add(new Member("a103", "장보고", "010-3000-1234", 34));
            members.Add(new Member("a104", "강감찬", "010-4000-1234", 44));
            members.Add(new Member("a105", "이순신", "010-5000-1234", 54));

            dgvMember.DataSource = members;
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            lbResultPosition.Text = "결과: " + cbPosition.Text;
        }

        private void btnHobby_Click(object sender, EventArgs e)
        {
            lbResultHobby.Text = "결과: " + cbHobby.Text;
        }

        private void lstCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbResultCountry.Text = lstCountry.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

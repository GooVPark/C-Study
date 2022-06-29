namespace Ch11
{
    public partial class Form1 : Form
    {
        private string textBox_ID;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�޼��� �ڽ�1");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("����� ������ �ִ� �޼��� �ڽ�", "�޼��� �ڽ�2");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�ΰ��� ��ư�� ���� �޼��� �ڽ�", "�޼��� �ڽ�3", MessageBoxButtons.YesNo);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������ ��ư�� ���� �޼��� �ڽ�", "�޼��� �ڽ�4", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
        }

        private void TextBox_ID(object sender, EventArgs e)
        {
        
        }

        private void TextBox_Name(object sender, EventArgs e)
        {

        }

        private void TextBox_Phone(object sender, EventArgs e)
        {

        }

        private void btnUID_Click(object sender, EventArgs e)
        {
            string uid = textUID.Text;
            lbUID.Text = "���: " + uid;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            lbName.Text = "���: " + name;
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            string phone = textPhone.Text;
            lbPhone.Text = "���: " + phone;
        }

        private void Lable_SelectedFruits(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckBox[] chnFruits = { chbFruit1, chbFruit2, chbFruit3, chbFruit4, chbFruit5 };
            
            List<string> fruits = new List<string>();

            foreach(CheckBox chb in chnFruits)
            {
                if(chb.Checked) fruits.Add(chb.Text);
            }

            lbSelectedFruits.Text = "������ ����: " + String.Join(", ", fruits);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void GroupBox_GenderSelect(object sender, EventArgs e)
        {

        }

        private void Button_GenderSelect(object sender, EventArgs e)
        {
            if(rdbGenderMale.Checked)
            {
                genderResult.Text = "���: ����";
            }
            else if(rdbGenderFemale.Checked)
            {
                genderResult.Text = "���: ����";
            }
        }  
        private void gradeCheck_Click(object sender, EventArgs e)
        {
            if(rdbGrade1.Checked)
            {
                gradeResult.Text = "���: 1�г�";
            }
            else if(rdbGrade2.Checked)
            {
                gradeResult.Text = "���: 2�г�";
            }
            else if(rdbGrade3.Checked)
            {
                gradeResult.Text = "���: 3�г�";
            }
            else if(rdbGrade4.Checked)
            {
                gradeResult.Text = "���: 4�г�";
            }
        }

        private void form2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
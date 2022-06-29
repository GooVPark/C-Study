namespace Project1
{
    public partial class MyCalculator : Form
    {
        private int var1;
        private int var2;
        private int result;

        private int operate = 0; //1: plus, 2: minus, 3: mulit, 4: div

        private List<int> list = new List<int>();

        private string input;
        private Postfix postfix = new Postfix();

        public MyCalculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnButtonClick(string input)
        {
            if (textProgress.Text == "0" && input == "0") textProgress.Text = input;
            else textProgress.Text += input;

            textResult.Text = input;
            
            postfix.InsertValue(input);
        }

        #region Numbers

        private void btn0_Click(object sender, EventArgs e)
        {
            OnButtonClick("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            OnButtonClick("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            OnButtonClick("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            OnButtonClick("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            OnButtonClick("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            OnButtonClick("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            OnButtonClick("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            OnButtonClick("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            OnButtonClick("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            OnButtonClick("9");
        }

        #endregion

        #region Operators

        private void btnPlus_Click(object sender, EventArgs e)
        {
            OnButtonClick("+");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            OnButtonClick("-");
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            OnButtonClick("*");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            OnButtonClick("/");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            postfix.InsertValue("=");
            textResult.Text = postfix.Print();
            textResult.Text = postfix.Calculate();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OnButtonClick("(");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            OnButtonClick(")");
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            postfix.Clear();
            textResult.Text = "0";
        }

        private void MyCalculator_Load(object sender, EventArgs e)
        {
            
        }


    }
}
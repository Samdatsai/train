namespace train
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string num = "�|�����";
        string kind = "�|�����";
        string start = "�|�����";
        string end = "�|�����";

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            num = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
            num = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
            num = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            num = "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            button7.Enabled = true;
            button6.Enabled = true;
            kind = "�۱j";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button8.Enabled = true;
            button7.Enabled = false;
            button6.Enabled = true;
            kind = "����";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button8.Enabled = true;
            button7.Enabled = true;
            button6.Enabled = false;
            kind = "�϶�";
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
        private void getticket(string num, string kind, string start, string end)
        {
            textBox1.Text += "�ʶR" + num + "��\t" + kind + "\t" + start + "\t" + end + "\r\n";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            getticket(num, kind, start, end);
        }
    }
}
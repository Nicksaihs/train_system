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

        private void get_ticket(string num, string kind, string start, string end)
        {
            textBox1.Text += "�ʶR" + num + "��\t " + kind + "\t" + start + "\t" + end + "\r\n";
        }

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

        private void button5_Click(object sender, EventArgs e)
        {

            get_ticket(num, kind, start, end);
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
    }
}
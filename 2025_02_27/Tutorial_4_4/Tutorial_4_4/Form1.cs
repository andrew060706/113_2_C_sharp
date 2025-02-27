using System.Diagnostics.Eventing.Reader;

namespace Tutorial_4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double distance, gas, average;//�ŧi�ϰ��ܼ�

            if (double.TryParse(distancetextBox1.Text, out distance))
            {
                if (double.TryParse(gastextBox2.Text, out gas))
                {
                    average = distance / gas;
                    averagelabel.Text = "�����o��:" + average.ToString("f2") + "����/����";
                    historylistBox1.Items.Add("��p" + distance + "�����A�Ӫo" + gas + "���ɡA�����o��:" + average.ToString("f2") + "����/����");
                }
                else
                {
                    MessageBox.Show("�п�J�Ʀr");
                    gastextBox2.Focus();//�N�ƹ���в���
                    gastextBox2.Text = "";//�M��TextBox   
                }
            }
            else
            {
                MessageBox.Show("�п�J�Ʀr");
                distancetextBox1.Focus();//�N�ƹ���в���
                distancetextBox1.Text = "";//�M��TextBox
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            historylistBox1.Items.Clear();
            historylistBox1.Items.Add("�����o�Ӭ���");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (historylistBox1.Items.Count > 1)
            {
                double sum = 0;
                for (int i = 1; i < historylistBox1.Items.Count; i++)
                {
                    string[] parts = historylistBox1.Items[i].ToString().Split('�A');
                    string averagePart = parts[2].Replace("�����o��:", "").Replace("����/����", "");
                    sum += double.Parse(averagePart);
                }
                historylistBox1.Items.Add("�����o��:" + (sum / (historylistBox1.Items.Count - 1)).ToString("f2") + "����/����");
            }
            else
            {
                MessageBox.Show("�S������");
            }
        }
    }
}

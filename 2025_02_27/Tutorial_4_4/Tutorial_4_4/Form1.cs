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
            double distance, gas, average;//宣告區域變數

            if (double.TryParse(distancetextBox1.Text, out distance))
            {
                if (double.TryParse(gastextBox2.Text, out gas))
                {
                    average = distance / gas;
                    averagelabel.Text = "平均油耗:" + average.ToString("f2") + "公里/公升";
                    historylistBox1.Items.Add("行駛" + distance + "公里，耗油" + gas + "公升，平均油耗:" + average.ToString("f2") + "公里/公升");
                }
                else
                {
                    MessageBox.Show("請輸入數字");
                    gastextBox2.Focus();//將滑鼠游標移至
                    gastextBox2.Text = "";//清空TextBox   
                }
            }
            else
            {
                MessageBox.Show("請輸入數字");
                distancetextBox1.Focus();//將滑鼠游標移至
                distancetextBox1.Text = "";//清空TextBox
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            historylistBox1.Items.Clear();
            historylistBox1.Items.Add("平均油耗紀錄");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (historylistBox1.Items.Count > 1)
            {
                double sum = 0;
                for (int i = 1; i < historylistBox1.Items.Count; i++)
                {
                    string[] parts = historylistBox1.Items[i].ToString().Split('，');
                    string averagePart = parts[2].Replace("平均油耗:", "").Replace("公里/公升", "");
                    sum += double.Parse(averagePart);
                }
                historylistBox1.Items.Add("平均油耗:" + (sum / (historylistBox1.Items.Count - 1)).ToString("f2") + "公里/公升");
            }
            else
            {
                MessageBox.Show("沒有紀錄");
            }
        }
    }
}

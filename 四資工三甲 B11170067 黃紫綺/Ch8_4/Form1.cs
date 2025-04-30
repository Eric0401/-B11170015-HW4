using System.CodeDom;

namespace Ch8_2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
//        public void bubbleSort(int[] data)
//        {
//            int i, j, l;
//            int n = data.Length;
//
//            for (i = 0; i < n - 1; i++)
//            {
//                for (j = 0; j < n - 1 - i; j++)
//                {
//                    if (data[j + 1] < data[j])
//                    {
//                        l = data[j + 1];
//                        data[j + 1] = data[j];
//                        data[j] = l;
//                    }
//                }
//            }
//        }
        private void arrMax(int[] data)
        {
            int i, index = 0;
            for (i = 0; i < data.GetLength(0); i++)
                if (data[i] > data[index])
                    index = i;
            label2.Text = "最大值：" + data[index];
        }
        private void arrMin(int[] data)
        {
            int j, jum = 0;
            for(j = 0; j < data.GetLength(0); j++)
                if(data[j] < data[jum])
                    jum = j;
            label1.Text = "最小值：" + data[jum];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] data1 = new int[6];
            data1[0] = Convert.ToInt32(textBox1.Text);
            data1[1] = Convert.ToInt32(textBox2.Text);
            data1[2] = Convert.ToInt32(textBox3.Text);
            data1[3] = Convert.ToInt32(textBox4.Text);
            data1[4] = Convert.ToInt32(textBox5.Text);
            data1[5] = Convert.ToInt32(textBox6.Text);
            arrMax(data1);
            arrMin(data1);
            textBox1.Text = data1[0].ToString();
            textBox2.Text = data1[1].ToString();
            textBox3.Text = data1[2].ToString();
            textBox4.Text = data1[3].ToString();
            textBox5.Text = data1[4].ToString();
            textBox6.Text = data1[5].ToString();
            }

    }
}

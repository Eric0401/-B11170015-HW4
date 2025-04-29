namespace 實作題8_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] numbes = textBox1.Text.Split(' ');
            int[] number = new int[numbes.Length];
            for (int i = 0; i < numbes.Length; i++)
            {
                number[i] = int.Parse(numbes[i]);       
            }
            label1.Text = "最小值:" + arrMin(number);
            label2.Text = "最大值:" + arrMax(number);
        }
        public int arrMin(int[] number)
        {
            int min = number[1];
            for(int i = 0; i < number.Length; i++)
            {
                if (number[i] < min)
                {
                    min = number[i];
                }
            }
            return min;
        }
        public int arrMax(int[] number)
        {
            int max = number[1];
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > max)
                {
                    max = number[i];
                }
            }
            return max;
        }
    }
}

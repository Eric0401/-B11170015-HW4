namespace 實作題8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] number = new int[5];
            Random random = new Random();
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = random.Next(1, 201);
            }

            label1.Text = "亂數：" + string.Join(" ", number);

            for(int j = number.Length - 1; j > 0; j--)
            {
                for (int k = 0; k < j; k++)
                {
                    if (number[k + 1] < number[k])
                    {
                        int temp = number[k + 1];
                        number[k + 1] = number[k];
                        number[k] = temp;
                    }
                }
            }

            label2.Text = "排序：" + string.Join(" ", number);
        }
    }
}

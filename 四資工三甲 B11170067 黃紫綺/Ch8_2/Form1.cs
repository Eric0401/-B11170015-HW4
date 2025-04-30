namespace Ch2_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[5];
            Random rand = new Random();

            // 產生 1~200 的隨機數填入陣列
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 201); // 上限為201，實際最大值為200
            }

            // 陣列排序
            Array.Sort(numbers);

            // 顯示在 label1
            label1.Text = "排序後陣列內容: " + string.Join(", ", numbers);
            Console.WriteLine(label1.Text);
        }
    }
}

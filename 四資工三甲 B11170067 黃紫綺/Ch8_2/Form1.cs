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

            // ���� 1~200 ���H���ƶ�J�}�C
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 201); // �W����201�A��ڳ̤j�Ȭ�200
            }

            // �}�C�Ƨ�
            Array.Sort(numbers);

            // ��ܦb label1
            label1.Text = "�Ƨǫ�}�C���e: " + string.Join(", ", numbers);
            Console.WriteLine(label1.Text);
        }
    }
}

namespace Task3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void multiplicationTableButton_Click(object sender, EventArgs e)
        {
            CreateMultiplicationTable("multiplicatioTable.csv");
        }

        private void CreateMultiplicationTable(string fileName)
        {
            using (StreamWriter writer = new(fileName, true))
            {
                writer.Write("0;");
                for (int j = 2; j <= 9; j++)
                    writer.Write($"{j};");
                writer.WriteLine();
                for (int i = 2; i <= 9; i++)
                {
                    writer.Write($"{i};");
                    for (int j = 2; j <= 9; j++)
                    {
                        writer.Write($"{i * j};");
                    }
                    writer.WriteLine();
                }
            }
        }
    }
}

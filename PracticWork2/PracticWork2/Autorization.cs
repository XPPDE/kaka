namespace PracticWork2
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void registration_Click(object sender, EventArgs e)
        {
            if (FileRead("logins.csv", LoginTextBox.Text))
            {
                MessageBox.Show("Введите логин еще раз.");
                LoginTextBox.Text = string.Empty;
            }
            else
            {
                WriteFileAsync("logins.csv");
                MessageBox.Show("Вы зарегистрированы.");
            }
                
                
        }
        
        bool FileRead(string fileName, string login)
        {
            using (StreamReader reader = new(fileName))
            {
                Console.WriteLine($"Чтение из файла {fileName} начато");
                string? line;
                while ((line = reader.ReadLine()) is not null)
                {
                    string[] user = line.Split(new char[] { ',', '.', ' ', ';' });
                    if (user[0] == LoginTextBox.Text)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        async Task WriteFileAsync(string fileName)
        {
            using (StreamWriter writer = new(fileName, true))
            {
                await writer.WriteLineAsync($"{LoginTextBox.Text};{PasswordTextBox.Text};{DateTime.Now}");
            }
        }
    }
}

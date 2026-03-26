namespace Opam_Lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            int length = 0;
            string chars = "";
            string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "0123456789";
            string symbols = "!@#$%^&*()_+";

            
            if (rbEasy.Checked)
            {
                chars = letters;
                length = 6;
            }
            else if (rbMedium.Checked)
            {
                chars = letters + numbers;
                length = 10;
            }
            else if (rbHard.Checked)
            {
                chars = letters + numbers + symbols;
                length = 14;
            }
            else
            {
                MessageBox.Show("Оберіть складність пароля!");
                return; 
            }

            
            if (cbReadFromFile.Checked)
            {
                try
                {
                    
                    string fileContent = File.ReadAllText("length.txt");
                    length = int.Parse(fileContent);
                }
                catch
                {
                    MessageBox.Show("Не вдалося прочитати довжину з файлу. Переконайтеся, що файл 'length.txt' існує і містить лише число.");
                    return;
                }
            }

           
            Random rnd = new Random();
            string password = "";

            for (int i = 0; i < length; i++)
            {
                int randomIndex = rnd.Next(chars.Length);
                password += chars[randomIndex];         
            }

           
            txtResult.Text = password;

            
           
            File.AppendAllText("passwords.txt", password + Environment.NewLine);

            MessageBox.Show("Пароль згенеровано!");
        }
      }
    }


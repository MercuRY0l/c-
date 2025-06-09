


using System.Drawing.Text;
using System.Text.RegularExpressions;

namespace practise30._05
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


        }

        private void ValidateForm() {

            bool allFieldsFilled =
          !string.IsNullOrWhiteSpace(textBox1.Text) &&
          !string.IsNullOrWhiteSpace(textBox2.Text) &&
          !string.IsNullOrWhiteSpace(textBox3.Text) &&
          !string.IsNullOrWhiteSpace(textBox4.Text);

            button1.Enabled = allFieldsFilled;

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PlaceholderText = "Введите email: ";
            ValidateForm();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PlaceholderText = "Введите номер телефона: ";
            ValidateForm();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.PlaceholderText = "Введите пароль: ";
            ValidateForm();
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            textBox4.PlaceholderText = "Повторите ввод пароля: ";
            ValidateForm();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text.Trim();
            string phone_number = textBox2.Text.Trim();
            string pass = textBox3.Text.Trim();
            string confirm_pass = textBox4.Text.Trim();

            Regex email_checking = new Regex(@"^[\w\.-]+@[\w\.-]+\.\w{2,6}$");
            Regex phone_checking = new Regex(@"^[+]{0,1}[0-9]{11}");

            bool error = false;

            if (pass != confirm_pass)
            {
                MessageBox.Show("Пароли не совпадают!");
                error = true;
            }

            if (!email_checking.IsMatch(email))
            {
                MessageBox.Show("Email не валидный");
                error = true;
            }

            if (!phone_checking.IsMatch(phone_number) )
            {
                MessageBox.Show("Номер телефона не валидный");
                error = true;
            }

            if (error == false){
                MessageBox.Show("Все четка!");
                this.Close();
            }
            

        }

    
    }
}

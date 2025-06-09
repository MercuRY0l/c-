using System;
using System.Drawing;
using System.Windows.Forms;

namespace practise4._06
{
    public partial class Form1 : Form
    {
        private double babosik;
        private Random rnd = new Random(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.BackgroundImage = Image.FromFile("C:\\Users\\udgit\\Downloads\\roulette.jpg");
            }
            catch
            {
                MessageBox.Show("");
            }

            babosik = 5000;
            textBox2.Text = babosik.ToString();
            textBox2.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string userInput = textBox1.Text.Trim();

            
            int rolledNumber = rnd.Next(0, 37);

            textBox3.Text = rolledNumber.ToString();

            
            double stake = int.Parse(textBox1.Text);

            
            if (userInput == rolledNumber.ToString())
            {
                if (rolledNumber == 0)
                {
                    babosik += stake * 10;
                    MessageBox.Show("Выпало 0! Джекпот! +10x");
                }
                else
                {
                    babosik += stake * 2;
                    MessageBox.Show("Ты угадал! +2x");
                }
            }
            else
            {
                babosik -= stake;
                MessageBox.Show($"Ты проиграл!. Выпало: {rolledNumber}");
            }

            
            textBox2.Text = babosik.ToString();

            
            if (babosik <= 0)
            {
                MessageBox.Show("ЕМАЕ, ТЫ ПРОИГРАЛ ВСЕ ДЕНЬГИ!");
                button1.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

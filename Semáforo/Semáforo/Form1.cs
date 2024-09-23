namespace Semáforo
{
    public partial class Form1 : Form
    {
        int cor = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVERDE_Click(object sender, EventArgs e)
        {
            pictureBoxSemaforo.Image = Image.FromFile("./verde.png");
        }

        private void buttonAMARELO_Click(object sender, EventArgs e)
        {
            pictureBoxSemaforo.Image = Image.FromFile("./amarelo.png");
        }

        private void buttonVERMELHO_Click(object sender, EventArgs e)
        {
            pictureBoxSemaforo.Image = Image.FromFile("./vermelho.png");
        }

        private void buttonAPAGADO_Click(object sender, EventArgs e)
        {
            pictureBoxSemaforo.Image = Image.FromFile("./apagado.png");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool jaExecutei = false;
            textBox1.Text = textBox1.Text + "ola";
           
            if ((cor == 1) && (jaExecutei==false))
            {
                cor = 2;
                pictureBoxSemaforo.Image = Image.FromFile("./amarelo.png");
                jaExecutei = true;

            }
            if ((cor == 2)&& (jaExecutei == false))
            {
               jaExecutei = true;
                cor = 3;
                pictureBoxSemaforo.Image = Image.FromFile("./vermelho.png");
            }
           
            if ((cor == 3)&& (jaExecutei == false))
            {
                jaExecutei = true;
                cor = 1;
                pictureBoxSemaforo.Image = Image.FromFile("./verde.png");
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x
            


            
        }
    }
}

namespace ARC_3_PRACTICA_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lado1, lado2, lado3;
            lado1 = double.Parse(textBox1.Text);
            lado2 = double.Parse(textBox2.Text);
            lado3 = double.Parse(textBox3.Text);
            if ((lado1 == lado2) && (lado2 == lado3))
                textBox4.Text = "Equilatero";
            else
            if ((lado1 == lado2) || (lado1 == lado3) || (lado2 == lado3))
                textBox4.Text = "Isosceles";
            else textBox4.Text = "Escaleno";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

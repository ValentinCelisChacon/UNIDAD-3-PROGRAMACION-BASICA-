namespace ARC_2_PRACTICA_6
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

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            if (numero % 2 == 0)
            {
                listBox1.Items.Add(numero + " es Par");
            }
            else
            {
                listBox1.Items.Add(numero + " es Impar");
            }
            textBox1.Text = " ";
            textBox1.Focus();
        }
    }
}

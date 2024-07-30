namespace SANA
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal telaMenu = new MenuPrincipal();
            telaMenu.FormClosed += TelaMenu_FormClosed;
            telaMenu.Show();
            this.Hide();
        }
        private void TelaMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}

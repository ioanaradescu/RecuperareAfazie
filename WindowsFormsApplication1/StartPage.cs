using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Data_Access_Layer;

namespace WindowsFormsApplication1
{
    public partial class StartPage : Form
    {
        private RecuperareAfazieContext dbContext = new RecuperareAfazieContext();

        public StartPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teste f2 = new Teste();
            f2.ShowDialog();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pacienti f4 = new Pacienti();
            f4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rezultate f5 = new Rezultate();
            f5.ShowDialog();
        }

        private void genereazaTestBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenereazaTeste f9 = new GenereazaTeste();
            f9.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}

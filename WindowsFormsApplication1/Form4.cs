using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication1.Data_Access_Layer;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        private RecuperareAfazieContext dbContext = new RecuperareAfazieContext();

        public void Afiseaza()
        {
            var pacienti = dbContext.Pacienti.ToList();
            dataGridView1.DataSource = pacienti;
        }

        public Form4()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new Form1().Show();
        }

        private void button2_Click(object sender, EventArgs e) // ADAUG PACIENT
        {
            var pacient = new Pacient();  //creez pacient

            pacient.CNP = textBox2.Text;
            pacient.Nume = textBox3.Text;
            pacient.Prenume = textBox4.Text;
            int varsta;
            bool varstaParsata = int.TryParse(textBox5.Text, out varsta);
            if(varstaParsata == true)
            {
                pacient.Varsta = varsta;
            }
            pacient.Observatii = textBox6.Text;
            dbContext.Pacienti.Add(pacient);
            dbContext.SaveChanges(); //Adaug pacient

            Afiseaza();

            MessageBox.Show("Datele au fost salvate");
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool selectat = dataGridView1.CurrentRow.Selected;

            if (selectat == true)
            {
                var id = ((Pacient)dataGridView1.CurrentRow.DataBoundItem).Id;

                var pacient = dbContext.Pacienti.Where(p => p.Id == id).SingleOrDefault();

                dbContext.Pacienti.Remove(pacient);
                dbContext.SaveChanges();
                MessageBox.Show("Pacientul a fost șters");
            }

            Afiseaza();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Afiseaza();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            new Form2().Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)  //Update
        {
            bool selectat = dataGridView1.CurrentRow.Selected;

            if (selectat == true)
            {
                var id = ((Pacient)dataGridView1.CurrentRow.DataBoundItem).Id;

                var pacient = dbContext.Pacienti.SingleOrDefault(p => p.Id == id);
                pacient.CNP = textBox2.Text;
                pacient.Nume = textBox3.Text;
                pacient.Prenume = textBox4.Text;

                int varsta;
                bool varstaParsata = int.TryParse(textBox5.Text, out varsta); // VARSTA
                if (varstaParsata == true)
                {
                    pacient.Varsta = varsta;
                }
                pacient.Observatii = textBox6.Text;

                dbContext.SaveChanges();
                Afiseaza();

                MessageBox.Show("Datele au fost salvate");
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
            }
        }
    }
}

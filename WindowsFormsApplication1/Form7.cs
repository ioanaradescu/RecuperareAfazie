using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication1.Data_Access_Layer;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1
{
    public partial class Form7 : Form
    {
        private RecuperareAfazieContext dbContext = new RecuperareAfazieContext();

        int id_test = 0;
        int id_pacient = 0;

        int numarIntrebare = 0;
        string numeT = "";

        string nume = "";
        string prenume = "";

        public Form7()
        {
            InitializeComponent();
            numarIntrebare = 1;
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            numarIntrebare++;

            var intrebare = new Intrebare();

            intrebare.TestId = id_test;
            intrebare.TextIntrebare = textBox1.Text;
            intrebare.Raspuns1 = textBox2.Text;
            intrebare.Raspuns2 = textBox3.Text;
            intrebare.Raspuns3 = textBox4.Text;
            intrebare.Raspuns4 = textBox5.Text;

            dbContext.Intrebari.Add(intrebare);
            dbContext.SaveChanges();
            label7.Text = numarIntrebare.ToString(); 

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            button5.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            //string constring = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=RecuperareAfazie;Data Source=(local)";
            //string Query = "insert into TesteGenerate(Nume_Test,Tip_Test) values ('" + this.textBox6.Text + "','" + 1 + "') SELECT CAST(scope_identity() AS int) ;";
            //SqlConnection conDataBase = new SqlConnection(constring);
            //SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);

            //try
            //{
            //    conDataBase.Open();
            //    id_test = (int) cmdDataBase.ExecuteScalar();
            //    MessageBox.Show("Datele au fost salvate");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            var test = new Test(); //creez test

            try {
                test.Nume = textBox6.Text;
                test.Nivel = 1;
                dbContext.Teste.Add(test);
                dbContext.SaveChanges(); // Salvez testul
                MessageBox.Show("Datele au fost salvate");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            id_test = test.TestId;  //retin id test creat

            textBox1.Visible = true;
            label4.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Text = numarIntrebare.ToString();
            label7.Visible = true;
            label8.Visible = true;
            button3.Visible = true;
            GenereazaTest.Visible = false;
            groupBox1.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "" || textBox5.Text != "")
            {
                var intrebare = new Intrebare();

                intrebare.TestId = id_test;
                intrebare.TextIntrebare = textBox1.Text;
                intrebare.Raspuns1 = textBox2.Text;
                intrebare.Raspuns2 = textBox3.Text;
                intrebare.Raspuns3 = textBox4.Text;
                intrebare.Raspuns4 = textBox5.Text;

                dbContext.Intrebari.Add(intrebare);
                dbContext.SaveChanges();
            }

            MessageBox.Show("Testul a fost salvat");
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;

            button3.Enabled = false;
            IncepeTest.Visible = true;
        }

        private void GenereazaTest_Click(object sender, EventArgs e)
        {
            AlegeTest.Visible = false;
            groupBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new Teste().Show();
        }

        private void IncepeTest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8(id_test);
            f8.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AlegeTest_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;

            var teste = dbContext.Teste
                .Select(t => new {t.Nume }).ToList();

            foreach (var x in teste)
            {
                numeTest.Items.Add(x.Nume);
            }

        }

        private void incepeBtn_Click(object sender, EventArgs e)
        {
            numeT = numeTest.Text;

            var test = dbContext.Teste
                .Where(t => t.Nume == numeT)
                .Select(t => new { t.TestId }).SingleOrDefault();

            id_test = test.TestId;
          
            this.Hide();
            TestAles f9 = new TestAles(id_test,id_pacient);
            f9.ShowDialog();
        }

        private void numeTest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numePacient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

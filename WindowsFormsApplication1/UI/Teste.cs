using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication1.DAL;

namespace WindowsFormsApplication1.UI
{
    public partial class Teste : Form
    {
        private RecuperareAfazieContext dbContext = new RecuperareAfazieContext();

        int nivelTest = 0;
        string id = "";
        string numeT = "";
        int idPacient = 0;
        int idTest = 0;

        Button butonVerificare = new Button();

        public Teste()
        {
            InitializeComponent();

        }

        public Teste(int idP, int nivelT, Button btn)
        {
            InitializeComponent();
            if (groupBox4.Visible == false)
            {
                groupBox4.Visible = true;
            }

            numeTestComboBox.Items.Clear();
            numePComboBox.Items.Clear();

            var teste = dbContext.Teste
              .Where(t => t.Nivel == nivelT)
              .Select(t => new { t.Nume }).ToList();

            foreach (var x in teste)
            {
                numeTestComboBox.Items.Add(x.Nume);
            }

            var pacienti = dbContext.Pacienti
                .OrderBy(p => p.Nume)
                .Select(p => new { p.Nume }).ToList();

            foreach (var x in pacienti)
            {
                numePComboBox.Items.Add(x.Nume);
            }

            var pacient = dbContext.Pacienti
            .Where(p => p.Id == idP)
            .Select(p => new { p.Id, p.Nume, p.Prenume, p.CNP, p.Varsta, p.Observatii }).ToList();

            PacientiGridView.DataSource = pacient;

            //foreach (DataGridViewRow row in PacientiGridView.Rows)  ????????????
            //{
            //    PacientiGridView.Rows[0].Selected = true;
            //}

            numeTestLabel.Text = btn.Text;
        }

        public void AlegeTest(int niv, Button btn)
        {
                numeTestComboBox.Items.Clear();
                numePComboBox.Items.Clear();

                var teste = dbContext.Teste
                  .Where(t => t.Nivel == niv)
                  .Select(t => new { t.Nume }).ToList();

                foreach (var x in teste)
                {
                    numeTestComboBox.Items.Add(x.Nume);
                }

                var pacienti = dbContext.Pacienti
                 .OrderBy(p => p.Nume)
                 .Select(p => new { p.Nume }).ToList();

                foreach (var x in pacienti)
                {
                    numePComboBox.Items.Add(x.Nume);
                }

                butonVerificare = btn;
            
        }

        private void test1Btn_Click(object sender, EventArgs e)
        {
            //numeTestComboBox.Items.Clear();
            nivelTest = 1;
            groupBox3.Text = test1Btn.Text;

          //  numeTestLabel.Text = test1Btn.Text;
            if (groupBox4.Visible == false)
            {
                groupBox4.Visible = true;
            }

            if (test1Btn.Focus() == true)
            {
                AlegeTest(nivelTest, test1Btn);
            }

        }

        private void test2Btn_Click(object sender, EventArgs e)
        {
           // numeTestComboBox.Items.Clear();
            nivelTest = 2;
            // numeTestLabel.Text = test2Btn.Text;
            groupBox3.Text = test2Btn.Text;

            if (groupBox4.Visible == false)
            {
                groupBox4.Visible = true;
            }

            AlegeTest(nivelTest, test2Btn);
        }

        private void test3Button_Click(object sender, EventArgs e)
        {
          //  numeTestComboBox.Items.Clear();
            nivelTest = 3;
            //   numeTestLabel.Text = test3Button.Text;
            groupBox3.Text = test3Button.Text;

            if (groupBox4.Visible == false)
            {
                groupBox4.Visible = true;
            }

            AlegeTest(nivelTest, test3Button);
        }

        private void veziPacientiBtn_Click(object sender, EventArgs e)
        {
            var pacienti = dbContext.Pacienti
             .Select(p => new { p.Id, p.Nume, p.Prenume, p.CNP, p.Varsta, p.Observatii }).ToList();

            PacientiGridView.DataSource = pacienti;
        }

        private void numePComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            prenPCombobox.Items.Clear();

            var pacienti = dbContext.Pacienti
               .Where(p => p.Nume == numePComboBox.Text)
               .OrderBy(p => p.Prenume)
               .Select(p => new { p.Prenume }).ToList();

            foreach (var p in pacienti)
            {
                if (pacienti.Count == 1)
                {
                    prenPCombobox.Text = p.Prenume;
                }
                else
                {
                    prenPCombobox.Items.Add(p.Prenume);
                }
            }
        }

        private void CautaPBtn_Click(object sender, EventArgs e)
        {
            string NumeP = "";
            string PrenumeP = "";

            NumeP = numePComboBox.Text.ToString();
            PrenumeP = prenPCombobox.Text.ToString();

            var pacienti = dbContext.Pacienti
                .Where(p => (p.Nume == NumeP && PrenumeP == "") || (p.Nume == NumeP && p.Prenume == PrenumeP))
                .Select(p => new { p.Id, p.Nume, p.Prenume, p.CNP, p.Varsta, p.Observatii }).ToList();

            if (pacienti.Count != 0)
            {
                PacientiGridView.DataSource = pacienti;
            }
            else
            {
                PacientiGridView.DataSource = pacienti;
                MessageBox.Show("Nu a fot gasit niciun pacient cu datele introduse");
            }

            numePComboBox.Text = "";
            prenPCombobox.Text = "";
        }

        private void incepeBtn_Click(object sender, EventArgs e)
        {
            if (PacientiGridView.Rows.Count != 0) 
            {
                bool selectat = PacientiGridView.CurrentRow.Selected;
                if (numeTestComboBox.Text == "")
                {
                    MessageBox.Show("Pentru a incepe testul, selectati numele acestuia !");
                }
                else
                {

                    if (selectat == true)
                    {
                        foreach (DataGridViewRow row in PacientiGridView.SelectedRows)
                        {
                            id = row.Cells[0].Value.ToString();

                            idPacient = int.Parse(id);
                        }

                        numeT = numeTestComboBox.Text;

                        var test = dbContext.Teste
                            .Where(t => t.Nivel == nivelTest && t.Nume == numeT)
                            .Select(t => new { t.TestId }).SingleOrDefault();  // Trebuie modificat = > eroare at cand sunt doua teste cu acelasi nume!

                        idTest = test.TestId;

                        VerificaNivel(nivelTest);
                    }

                    else
                    {
                        MessageBox.Show("Selectati un pacient pentru a incepe testul !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selectati un pacient pentru a incepe testul !");
            }
        }

        public void VerificaNivel(int nivTest)
        {
            if (nivTest == 1)
            {
                this.Hide();
                TestAles1 f1 = new TestAles1(idTest, idPacient, butonVerificare);
                f1.ShowDialog();
            }
            if (nivTest == 2)
            {
                this.Hide();
                TestAles1 f2 = new TestAles1(idTest, idPacient, butonVerificare);
                f2.ShowDialog();
            }

            if (nivTest == 3)
            {
                this.Hide();
                TestAles1 f3 = new TestAles1(idTest, idPacient, butonVerificare);
                f3.ShowDialog();
            }

            if (nivTest == 4)
            {
                this.Hide();
                TestAles4 f4 = new TestAles4(idTest, idPacient, butonVerificare);
                f4.ShowDialog();
            }

            if (nivTest == 5)
            {
                this.Hide();
                TestAles5 f5 = new TestAles5(idTest, idPacient, butonVerificare);
                f5.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)  // butonul pentru revenire la pagina de start
        {
            Hide();
            new StartPage().Show();
        }


        private void numeTestComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void test4Button_Click(object sender, EventArgs e)
        {
            nivelTest = 4;
            // numeTestLabel.Text = test4Button.Text;
            groupBox3.Text = test4Button.Text;
            if (groupBox4.Visible == false)
            {
                groupBox4.Visible = true;
            }

            AlegeTest(nivelTest, test4Button);
        }

        private void test5Button_Click(object sender, EventArgs e)
        {
            nivelTest = 5;
            groupBox3.Text = test5Button.Text;

            if (groupBox4.Visible == false)
            {
                groupBox4.Visible = true;
            }

            AlegeTest(nivelTest, test5Button);
        }
    }
}

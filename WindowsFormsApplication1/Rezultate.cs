using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication1.Data_Access_Layer;

namespace WindowsFormsApplication1
{
    public partial class Rezultate : Form
    {
        private RecuperareAfazieContext dbContext = new RecuperareAfazieContext();

        int nivel = 0;
        string numePacient = "";
        string prenumePacient = "";
        string numeTest = "";

        int idPacient = 0;
        int idTest = 0;
        int nrTeste = 0;


        public Rezultate()
        {
            InitializeComponent();

            var pacienti = dbContext.Pacienti
               .OrderBy(p => p.Nume)
               .Select(p => new { p.Nume }).ToList();

            foreach (var x in pacienti)
            {
                numeComboBox.Items.Add(x.Nume);
            }

            for (int i = 1; i <= 20; i++)
            {
                nivelTestComboBox.Items.Add(i);
            }

        }

        private void numeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            prenComboBox.Text = "";

            var pacienti = dbContext.Pacienti
               .Where(p => p.Nume == numeComboBox.Text)
               .OrderBy(p => p.Prenume)
               .Select(p => new { p.Prenume }).ToList();

            foreach (var p in pacienti)
            {
                if (pacienti.Count == 1)
                {
                    prenComboBox.Text = p.Prenume;
                }
                else
                {
                    prenComboBox.Items.Add(p.Prenume);
                }
            }
        }

        private void nivelTestComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            numeTestComboBox.Items.Clear();

            nivel = int.Parse(nivelTestComboBox.Text);

            var teste = dbContext.Teste
                .Where(t => t.Nivel == nivel)
                .OrderBy(t => t.TestId)
                .Select(t => new { t.Nume }).ToList();

            foreach (var t in teste)
            {
                numeTestComboBox.Items.Add(t.Nume);
            }
        }

        private void veziRezultateBtn_Click(object sender, EventArgs e)
        {
            if (numeComboBox.Text == "")
            {
                MessageBox.Show("Selectati numele pacientului");
            }
            else
                if (prenComboBox.Text == "")
            {
                MessageBox.Show("Selectati prenumele pacientului");
            }

            else
                if (nivelTestComboBox.Text == "")
            {
                MessageBox.Show("Selectati nivelul testului");
            }
            else

                if (numeTestComboBox.Text == "")
            {
                MessageBox.Show("Selectati numele testului");
            }
            else
            {

                bool nivelParsat = int.TryParse(nivelTestComboBox.Text, out nivel);
                if (nivelParsat == true)
                {
                    nivel = int.Parse(nivelTestComboBox.Text);
                }

                var rezultate = (from rez in dbContext.Rezultate
                                 join p in dbContext.Pacienti on rez.PacientId equals p.Id
                                 join t in dbContext.Teste on rez.TestId equals t.TestId
                                 where (p.Nume == numeComboBox.Text && p.Prenume == prenComboBox.Text && t.Nivel == nivel && t.Nume == numeTestComboBox.Text)
                                 orderby t.TestId
                                 select new
                                 {
                                     Nume_Pacient = p.Nume,
                                     Prenume_Pacient = p.Prenume,
                                     Nume_Test = t.Nume,
                                     Nivel_Test = t.Nivel,
                                     Raspunsuri_Corecte = rez.RaspunsuriCorecte,
                                     Raspunsuri_Gresite = rez.RaspunsuriGresite,
                                     Timp_Rezolvare = rez.TimpRezolvare,
                                     Data_Rezolvare = rez.DataRezolvare,

                                 }).ToList();

                var rezultateId = (from rez in dbContext.Rezultate
                                   join p in dbContext.Pacienti on rez.PacientId equals p.Id
                                   join t in dbContext.Teste on rez.TestId equals t.TestId
                                   where (p.Nume == numeComboBox.Text && p.Prenume == prenComboBox.Text && t.Nivel == nivel && t.Nume == numeTestComboBox.Text)
                                   orderby t.TestId
                                   select new
                                   {
                                       p.Id,
                                       t.TestId,

                                   }).ToList();

                numePacient = numeComboBox.Text;
                prenumePacient = prenComboBox.Text;
                numeTest = numeTestComboBox.Text;

                int i = 0;
                foreach (var x in rezultateId)
                {
                    idPacient = x.Id;
                    idTest = x.TestId;
                    i++;
                    nrTeste++;
                }

                RezultateGridView.DataSource = rezultate;
                numeTestComboBox.Text = "";
            }
        }

        private void veziRaspButton_Click(object sender, EventArgs e)
        {

            var raspunsuri = (from rasp in dbContext.Raspunsuri
                              join r in dbContext.Rezultate on rasp.RezultatId equals r.RezultatId
                              where r.TestId == idTest && r.PacientId == idPacient
                              select new
                              {
                                  Numar_Intrebare = rasp.NumarIntrebare,
                                  Raspuns_Corect = rasp.RaspunsCorect,
                                  Raspuns_Primit = rasp.RaspunsDat,

                              }).ToList();

            raspunsuriDataGridView.DataSource = raspunsuri;

        }

        public void VeziRaspunsuriCompleteOrdonate(Button btn)
        {
            if (btn.Name == ordDupaRaspCorButton.Name)
            {

                var raspunsuri = (from rasp in dbContext.Raspunsuri
                                  join r in dbContext.Rezultate on rasp.RezultatId equals r.RezultatId
                                  where r.TestId == idTest && r.PacientId == idPacient
                                  orderby r.RaspunsuriCorecte
                                  select new
                                  {
                                      Numar_Intrebare = rasp.NumarIntrebare,
                                      Raspuns_Corect = rasp.RaspunsCorect,
                                      Raspuns_Primit = rasp.RaspunsDat,

                                  }).ToList();

                raspunsuriDataGridView.DataSource = raspunsuri;
            }

            else
                if (btn.Name == ordDupaRaspGresButton.Name)
            {
                var raspunsuri = (from rasp in dbContext.Raspunsuri
                                  join r in dbContext.Rezultate on rasp.RezultatId equals r.RezultatId
                                  where r.TestId == idTest && r.PacientId == idPacient
                                  orderby r.RaspunsuriGresite
                                  select new
                                  {
                                      Numar_Intrebare = rasp.NumarIntrebare,
                                      Raspuns_Corect = rasp.RaspunsCorect,
                                      Raspuns_Primit = rasp.RaspunsDat,

                                  }).ToList();

                raspunsuriDataGridView.DataSource = raspunsuri;
            }
            else
                 if (btn.Name == ordDupaTimpRezButton.Name)
            {
                var raspunsuri = (from rasp in dbContext.Raspunsuri
                                  join r in dbContext.Rezultate on rasp.RezultatId equals r.RezultatId
                                  where r.TestId == idTest && r.PacientId == idPacient
                                  orderby r.TimpRezolvare
                                  select new
                                  {
                                      Numar_Intrebare = rasp.NumarIntrebare,
                                      Raspuns_Corect = rasp.RaspunsCorect,
                                      Raspuns_Primit = rasp.RaspunsDat,

                                  }).ToList();

                raspunsuriDataGridView.DataSource = raspunsuri;
            }
        }


        private void ordDupaRaspCorButton_Click(object sender, EventArgs e)
        {
            var rezultate = (from rez in dbContext.Rezultate
                             join p in dbContext.Pacienti on rez.PacientId equals p.Id
                             join t in dbContext.Teste on rez.TestId equals t.TestId
                             where (p.Nume == numePacient && p.Prenume == prenumePacient && t.Nivel == nivel && t.Nume == numeTest)
                             orderby rez.RaspunsuriCorecte ascending
                             select new
                             {
                                 Nume_Pacient = p.Nume,
                                 Prenume_Pacient = p.Prenume,
                                 Nume_Test = t.Nume,
                                 Nivel_Test = t.Nivel,
                                 Raspunsuri_Corecte = rez.RaspunsuriCorecte,
                                 Raspunsuri_Gresite = rez.RaspunsuriGresite,
                                 Timp_Rezolvare = rez.TimpRezolvare,
                                 Data_Rezolvare = rez.DataRezolvare,

                             }).ToList();
            RezultateGridView.DataSource = rezultate;

            VeziRaspunsuriCompleteOrdonate(ordDupaRaspCorButton);
        }

        private void ordDupaRaspGresButton_Click(object sender, EventArgs e)
        {
            var rezultate = (from rez in dbContext.Rezultate
                             join p in dbContext.Pacienti on rez.PacientId equals p.Id
                             join t in dbContext.Teste on rez.TestId equals t.TestId
                             where (p.Nume == numePacient && p.Prenume == prenumePacient && t.Nivel == nivel && t.Nume == numeTest)
                             orderby rez.RaspunsuriGresite ascending
                             select new
                             {
                                 Nume_Pacient = p.Nume,
                                 Prenume_Pacient = p.Prenume,
                                 Nume_Test = t.Nume,
                                 Nivel_Test = t.Nivel,
                                 Raspunsuri_Corecte = rez.RaspunsuriCorecte,
                                 Raspunsuri_Gresite = rez.RaspunsuriGresite,
                                 Timp_Rezolvare = rez.TimpRezolvare,
                                 Data_Rezolvare = rez.DataRezolvare,

                             }).ToList();
            RezultateGridView.DataSource = rezultate;

            VeziRaspunsuriCompleteOrdonate(ordDupaRaspGresButton);
        }

        private void ordDupaTimpRezButton_Click(object sender, EventArgs e)
        {
            var rezultate = (from rez in dbContext.Rezultate
                             join p in dbContext.Pacienti on rez.PacientId equals p.Id
                             join t in dbContext.Teste on rez.TestId equals t.TestId
                             where (p.Nume == numePacient && p.Prenume == prenumePacient && t.Nivel == nivel && t.Nume == numeTest)
                             orderby rez.TimpRezolvare ascending
                             select new
                             {
                                 Nume_Pacient = p.Nume,
                                 Prenume_Pacient = p.Prenume,
                                 Nume_Test = t.Nume,
                                 Nivel_Test = t.Nivel,
                                 Raspunsuri_Corecte = rez.RaspunsuriCorecte,
                                 Raspunsuri_Gresite = rez.RaspunsuriGresite,
                                 Timp_Rezolvare = rez.TimpRezolvare,
                                 Data_Rezolvare = rez.DataRezolvare,

                             }).ToList();
            RezultateGridView.DataSource = rezultate;

            VeziRaspunsuriCompleteOrdonate(ordDupaTimpRezButton);
        }

        public Rezultate(int idT, int idP, int idRez)
        {
            InitializeComponent();

            var pacienti = dbContext.Pacienti
                .OrderBy(p => p.Nume)
                .Select(p => new { p.Nume }).ToList();

            foreach (var x in pacienti)
            {
                numeComboBox.Items.Add(x.Nume);
            }

            for (int i = 1; i <= 20; i++)
            {
                nivelTestComboBox.Items.Add(i);
            }

            var rezultate = (from rez in dbContext.Rezultate
                             join p in dbContext.Pacienti on rez.PacientId equals p.Id
                             join t in dbContext.Teste on rez.TestId equals t.TestId
                             join r in dbContext.Raspunsuri on rez.RezultatId equals r.RezultatId
                             where rez.TestId == idT && rez.PacientId == idP && rez.RezultatId == idRez
                             orderby rez.RezultatId descending
                             select new
                             {
                                 Nume_Test = t.Nume,
                                 Nivel_Test = t.Nivel,
                                 Nume_Pacient = p.Nume,
                                 Prenume_Pacient = p.Prenume,
                                 Raspunsuri_Corecte = rez.RaspunsuriCorecte,
                                 Raspunsuri_Gresite = rez.RaspunsuriGresite,
                                 Timp_Rezolvare = rez.TimpRezolvare,
                                 Raspuns_Corect = r.RaspunsCorect,
                                 Raspuns_Primit = r.RaspunsDat,

                             }).ToList();

            RezultateGridView.DataSource = rezultate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new StartPage().Show();
        }

        private void prenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      
    }
}

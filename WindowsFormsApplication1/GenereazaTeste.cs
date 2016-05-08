using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class GenereazaTeste : Form
    {
        public GenereazaTeste()
        {
            InitializeComponent();
        }

        private void inapoiBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new StartPage().Show();
        }

        private void test1Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenereazaTest1 f1 = new GenereazaTest1(test1Btn);
            f1.ShowDialog();
        }

        private void test2Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenereazaTest2 f2 = new GenereazaTest2(test2Btn);
            f2.ShowDialog();

        }

        private void GenereazaTeste_Load(object sender, EventArgs e)
        {

        }

        private void test3Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenereazaTest3 f3 = new GenereazaTest3(test3Button);
            f3.ShowDialog();
        }

        private void test4Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenereazaTest4 f4 = new GenereazaTest4(test4Button);
            f4.ShowDialog();
        }

        private void test5Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenereazaTest5 f5 = new GenereazaTest5(test5Button);
            f5.ShowDialog();
        }
    }
}

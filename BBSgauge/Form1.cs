using System;
using System.Linq;
using System.Windows.Forms;

namespace BBSgauge
{
    public partial class Form1 : Form
    {
        private BBS bbs_obj;

        public Form1()
        {
            InitializeComponent();
            createComboBoxMenu();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                labelUserGeneration.Visible = false;
                textBoxUserGeneration.Visible = false;
                userGenerationButton.Visible = false;
                bbs_obj = new BBS();
                comboBox1.Visible = true;
                bbs_obj.GenerateSequense();
                printSecuence(bbs_obj);
            }
            if (radioButton2.Checked)
            {
                labelUserGeneration.Visible = true;
                textBoxUserGeneration.Visible = true;
                userGenerationButton.Visible = true;
            }
        }

        private void userGenerationButton_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBoxUserGeneration.Text);
            bbs_obj = new BBS(number);
            comboBox1.Visible = true;
            bbs_obj.GenerateSequense();
            printSecuence(bbs_obj);
        }

        private void printSecuence(BBS obj)
        {
            string sequence = "";
            for (int i = 0; i < obj.U.Count(); i++)
            {
                if (i != obj.U.Count() - 1)
                {
                    sequence += Convert.ToString(obj.U[i]) + "; ";
                }
                else
                {
                    sequence += Convert.ToString(obj.U[i]) + ".";
                }
            }
            richTextBox1.Text = sequence;
        }

        private void createComboBoxMenu()
        {
            comboBox1.Items.Add("Show starry sky");
            comboBox1.Items.Add("Show period of sequence");
            comboBox1.Items.Add("Show expected value");
            comboBox1.Items.Add("Show dispersion value");
            comboBox1.Items.Add("Show Xi value");
            comboBox1.Items.Add("Show chart");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                StarSkyForm ssf = new StarSkyForm(bbs_obj);
                ssf.Show();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                MessageBox.Show(bbs_obj.U.Count().ToString(), "Period of sequence");
            }
            if (comboBox1.SelectedIndex == 2)
            {
                Tests test = new Tests(bbs_obj.U, bbs_obj.N);
                MessageBox.Show(test.CalculateExpectedValue().ToString(), "Expected value");
            }
            if (comboBox1.SelectedIndex == 3)
            {
                Tests test = new Tests(bbs_obj.U, bbs_obj.N);
                test.CalculateExpectedValue();
                MessageBox.Show(test.CalculateDispersion().ToString(), "Dispersion value");
            }
            if (comboBox1.SelectedIndex == 4)
            {
                Tests test = new Tests(bbs_obj.U, bbs_obj.N);
                MessageBox.Show(test.CalculateXi().ToString(), "Xi value");
            }
            if (comboBox1.SelectedIndex == 5)
            {
                Tests test = new Tests(bbs_obj.U, bbs_obj.N);
                test.CreateChart();
            }
        }
    }
}

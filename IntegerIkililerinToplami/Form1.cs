using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegerIkililerinToplami
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int>();
        List<double> results = new List<double>();
        public Form1()
        {
            InitializeComponent();
            byte counter = Convert.ToByte(nudCift.Value);
        }

        private void ButtonOpenClose()
        {
            nudCift.Value = 0;
            rbtnAuto.Checked = false;
            rbtnManuel.Checked = false;
            nudCift.Enabled = false;
            pnl1.Enabled = false;
            btnAssignment.Enabled = false;
            btnCalculate.Enabled = false;
            rbtnManuel.Enabled = true;
            rbtnAuto.Enabled = true;
            tbxResult.Text = "";
            lblCounter.Visible = false;
        }


        public void Form1_Load(object sender, EventArgs e)
        {
            ButtonOpenClose();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ButtonOpenClose();
            numbers.Clear();
            results.Clear();
        }

        private void rbtnManuel_CheckedChanged(object sender, EventArgs e)
        {
            pnl1.Enabled = true;
            nudCift.Enabled = true;
            rbtnAuto.Enabled = false;
            lblCounter.Visible = true;

        }

        private void rbtnAuto_CheckedChanged(object sender, EventArgs e)
        {
            btnAssignment.Enabled = true;
            nudCift.Enabled = true;
            rbtnManuel.Enabled = false;
        }

        private void btnAssignment_Click(object sender, EventArgs e)
        {
            btnCalculate.Enabled = true;
            if (nudCift.Value != 0)
            {
                Random rnd = new Random();
                for (int i = 0; i < nudCift.Value; i++)
                {
                    int num = rnd.Next(1, 10);
                    numbers.Add(num);
                }
            }
            tbxResult.Text = string.Join(", ", numbers);
            btnAssignment.Enabled = false;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            tbxResult.Clear();
            for (int i = 0; i < numbers.Count; i += 2)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    double total = Math.Pow((Convert.ToDouble(numbers[i] + numbers[i + 1])), 2);
                    results.Add(total);
                }
                else
                {
                    double total = Convert.ToDouble(numbers[i] + numbers[i + 1]);
                    results.Add(total);
                }
            }
            tbxResult.Text = string.Join(", ", numbers) + Environment.NewLine + string.Join(", ", results);
        }
        private void NumClick(object sender, EventArgs e)
        {
            if (nudCift.Value==0)
            {
                MessageBox.Show("Specify the number of numbers to add.");
            }
            else
            {
                Button btnNum = (Button)sender;
                numbers.Add(Convert.ToInt32(btnNum.Text));
                nudCift.Enabled = false;
                nudCift.Value--;
                lblCounter.Text = "Counter: " + nudCift.Value;
                tbxResult.Text = string.Join(", ", numbers);
                if (nudCift.Value == 0)
                {
                    pnl1.Enabled = false;
                    btnCalculate.Enabled = true;
                }
            }

        }

        private void nudCift_ValueChanged(object sender, EventArgs e)
        {
            lblCounter.Text = "Counter: " + nudCift.Value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmTuringInterface
{
    public partial class Form1 : Form
    {
        Dictionary<int, string> tape = new Dictionary<int, string>();
        int shift = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeTape();
        }

        private void PreviousElement_Click(object sender, EventArgs e)
        {
            shift--;
            InitializeTape();
        }
        private void NextElement_Click(object sender, EventArgs e)
        {
            shift++;
            InitializeTape();
        }

        private void Tape_Paint(object sender, PaintEventArgs e)
        {
            tape[-4] = "0";
            tape[-1] = "1";
            tape[0] = "0";
            tape[1] = "1";
            InitializeTape();
        }

        private void InitializeTape()
        {
            this.textBox1.Text = (-4 + shift).ToString();
            this.textBox2.Text = (-3 + shift).ToString();
            this.textBox3.Text = (-2 + shift).ToString();
            this.textBox4.Text = (-1 + shift).ToString();
            this.textBox5.Text = (0 + shift).ToString();
            this.textBox6.Text = (1 + shift).ToString();
            this.textBox7.Text = (2 + shift).ToString();
            this.textBox8.Text = (3 + shift).ToString();
            this.textBox9.Text = (4 + shift).ToString();
            this.textBox10.Text = (5 + shift).ToString();
            try { this.textBox11.Text = tape[-4 + shift]; } catch { this.textBox11.Text = ""; }
            try { this.textBox12.Text = tape[-3 + shift]; } catch { this.textBox12.Text = ""; }
            try { this.textBox13.Text = tape[-2 + shift]; } catch { this.textBox13.Text = ""; }
            try { this.textBox14.Text = tape[-1 + shift]; } catch { this.textBox14.Text = ""; }
            try { this.textBox15.Text = tape[0 + shift]; } catch { this.textBox15.Text = ""; }
            try { this.textBox16.Text = tape[1 + shift]; } catch { this.textBox16.Text = ""; }
            try { this.textBox17.Text = tape[2 + shift]; } catch { this.textBox17.Text = ""; }
            try { this.textBox18.Text = tape[3 + shift]; } catch { this.textBox18.Text = ""; }
            try { this.textBox19.Text = tape[4 + shift]; } catch { this.textBox19.Text = ""; }
            try { this.textBox20.Text = tape[5 + shift]; } catch { this.textBox20.Text = ""; }
        }

        
    }
}

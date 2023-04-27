using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AlgorithmTuringInterface
{
    public partial class Form1 : Form
    {
        Dictionary<int, string> tape = new Dictionary<int, string>();
        int shift = 0;
        TextBox[] textBoxes = new TextBox[22];
        int chosenIndex = 0;

        public Form1()
        {
            InitializeTextBoxes();
            InitializeComponent();
        }

        private void InitializeTextBoxes()
        {
            textBoxes[0] = textBox1;
            textBoxes[1] = textBox2;
            textBoxes[2] = textBox3;
            textBoxes[3] = textBox4;
            textBoxes[4] = textBox5;
            textBoxes[5] = textBox6;
            textBoxes[6] = textBox7;
            textBoxes[7] = textBox8;
            textBoxes[8] = textBox9;
            textBoxes[9] = textBox10;
            textBoxes[10] = textBox11;
            textBoxes[11] = textBox12;
            textBoxes[12] = textBox13;
            textBoxes[13] = textBox14;
            textBoxes[14] = textBox15;
            textBoxes[15] = textBox16;
            textBoxes[16] = textBox17;
            textBoxes[17] = textBox18;
            textBoxes[18] = textBox19;
            textBoxes[19] = textBox20;
            textBoxes[20] = textBox21;
            textBoxes[21] = textBox22;
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
            InitializeTextBoxes();
            foreach(TextBox textbox in textBoxes)
            {
                if (textbox.TabIndex <= 11)
                    PrintIndex(textbox, shift);
                else
                    PrintTapeElement(textbox, shift);
            }
        }

        private void PrintIndex(TextBox box, int shift)
        {
            box.Text = (box.TabIndex - 6 + shift).ToString();
        }

        private void PrintTapeElement(TextBox box, int shift, string gap = "")
        {
            int index = box.TabIndex - 17 + shift;
            try
            {
                box.Text = tape[index];
                if (chosenIndex == index)
                    box.BackColor = Color.LightYellow;
                else
                    box.BackColor = Color.FromArgb(255, 240, 240, 240);
            }
            catch
            {
                box.Text = gap;
            }
        }
    }
}

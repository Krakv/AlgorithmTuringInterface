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
    public partial class EditTape : Form
    {
        TextBox[] textBoxes = new TextBox[22];
        Dictionary<long, string> tape = new Dictionary<long, string>();
        long shift = 0;
        long chosenIndex = 0;

        public EditTape(Dictionary<long, string> tape)
        {
            this.tape = tape;
            InitializeComponent();
        }

        //Занесение textbox-ов в массив
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

        private void PrintIndex(TextBox box, long shift)
        {
            box.Text = (box.TabIndex - 6 + shift).ToString();
        }

        private void PrintTapeElement(TextBox box, long shift, string gap = "")
        {
            Color defaultColor = Color.FromArgb(255, 240, 240, 240);
            long index = box.TabIndex - 17 + shift;
            try
            {
                box.Text = tape[index];
            }
            catch
            {
                box.Text = gap;
            }
            if (chosenIndex == index)
                box.BackColor = Color.LightYellow;
            else
                box.BackColor = defaultColor;
        }

        private void InitializeTape()
        {
            if (textBoxes[0] == null)
                InitializeTextBoxes();
            foreach (TextBox textbox in textBoxes)
            {
                if (textbox.TabIndex <= 11)
                    PrintIndex(textbox, shift);
                else
                    PrintTapeElement(textbox, shift);
            }
        }

        private void EditTape_Load(object sender, EventArgs e)
        {
            InitializeTextBoxes();
            InitializeTape();
        }

        private void NextElement_Click(object sender, EventArgs e)
        {
            shift++;
            InitializeTape();
        }

        private void PreviousElement_Click(object sender, EventArgs e)
        {
            shift--;
            InitializeTape();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shift = chosenIndex;
            InitializeTape();
        }

        private void ChooseElementIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                chosenIndex = Int64.Parse(ChooseElementIndexTextBox.Text);
                errorProvider1.SetError(ChooseElementIndexTextBox, "");
            }
            catch
            {
                errorProvider1.SetError(ChooseElementIndexTextBox, "Некорректно введен индекс.");
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            tape[textBox12.TabIndex - 17 + shift] = textBox12.Text;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            tape[textBox13.TabIndex - 17 + shift] = textBox13.Text;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            tape[textBox14.TabIndex - 17 + shift] = textBox14.Text;
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            tape[textBox15.TabIndex - 17 + shift] = textBox15.Text;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            tape[textBox16.TabIndex - 17 + shift] = textBox16.Text;
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            tape[textBox17.TabIndex - 17 + shift] = textBox17.Text;
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            tape[textBox18.TabIndex - 17 + shift] = textBox18.Text;
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            tape[textBox19.TabIndex - 17 + shift] = textBox19.Text;
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            tape[textBox20.TabIndex - 17 + shift] = textBox20.Text;
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            tape[textBox21.TabIndex - 17 + shift] = textBox21.Text;
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            tape[textBox22.TabIndex - 17 + shift] = textBox22.Text;
        }
    }
}

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

        private void textBoxes_Validating(object sender, CancelEventArgs e)
        {
            TextBox txtbx = sender as TextBox;
            foreach(string index in Data.actions.Keys)
            {
                if (index == txtbx.Text)
                {
                    tape[txtbx.TabIndex - 17 + shift] = txtbx.Text;
                    errorProvider1.SetError(txtbx, null);
                    return;
                }
            }
            if (txtbx.Text != "")
                errorProvider1.SetError(txtbx, "Символ не найден в алфавите таблицы множества состояний.");
            else
                errorProvider1.SetError(txtbx, null);
        }

        private void textBoxes_Validated(object sender, EventArgs e)
        {
            TextBox txtbx = sender as TextBox;
            
        }
    }
}

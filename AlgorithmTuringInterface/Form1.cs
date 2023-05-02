using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AlgorithmTuringInterface
{
    public partial class MachineTuring : Form
    {
        Dictionary<int, string> tape = new Dictionary<int, string>();
        int shift = 0;
        TextBox[] textBoxes = new TextBox[22];
        int chosenIndex = 0;

        public MachineTuring()
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
            shift = chosenIndex;
            InitializeTape();
            QuantityStatesForm frm = new QuantityStatesForm() { TopLevel = false, Dock = DockStyle.Fill, TopMost = true };
            this.QuantityStates.Controls.Add(frm);
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
            if (textBoxes[0] == null)
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
            Color defaultColor = Color.FromArgb(255, 240, 240, 240);
            int index = box.TabIndex - 17 + shift;
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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        //private void FindWay_Click(object sender, EventArgs e)
        //{
        //    var fileContent = string.Empty;
        //    var filePath = string.Empty;

        //    using (OpenFileDialog openFileDialog = new OpenFileDialog())
        //    {
        //        openFileDialog.InitialDirectory = "c:\\";
        //        openFileDialog.Filter = "csv files (*.csv)|*.csv";
        //        openFileDialog.FilterIndex = 2;
        //        openFileDialog.RestoreDirectory = true;

        //        if (openFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            //Get the path of specified file
        //            filePath = openFileDialog.FileName;

        //            //Read the contents of the file into a stream
        //            var fileStream = openFileDialog.OpenFile();

        //            using (StreamReader reader = new StreamReader(fileStream))
        //            {
        //                fileContent = reader.ReadToEnd();
        //            }
        //        }
        //        if (filePath != string.Empty)
        //        {
        //            this.TapeWay.Text = filePath;
        //        }
        //    }
        //}

        //private void Read_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //       string path = File.ReadAllText(TapeWay.Text);
        //    }
        //    catch
        //    {
        //        // Initializes the variables to pass to the MessageBox.Show method.
        //        string message = "Не удалось считать файл из выбранного пути.";
        //        string caption = "Error Detected in Input";
        //        MessageBoxButtons buttons = MessageBoxButtons.OK;

        //        // Displays the MessageBox.
        //        MessageBox.Show(message, caption, buttons);
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            QuantityStatesForm frm = new QuantityStatesForm() { BackColor = Color.White, TopLevel = false, Dock = DockStyle.Fill, TopMost = true};
            this.QuantityStates.Controls.Add(frm);
            frm.Show();
        }

        private void FileComboBox_Click(object sender, EventArgs e)
        {

        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tapePath = string.Empty;
            try
            {
                var fileContent = string.Empty;
                var filePath = string.Empty;

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "csv files (*.csv)|*.csv";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        //Read the contents of the file into a stream
                        var fileStream = openFileDialog.OpenFile();

                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            fileContent = reader.ReadToEnd();
                        }
                    }
                    if (filePath != string.Empty)
                    {
                        tapePath = filePath;
                    }
                }
                string path = File.ReadAllText(tapePath);
            }
            catch
            {
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "Не удалось считать файл из выбранного пути.";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                // Displays the MessageBox.
                MessageBox.Show(message, caption, buttons);
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            NextStepBtn.Enabled = true;
            PreviousStepBtn.Enabled = true;
            FinishBtn.Enabled = true;
            StartBtn.Enabled = false;
            ChooseElementIndexTextBox.Enabled = false;
            ChooseElementIndexTextBox.Text = chosenIndex.ToString();
            BtnComplete.Enabled = false;
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            NextStepBtn.Enabled = false;
            PreviousStepBtn.Enabled = false;
            FinishBtn.Enabled = false;
            StartBtn.Enabled = true;
            ChooseElementIndexTextBox.Enabled = true;
            BtnComplete.Enabled = true;
        }

        private void ChooseElementIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnComplete_Click(object sender, EventArgs e)
        {
            bool isSuccess = Int32.TryParse(ChooseElementIndexTextBox.Text, out int index);
            if (isSuccess)
            {
                chosenIndex = index;
                InitializeTape();
                StartBtn.Enabled = true;
            }
            else
            {
                StartBtn.Enabled = false;
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "Введенный индекс не является целым числом.";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                // Displays the MessageBox.
                MessageBox.Show(message, caption, buttons);
            }
        }

        private void ChooseElementIndexLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

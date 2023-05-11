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

namespace AlgorithmTuringInterface
{
    public partial class MachineTuring : Form
    {
        Dictionary<long, string> tape = new Dictionary<long, string>();
        long shift = 0;
        TextBox[] textBoxes = new TextBox[22];
        long chosenIndex = 0;
        

        public MachineTuring()
        {
            InitializeActions();
            InitializeTextBoxes();
            InitializeComponent();
        }

        private void InitializeActions()
        {
            try
            {
                Data.actions.Add("0", new List<string> { "0>Q5", "0>Q5", "0>Q5", "0>Q5", "0>Q5" });
                Data.actions.Add("1", new List<string> { "1>Q5", "1>Q5", "1>Q5", "1>Q5", "1>Q5" });
                Data.actions.Add("2", new List<string> { "1>Q5", "1>Q5", "1>Q5", "1>Q5", "1>Q5" });
                Data.actions.Add("3", new List<string> { "1>Q5", "1>Q5", "1>Q5", "1>Q5", "1>Q5" });
                Data.actions.Add("4", new List<string> { "1>Q5", "1>Q5", "1>Q5", "1>Q5", "1>Q5" });
                Data.actions.Add("5", new List<string> { "1>Q5", "1>Q5", "1>Q5", "1>Q5", "1>Q5" });
                Data.actions.Add("6", new List<string> { "1>Q5", "1>Q5", "1>Q5", "1>Q5", "1>Q5" });
                Data.actions.Add("7", new List<string> { "1>Q5", "1>Q5", "1>Q5", "1>Q5", "1>Q5" });
                Data.actions.Add("8", new List<string> { "1>Q5", "1>Q5", "1>Q5", "1>Q5", "1>Q5" });
                Data.actions.Add("9", new List<string> { "1>Q5", "1>Q5", "1>Q5", "1>Q5", "1>Q5" });
            }
            catch
            {
                //nothing
            }
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

        #region Buttons

        private void button1_Click(object sender, EventArgs e)
        {
            shift = chosenIndex;
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

        private void StartBtn_Click(object sender, EventArgs e)
        {
            NextStepBtn.Enabled = true;
            PreviousStepBtn.Enabled = true;
            FinishBtn.Enabled = true;
            StartBtn.Enabled = false;
            //ChooseElementIndexTextBox.Enabled = false;
            //ChooseElementIndexTextBox.Text = chosenIndex.ToString();
            //BtnComplete.Enabled = false;
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            NextStepBtn.Enabled = false;
            PreviousStepBtn.Enabled = false;
            FinishBtn.Enabled = false;
            StartBtn.Enabled = true;
            //ChooseElementIndexTextBox.Enabled = true;
            //BtnComplete.Enabled = true;
        }

        //private void BtnComplete_Click(object sender, EventArgs e)
        //{
        //    bool isSuccess = Int32.TryParse(ChooseElementIndexTextBox.Text, out int index);
        //    if (isSuccess)
        //    {
        //        chosenIndex = index;
        //        InitializeTape();
        //        StartBtn.Enabled = true;
        //    }
        //    else
        //    {
        //        StartBtn.Enabled = false;
        //        // Initializes the variables to pass to the MessageBox.Show method.
        //        string message = "Введенный индекс не является целым числом.";
        //        string caption = "Ошибка ввода";
        //        MessageBoxButtons buttons = MessageBoxButtons.OK;

        //        // Displays the MessageBox.
        //        MessageBox.Show(message, caption, buttons);
        //    }
        //    ChooseElementIndexTextBox.Focus();
        //}

        #endregion Buttons

        private void Tape_Paint(object sender, PaintEventArgs e)
        {
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

        public void InitializePanel1Paint()
        {
            QuantityStatesForm frm = new QuantityStatesForm() { BackColor = Color.White, TopLevel = false, Dock = DockStyle.Fill, TopMost = true };
            this.QuantityStates.Controls.Add(frm);
            frm.Show();
        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {
            InitializePanel1Paint();
        }

        private void OpenTapeFile_Click(object sender, EventArgs e)
        {
            string tapePath = string.Empty;
            try
            {
                tapePath = Program.FindPathManually();
                tape = Program.ReadTape(tapePath);
            }
            catch
            {
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "Не удалось считать файл из выбранного пути.";
                string caption = "Ошибка ввода";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                // Displays the MessageBox.
                MessageBox.Show(message, caption, buttons);
            }
        }


        private void NextElement_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath =
                new System.Drawing.Drawing2D.GraphicsPath();

            // Set a new rectangle to the same size as the button's 
            // ClientRectangle property.
            System.Drawing.Rectangle newRectangle = NextElement.ClientRectangle;

            // Decrease the size of the rectangle.
            newRectangle.Inflate(-3, -3);

            // Increase the size of the rectangle to include the border.
            newRectangle.Inflate(1, 1);

            // Create a circle within the new rectangle.
            buttonPath.AddEllipse(newRectangle);

            // Set the button's Region property to the newly created 
            // circle region.
            NextElement.Region = new System.Drawing.Region(buttonPath);
        }

        private void PreviousElement_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath =
                new System.Drawing.Drawing2D.GraphicsPath();

            // Set a new rectangle to the same size as the button's 
            // ClientRectangle property.
            System.Drawing.Rectangle newRectangle = PreviousElement.ClientRectangle;

            // Decrease the size of the rectangle.
            newRectangle.Inflate(-3, -3);

            // Increase the size of the rectangle to include the border.
            newRectangle.Inflate(1, 1);

            // Create a circle within the new rectangle.
            buttonPath.AddEllipse(newRectangle);

            // Set the button's Region property to the newly created 
            // circle region.
            PreviousElement.Region = new System.Drawing.Region(buttonPath);
        }

        // This method will change the square button to a circular button by 
        // creating a new circle-shaped GraphicsPath object and setting it 
        // to the RoundButton objects region.
        private void button1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath =
                new System.Drawing.Drawing2D.GraphicsPath();

            // Set a new rectangle to the same size as the button's 
            // ClientRectangle property.
            System.Drawing.Rectangle newRectangle = button1.ClientRectangle;

            // Decrease the size of the rectangle.
            newRectangle.Inflate(-3, -3);

            // Increase the size of the rectangle to include the border.
            newRectangle.Inflate(1, 1);

            // Create a circle within the new rectangle.
            buttonPath.AddEllipse(newRectangle);

            // Set the button's Region property to the newly created 
            // circle region.
            button1.Region = new System.Drawing.Region(buttonPath);
        }

        private void EditTapeFile_Click(object sender, EventArgs e)
        {
            EditTape editTape = new EditTape(tape);
            editTape.Show();
        }

        private void EditQuantitiesFile_Click(object sender, EventArgs e)
        {
            EditQuantities editQuantities = new EditQuantities(this, Data.quantities, Data.actions);
            editQuantities.Owner = this;
            editQuantities.Show();
        }

        private void MachineTuring_Activated(object sender, EventArgs e)
        {
            QuantityStates.Controls.Clear();
        }

        private void CreateTapeFile_Click(object sender, EventArgs e)
        {
            EditTape editTape = new EditTape(new Dictionary<long, string>());
            editTape.Show();
        }

        private void CreateQuantitiesFile_Click(object sender, EventArgs e)
        {
            EditQuantities editQuantities = new EditQuantities(this, new string[0], new Dictionary<string, List<string>>());
            editQuantities.Owner = this;
            editQuantities.Show();
        }

        private void OpenQuantitiesFile_Click(object sender, EventArgs e)
        {
            string actionsPath = string.Empty;
            try
            {
                actionsPath = Program.FindPathManually();
                object[] obj = Program.ReadActionsFile(actionsPath);
                Data.actions = obj[0] as Dictionary<string, List<string>>;
                Data.quantities = obj[1] as string[];
            }
            catch
            {
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "Не удалось считать файл из выбранного пути.";
                string caption = "Ошибка ввода";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                // Displays the MessageBox.
                MessageBox.Show(message, caption, buttons);
            }
        }
    }
}

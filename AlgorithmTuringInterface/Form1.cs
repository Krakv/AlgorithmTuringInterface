using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AlgorithmTuringInterface.Program;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace AlgorithmTuringInterface
{
    public partial class MachineTuring : Form
    {
        Dictionary<long, string> tape = new Dictionary<long, string>();
        DoubleBufferedDataGridView table = new Program.DoubleBufferedDataGridView();
        long shift = 0;
        long chosenIndex = 0;
        long speed;

        public MachineTuring()
        {
            InitializeActions();
            InitializeComponent();
            InitializeTable(Data.quantities, Data.actions);
            speed = Int64.Parse(Regex.Replace(SpeedTxtBx.Text, @"[^\d]+", ""));
        }

        public void InitializeTable(string[] quantities, Dictionary<string, List<string>> actions)
        {
            // Adding first row (quantities)
            for (int i = 0; i < quantities.Length; i++)
            {
                table.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = quantities[i] });
            }
            // Adding Rows (actions)
            foreach (string key in actions.Keys)
            {
                DataGridViewCell[] array = new DataGridViewCell[actions[key].Count];
                for (int i = 0; i < actions[key].Count; i++)
                {
                    array[i] = new DataGridViewTextBoxCell() { Value = actions[key][i] };
                }
                DataGridViewRow row = new DataGridViewRow() { HeaderCell = new DataGridViewRowHeaderCell() { Value = key } };
                row.Cells.AddRange(array);
                table.Rows.Add(row);
            }
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

        public void InitializeTape()
        {
            tape = Data.tape;
            foreach(TextBox textbox in Tape.Controls)
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

        public void PaintQuantitiesStatesForm()
        {
            this.QuantityStates.Controls.Clear();
            QuantityStatesForm frm = new QuantityStatesForm() { BackColor = Color.White, TopLevel = false, Dock = DockStyle.Fill, TopMost = true };
            this.QuantityStates.Controls.Add(frm);
            frm.Show();
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
            EditTape editTape = new EditTape(this, tape);
            editTape.Show();
        }

        private void EditQuantitiesFile_Click(object sender, EventArgs e)
        {
            EditQuantities editQuantities = new EditQuantities(this, table);
            editQuantities.Show();
        }

        private void MachineTuring_Activated(object sender, EventArgs e)
        {
            
        }

        private void CreateTapeFile_Click(object sender, EventArgs e)
        {
            EditTape editTape = new EditTape(this, new Dictionary<long, string>());
            editTape.Show();
        }

        private void CreateQuantitiesFile_Click(object sender, EventArgs e)
        {
            EditQuantities editQuantities = new EditQuantities(this, table);
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

        private void MachineTuring_Shown(object sender, EventArgs e)
        {
            PaintQuantitiesStatesForm();
            InitializeTape();
        }

        private void ChangeSpeedBtn_Click(object sender, EventArgs e)
        {
            string result = Microsoft.VisualBasic.Interaction.InputBox("Введите положительное число - скорость выполнения алгоритма:");
            bool isSuccess = result == "" || Int64.TryParse(result, out speed) && speed >= 0;
            if (!isSuccess )
            {
                MessageBox.Show("Не удалось получить положительное число", "Ошибка ввода", MessageBoxButtons.OK);
                ChangeSpeedBtn_Click(sender, e);
                return;
            }
            if (result != "")
                SpeedTxtBx.Text = speed.ToString() + " мс";
        }

        private void OpenQuantitiesTableBtn_Click(object sender, EventArgs e)
        {
            QuantityStatesForm frm = new QuantityStatesForm() { FormBorderStyle = FormBorderStyle.Sizable };
            frm.Show();
        }

        private void InitChosenIndexBtn_Click(object sender, EventArgs e)
        {
            string result = Microsoft.VisualBasic.Interaction.InputBox("Введите целое число - индекс элемента, с которого будет произведен запуск алогритма:");
            bool isSuccess = result == "" || Int64.TryParse(result, out chosenIndex);
            if (!isSuccess)
            {
                MessageBox.Show("Введенный индекс не является целым числом", "Ошибка ввода", MessageBoxButtons.OK);
                InitChosenIndexBtn_Click(sender, e);
                return;
            }
            if (result != "")
                InitializeTape();
        }

        private void MachineTuring_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("Вы действительно хотите выйти?", "Выход из программы",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            e.Cancel = !(res == DialogResult.Yes);
        }

        public void Table_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Data.actions[table.Rows[e.RowIndex].HeaderCell.Value.ToString()][e.ColumnIndex] = table[e.ColumnIndex, e.RowIndex].Value.ToString();
        }
    }
}

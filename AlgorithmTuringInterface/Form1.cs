﻿using AlgorithmTuringInterface.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Resources;
using System.Runtime.Remoting.Channels;
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
        Dictionary<long, string> tape;
        DataGridView table;
        long shift = 0;
        long chosenIndex = 0;
        long speed;
        bool isCreated = false;

        public MachineTuring()
        {
            InitializeComponent();

            // Заполнение значений таблицы состояний по умолчанию
            InitializeActions();

            // Создание таблицы состояний
            table = InitializeTable(Data.quantities, Data.Actions, table);

            // Сохранение таблицы в общем классе Data
            Data.table = table;

            // Считывание скорости из текстового бокса
            speed = Int64.Parse(Regex.Replace(SpeedTxtBx.Text, @"[^\d]+", ""));

            // Инициализация индексов названий строк (Для удаления строк)
            Data.InitializeKeysIndexes();

            // флажок, указывающий, что объект не находится в процессе инициализации
            isCreated = true; 
        }

        private void MachineTuring_Shown(object sender, EventArgs e)
        {
            PaintQuantitiesStatesForm(); // Прорисовка таблицы состояний
            InitializeTape(); // Прорисовка значений на ленте
        }

        private void MachineTuring_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Подтверждение выхода из программы
            var res = MessageBox.Show("Вы действительно хотите выйти?", "Выход из программы",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = !(res == DialogResult.Yes);
        }

        #region Initializing

        public DataGridView InitializeTable(string[] quantities, Dictionary<string, List<string>> actions, DataGridView table = null)
        {
            if (table == null)
            {
                table = new System.Windows.Forms.DataGridView();
                table.AllowUserToAddRows = false;
                table.AllowUserToDeleteRows = false;
                table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                table.Name = "table";
                table.StandardTab = true;
                table.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellEndEdit);
                table.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.table_ColumnAdded);
                table.ColumnRemoved += new System.Windows.Forms.DataGridViewColumnEventHandler(this.table_ColumnRemoved);
                table.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.table_RowAdded);
                table.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.table_RowRemoved);
            }
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
            table.Size = new Size(1097, 515);
            table.Location = new Point(12, 12);
            table.Dock = DockStyle.None;
            table.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            return table;
        }

        private void InitializeActions()
        {
            try
            {
                Data.Actions.Add("", new List<string> { "<Q2", ">finish"});
                Data.Actions.Add("0", new List<string> { "1>Q1", "<Q2" });
                Data.Actions.Add("1", new List<string> { "0>Q1", "<Q2" });
            }
            catch
            {
                //nothing
            }
        }

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
            QuantityStatesForm frm = new QuantityStatesForm(Data.quantities, Data.Actions) { BackColor = Color.White, TopLevel = false, Dock = DockStyle.Fill, TopMost = true };
            this.QuantityStates.Controls.Add(frm);
            frm.Show();
        }

        #region change the square button to a circular button

        // This method will change the square button to a circular button by 
        // creating a new circle-shaped GraphicsPath object and setting it 
        // to the RoundButton objects region.
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
            System.Drawing.Rectangle newRectangle = PreviousElement.ClientRectangle;
            newRectangle.Inflate(-3, -3);
            newRectangle.Inflate(1, 1);
            buttonPath.AddEllipse(newRectangle);
            PreviousElement.Region = new System.Drawing.Region(buttonPath);
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath =
                new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Rectangle newRectangle = button1.ClientRectangle;
            newRectangle.Inflate(-3, -3);
            newRectangle.Inflate(1, 1);
            buttonPath.AddEllipse(newRectangle);
            button1.Region = new System.Drawing.Region(buttonPath);
        }

        #endregion change the square button to a circular button

        #endregion Initializing

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
            InitChosenIndexBtn.Enabled = false;
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            NextStepBtn.Enabled = false;
            PreviousStepBtn.Enabled = false;
            FinishBtn.Enabled = false;
            StartBtn.Enabled = true;
            InitChosenIndexBtn.Enabled = true;
        }

        #endregion Buttons

        #region Upper Menu

        #region TapeFile

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

        private void EditTapeFile_Click(object sender, EventArgs e)
        {
            EditTape editTape = new EditTape(this, tape);
            editTape.Show();
        }

        private void CreateTapeFile_Click(object sender, EventArgs e)
        {
            EditTape editTape = new EditTape(this, new Dictionary<long, string>());
            editTape.Show();
        }

        private void SaveTapeFile_Click(object sender, EventArgs e)
        {
            if (Data.tape.Keys.Count == 0)
                return;

            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "csv files (*.csv)|*.csv";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    using (StreamWriter writer = new StreamWriter(myStream))
                    {
                        long[] keys = new long[Data.tape.Count];
                        long counter = 0;
                        foreach(long index in Data.tape.Keys)
                        {
                            keys[counter++] = index;
                        }
                        Array.Sort(keys);
                        for (long i = keys[0]; i <= keys[keys.Length - 1]; i++)
                        {
                            writer.Write(i);
                            writer.Write(';');
                        }
                        writer.WriteLine();
                        for (long i = keys[0]; i <= keys[keys.Length - 1]; i++)
                        {
                            try
                            {
                                writer.Write(Data.tape[i]);
                            }
                            catch
                            {
                            }
                            writer.Write(';');
                        }
                        writer.Close();
                    }
                    
                    myStream.Close();
                }
            }
        }

        #endregion TapeFile

        #region QuantitiesFile

        private void OpenQuantitiesFile_Click(object sender, EventArgs e)
        {
            string actionsPath = string.Empty;
            try
            {
                actionsPath = Program.FindPathManually();
                object[] obj = Program.ReadActionsFile(actionsPath);
                Data.Actions = obj[0] as Dictionary<string, List<string>>;
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

        private void EditQuantitiesFile_Click(object sender, EventArgs e)
        {
            EditQuantities editQuantities = new EditQuantities(this, table);
            editQuantities.Show();
        }

        private void CreateQuantitiesFile_Click(object sender, EventArgs e)
        {
            Dictionary<string, List<string>> actions = new Dictionary<string, List<string>>();
            actions.Add("", new List<string>() { " " });
            isCreated = false;
            EditQuantities editQuantities = new EditQuantities(this, InitializeTable(new string[1] { "Q1" }, actions));
            isCreated = true;
            editQuantities.Show();
        }

        private void SaveQuantitiesFile_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "csv files (*.csv)|*.csv";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    using (StreamWriter writer = new StreamWriter(myStream))
                    {
                        writer.Write(' ');
                        foreach (string str in Data.quantities)
                        {
                            writer.Write(';');
                            writer.Write(str);
                        }
                        writer.WriteLine();
                        foreach (string str in Data.Actions.Keys)
                        {
                            writer.Write(str);
                            foreach (string action in Data.Actions[str])
                            {
                                writer.Write(';');
                                writer.Write(action);
                            }
                            writer.WriteLine();
                        }
                    }
                    myStream.Close();
                }
            }
        }

        #endregion QuantitiesFile

        #region other

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

        private void OpenQuantitiesTableBtn_Click(object sender, EventArgs e)
        {
            QuantityStatesForm frm = new QuantityStatesForm(Data.quantities, Data.Actions) { FormBorderStyle = FormBorderStyle.Sizable };
            frm.Show();
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

        private void UserGuideMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, Environment.CurrentDirectory + "\\UserGuide.chm");
        }

        #endregion other

        #endregion Upper menu

        #region TableEdited

        public void Table_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Data.Actions[table.Rows[e.RowIndex].HeaderCell.Value.ToString()][e.ColumnIndex] = table[e.ColumnIndex, e.RowIndex].Value.ToString();
        //    QuantityStatesForm tablePanel = QuantityStates.Controls[0] as QuantityStatesForm;
        //    tablePanel.ChangeTableElement(table[e.ColumnIndex, e.RowIndex].Value.ToString(), (e.RowIndex + 1) * (table.ColumnCount + 1)  + e.ColumnIndex + 1);
        }

        private void table_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (isCreated)
            {
                string[] states = new string[table.Columns.Count];
                int counter = 0;
                foreach (DataGridViewColumn dataGridViewColumn in table.Columns)
                    states[counter++] = dataGridViewColumn.HeaderText;
                Data.quantities = states;
                foreach (List<string> list in Data.Actions.Values)
                    list.Add("");
                //QuantityStatesForm tablePanel = QuantityStates.Controls[0] as QuantityStatesForm;
                //tablePanel.ChangeTable(Data.quantities, Data.Actions);
                Data.InitializeKeysIndexes();
            }
        }

        private void table_ColumnRemoved(object sender, DataGridViewColumnEventArgs e)
        {
            if (isCreated)
            {
                string[] states = new string[table.Columns.Count];
                int counter = 0;
                foreach (DataGridViewColumn dataGridViewColumn in table.Columns)
                    states[counter++] = dataGridViewColumn.HeaderText;
                Data.quantities = states;
                foreach (List<string> list in Data.Actions.Values)
                    list.RemoveAt(e.Column.DisplayIndex);
                //QuantityStatesForm tablePanel = QuantityStates.Controls[0] as QuantityStatesForm;
                //tablePanel.ChangeTable(Data.quantities, Data.Actions);
                Data.InitializeKeysIndexes();
            }
        }
        
        private void table_RowAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (isCreated)
            {
                List<string> elems = new List<string>();
                for (int i = 0; i < table.Columns.Count; i++)
                    elems.Add("");
                Data.Actions.Add(table.Rows[e.RowIndex].HeaderCell.Value.ToString(), elems);
                //QuantityStatesForm tablePanel = QuantityStates.Controls[0] as QuantityStatesForm;
                //tablePanel.ChangeTable(Data.quantities, Data.Actions);
                Data.InitializeKeysIndexes();
            }
        }
        
        private void table_RowRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (isCreated)
            {
                Data.Actions.Remove(Data.KeysIndexes[e.RowIndex]);
                //QuantityStatesForm tablePanel = QuantityStates.Controls[0] as QuantityStatesForm;
                //tablePanel.AutoScrollPosition = new Point(0, 0);
                //tablePanel.ChangeTable(Data.quantities, Data.Actions);
                Data.InitializeKeysIndexes();
            }
        }

        #endregion TableEdited

        private void TapeLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tape_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuantityLabel_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьФайлToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TapeFile_Click(object sender, EventArgs e)
        {

        }

        private void TapeSeparator_Click(object sender, EventArgs e)
        {

        }

        private void QuantitiesFile_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void CurrentSpeedTxtBx_Click(object sender, EventArgs e)
        {

        }

        private void SpeedTxtBx_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator3_Click(object sender, EventArgs e)
        {

        }

        private void NextStepBtn_Click(object sender, EventArgs e)
        {

        }

        private void PreviousStepBtn_Click(object sender, EventArgs e)
        {

        }

        private void StartNFinishBtn_Click(object sender, EventArgs e)
        {

        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void QuantityStates_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

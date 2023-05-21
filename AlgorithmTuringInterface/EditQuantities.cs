using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace AlgorithmTuringInterface
{
    public partial class EditQuantities : Form
    {
        string[] quantities;
        Dictionary<string, List<string>> actions;
        MachineTuring owner;
        Program.DoubleBufferedDataGridView tableReference;

        public EditQuantities(MachineTuring owner, Program.DoubleBufferedDataGridView table)
        {
            tableReference = table;
            this.owner = owner;
            InitializeComponent();
            this.table.Visible = false;
            this.table = table;
            Controls.Add(table);
        }

        private void InitializeQuantitiesTableEdit()
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

        public void Table_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            actions[table.Rows[e.RowIndex].HeaderCell.Value.ToString()][e.ColumnIndex] = table[e.ColumnIndex, e.RowIndex].Value.ToString();
        }

        // Сохранение 
        private void EditQuantities_Deactivate(object sender, EventArgs e)
        {
            quantities = new string[table.Columns.Count];
            foreach(DataGridViewTextBoxColumn column in table.Columns)
            {
                quantities[column.Index] = column.HeaderText;
            }
            actions = new Dictionary<string, List<string>>();
            foreach (DataGridViewRow row in table.Rows)
            {
                List<string> list = new List<string>();
                foreach(DataGridViewTextBoxCell item in row.Cells)
                {
                    list.Add(item.Value?.ToString());
                }
                if (row.HeaderCell.Value != null)
                    actions[row.HeaderCell.Value?.ToString()] = list;
            }
            Data.actions = actions;
            Data.quantities = quantities;
            owner.PaintQuantitiesStatesForm();
        }

        #region RowFuncs

        private void AddRowBtn_Click(object sender, EventArgs e)
        {
            // если введенный символ уже содержится в алфавите
            foreach (DataGridViewRow row in table.Rows)
            {
                if (row.HeaderCell.Value?.ToString() == RowNameTxtBx.Text.Trim())
                {
                    errorProvider1.SetError(RowNameTxtBx, "Введенный символ уже есть в алфавите.");
                    AddRowBtn.Enabled = false;
                    DelRowBtn.Enabled = false;
                    return;
                }
            }
            // если введенный символ удовлетворяет ограничениям
            {
                DataGridViewRow row = new DataGridViewRow() { HeaderCell = new DataGridViewRowHeaderCell() { Value = RowNameTxtBx.Text.Trim() } };
                table.Rows.Add(row);
            }
        }

        private void DelRowBtn_Click(object sender, EventArgs e)
        {
            if (RowNameTxtBx.Text.Trim() == "")
                return;
            // Initializes the variables to pass to the MessageBox.Show method.
            string message = $"Вы действительно хотите удалить строку символа {RowNameTxtBx.Text.Trim()}?";
            string caption = "Подтверждение";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);

            // Deleting
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                foreach(DataGridViewRow row in table.Rows)
                {
                    if (row.HeaderCell.Value?.ToString() == RowNameTxtBx.Text.Trim())
                    {
                        table.Rows.RemoveAt(row.Index);
                        return;
                    }
                }
            }
            MessageBox.Show("Строка не найдена.", "Ошибка удаления", MessageBoxButtons.OK);
        }

        private void RowNameTxtBx_TextChanged(object sender, EventArgs e)
        {
            AddRowBtn.Enabled = true;
            DelRowBtn.Enabled = true;
        }

        #endregion RowFuncs

        #region ColumnFuncs

        private void AddColumnBtn_Click(object sender, EventArgs e)
        {
            // если введенный символ уже содержится в алфавите
            foreach (DataGridViewColumn column in table.Columns)
            {
                if (column.HeaderText == "Q" + ColumnNameTxtBx.Text.Trim())
                {
                    errorProvider1.SetError(ColumnNameTxtBx, "Введенное состояние уже есть в таблице.");
                    AddColumnBtn.Enabled = false;
                    DelColumnBtn.Enabled = false;
                    return;
                }
            }
            // если введенный символ удовлетворяет ограничениям
            {
                int index = Int32.Parse(ColumnNameTxtBx.Text.Trim()) - 1;
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn() { HeaderText = "Q" + ColumnNameTxtBx.Text.Trim(), DisplayIndex = index };
                table.Columns.Add(column);
            }
        }

        private void DelColumnBtn_Click(object sender, EventArgs e)
        {
            if (ColumnNameTxtBx.Text.Trim() == "")
                return;
            // Initializes the variables to pass to the MessageBox.Show method.
            string message = $"Вы действительно хотите удалить столбец состояния {"Q" + ColumnNameTxtBx.Text.Trim()}?";
            string caption = "Подтверждение";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            // Deleting
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (DataGridViewColumn column in table.Columns)
                {
                    if (column.HeaderCell.Value?.ToString() == "Q" + ColumnNameTxtBx.Text.Trim())
                    {
                        table.Columns.RemoveAt(column.Index);
                        return;
                    }
                }
            }
            MessageBox.Show("Столбец не найден.", "Ошибка удаления", MessageBoxButtons.OK);
        }

        private void ColumnNameTxtBx_TextChanged(object sender, EventArgs e)
        {
            AddColumnBtn.Enabled = true;
            DelColumnBtn.Enabled = true;
        }

        private void ColumnNameTxtBx_Validating(object sender, CancelEventArgs e)
        {
            if (ColumnNameTxtBx.Text.Trim() == "")
                return;
            int number;
            // если введенный номер состояния не натуральное число
            if (!Int32.TryParse(ColumnNameTxtBx.Text, out number) || number < 1)
            {
                if (ColumnNameTxtBx.Text != "")
                    errorProvider1.SetError(ColumnNameTxtBx, "Введите натуральное число - номер состояния.");
                AddColumnBtn.Enabled = false;
                DelColumnBtn.Enabled = false;
                return;
            }
            // если введенный номер удовлетворяет ограничениям
            errorProvider1.SetError(ColumnNameTxtBx, null);
            AddColumnBtn.Enabled = true;
            DelColumnBtn.Enabled = true;
        }

        #endregion ColumnFuncs

        private void EditQuantities_Shown(object sender, EventArgs e)
        {
            table = tableReference;
            
        }
    }
}

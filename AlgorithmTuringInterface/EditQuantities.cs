using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace AlgorithmTuringInterface
{
    public partial class EditQuantities : Form
    {
        MachineTuring owner;
        DataGridView table;

        public EditQuantities(MachineTuring owner, DataGridView table)
        {
            InitializeComponent();
            this.owner = owner; // Добавление формы-владельца, которая инициировала запуск данной формы
            this.table = table; // Передача таблицы DataGridView
            Controls.Add(table); // Добавление таблицы в форму
        }
        
        private void EditQuantities_Shown(object sender, EventArgs e)
        {
            owner.Enabled = false; // Выключение формы-владельца
        }

        private void EditQuantities_FormClosing(object sender, FormClosingEventArgs e)
        {
            Controls.Clear(); // Для избежания удаления таблицы в качестве мусора
            QuantityStatesForm tablePanel = owner.QuantityStates.Controls[0] as QuantityStatesForm;
            tablePanel.ChangeTable(Data.quantities, Data.Actions); // Перерисовка таблицы в форме-владельце
            owner.Enabled = true; // Включение формы-владельца
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
            // Если в текстовом боксе ничего не написано
            if (RowNameTxtBx.Text.Trim() == "")
                return;

            // Вывод MessageBox
            string message = $"Вы действительно хотите удалить строку символа {RowNameTxtBx.Text.Trim()}?";
            DialogResult result = MessageBox.Show(message, "Подтверждение", MessageBoxButtons.YesNo); 

            // Удаление строки
            if (result == DialogResult.Yes)
            {
                foreach(DataGridViewRow row in table.Rows) // Перебор строк таблицы состояний
                {
                    // Если нашлась строка с введенным символом в названии
                    if (row.HeaderCell.Value?.ToString() == RowNameTxtBx.Text.Trim())
                    {
                        table.Rows.RemoveAt(row.Index);
                        return;
                    }
                }
                MessageBox.Show("Строка не найдена.", "Ошибка удаления", MessageBoxButtons.OK);
            }
        }

        private void RowNameTxtBx_TextChanged(object sender, EventArgs e)
        {
            // Включение кнопок удаления и добавления строк
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
            // Если в текстовом боксе ничего не написано
            if (ColumnNameTxtBx.Text.Trim() == "")
                return;

            // Вывод Message Box
            string message = $"Вы действительно хотите удалить столбец состояния {"Q" + ColumnNameTxtBx.Text.Trim()}?";
            DialogResult result = MessageBox.Show(message, "Подтверждение", MessageBoxButtons.YesNo);

            // Удаление столбца таблицы состояний
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (DataGridViewColumn column in table.Columns) // Перебор столбцов таблицы состояний
                {
                    // Если нашелся столбец с введенным номером в названии
                    if (column.HeaderCell.Value?.ToString() == "Q" + ColumnNameTxtBx.Text.Trim())
                    {
                        table.Columns.RemoveAt(column.Index);
                        return;
                    }
                }
                MessageBox.Show("Столбец не найден.", "Ошибка удаления", MessageBoxButtons.OK);
            }
        }

        private void ColumnNameTxtBx_TextChanged(object sender, EventArgs e)
        {
            // Включение кнопок удаления и добавление столбцов
            AddColumnBtn.Enabled = true;
            DelColumnBtn.Enabled = true;
        }

        private void ColumnNameTxtBx_Validating(object sender, CancelEventArgs e)
        {
            // Если в текстовом боксе ничего не написано
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
    }
}

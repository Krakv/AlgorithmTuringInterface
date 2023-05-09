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
    public partial class EditQuantities : Form
    {
        string[] quantities = Data.quantities;
        Dictionary<string, List<string>> actions = Data.actions;
        MachineTuring owner;

        public EditQuantities(MachineTuring owner)
        {
            this.owner = owner;
            InitializeComponent();
            InitializeQuantitiesTableEdit();
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

        private void EditQuantities_Activated(object sender, EventArgs e)
        {
            
        }

        private void AddRowBtn_Click(object sender, EventArgs e)
        {
            // если введенный символ уже содержится в алфавите
            foreach (DataGridViewRow row in table.Rows)
            {
                if (row.HeaderCell.Value?.ToString() == RowNameTxtBx.Text)
                {
                    errorProvider1.SetError(RowNameTxtBx, "Введенный символ уже есть в алфавите.");
                    AddRowBtn.Enabled = false;
                    DelRowBtn.Enabled = false;
                    return;
                }
            }
            {
                DataGridViewRow row = new DataGridViewRow() { HeaderCell = new DataGridViewRowHeaderCell() { Value = RowNameTxtBx.Text } };
                table.Rows.Add(row);
            }
        }

        private void DelRowBtn_Click(object sender, EventArgs e)
        {
            // Initializes the variables to pass to the MessageBox.Show method.
            string message = $"Вы действительно хотите удалить строку символа {RowNameTxtBx.Text}?";
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
                    if (row.HeaderCell.Value?.ToString() == RowNameTxtBx.Text)
                    {
                        table.Rows.RemoveAt(row.Index);
                        return;
                    }
                }
            }
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
            owner.Enabled = true;
        }


        // Проверка ввода символа алфавита
        private void RowNameTxtBx_Validating(object sender, CancelEventArgs e)
        {
            // если в алфавит подается несколько символов или ни одного
            if (RowNameTxtBx.Text.Length != 1)
            {
                errorProvider1.SetError(RowNameTxtBx, "Каждый элемент алфавита должен являться одним символом.");
                AddRowBtn.Enabled = false;
                DelRowBtn.Enabled = false;
                return;
            }
            // если введенный символ удовлетворяет ограничениям
            errorProvider1.SetError(RowNameTxtBx, null);
            AddRowBtn.Enabled = true;
            DelRowBtn.Enabled = true;
        }

        private void RowNameTxtBx_TextChanged(object sender, EventArgs e)
        {
            AddRowBtn.Enabled = true;
            DelRowBtn.Enabled = true;
        }
    }
}

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
        string[] quantities;
        Dictionary<string, List<string>> actions = new Dictionary<string, List<string>>();

        public EditQuantities(string[] quantities, Dictionary<string, List<string>> actions)
        {
            this.quantities = quantities;
            this.actions = actions;
            InitializeComponent();
        }

        private void EditQuantities_Activated(object sender, EventArgs e)
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
    }
}

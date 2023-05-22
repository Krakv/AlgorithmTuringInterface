using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmTuringInterface
{
    public partial class QuantityStatesForm : Form
    {
        string[] quantities;
        Dictionary<string, List<string>> actions;
        Font font = new Font("Microsoft Sans Serif; 16pt", 16);

        public QuantityStatesForm(string[] quantities, Dictionary<string, List<string>> actions)
        {
            this.quantities = quantities;
            this.actions = actions;
            InitializeComponent();
            MakeQuantitiesTable();
        }
        
        public void ChangeTableElement(string value, int index)
        {
            QuantitiesTable.Controls[index].Text = value;
        }

        public void AddColumn(string[] quantities, Dictionary<string, List<string>> actions)
        {
            this.quantities = quantities;
            this.actions = actions;
            Controls.Clear();
            MakeQuantitiesTable();
        }

        private void MakeQuantitiesTable()
        {
            QuantitiesTable.Controls.Clear();
            QuantitiesTable.ColumnCount = quantities.Length + 1;
            QuantitiesTable.RowCount = actions.Count + 1;
            QuantitiesTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            QuantitiesTable.AutoSize = true;
            QuantitiesTable.Controls.Add(new Label() { Font = font, AutoSize = true }, 0, 0);
            for (int i = 0; i < quantities.Length; i++)
            {
                Label lbl = new Label() { Text = quantities[i], Font = font, Dock = DockStyle.Fill, AutoSize = true, Anchor = AnchorStyles.None };
                QuantitiesTable.Controls.Add(lbl, i + 1, 0);
            }
            int counter = 0;
            foreach (string key in actions.Keys)
            {
                Label lbl1 = new Label() { Text = key, Font = font, Dock = DockStyle.Fill, AutoSize = true, Anchor = AnchorStyles.None };
                QuantitiesTable.Controls.Add(lbl1, 0, ++counter);
                for (int i = 0; i < actions[key].Count; i++)
                {
                    Label lbl = new Label() { Text = actions[key][i], Font = font, AutoSize = true, Dock = DockStyle.Fill, Anchor = AnchorStyles.None };
                    QuantitiesTable.Controls.Add(lbl, i + 1, counter);
                }
            }
            this.Controls.Add(QuantitiesTable);
        }
    }
}

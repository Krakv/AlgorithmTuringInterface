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
        string[] quantities = { "Q1", "Q2", "Q3", "Q4", "Q5"};
        Dictionary<string, List<string>> actions = new Dictionary<string, List<string>>();

        public QuantityStatesForm()
        {
            InitializeActions();
            InitializeComponent();
            QuantitiesTable_Paint();
        }

        private void InitializeActions()
        {
            actions.Add("0", new List<string> { "0>Q5", "0>Q5", "0>Q5", "0>Q5", "0>Q5" });
            actions.Add("1", new List<string> { "1>Q5", "1>Q5", "1>Q5", "1>Q5", "1>Q5" });
        }

        private void QuantitiesTable_Paint()
        {
            Font font = new Font("Microsoft Sans Serif; 16pt", 16);
            TableLayoutPanel QuantitiesTable;
            QuantitiesTable = new TableLayoutPanel() { ColumnCount = quantities.Length + 1, RowCount = actions.Count + 1, CellBorderStyle = TableLayoutPanelCellBorderStyle.Single, AutoScroll = true, AutoSize = true};
            QuantitiesTable.Controls.Add(new Label() { Font = font, AutoSize = true }, 0, 0);
            for (int i = 0; i < quantities.Length; i++)
            {
                Label lbl = new Label() { Text = quantities[i], Font = font, Dock = DockStyle.Fill, AutoSize = true, Anchor = AnchorStyles.None };
                QuantitiesTable.Controls.Add(lbl, i + 1, 0);
            }
            int counter = 0;
            foreach (string key in actions.Keys)
            {
                Label lbl1 = new Label() { Text = key, Font = font, Dock = DockStyle.Fill, AutoSize = true, Anchor = AnchorStyles.None};
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

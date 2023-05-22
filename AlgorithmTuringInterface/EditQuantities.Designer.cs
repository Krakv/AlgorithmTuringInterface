using System.Windows.Forms;

namespace AlgorithmTuringInterface
{
    partial class EditQuantities
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AddRowBtn = new System.Windows.Forms.Button();
            this.RowNameLbl = new System.Windows.Forms.Label();
            this.RowNameTxtBx = new System.Windows.Forms.TextBox();
            this.DelRowBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DelColumnBtn = new System.Windows.Forms.Button();
            this.ColumnNameTxtBx = new System.Windows.Forms.TextBox();
            this.ColumnNameLbl = new System.Windows.Forms.Label();
            this.AddColumnBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddRowBtn
            // 
            this.AddRowBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddRowBtn.Location = new System.Drawing.Point(579, 533);
            this.AddRowBtn.Name = "AddRowBtn";
            this.AddRowBtn.Size = new System.Drawing.Size(175, 31);
            this.AddRowBtn.TabIndex = 1;
            this.AddRowBtn.Text = "Добавить";
            this.AddRowBtn.UseVisualStyleBackColor = true;
            this.AddRowBtn.Click += new System.EventHandler(this.AddRowBtn_Click);
            // 
            // RowNameLbl
            // 
            this.RowNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RowNameLbl.AutoSize = true;
            this.RowNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RowNameLbl.Location = new System.Drawing.Point(12, 536);
            this.RowNameLbl.Name = "RowNameLbl";
            this.RowNameLbl.Size = new System.Drawing.Size(472, 25);
            this.RowNameLbl.TabIndex = 2;
            this.RowNameLbl.Text = "Введите символ алфавита (название строки):";
            // 
            // RowNameTxtBx
            // 
            this.RowNameTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RowNameTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RowNameTxtBx.Location = new System.Drawing.Point(490, 533);
            this.RowNameTxtBx.MaxLength = 1;
            this.RowNameTxtBx.Name = "RowNameTxtBx";
            this.RowNameTxtBx.Size = new System.Drawing.Size(83, 31);
            this.RowNameTxtBx.TabIndex = 3;
            this.RowNameTxtBx.TextChanged += new System.EventHandler(this.RowNameTxtBx_TextChanged);
            // 
            // DelRowBtn
            // 
            this.DelRowBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DelRowBtn.Location = new System.Drawing.Point(760, 533);
            this.DelRowBtn.Name = "DelRowBtn";
            this.DelRowBtn.Size = new System.Drawing.Size(175, 31);
            this.DelRowBtn.TabIndex = 4;
            this.DelRowBtn.Text = "Удалить";
            this.DelRowBtn.UseVisualStyleBackColor = true;
            this.DelRowBtn.Click += new System.EventHandler(this.DelRowBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DelColumnBtn
            // 
            this.DelColumnBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DelColumnBtn.Location = new System.Drawing.Point(760, 570);
            this.DelColumnBtn.Name = "DelColumnBtn";
            this.DelColumnBtn.Size = new System.Drawing.Size(175, 31);
            this.DelColumnBtn.TabIndex = 8;
            this.DelColumnBtn.Text = "Удалить";
            this.DelColumnBtn.UseVisualStyleBackColor = true;
            this.DelColumnBtn.Click += new System.EventHandler(this.DelColumnBtn_Click);
            // 
            // ColumnNameTxtBx
            // 
            this.ColumnNameTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ColumnNameTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnNameTxtBx.Location = new System.Drawing.Point(490, 570);
            this.ColumnNameTxtBx.MaxLength = 10;
            this.ColumnNameTxtBx.Name = "ColumnNameTxtBx";
            this.ColumnNameTxtBx.Size = new System.Drawing.Size(83, 31);
            this.ColumnNameTxtBx.TabIndex = 7;
            this.ColumnNameTxtBx.TextChanged += new System.EventHandler(this.ColumnNameTxtBx_TextChanged);
            this.ColumnNameTxtBx.Validating += new System.ComponentModel.CancelEventHandler(this.ColumnNameTxtBx_Validating);
            // 
            // ColumnNameLbl
            // 
            this.ColumnNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ColumnNameLbl.AutoSize = true;
            this.ColumnNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnNameLbl.Location = new System.Drawing.Point(73, 573);
            this.ColumnNameLbl.Name = "ColumnNameLbl";
            this.ColumnNameLbl.Size = new System.Drawing.Size(411, 25);
            this.ColumnNameLbl.TabIndex = 6;
            this.ColumnNameLbl.Text = "Введите состояние (название столбца):";
            // 
            // AddColumnBtn
            // 
            this.AddColumnBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddColumnBtn.Location = new System.Drawing.Point(579, 570);
            this.AddColumnBtn.Name = "AddColumnBtn";
            this.AddColumnBtn.Size = new System.Drawing.Size(175, 31);
            this.AddColumnBtn.TabIndex = 5;
            this.AddColumnBtn.Text = "Добавить";
            this.AddColumnBtn.UseVisualStyleBackColor = true;
            this.AddColumnBtn.Click += new System.EventHandler(this.AddColumnBtn_Click);
            // 
            // EditQuantities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1121, 608);
            this.Controls.Add(this.DelColumnBtn);
            this.Controls.Add(this.ColumnNameTxtBx);
            this.Controls.Add(this.ColumnNameLbl);
            this.Controls.Add(this.AddColumnBtn);
            this.Controls.Add(this.DelRowBtn);
            this.Controls.Add(this.RowNameTxtBx);
            this.Controls.Add(this.RowNameLbl);
            this.Controls.Add(this.AddRowBtn);
            this.Name = "EditQuantities";
            this.Text = "EditQuantities";
            this.Deactivate += new System.EventHandler(this.EditQuantities_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditQuantities_FormClosing);
            this.Shown += new System.EventHandler(this.EditQuantities_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddRowBtn;
        private System.Windows.Forms.Label RowNameLbl;
        private System.Windows.Forms.TextBox RowNameTxtBx;
        private System.Windows.Forms.Button DelRowBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button DelColumnBtn;
        private System.Windows.Forms.TextBox ColumnNameTxtBx;
        private System.Windows.Forms.Label ColumnNameLbl;
        private System.Windows.Forms.Button AddColumnBtn;
    }
}
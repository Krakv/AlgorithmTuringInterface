using System.Drawing;
using System.Windows.Forms;

namespace AlgorithmTuringInterface
{
    partial class MachineTuring
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MachineTuring));
            this.Tape = new System.Windows.Forms.TableLayoutPanel();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.TapeLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.QuantityStates = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьФайлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TapeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TapeFile = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateTapeFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTapeFile = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTapeFile = new System.Windows.Forms.ToolStripMenuItem();
            this.EditTapeFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TapeSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.InitChosenIndexBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.QuantitiesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuantitiesFile = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateQuantitiesFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveQuantitiesFile = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenQuantitiesFile = new System.Windows.Forms.ToolStripMenuItem();
            this.EditQuantitiesFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenQuantitiesTableBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.скоростьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentSpeedTxtBx = new System.Windows.Forms.ToolStripMenuItem();
            this.SpeedTxtBx = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ChangeSpeedBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.задачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserGuideMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartBtn = new System.Windows.Forms.Button();
            this.NextStepBtn = new System.Windows.Forms.Button();
            this.PreviousStepBtn = new System.Windows.Forms.Button();
            this.StartNFinishBtn = new System.Windows.Forms.Button();
            this.FinishBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.table = new System.Windows.Forms.DataGridView();
            this.EditTapeFileBtn = new System.Windows.Forms.Button();
            this.EditQuantitiesFileBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PreviousElement = new System.Windows.Forms.Button();
            this.NextElement = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.Tape.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // Tape
            // 
            resources.ApplyResources(this.Tape, "Tape");
            this.Tape.Controls.Add(this.textBox12, 0, 1);
            this.Tape.Controls.Add(this.textBox16, 0, 1);
            this.Tape.Controls.Add(this.textBox17, 0, 1);
            this.Tape.Controls.Add(this.textBox15, 0, 1);
            this.Tape.Controls.Add(this.textBox13, 0, 1);
            this.Tape.Controls.Add(this.textBox14, 0, 1);
            this.Tape.Controls.Add(this.textBox21, 0, 1);
            this.Tape.Controls.Add(this.textBox2, 0, 0);
            this.Tape.Controls.Add(this.textBox22, 0, 1);
            this.Tape.Controls.Add(this.textBox20, 0, 1);
            this.Tape.Controls.Add(this.textBox18, 0, 1);
            this.Tape.Controls.Add(this.textBox19, 0, 1);
            this.Tape.Controls.Add(this.textBox4, 0, 0);
            this.Tape.Controls.Add(this.textBox5, 0, 0);
            this.Tape.Controls.Add(this.textBox6, 0, 0);
            this.Tape.Controls.Add(this.textBox1, 0, 0);
            this.Tape.Controls.Add(this.textBox3, 0, 0);
            this.Tape.Controls.Add(this.textBox10, 0, 0);
            this.Tape.Controls.Add(this.textBox11, 0, 0);
            this.Tape.Controls.Add(this.textBox9, 0, 0);
            this.Tape.Controls.Add(this.textBox7, 0, 0);
            this.Tape.Controls.Add(this.textBox8, 0, 0);
            this.helpProvider1.SetHelpKeyword(this.Tape, resources.GetString("Tape.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.Tape, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("Tape.HelpNavigator"))));
            this.Tape.Name = "Tape";
            this.helpProvider1.SetShowHelp(this.Tape, ((bool)(resources.GetObject("Tape.ShowHelp"))));
            this.Tape.Paint += new System.Windows.Forms.PaintEventHandler(this.Tape_Paint);
            // 
            // textBox12
            // 
            resources.ApplyResources(this.textBox12, "textBox12");
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.textBox12, ((bool)(resources.GetObject("textBox12.ShowHelp"))));
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // textBox16
            // 
            resources.ApplyResources(this.textBox16, "textBox16");
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.textBox16, ((bool)(resources.GetObject("textBox16.ShowHelp"))));
            this.textBox16.TextChanged += new System.EventHandler(this.textBox16_TextChanged);
            // 
            // textBox17
            // 
            resources.ApplyResources(this.textBox17, "textBox17");
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.textBox17, ((bool)(resources.GetObject("textBox17.ShowHelp"))));
            this.textBox17.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            // 
            // textBox15
            // 
            resources.ApplyResources(this.textBox15, "textBox15");
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.textBox15, ((bool)(resources.GetObject("textBox15.ShowHelp"))));
            this.textBox15.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            // 
            // textBox13
            // 
            resources.ApplyResources(this.textBox13, "textBox13");
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.textBox13, ((bool)(resources.GetObject("textBox13.ShowHelp"))));
            this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // textBox14
            // 
            resources.ApplyResources(this.textBox14, "textBox14");
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.textBox14, ((bool)(resources.GetObject("textBox14.ShowHelp"))));
            this.textBox14.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // textBox21
            // 
            resources.ApplyResources(this.textBox21, "textBox21");
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.textBox21, ((bool)(resources.GetObject("textBox21.ShowHelp"))));
            this.textBox21.TextChanged += new System.EventHandler(this.textBox21_TextChanged);
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.textBox2, ((bool)(resources.GetObject("textBox2.ShowHelp"))));
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox22
            // 
            resources.ApplyResources(this.textBox22, "textBox22");
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.textBox22, ((bool)(resources.GetObject("textBox22.ShowHelp"))));
            this.textBox22.TextChanged += new System.EventHandler(this.textBox22_TextChanged);
            // 
            // textBox20
            // 
            resources.ApplyResources(this.textBox20, "textBox20");
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.textBox20, ((bool)(resources.GetObject("textBox20.ShowHelp"))));
            this.textBox20.TextChanged += new System.EventHandler(this.textBox20_TextChanged);
            // 
            // textBox18
            // 
            resources.ApplyResources(this.textBox18, "textBox18");
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.textBox18, ((bool)(resources.GetObject("textBox18.ShowHelp"))));
            this.textBox18.TextChanged += new System.EventHandler(this.textBox18_TextChanged);
            // 
            // textBox19
            // 
            resources.ApplyResources(this.textBox19, "textBox19");
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.textBox19, ((bool)(resources.GetObject("textBox19.ShowHelp"))));
            this.textBox19.TextChanged += new System.EventHandler(this.textBox19_TextChanged);
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.textBox4, ((bool)(resources.GetObject("textBox4.ShowHelp"))));
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.textBox5, ((bool)(resources.GetObject("textBox5.ShowHelp"))));
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.textBox6, ((bool)(resources.GetObject("textBox6.ShowHelp"))));
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.textBox1, ((bool)(resources.GetObject("textBox1.ShowHelp"))));
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.textBox3, ((bool)(resources.GetObject("textBox3.ShowHelp"))));
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox10
            // 
            resources.ApplyResources(this.textBox10, "textBox10");
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.textBox10, ((bool)(resources.GetObject("textBox10.ShowHelp"))));
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // textBox11
            // 
            resources.ApplyResources(this.textBox11, "textBox11");
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.textBox11, ((bool)(resources.GetObject("textBox11.ShowHelp"))));
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // textBox9
            // 
            resources.ApplyResources(this.textBox9, "textBox9");
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.textBox9, ((bool)(resources.GetObject("textBox9.ShowHelp"))));
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBox7
            // 
            resources.ApplyResources(this.textBox7, "textBox7");
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.textBox7, ((bool)(resources.GetObject("textBox7.ShowHelp"))));
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox8
            // 
            resources.ApplyResources(this.textBox8, "textBox8");
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.textBox8, ((bool)(resources.GetObject("textBox8.ShowHelp"))));
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // TapeLabel
            // 
            resources.ApplyResources(this.TapeLabel, "TapeLabel");
            this.helpProvider1.SetHelpKeyword(this.TapeLabel, resources.GetString("TapeLabel.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.TapeLabel, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("TapeLabel.HelpNavigator"))));
            this.TapeLabel.Name = "TapeLabel";
            this.helpProvider1.SetShowHelp(this.TapeLabel, ((bool)(resources.GetObject("TapeLabel.ShowHelp"))));
            this.TapeLabel.Click += new System.EventHandler(this.TapeLabel_Click);
            // 
            // QuantityLabel
            // 
            resources.ApplyResources(this.QuantityLabel, "QuantityLabel");
            this.helpProvider1.SetHelpKeyword(this.QuantityLabel, resources.GetString("QuantityLabel.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.QuantityLabel, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("QuantityLabel.HelpNavigator"))));
            this.QuantityLabel.Name = "QuantityLabel";
            this.helpProvider1.SetShowHelp(this.QuantityLabel, ((bool)(resources.GetObject("QuantityLabel.ShowHelp"))));
            this.QuantityLabel.Click += new System.EventHandler(this.QuantityLabel_Click);
            // 
            // QuantityStates
            // 
            this.QuantityStates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpProvider1.SetHelpKeyword(this.QuantityStates, resources.GetString("QuantityStates.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.QuantityStates, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("QuantityStates.HelpNavigator"))));
            resources.ApplyResources(this.QuantityStates, "QuantityStates");
            this.QuantityStates.Name = "QuantityStates";
            this.helpProvider1.SetShowHelp(this.QuantityStates, ((bool)(resources.GetObject("QuantityStates.ShowHelp"))));
            this.QuantityStates.Paint += new System.Windows.Forms.PaintEventHandler(this.QuantityStates_Paint);
            // 
            // menuStrip1
            // 
            this.helpProvider1.SetHelpKeyword(this.menuStrip1, resources.GetString("menuStrip1.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.menuStrip1, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("menuStrip1.HelpNavigator"))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.TapeMenuItem,
            this.QuantitiesMenuItem,
            this.скоростьToolStripMenuItem,
            this.задачиToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.helpProvider1.SetShowHelp(this.menuStrip1, ((bool)(resources.GetObject("menuStrip1.ShowHelp"))));
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьФайлToolStripMenuItem1,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            resources.ApplyResources(this.файлToolStripMenuItem, "файлToolStripMenuItem");
            // 
            // сохранитьФайлToolStripMenuItem1
            // 
            this.сохранитьФайлToolStripMenuItem1.Name = "сохранитьФайлToolStripMenuItem1";
            resources.ApplyResources(this.сохранитьФайлToolStripMenuItem1, "сохранитьФайлToolStripMenuItem1");
            this.сохранитьФайлToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьФайлToolStripMenuItem1_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            resources.ApplyResources(this.загрузитьToolStripMenuItem, "загрузитьToolStripMenuItem");
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // TapeMenuItem
            // 
            this.TapeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TapeFile,
            this.TapeSeparator,
            this.InitChosenIndexBtn});
            this.TapeMenuItem.Name = "TapeMenuItem";
            resources.ApplyResources(this.TapeMenuItem, "TapeMenuItem");
            // 
            // TapeFile
            // 
            this.TapeFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateTapeFile,
            this.SaveTapeFile,
            this.OpenTapeFile,
            this.EditTapeFile});
            this.TapeFile.Name = "TapeFile";
            resources.ApplyResources(this.TapeFile, "TapeFile");
            this.TapeFile.Click += new System.EventHandler(this.TapeFile_Click);
            // 
            // CreateTapeFile
            // 
            this.CreateTapeFile.Name = "CreateTapeFile";
            resources.ApplyResources(this.CreateTapeFile, "CreateTapeFile");
            this.CreateTapeFile.Click += new System.EventHandler(this.CreateTapeFile_Click);
            // 
            // SaveTapeFile
            // 
            this.SaveTapeFile.Name = "SaveTapeFile";
            resources.ApplyResources(this.SaveTapeFile, "SaveTapeFile");
            this.SaveTapeFile.Click += new System.EventHandler(this.SaveTapeFile_Click);
            // 
            // OpenTapeFile
            // 
            this.OpenTapeFile.Name = "OpenTapeFile";
            resources.ApplyResources(this.OpenTapeFile, "OpenTapeFile");
            this.OpenTapeFile.Click += new System.EventHandler(this.OpenTapeFile_Click);
            // 
            // EditTapeFile
            // 
            this.EditTapeFile.Name = "EditTapeFile";
            resources.ApplyResources(this.EditTapeFile, "EditTapeFile");
            this.EditTapeFile.Click += new System.EventHandler(this.EditTapeFile_Click);
            // 
            // TapeSeparator
            // 
            this.TapeSeparator.Name = "TapeSeparator";
            resources.ApplyResources(this.TapeSeparator, "TapeSeparator");
            this.TapeSeparator.Click += new System.EventHandler(this.TapeSeparator_Click);
            // 
            // InitChosenIndexBtn
            // 
            this.InitChosenIndexBtn.Name = "InitChosenIndexBtn";
            resources.ApplyResources(this.InitChosenIndexBtn, "InitChosenIndexBtn");
            this.InitChosenIndexBtn.Click += new System.EventHandler(this.InitChosenIndexBtn_Click);
            // 
            // QuantitiesMenuItem
            // 
            this.QuantitiesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuantitiesFile,
            this.toolStripSeparator2,
            this.OpenQuantitiesTableBtn});
            this.QuantitiesMenuItem.Name = "QuantitiesMenuItem";
            resources.ApplyResources(this.QuantitiesMenuItem, "QuantitiesMenuItem");
            // 
            // QuantitiesFile
            // 
            this.QuantitiesFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateQuantitiesFile,
            this.SaveQuantitiesFile,
            this.OpenQuantitiesFile,
            this.EditQuantitiesFile});
            this.QuantitiesFile.Name = "QuantitiesFile";
            resources.ApplyResources(this.QuantitiesFile, "QuantitiesFile");
            this.QuantitiesFile.Click += new System.EventHandler(this.QuantitiesFile_Click);
            // 
            // CreateQuantitiesFile
            // 
            this.CreateQuantitiesFile.Name = "CreateQuantitiesFile";
            resources.ApplyResources(this.CreateQuantitiesFile, "CreateQuantitiesFile");
            this.CreateQuantitiesFile.Click += new System.EventHandler(this.CreateQuantitiesFile_Click);
            // 
            // SaveQuantitiesFile
            // 
            this.SaveQuantitiesFile.Name = "SaveQuantitiesFile";
            resources.ApplyResources(this.SaveQuantitiesFile, "SaveQuantitiesFile");
            this.SaveQuantitiesFile.Click += new System.EventHandler(this.SaveQuantitiesFile_Click);
            // 
            // OpenQuantitiesFile
            // 
            this.OpenQuantitiesFile.Name = "OpenQuantitiesFile";
            resources.ApplyResources(this.OpenQuantitiesFile, "OpenQuantitiesFile");
            this.OpenQuantitiesFile.Click += new System.EventHandler(this.OpenQuantitiesFile_Click);
            // 
            // EditQuantitiesFile
            // 
            this.EditQuantitiesFile.Name = "EditQuantitiesFile";
            resources.ApplyResources(this.EditQuantitiesFile, "EditQuantitiesFile");
            this.EditQuantitiesFile.Click += new System.EventHandler(this.EditQuantitiesFile_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Click += new System.EventHandler(this.toolStripSeparator2_Click);
            // 
            // OpenQuantitiesTableBtn
            // 
            this.OpenQuantitiesTableBtn.Name = "OpenQuantitiesTableBtn";
            resources.ApplyResources(this.OpenQuantitiesTableBtn, "OpenQuantitiesTableBtn");
            this.OpenQuantitiesTableBtn.Click += new System.EventHandler(this.OpenQuantitiesTableBtn_Click);
            // 
            // скоростьToolStripMenuItem
            // 
            this.скоростьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentSpeedTxtBx,
            this.SpeedTxtBx,
            this.toolStripSeparator3,
            this.ChangeSpeedBtn});
            this.скоростьToolStripMenuItem.Name = "скоростьToolStripMenuItem";
            resources.ApplyResources(this.скоростьToolStripMenuItem, "скоростьToolStripMenuItem");
            // 
            // CurrentSpeedTxtBx
            // 
            resources.ApplyResources(this.CurrentSpeedTxtBx, "CurrentSpeedTxtBx");
            this.CurrentSpeedTxtBx.Name = "CurrentSpeedTxtBx";
            this.CurrentSpeedTxtBx.Click += new System.EventHandler(this.CurrentSpeedTxtBx_Click);
            // 
            // SpeedTxtBx
            // 
            resources.ApplyResources(this.SpeedTxtBx, "SpeedTxtBx");
            this.SpeedTxtBx.Name = "SpeedTxtBx";
            this.SpeedTxtBx.Click += new System.EventHandler(this.SpeedTxtBx_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Click += new System.EventHandler(this.toolStripSeparator3_Click);
            // 
            // ChangeSpeedBtn
            // 
            this.ChangeSpeedBtn.Name = "ChangeSpeedBtn";
            resources.ApplyResources(this.ChangeSpeedBtn, "ChangeSpeedBtn");
            this.ChangeSpeedBtn.Click += new System.EventHandler(this.ChangeSpeedBtn_Click);
            // 
            // задачиToolStripMenuItem
            // 
            this.задачиToolStripMenuItem.Name = "задачиToolStripMenuItem";
            resources.ApplyResources(this.задачиToolStripMenuItem, "задачиToolStripMenuItem");
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserGuideMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            resources.ApplyResources(this.помощьToolStripMenuItem, "помощьToolStripMenuItem");
            // 
            // UserGuideMenuItem
            // 
            this.UserGuideMenuItem.Name = "UserGuideMenuItem";
            resources.ApplyResources(this.UserGuideMenuItem, "UserGuideMenuItem");
            this.UserGuideMenuItem.Click += new System.EventHandler(this.UserGuideMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            resources.ApplyResources(this.оПрограммеToolStripMenuItem, "оПрограммеToolStripMenuItem");
            // 
            // StartBtn
            // 
            resources.ApplyResources(this.StartBtn, "StartBtn");
            this.helpProvider1.SetHelpKeyword(this.StartBtn, resources.GetString("StartBtn.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.StartBtn, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("StartBtn.HelpNavigator"))));
            this.StartBtn.Name = "StartBtn";
            this.helpProvider1.SetShowHelp(this.StartBtn, ((bool)(resources.GetObject("StartBtn.ShowHelp"))));
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // NextStepBtn
            // 
            resources.ApplyResources(this.NextStepBtn, "NextStepBtn");
            this.helpProvider1.SetHelpKeyword(this.NextStepBtn, resources.GetString("NextStepBtn.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.NextStepBtn, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("NextStepBtn.HelpNavigator"))));
            this.NextStepBtn.Name = "NextStepBtn";
            this.helpProvider1.SetShowHelp(this.NextStepBtn, ((bool)(resources.GetObject("NextStepBtn.ShowHelp"))));
            this.NextStepBtn.UseVisualStyleBackColor = true;
            this.NextStepBtn.Click += new System.EventHandler(this.NextStepBtn_Click);
            // 
            // PreviousStepBtn
            // 
            resources.ApplyResources(this.PreviousStepBtn, "PreviousStepBtn");
            this.helpProvider1.SetHelpKeyword(this.PreviousStepBtn, resources.GetString("PreviousStepBtn.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.PreviousStepBtn, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("PreviousStepBtn.HelpNavigator"))));
            this.PreviousStepBtn.Name = "PreviousStepBtn";
            this.helpProvider1.SetShowHelp(this.PreviousStepBtn, ((bool)(resources.GetObject("PreviousStepBtn.ShowHelp"))));
            this.PreviousStepBtn.UseVisualStyleBackColor = true;
            this.PreviousStepBtn.Click += new System.EventHandler(this.PreviousStepBtn_Click);
            // 
            // StartNFinishBtn
            // 
            resources.ApplyResources(this.StartNFinishBtn, "StartNFinishBtn");
            this.helpProvider1.SetHelpKeyword(this.StartNFinishBtn, resources.GetString("StartNFinishBtn.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.StartNFinishBtn, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("StartNFinishBtn.HelpNavigator"))));
            this.StartNFinishBtn.Name = "StartNFinishBtn";
            this.helpProvider1.SetShowHelp(this.StartNFinishBtn, ((bool)(resources.GetObject("StartNFinishBtn.ShowHelp"))));
            this.StartNFinishBtn.UseVisualStyleBackColor = true;
            this.StartNFinishBtn.Click += new System.EventHandler(this.StartNFinishBtn_Click);
            // 
            // FinishBtn
            // 
            resources.ApplyResources(this.FinishBtn, "FinishBtn");
            this.helpProvider1.SetHelpKeyword(this.FinishBtn, resources.GetString("FinishBtn.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.FinishBtn, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("FinishBtn.HelpNavigator"))));
            this.FinishBtn.Name = "FinishBtn";
            this.helpProvider1.SetShowHelp(this.FinishBtn, ((bool)(resources.GetObject("FinishBtn.ShowHelp"))));
            this.FinishBtn.UseVisualStyleBackColor = true;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.table, "table");
            this.table.Name = "table";
            this.table.StandardTab = true;
            this.table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellContentClick);
            this.table.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellEndEdit);
            this.table.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.table_ColumnAdded);
            this.table.ColumnRemoved += new System.Windows.Forms.DataGridViewColumnEventHandler(this.table_ColumnRemoved);
            this.table.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.table_RowAdded);
            this.table.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.table_RowRemoved);
            // 
            // EditTapeFileBtn
            // 
            this.EditTapeFileBtn.BackgroundImage = global::AlgorithmTuringInterface.Properties.Resources._1159633;
            resources.ApplyResources(this.EditTapeFileBtn, "EditTapeFileBtn");
            this.helpProvider1.SetHelpKeyword(this.EditTapeFileBtn, resources.GetString("EditTapeFileBtn.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.EditTapeFileBtn, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("EditTapeFileBtn.HelpNavigator"))));
            this.EditTapeFileBtn.Name = "EditTapeFileBtn";
            this.helpProvider1.SetShowHelp(this.EditTapeFileBtn, ((bool)(resources.GetObject("EditTapeFileBtn.ShowHelp"))));
            this.EditTapeFileBtn.UseVisualStyleBackColor = true;
            this.EditTapeFileBtn.Click += new System.EventHandler(this.EditTapeFile_Click);
            // 
            // EditQuantitiesFileBtn
            // 
            this.EditQuantitiesFileBtn.BackgroundImage = global::AlgorithmTuringInterface.Properties.Resources._1159633;
            resources.ApplyResources(this.EditQuantitiesFileBtn, "EditQuantitiesFileBtn");
            this.helpProvider1.SetHelpKeyword(this.EditQuantitiesFileBtn, resources.GetString("EditQuantitiesFileBtn.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.EditQuantitiesFileBtn, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("EditQuantitiesFileBtn.HelpNavigator"))));
            this.EditQuantitiesFileBtn.Name = "EditQuantitiesFileBtn";
            this.helpProvider1.SetShowHelp(this.EditQuantitiesFileBtn, ((bool)(resources.GetObject("EditQuantitiesFileBtn.ShowHelp"))));
            this.EditQuantitiesFileBtn.UseVisualStyleBackColor = true;
            this.EditQuantitiesFileBtn.Click += new System.EventHandler(this.EditQuantitiesFile_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AlgorithmTuringInterface.Properties.Resources._109164;
            resources.ApplyResources(this.button1, "button1");
            this.helpProvider1.SetHelpKeyword(this.button1, resources.GetString("button1.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.button1, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("button1.HelpNavigator"))));
            this.button1.Name = "button1";
            this.helpProvider1.SetShowHelp(this.button1, ((bool)(resources.GetObject("button1.ShowHelp"))));
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
            // 
            // PreviousElement
            // 
            this.PreviousElement.BackgroundImage = global::AlgorithmTuringInterface.Properties.Resources.w512h5121390846436left512;
            resources.ApplyResources(this.PreviousElement, "PreviousElement");
            this.helpProvider1.SetHelpKeyword(this.PreviousElement, resources.GetString("PreviousElement.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.PreviousElement, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("PreviousElement.HelpNavigator"))));
            this.PreviousElement.Name = "PreviousElement";
            this.helpProvider1.SetShowHelp(this.PreviousElement, ((bool)(resources.GetObject("PreviousElement.ShowHelp"))));
            this.PreviousElement.UseVisualStyleBackColor = true;
            this.PreviousElement.Click += new System.EventHandler(this.PreviousElement_Click);
            this.PreviousElement.Paint += new System.Windows.Forms.PaintEventHandler(this.PreviousElement_Paint);
            // 
            // NextElement
            // 
            this.NextElement.BackgroundImage = global::AlgorithmTuringInterface.Properties.Resources.w512h5121390846449right512;
            resources.ApplyResources(this.NextElement, "NextElement");
            this.helpProvider1.SetHelpKeyword(this.NextElement, resources.GetString("NextElement.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.NextElement, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("NextElement.HelpNavigator"))));
            this.NextElement.Name = "NextElement";
            this.helpProvider1.SetShowHelp(this.NextElement, ((bool)(resources.GetObject("NextElement.ShowHelp"))));
            this.NextElement.UseVisualStyleBackColor = true;
            this.NextElement.Click += new System.EventHandler(this.NextElement_Click);
            this.NextElement.Paint += new System.Windows.Forms.PaintEventHandler(this.NextElement_Paint);
            // 
            // helpProvider1
            // 
            resources.ApplyResources(this.helpProvider1, "helpProvider1");
            // 
            // MachineTuring
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.EditTapeFileBtn);
            this.Controls.Add(this.EditQuantitiesFileBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FinishBtn);
            this.Controls.Add(this.StartNFinishBtn);
            this.Controls.Add(this.PreviousStepBtn);
            this.Controls.Add(this.NextStepBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.QuantityStates);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.TapeLabel);
            this.Controls.Add(this.PreviousElement);
            this.Controls.Add(this.NextElement);
            this.Controls.Add(this.Tape);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.helpProvider1.SetHelpKeyword(this, resources.GetString("$this.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("$this.HelpNavigator"))));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MachineTuring";
            this.helpProvider1.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MachineTuring_FormClosing);
            this.Shown += new System.EventHandler(this.MachineTuring_Shown);
            this.Tape.ResumeLayout(false);
            this.Tape.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private TableLayoutPanel Tape;
        private TextBox textBox8;
        private TextBox textBox19;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox9;
        private TextBox textBox7;
        private TextBox textBox18;
        private TextBox textBox17;
        private TextBox textBox15;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox21;
        private TextBox textBox2;
        private TextBox textBox22;
        private TextBox textBox20;
        private Button NextElement;
        private Button PreviousElement;
        private TextBox textBox16;
        private TextBox textBox12;
        private Label TapeLabel;
        private Label QuantityLabel;
        public Panel QuantityStates;
        private MenuStrip menuStrip1;
        private Button StartBtn;
        private Button NextStepBtn;
        private Button PreviousStepBtn;
        private Button StartNFinishBtn;
        private Button FinishBtn;
        private ErrorProvider errorProvider1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem сохранитьФайлToolStripMenuItem1;
        private ToolStripMenuItem загрузитьToolStripMenuItem;
        private ToolStripMenuItem TapeMenuItem;
        private ToolStripMenuItem TapeFile;
        private ToolStripMenuItem CreateTapeFile;
        private ToolStripMenuItem SaveTapeFile;
        private ToolStripMenuItem OpenTapeFile;
        private ToolStripMenuItem EditTapeFile;
        private ToolStripMenuItem помощьToolStripMenuItem;
        private ToolStripMenuItem QuantitiesMenuItem;
        private ToolStripMenuItem QuantitiesFile;
        private ToolStripSeparator TapeSeparator;
        private ToolStripMenuItem InitChosenIndexBtn;
        private ToolStripMenuItem CreateQuantitiesFile;
        private ToolStripMenuItem SaveQuantitiesFile;
        private ToolStripMenuItem OpenQuantitiesFile;
        private ToolStripMenuItem EditQuantitiesFile;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem скоростьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem ChangeSpeedBtn;
        private Button EditQuantitiesFileBtn;
        private Button EditTapeFileBtn;
        private ToolStripMenuItem задачиToolStripMenuItem;
        private ToolStripMenuItem OpenQuantitiesTableBtn;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem CurrentSpeedTxtBx;
        private ToolStripMenuItem SpeedTxtBx;
        private ToolStripMenuItem UserGuideMenuItem;
        private HelpProvider helpProvider1;
    }
}


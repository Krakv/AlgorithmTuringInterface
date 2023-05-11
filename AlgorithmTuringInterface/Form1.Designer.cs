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
            this.задатьИндексНачальногоЭлементаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuantitiesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuantitiesFile = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateQuantitiesFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveQuantitiesFile = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenQuantitiesFile = new System.Windows.Forms.ToolStripMenuItem();
            this.EditQuantitiesFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.вывестиВОтдельноеОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скоростьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentSpeedTxtBx = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.изменитьСкоростьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartBtn = new System.Windows.Forms.Button();
            this.NextStepBtn = new System.Windows.Forms.Button();
            this.PreviousStepBtn = new System.Windows.Forms.Button();
            this.StartNFinishBtn = new System.Windows.Forms.Button();
            this.FinishBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.EditQuantitiesFileBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PreviousElement = new System.Windows.Forms.Button();
            this.NextElement = new System.Windows.Forms.Button();
            this.EditTapeFileBtn = new System.Windows.Forms.Button();
            this.Tape.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.Tape.Name = "Tape";
            this.Tape.Paint += new System.Windows.Forms.PaintEventHandler(this.Tape_Paint);
            // 
            // textBox12
            // 
            resources.ApplyResources(this.textBox12, "textBox12");
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            // 
            // textBox16
            // 
            resources.ApplyResources(this.textBox16, "textBox16");
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            // 
            // textBox17
            // 
            resources.ApplyResources(this.textBox17, "textBox17");
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            // 
            // textBox15
            // 
            resources.ApplyResources(this.textBox15, "textBox15");
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            // 
            // textBox13
            // 
            resources.ApplyResources(this.textBox13, "textBox13");
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            // 
            // textBox14
            // 
            resources.ApplyResources(this.textBox14, "textBox14");
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            // 
            // textBox21
            // 
            resources.ApplyResources(this.textBox21, "textBox21");
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            // 
            // textBox22
            // 
            resources.ApplyResources(this.textBox22, "textBox22");
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            // 
            // textBox20
            // 
            resources.ApplyResources(this.textBox20, "textBox20");
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            // 
            // textBox18
            // 
            resources.ApplyResources(this.textBox18, "textBox18");
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            // 
            // textBox19
            // 
            resources.ApplyResources(this.textBox19, "textBox19");
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            // 
            // textBox6
            // 
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            // 
            // textBox10
            // 
            resources.ApplyResources(this.textBox10, "textBox10");
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            // 
            // textBox11
            // 
            resources.ApplyResources(this.textBox11, "textBox11");
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            // 
            // textBox9
            // 
            resources.ApplyResources(this.textBox9, "textBox9");
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            // 
            // textBox7
            // 
            resources.ApplyResources(this.textBox7, "textBox7");
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            // 
            // textBox8
            // 
            resources.ApplyResources(this.textBox8, "textBox8");
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            // 
            // TapeLabel
            // 
            resources.ApplyResources(this.TapeLabel, "TapeLabel");
            this.TapeLabel.Name = "TapeLabel";
            // 
            // QuantityLabel
            // 
            resources.ApplyResources(this.QuantityLabel, "QuantityLabel");
            this.QuantityLabel.Name = "QuantityLabel";
            // 
            // QuantityStates
            // 
            this.QuantityStates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.QuantityStates, "QuantityStates");
            this.QuantityStates.Name = "QuantityStates";
            this.QuantityStates.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menuStrip1
            // 
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
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            resources.ApplyResources(this.загрузитьToolStripMenuItem, "загрузитьToolStripMenuItem");
            // 
            // TapeMenuItem
            // 
            this.TapeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TapeFile,
            this.TapeSeparator,
            this.задатьИндексНачальногоЭлементаToolStripMenuItem});
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
            // 
            // задатьИндексНачальногоЭлементаToolStripMenuItem
            // 
            this.задатьИндексНачальногоЭлементаToolStripMenuItem.Name = "задатьИндексНачальногоЭлементаToolStripMenuItem";
            resources.ApplyResources(this.задатьИндексНачальногоЭлементаToolStripMenuItem, "задатьИндексНачальногоЭлементаToolStripMenuItem");
            // 
            // QuantitiesMenuItem
            // 
            this.QuantitiesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuantitiesFile,
            this.toolStripSeparator2,
            this.вывестиВОтдельноеОкноToolStripMenuItem});
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
            // 
            // вывестиВОтдельноеОкноToolStripMenuItem
            // 
            this.вывестиВОтдельноеОкноToolStripMenuItem.Name = "вывестиВОтдельноеОкноToolStripMenuItem";
            resources.ApplyResources(this.вывестиВОтдельноеОкноToolStripMenuItem, "вывестиВОтдельноеОкноToolStripMenuItem");
            // 
            // скоростьToolStripMenuItem
            // 
            this.скоростьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentSpeedTxtBx,
            this.toolStripSeparator1,
            this.toolStripSeparator3,
            this.изменитьСкоростьToolStripMenuItem});
            this.скоростьToolStripMenuItem.Name = "скоростьToolStripMenuItem";
            resources.ApplyResources(this.скоростьToolStripMenuItem, "скоростьToolStripMenuItem");
            // 
            // CurrentSpeedTxtBx
            // 
            resources.ApplyResources(this.CurrentSpeedTxtBx, "CurrentSpeedTxtBx");
            this.CurrentSpeedTxtBx.Name = "CurrentSpeedTxtBx";
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // изменитьСкоростьToolStripMenuItem
            // 
            this.изменитьСкоростьToolStripMenuItem.Name = "изменитьСкоростьToolStripMenuItem";
            resources.ApplyResources(this.изменитьСкоростьToolStripMenuItem, "изменитьСкоростьToolStripMenuItem");
            // 
            // задачиToolStripMenuItem
            // 
            this.задачиToolStripMenuItem.Name = "задачиToolStripMenuItem";
            resources.ApplyResources(this.задачиToolStripMenuItem, "задачиToolStripMenuItem");
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            resources.ApplyResources(this.помощьToolStripMenuItem, "помощьToolStripMenuItem");
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            resources.ApplyResources(this.оПрограммеToolStripMenuItem, "оПрограммеToolStripMenuItem");
            // 
            // StartBtn
            // 
            resources.ApplyResources(this.StartBtn, "StartBtn");
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // NextStepBtn
            // 
            resources.ApplyResources(this.NextStepBtn, "NextStepBtn");
            this.NextStepBtn.Name = "NextStepBtn";
            this.NextStepBtn.UseVisualStyleBackColor = true;
            // 
            // PreviousStepBtn
            // 
            resources.ApplyResources(this.PreviousStepBtn, "PreviousStepBtn");
            this.PreviousStepBtn.Name = "PreviousStepBtn";
            this.PreviousStepBtn.UseVisualStyleBackColor = true;
            // 
            // StartNFinishBtn
            // 
            resources.ApplyResources(this.StartNFinishBtn, "StartNFinishBtn");
            this.StartNFinishBtn.Name = "StartNFinishBtn";
            this.StartNFinishBtn.UseVisualStyleBackColor = true;
            // 
            // FinishBtn
            // 
            resources.ApplyResources(this.FinishBtn, "FinishBtn");
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.UseVisualStyleBackColor = true;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditQuantitiesFileBtn
            // 
            this.EditQuantitiesFileBtn.BackgroundImage = global::AlgorithmTuringInterface.Properties.Resources._1159633;
            resources.ApplyResources(this.EditQuantitiesFileBtn, "EditQuantitiesFileBtn");
            this.EditQuantitiesFileBtn.Name = "EditQuantitiesFileBtn";
            this.EditQuantitiesFileBtn.UseVisualStyleBackColor = true;
            this.EditQuantitiesFileBtn.Click += new System.EventHandler(this.EditQuantitiesFile_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AlgorithmTuringInterface.Properties.Resources._109164;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
            // 
            // PreviousElement
            // 
            this.PreviousElement.BackgroundImage = global::AlgorithmTuringInterface.Properties.Resources.w512h5121390846436left512;
            resources.ApplyResources(this.PreviousElement, "PreviousElement");
            this.PreviousElement.Name = "PreviousElement";
            this.PreviousElement.UseVisualStyleBackColor = true;
            this.PreviousElement.Click += new System.EventHandler(this.PreviousElement_Click);
            this.PreviousElement.Paint += new System.Windows.Forms.PaintEventHandler(this.PreviousElement_Paint);
            // 
            // NextElement
            // 
            this.NextElement.BackgroundImage = global::AlgorithmTuringInterface.Properties.Resources.w512h5121390846449right512;
            resources.ApplyResources(this.NextElement, "NextElement");
            this.NextElement.Name = "NextElement";
            this.NextElement.UseVisualStyleBackColor = true;
            this.NextElement.Click += new System.EventHandler(this.NextElement_Click);
            this.NextElement.Paint += new System.Windows.Forms.PaintEventHandler(this.NextElement_Paint);
            // 
            // EditTapeFileBtn
            // 
            this.EditTapeFileBtn.BackgroundImage = global::AlgorithmTuringInterface.Properties.Resources._1159633;
            resources.ApplyResources(this.EditTapeFileBtn, "EditTapeFileBtn");
            this.EditTapeFileBtn.Name = "EditTapeFileBtn";
            this.EditTapeFileBtn.UseVisualStyleBackColor = true;
            this.EditTapeFileBtn.Click += new System.EventHandler(this.EditTapeFile_Click);
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
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MachineTuring";
            this.Activated += new System.EventHandler(this.MachineTuring_Activated);
            this.Tape.ResumeLayout(false);
            this.Tape.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private Panel QuantityStates;
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
        private ToolStripMenuItem задатьИндексНачальногоЭлементаToolStripMenuItem;
        private ToolStripMenuItem CreateQuantitiesFile;
        private ToolStripMenuItem SaveQuantitiesFile;
        private ToolStripMenuItem OpenQuantitiesFile;
        private ToolStripMenuItem EditQuantitiesFile;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem скоростьToolStripMenuItem;
        private ToolStripTextBox toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem изменитьСкоростьToolStripMenuItem;
        private ToolStripMenuItem CurrentSpeedTxtBx;
        private Button EditQuantitiesFileBtn;
        private Button EditTapeFileBtn;
        private ToolStripMenuItem задачиToolStripMenuItem;
        private ToolStripMenuItem вывестиВОтдельноеОкноToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}


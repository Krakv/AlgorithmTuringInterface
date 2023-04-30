using System.Windows.Forms;

namespace AlgorithmTuringInterface
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
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
            this.NextElement = new System.Windows.Forms.Button();
            this.PreviousElement = new System.Windows.Forms.Button();
            this.Tape.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
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
            // NextElement
            // 
            resources.ApplyResources(this.NextElement, "NextElement");
            this.NextElement.Name = "NextElement";
            this.NextElement.UseVisualStyleBackColor = true;
            this.NextElement.Click += new System.EventHandler(this.NextElement_Click);
            // 
            // PreviousElement
            // 
            resources.ApplyResources(this.PreviousElement, "PreviousElement");
            this.PreviousElement.Name = "PreviousElement";
            this.PreviousElement.UseVisualStyleBackColor = true;
            this.PreviousElement.Click += new System.EventHandler(this.PreviousElement_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.PreviousElement);
            this.Controls.Add(this.NextElement);
            this.Controls.Add(this.Tape);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Tape.ResumeLayout(false);
            this.Tape.PerformLayout();
            this.ResumeLayout(false);

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
    }
}


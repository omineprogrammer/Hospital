using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form4 : Form {
        public Form4() {
            InitializeComponent();
            Program.Logger("INFO", this.Name + " initialized");
        }

        private void button1_Click(object sender, EventArgs e) {
            if (CheckFields()) {
                Program.Logger("DEBG", "All fields checked, ok");
                timer1.Enabled = true;
                Program.Logger("DEBG", "Execution transfer to timer1");
            }
        }

        private bool CheckFields() {
            bool sw = true;
            //Cedula
            if (maskedTextBox1.TextLength < 1) {
                label1.ForeColor = System.Drawing.Color.Red;
                sw = false;
                Program.Logger("ERRO", "Field " + label1.Name + ": invalid \"" + maskedTextBox1.Text + "\"");
            } else {
                label1.ForeColor = System.Drawing.SystemColors.ControlText;
                Program.Logger("DEBG", "Field " + label1.Name + ": \"" + maskedTextBox1.Text + "\"");
            }
            //Nombre
            if (textBox1.TextLength < 1) {
                label2.ForeColor = System.Drawing.Color.Red;
                sw = false;
                Program.Logger("ERRO", "Field " + label2.Name + ": invalid \"" + textBox1.Text + "\"");
            } else {
                label2.ForeColor = System.Drawing.SystemColors.ControlText;
                Program.Logger("DEBG", "Field " + label2.Name + ": \"" + textBox1.Text + "\"");
            }
            //Apellido
            if (textBox2.TextLength < 1) {
                label3.ForeColor = System.Drawing.Color.Red;
                sw = false;
                Program.Logger("ERRO", "Field " + label3.Name + ": invalid \"" + textBox2.Text + "\"");
            } else {
                label3.ForeColor = System.Drawing.SystemColors.ControlText;
                Program.Logger("DEBG", "Field " + label3.Name + ": " + textBox2.Text + "\"");
            }
            //Celular
            if (!maskedTextBox2.MaskCompleted) {
                label5.ForeColor = System.Drawing.Color.Red;
                sw = false;
                Program.Logger("ERRO", "Field " + label5.Name + ": invalid \"" + maskedTextBox2.Text + "\"");
            } else {
                label5.ForeColor = System.Drawing.SystemColors.ControlText;
                Program.Logger("DEBG", "Field " + label5.Name + ": " + maskedTextBox2.Text + "\"");
            }
            //Edad
            if (numericUpDown1.Value < 0) {
                label4.ForeColor = System.Drawing.Color.Red;
                sw = false;
                Program.Logger("ERRO", "Field " + label4.Name + ": invalid \"" + numericUpDown1.Value.ToString() + "\"");
            } else {
                label4.ForeColor = System.Drawing.SystemColors.ControlText;
                Program.Logger("DEBG", "Field " + label4.Name + ": " + numericUpDown1.Value.ToString() + "\"");
            }
            //Calendario
            if (monthCalendar1.SelectionStart == null) {
                monthCalendar1.ForeColor = System.Drawing.Color.Red;
                Program.Logger("ERRO", "Field " + monthCalendar1.Name + ": \"" + monthCalendar1.SelectionStart.ToString() + "\"");
            } else {
                monthCalendar1.ForeColor = System.Drawing.SystemColors.WindowText;
                Program.Logger("DEBG", "Field " + monthCalendar1.Name + ": \"" + monthCalendar1.SelectionStart.ToString() + "\"");
            }
            return sw;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {

        }

        private void timer1_Tick(object sender, EventArgs e) {
            progressBar1.Increment(2);
            if (progressBar1.Value.Equals(100)) {
                timer1.Enabled = false;
                Program.Logger("DEBG", "ProgressBar full: \"" + progressBar1.Value + "/" + progressBar1.Maximum + "\"");
            }
        }
    }
}

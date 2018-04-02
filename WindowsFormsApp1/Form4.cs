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
                Program.Logger("ERRO", "Field " + label1.Text + ": invalid \"" + maskedTextBox1.Text + "\"");
            } else {
                label1.ForeColor = System.Drawing.SystemColors.ControlText;
                Program.Logger("DEBG", "Field " + label1.Text + ": \"" + maskedTextBox1.Text + "\"");
            }
            //Nombre
            if (textBox1.TextLength < 1) {
                label2.ForeColor = System.Drawing.Color.Red;
                sw = false;
                Program.Logger("ERRO", "Field " + label2.Text + ": invalid \"" + textBox1.Text + "\"");
            } else {
                label2.ForeColor = System.Drawing.SystemColors.ControlText;
                Program.Logger("DEBG", "Field " + label2.Text + ": \"" + textBox1.Text + "\"");
            }
            //Apellido
            if (textBox2.TextLength < 1) {
                label3.ForeColor = System.Drawing.Color.Red;
                sw = false;
                Program.Logger("ERRO", "Field " + label3.Text + ": invalid \"" + textBox2.Text + "\"");
            } else {
                label3.ForeColor = System.Drawing.SystemColors.ControlText;
                Program.Logger("DEBG", "Field " + label3.Text + ": " + textBox2.Text + "\"");
            }
            //Celular
            if (!maskedTextBox2.MaskCompleted) {
                label5.ForeColor = System.Drawing.Color.Red;
                sw = false;
                Program.Logger("ERRO", "Field " + label5.Text + ": invalid \"" + maskedTextBox2.Text + "\"");
            } else {
                label5.ForeColor = System.Drawing.SystemColors.ControlText;
                Program.Logger("DEBG", "Field " + label5.Text + ": " + maskedTextBox2.Text + "\"");
            }
            //Edad
            if (numericUpDown1.Value < 0) {
                label4.ForeColor = System.Drawing.Color.Red;
                sw = false;
                Program.Logger("ERRO", "Field " + label4.Text + ": invalid \"" + numericUpDown1.Value.ToString() + "\"");
            } else {
                label4.ForeColor = System.Drawing.SystemColors.ControlText;
                Program.Logger("DEBG", "Field " + label4.Text + ": " + numericUpDown1.Value.ToString() + "\"");
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

        private void timer1_Tick(object sender, EventArgs e) {
            progressBar1.Increment(5);
            if (progressBar1.Value.Equals(100)) {
                timer1.Enabled = false;
                Program.Logger("DEBG", "ProgressBar full: \"" + progressBar1.Value + "/" + progressBar1.Maximum + "\"");
                InsertDB();
            }
        }

        private void InsertDB() {
            Program.db.Add(
                new ListViewItem(
                    new string[] {
                        maskedTextBox1.Text, //cedula
                        textBox1.Text, //nombre
                        textBox2.Text, //apellido
                        maskedTextBox2.Text, //celular
                        monthCalendar1.SelectionStart.ToString() //fecha
                    }
                )
            );
            Program.Logger("DEBG", "New insert to DB, Count: \"" + Program.db.Count + "\"");
        }

        private void button2_Click(object sender, EventArgs e) {
            Program.ReturnMainMenu(this);
        }
    }
}

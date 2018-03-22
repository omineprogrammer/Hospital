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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if ((textBox1.Text == "pepe") && (textBox2.Text == "12345")) {
                this.Hide();
                Form3 frm = new Form3();
                frm.Show();
            } else {
                MessageBox.Show("Verifique su usuario y contraseña");
            }
        }
    }
}

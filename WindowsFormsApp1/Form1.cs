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
            Program.Logger("INFO", "Form1 initialized");
        }

        private void button1_Click(object sender, EventArgs e) {
            if (loggin(textBox1.Text, textBox2.Text)) {
                this.Hide();
                Form3 frm = new Form3();
                frm.Show();
                Program.Logger("INFO", "User " + textBox1.Text + " logged");
            } else {
                MessageBox.Show("Verifique su usuario y contraseña");
                Program.Logger("WARN", "User " + textBox1.Text + " wrong credentials");
            }
        }

        private bool loggin(string user, string passwd) {
            return (user == "user") && (passwd == "123456");
        }

    }
}

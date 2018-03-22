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
    public partial class Form3 : Form {
        public Form3() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
<<<<<<< HEAD
            if (treeView1.SelectedNode.Name == "Nodo0") { //zPrincipal
                //nothing...
            } else if (treeView1.SelectedNode.Name == "Nodo1") { //Registro
                this.Hide();
                Form4 frm = new Form4();
                frm.Show();
                Program.Logger("INFO", "Go to " + frm.Name);
            } else if (treeView1.SelectedNode.Name == "Nodo2") { //Citas
                this.Hide();
                Form5 frm = new Form5();
                frm.Show();
                Program.Logger("INFO", "Go to " + frm.Name);
            } else if (treeView1.SelectedNode.Name == "Nodo3") { //Web
                this.Hide();
                Form6 frm = new Form6();
                frm.Show();
                Program.Logger("INFO", "Go to " + frm.Name);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
=======
>>>>>>> parent of 9ade601... 0.5
            this.Hide();

            Form1 frm = new Form1();
<<<<<<< HEAD
            frm.Show();
            Program.Logger("INFO", "Closed session");
=======

            frm.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) {
            this.Hide();

            Form4 frm = new Form4();

            frm.Show();
>>>>>>> parent of 9ade601... 0.5
        }
    }
}

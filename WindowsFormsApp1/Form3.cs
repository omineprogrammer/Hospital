﻿using System;
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
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) {
            this.Hide();

            Form4 frm = new Form4();

            frm.Show();
        }
    }
}

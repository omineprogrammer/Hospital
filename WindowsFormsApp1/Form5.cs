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
    public partial class Form5 : Form {
        public Form5() {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e) {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e) {
            LoadDB();
        }

        private void button3_Click(object sender, EventArgs e) {

        }

        private void LoadDB() {
            listView1.Items.Clear();
            this.listView1.Items.AddRange(Program.db.ToArray());
        }
    }
}

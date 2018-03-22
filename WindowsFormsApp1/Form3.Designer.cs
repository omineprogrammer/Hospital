namespace WindowsFormsApp1 {
    partial class Form3 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Registro");
<<<<<<< HEAD
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Citas");
=======
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Usuarios");
>>>>>>> parent of 9ade601... 0.5
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Web");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Principal", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.button2 = new System.Windows.Forms.Button();
=======
>>>>>>> parent of 9ade601... 0.5
            this.SuspendLayout();
            // 
            // treeView1
            // 
<<<<<<< HEAD
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nodo1";
            treeNode1.Text = "Registro";
            treeNode2.Name = "Nodo2";
            treeNode2.Text = "Citas";
            treeNode3.Name = "Nodo3z";
=======
            this.treeView1.Location = new System.Drawing.Point(21, 47);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nodo1";
            treeNode1.Text = "Registro";
            treeNode2.Name = "Nodo4";
            treeNode2.Text = "Usuarios";
            treeNode3.Name = "Nodo5";
>>>>>>> parent of 9ade601... 0.5
            treeNode3.Text = "Web";
            treeNode4.Name = "Nodo0";
            treeNode4.Text = "Principal";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
<<<<<<< HEAD
            this.treeView1.Size = new System.Drawing.Size(142, 208);
            this.treeView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ir al Submenu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cerrar Sesion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
=======
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar Sesion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
>>>>>>> parent of 9ade601... 0.5
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(317, 266);
            this.Controls.Add(this.button2);
=======
            this.ClientSize = new System.Drawing.Size(165, 206);
>>>>>>> parent of 9ade601... 0.5
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
<<<<<<< HEAD
=======

>>>>>>> parent of 9ade601... 0.5
        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
<<<<<<< HEAD
        private System.Windows.Forms.Button button2;
=======
>>>>>>> parent of 9ade601... 0.5
    }
}
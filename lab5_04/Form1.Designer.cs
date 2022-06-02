namespace lab5_04
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnLogin = new System.Windows.Forms.Button();
            this.Usrname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbUsr = new System.Windows.Forms.TextBox();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 134);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(740, 277);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(619, 27);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(98, 39);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Usrname
            // 
            this.Usrname.AutoSize = true;
            this.Usrname.Location = new System.Drawing.Point(61, 27);
            this.Usrname.Name = "Usrname";
            this.Usrname.Size = new System.Drawing.Size(55, 13);
            this.Usrname.TabIndex = 2;
            this.Usrname.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Recent";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txbUsr
            // 
            this.txbUsr.Location = new System.Drawing.Point(131, 24);
            this.txbUsr.Name = "txbUsr";
            this.txbUsr.Size = new System.Drawing.Size(353, 20);
            this.txbUsr.TabIndex = 6;
            this.txbUsr.TextChanged += new System.EventHandler(this.txbUsr_TextChanged);
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(131, 50);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(353, 20);
            this.txbPass.TabIndex = 7;
            this.txbPass.TextChanged += new System.EventHandler(this.txbPass_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.txbUsr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Usrname);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label Usrname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbUsr;
        private System.Windows.Forms.TextBox txbPass;
    }
}


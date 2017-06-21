namespace Simulacija
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtConst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chkodb = new System.Windows.Forms.CheckBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblBrt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMultp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGraf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 530);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtConst
            // 
            this.txtConst.Location = new System.Drawing.Point(340, 14);
            this.txtConst.Name = "txtConst";
            this.txtConst.Size = new System.Drawing.Size(37, 20);
            this.txtConst.TabIndex = 1;
            this.txtConst.Text = "1E0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Const:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(832, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(53, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chkodb
            // 
            this.chkodb.AutoSize = true;
            this.chkodb.Location = new System.Drawing.Point(501, 16);
            this.chkodb.Name = "chkodb";
            this.chkodb.Size = new System.Drawing.Size(70, 17);
            this.chkodb.TabIndex = 4;
            this.chkodb.Text = "Odbijanje";
            this.chkodb.UseVisualStyleBackColor = true;
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(891, 12);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(46, 23);
            this.btnreset.TabIndex = 5;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(118, 12);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(100, 23);
            this.btnAddFile.TabIndex = 6;
            this.btnAddFile.Text = "Dodaj iz fajla";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblBrt
            // 
            this.lblBrt.AutoSize = true;
            this.lblBrt.Location = new System.Drawing.Point(224, 17);
            this.lblBrt.Name = "lblBrt";
            this.lblBrt.Size = new System.Drawing.Size(57, 13);
            this.lblBrt.TabIndex = 7;
            this.lblBrt.Text = "Broj tela: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "1px =";
            // 
            // txtMultp
            // 
            this.txtMultp.Location = new System.Drawing.Point(433, 14);
            this.txtMultp.Name = "txtMultp";
            this.txtMultp.Size = new System.Drawing.Size(41, 20);
            this.txtMultp.TabIndex = 10;
            this.txtMultp.Text = "1E0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "m";
            // 
            // btnGraf
            // 
            this.btnGraf.Location = new System.Drawing.Point(595, 12);
            this.btnGraf.Name = "btnGraf";
            this.btnGraf.Size = new System.Drawing.Size(100, 23);
            this.btnGraf.TabIndex = 12;
            this.btnGraf.Text = "Grafik";
            this.btnGraf.UseVisualStyleBackColor = true;
            this.btnGraf.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 571);
            this.Controls.Add(this.btnGraf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMultp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBrt);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.chkodb);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtConst);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulacija N tela";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtConst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox chkodb;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblBrt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMultp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGraf;
    }
}


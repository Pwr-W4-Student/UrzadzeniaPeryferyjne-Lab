namespace GPSReader
{
    partial class frmPP
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.btnMapIt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtElv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(99, 120);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(111, 20);
            this.txtLong.TabIndex = 1;
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(99, 71);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(111, 20);
            this.txtLat.TabIndex = 2;
            // 
            // btnMapIt
            // 
            this.btnMapIt.Location = new System.Drawing.Point(89, 307);
            this.btnMapIt.Name = "btnMapIt";
            this.btnMapIt.Size = new System.Drawing.Size(98, 23);
            this.btnMapIt.TabIndex = 3;
            this.btnMapIt.Text = "Pokaz na mapie";
            this.btnMapIt.UseVisualStyleBackColor = true;
            this.btnMapIt.Click += new System.EventHandler(this.btnMapIt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Szerokosc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wysokosc";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Zmien";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "COM Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Satelity";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSat
            // 
            this.txtSat.Location = new System.Drawing.Point(99, 168);
            this.txtSat.Name = "txtSat";
            this.txtSat.Size = new System.Drawing.Size(111, 20);
            this.txtSat.TabIndex = 9;
            this.txtSat.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Wysokosc NPM";
            // 
            // txtElv
            // 
            this.txtElv.Location = new System.Drawing.Point(99, 212);
            this.txtElv.Name = "txtElv";
            this.txtElv.Size = new System.Drawing.Size(111, 20);
            this.txtElv.TabIndex = 11;
            // 
            // frmPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 355);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtElv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMapIt);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.button1);
            this.Name = "frmPP";
            this.Text = "GPS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Button btnMapIt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtElv;
    }
}
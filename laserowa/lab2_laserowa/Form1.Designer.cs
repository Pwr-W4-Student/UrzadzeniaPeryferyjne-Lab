namespace lab2_laserowa
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
            this.textBox_text = new System.Windows.Forms.TextBox();
            this.Print = new System.Windows.Forms.Button();
            this.pogrubienie = new System.Windows.Forms.CheckBox();
            this.Kursywa = new System.Windows.Forms.CheckBox();
            this.podkreslenie = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_picture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_text
            // 
            this.textBox_text.Location = new System.Drawing.Point(12, 12);
            this.textBox_text.Multiline = true;
            this.textBox_text.Name = "textBox_text";
            this.textBox_text.Size = new System.Drawing.Size(291, 144);
            this.textBox_text.TabIndex = 0;
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(139, 185);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(75, 23);
            this.Print.TabIndex = 1;
            this.Print.Text = "Drukuj";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // pogrubienie
            // 
            this.pogrubienie.AutoSize = true;
            this.pogrubienie.Location = new System.Drawing.Point(12, 162);
            this.pogrubienie.Name = "pogrubienie";
            this.pogrubienie.Size = new System.Drawing.Size(82, 17);
            this.pogrubienie.TabIndex = 2;
            this.pogrubienie.Text = "Pogrubienie";
            this.pogrubienie.UseVisualStyleBackColor = true;
            // 
            // Kursywa
            // 
            this.Kursywa.AutoSize = true;
            this.Kursywa.Location = new System.Drawing.Point(101, 162);
            this.Kursywa.Name = "Kursywa";
            this.Kursywa.Size = new System.Drawing.Size(66, 17);
            this.Kursywa.TabIndex = 3;
            this.Kursywa.Text = "Kursywa";
            this.Kursywa.UseVisualStyleBackColor = true;
            // 
            // podkreslenie
            // 
            this.podkreslenie.AutoSize = true;
            this.podkreslenie.Location = new System.Drawing.Point(174, 162);
            this.podkreslenie.Name = "podkreslenie";
            this.podkreslenie.Size = new System.Drawing.Size(87, 17);
            this.podkreslenie.TabIndex = 4;
            this.podkreslenie.Text = "Podkreslenie";
            this.podkreslenie.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(267, 161);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(34, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CG Times",
            "Arial",
            "Windings"});
            this.comboBox1.Location = new System.Drawing.Point(12, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Arial";
            // 
            // button_picture
            // 
            this.button_picture.Location = new System.Drawing.Point(228, 185);
            this.button_picture.Name = "button_picture";
            this.button_picture.Size = new System.Drawing.Size(75, 23);
            this.button_picture.TabIndex = 7;
            this.button_picture.Text = "Zdjecie";
            this.button_picture.UseVisualStyleBackColor = true;
            this.button_picture.Click += new System.EventHandler(this.button_picture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 217);
            this.Controls.Add(this.button_picture);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.podkreslenie);
            this.Controls.Add(this.Kursywa);
            this.Controls.Add(this.pogrubienie);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.textBox_text);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_text;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.CheckBox pogrubienie;
        private System.Windows.Forms.CheckBox Kursywa;
        private System.Windows.Forms.CheckBox podkreslenie;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_picture;
    }
}


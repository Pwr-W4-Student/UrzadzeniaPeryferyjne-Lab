namespace Barcode
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
            this.Generate = new System.Windows.Forms.Button();
            this.textBoxEAN = new System.Windows.Forms.TextBox();
            this.EAN = new System.Windows.Forms.Label();
            this.checkBoxSumCtrl = new System.Windows.Forms.CheckBox();
            this.pictureBoxBarcode = new System.Windows.Forms.PictureBox();
            this.print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(529, 44);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(185, 43);
            this.Generate.TabIndex = 0;
            this.Generate.Text = "Generate Barcode";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // textBoxEAN
            // 
            this.textBoxEAN.Location = new System.Drawing.Point(69, 12);
            this.textBoxEAN.Name = "textBoxEAN";
            this.textBoxEAN.Size = new System.Drawing.Size(253, 26);
            this.textBoxEAN.TabIndex = 1;
            // 
            // EAN
            // 
            this.EAN.AutoSize = true;
            this.EAN.Location = new System.Drawing.Point(17, 15);
            this.EAN.Name = "EAN";
            this.EAN.Size = new System.Drawing.Size(46, 20);
            this.EAN.TabIndex = 2;
            this.EAN.Text = "EAN:";
            // 
            // checkBoxSumCtrl
            // 
            this.checkBoxSumCtrl.AutoSize = true;
            this.checkBoxSumCtrl.Location = new System.Drawing.Point(328, 14);
            this.checkBoxSumCtrl.Name = "checkBoxSumCtrl";
            this.checkBoxSumCtrl.Size = new System.Drawing.Size(195, 24);
            this.checkBoxSumCtrl.TabIndex = 3;
            this.checkBoxSumCtrl.Text = "Generate Control Sum";
            this.checkBoxSumCtrl.UseVisualStyleBackColor = true;
            // 
            // pictureBoxBarcode
            // 
            this.pictureBoxBarcode.Location = new System.Drawing.Point(21, 44);
            this.pictureBoxBarcode.Name = "pictureBoxBarcode";
            this.pictureBoxBarcode.Size = new System.Drawing.Size(502, 280);
            this.pictureBoxBarcode.TabIndex = 4;
            this.pictureBoxBarcode.TabStop = false;
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(530, 94);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(184, 44);
            this.print.TabIndex = 5;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 392);
            this.Controls.Add(this.print);
            this.Controls.Add(this.pictureBoxBarcode);
            this.Controls.Add(this.checkBoxSumCtrl);
            this.Controls.Add(this.EAN);
            this.Controls.Add(this.textBoxEAN);
            this.Controls.Add(this.Generate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.TextBox textBoxEAN;
        private System.Windows.Forms.Label EAN;
        private System.Windows.Forms.CheckBox checkBoxSumCtrl;
        private System.Windows.Forms.PictureBox pictureBoxBarcode;
        private System.Windows.Forms.Button print;
    }
}


namespace modem
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
            this.messageBox = new System.Windows.Forms.TextBox();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.comboBoxComList = new System.Windows.Forms.ComboBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(12, 43);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(134, 20);
            this.messageBox.TabIndex = 1;
            this.messageBox.TextChanged += new System.EventHandler(this.messageBox_TextChanged);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(152, 10);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.ConnectBtn.TabIndex = 2;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // comboBoxComList
            // 
            this.comboBoxComList.FormattingEnabled = true;
            this.comboBoxComList.Items.AddRange(new object[] {
            "TestItem"});
            this.comboBoxComList.Location = new System.Drawing.Point(12, 12);
            this.comboBoxComList.Name = "comboBoxComList";
            this.comboBoxComList.Size = new System.Drawing.Size(134, 21);
            this.comboBoxComList.TabIndex = 3;
            this.comboBoxComList.SelectedIndexChanged += new System.EventHandler(this.COMBox_SelectedIndexChanged);
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(152, 41);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(75, 23);
            this.SendBtn.TabIndex = 5;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(233, 10);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(75, 53);
            this.btnSendFile.TabIndex = 6;
            this.btnSendFile.Text = "SendFile";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 74);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.comboBoxComList);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.messageBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.ComboBox comboBoxComList;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Button btnSendFile;
    }
}


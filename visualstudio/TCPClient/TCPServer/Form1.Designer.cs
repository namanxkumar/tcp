namespace TCPServer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ipTXT = new System.Windows.Forms.TextBox();
            this.infoTXT = new System.Windows.Forms.TextBox();
            this.messageTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clientIP = new System.Windows.Forms.ListBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ipTXT
            // 
            this.ipTXT.Location = new System.Drawing.Point(57, 6);
            this.ipTXT.Name = "ipTXT";
            this.ipTXT.Size = new System.Drawing.Size(259, 23);
            this.ipTXT.TabIndex = 1;
            this.ipTXT.Text = "127.0.0.1:9000";
            this.ipTXT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // infoTXT
            // 
            this.infoTXT.Location = new System.Drawing.Point(12, 35);
            this.infoTXT.Multiline = true;
            this.infoTXT.Name = "infoTXT";
            this.infoTXT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.infoTXT.Size = new System.Drawing.Size(304, 199);
            this.infoTXT.TabIndex = 2;
            // 
            // messageTXT
            // 
            this.messageTXT.Location = new System.Drawing.Point(71, 240);
            this.messageTXT.Name = "messageTXT";
            this.messageTXT.Size = new System.Drawing.Size(245, 23);
            this.messageTXT.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Message";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Client IPs";
            // 
            // clientIP
            // 
            this.clientIP.FormattingEnabled = true;
            this.clientIP.ItemHeight = 15;
            this.clientIP.Location = new System.Drawing.Point(329, 35);
            this.clientIP.Name = "clientIP";
            this.clientIP.Size = new System.Drawing.Size(181, 229);
            this.clientIP.TabIndex = 6;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(241, 269);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(160, 269);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 8;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 405);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.clientIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.messageTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.infoTXT);
            this.Controls.Add(this.ipTXT);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox ipTXT;
        private TextBox infoTXT;
        private TextBox messageTXT;
        private Label label2;
        private Label label3;
        private ListBox clientIP;
        private Button buttonStart;
        private Button buttonSend;
    }
}
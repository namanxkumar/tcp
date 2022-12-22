namespace TCPClient
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
            this.infoTXT = new System.Windows.Forms.TextBox();
            this.ipTXT = new System.Windows.Forms.TextBox();
            this.messageTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // infoTXT
            // 
            this.infoTXT.Location = new System.Drawing.Point(21, 47);
            this.infoTXT.Multiline = true;
            this.infoTXT.Name = "infoTXT";
            this.infoTXT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.infoTXT.Size = new System.Drawing.Size(292, 143);
            this.infoTXT.TabIndex = 1;
            this.infoTXT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ipTXT
            // 
            this.ipTXT.Location = new System.Drawing.Point(66, 18);
            this.ipTXT.Name = "ipTXT";
            this.ipTXT.PlaceholderText = "IP:HOST";
            this.ipTXT.Size = new System.Drawing.Size(247, 23);
            this.ipTXT.TabIndex = 2;
            this.ipTXT.Text = "127.0.0.1:9000";
            // 
            // messageTXT
            // 
            this.messageTXT.Location = new System.Drawing.Point(80, 196);
            this.messageTXT.Name = "messageTXT";
            this.messageTXT.PlaceholderText = "Message";
            this.messageTXT.Size = new System.Drawing.Size(233, 23);
            this.messageTXT.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Message";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Connect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 280);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.messageTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipTXT);
            this.Controls.Add(this.infoTXT);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox infoTXT;
        private TextBox ipTXT;
        private TextBox messageTXT;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}
namespace Integration.TestClient
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SendDataTimer = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.IPAdddressTextBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SetResponseButton = new System.Windows.Forms.Button();
            this.MouldNumberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Status Request";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 266);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(413, 140);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data Received";
            // 
            // SendDataTimer
            // 
            this.SendDataTimer.Interval = 1000;
            this.SendDataTimer.Tick += new System.EventHandler(this.SendDataTimer_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(287, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "Change Mode";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // IPAdddressTextBox
            // 
            this.IPAdddressTextBox.Location = new System.Drawing.Point(38, 120);
            this.IPAdddressTextBox.Name = "IPAdddressTextBox";
            this.IPAdddressTextBox.Size = new System.Drawing.Size(150, 20);
            this.IPAdddressTextBox.TabIndex = 5;
            this.IPAdddressTextBox.Text = "127.0.0.1";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(287, 191);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(141, 37);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SetResponseButton
            // 
            this.SetResponseButton.Location = new System.Drawing.Point(287, 123);
            this.SetResponseButton.Name = "SetResponseButton";
            this.SetResponseButton.Size = new System.Drawing.Size(141, 41);
            this.SetResponseButton.TabIndex = 7;
            this.SetResponseButton.Text = "Set Response";
            this.SetResponseButton.UseVisualStyleBackColor = true;
            this.SetResponseButton.Click += new System.EventHandler(this.SetResponseButton_Click);
            // 
            // MouldNumberTextBox
            // 
            this.MouldNumberTextBox.Location = new System.Drawing.Point(38, 147);
            this.MouldNumberTextBox.Name = "MouldNumberTextBox";
            this.MouldNumberTextBox.Size = new System.Drawing.Size(150, 20);
            this.MouldNumberTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 433);
            this.Controls.Add(this.MouldNumberTextBox);
            this.Controls.Add(this.SetResponseButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.IPAdddressTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer SendDataTimer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox IPAdddressTextBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SetResponseButton;
        private System.Windows.Forms.TextBox MouldNumberTextBox;
    }
}


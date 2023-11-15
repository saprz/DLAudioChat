namespace DLAudioChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Connect2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Stop1 = new System.Windows.Forms.Button();
            this.Stop2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.MICcheckBox1 = new System.Windows.Forms.CheckBox();
            this.SoundcheckBox1 = new System.Windows.Forms.CheckBox();
            this.SoundcheckBox2 = new System.Windows.Forms.CheckBox();
            this.MICcheckBox2 = new System.Windows.Forms.CheckBox();
            this.SoundcheckBox3 = new System.Windows.Forms.CheckBox();
            this.MICcheckBox3 = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonConnect.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConnect.Location = new System.Drawing.Point(110, 282);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(118, 32);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "link start1";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(110, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "192.168.3.15";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Connect2
            // 
            this.Connect2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Connect2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect2.Location = new System.Drawing.Point(319, 282);
            this.Connect2.Name = "Connect2";
            this.Connect2.Size = new System.Drawing.Size(119, 32);
            this.Connect2.TabIndex = 4;
            this.Connect2.Text = "link start2";
            this.Connect2.UseVisualStyleBackColor = false;
            this.Connect2.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(319, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 26);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "192.168.3.40";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Stop1
            // 
            this.Stop1.Font = new System.Drawing.Font("Constantia", 12F);
            this.Stop1.Location = new System.Drawing.Point(110, 330);
            this.Stop1.Name = "Stop1";
            this.Stop1.Size = new System.Drawing.Size(118, 34);
            this.Stop1.TabIndex = 6;
            this.Stop1.Text = "Stop1";
            this.Stop1.UseVisualStyleBackColor = true;
            this.Stop1.Click += new System.EventHandler(this.button2_Click);
            // 
            // Stop2
            // 
            this.Stop2.Font = new System.Drawing.Font("Constantia", 12F);
            this.Stop2.Location = new System.Drawing.Point(319, 330);
            this.Stop2.Name = "Stop2";
            this.Stop2.Size = new System.Drawing.Size(119, 34);
            this.Stop2.TabIndex = 7;
            this.Stop2.Text = "Stop2";
            this.Stop2.UseVisualStyleBackColor = true;
            this.Stop2.Click += new System.EventHandler(this.Stop2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(66, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "当前状态：空闲";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Constantia", 12F);
            this.button1.Location = new System.Drawing.Point(523, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Stop3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(523, 209);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(119, 26);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "192.168.3.40";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(523, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 32);
            this.button2.TabIndex = 9;
            this.button2.Text = "link start3";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // MICcheckBox1
            // 
            this.MICcheckBox1.AutoSize = true;
            this.MICcheckBox1.Location = new System.Drawing.Point(110, 380);
            this.MICcheckBox1.Name = "MICcheckBox1";
            this.MICcheckBox1.Size = new System.Drawing.Size(84, 16);
            this.MICcheckBox1.TabIndex = 12;
            this.MICcheckBox1.Text = "MicSwitch1";
            this.MICcheckBox1.UseVisualStyleBackColor = true;
            this.MICcheckBox1.CheckedChanged += new System.EventHandler(this.MICcheckBox1_CheckedChanged);
            // 
            // SoundcheckBox1
            // 
            this.SoundcheckBox1.AutoSize = true;
            this.SoundcheckBox1.Location = new System.Drawing.Point(110, 402);
            this.SoundcheckBox1.Name = "SoundcheckBox1";
            this.SoundcheckBox1.Size = new System.Drawing.Size(96, 16);
            this.SoundcheckBox1.TabIndex = 13;
            this.SoundcheckBox1.Text = "SoundSwitch1";
            this.SoundcheckBox1.UseVisualStyleBackColor = true;
            this.SoundcheckBox1.CheckedChanged += new System.EventHandler(this.SoundcheckBox1_CheckedChanged);
            // 
            // SoundcheckBox2
            // 
            this.SoundcheckBox2.AutoSize = true;
            this.SoundcheckBox2.Location = new System.Drawing.Point(319, 402);
            this.SoundcheckBox2.Name = "SoundcheckBox2";
            this.SoundcheckBox2.Size = new System.Drawing.Size(96, 16);
            this.SoundcheckBox2.TabIndex = 15;
            this.SoundcheckBox2.Text = "SoundSwitch2";
            this.SoundcheckBox2.UseVisualStyleBackColor = true;
            this.SoundcheckBox2.CheckedChanged += new System.EventHandler(this.SoundcheckBox2_CheckedChanged);
            // 
            // MICcheckBox2
            // 
            this.MICcheckBox2.AutoSize = true;
            this.MICcheckBox2.Location = new System.Drawing.Point(319, 380);
            this.MICcheckBox2.Name = "MICcheckBox2";
            this.MICcheckBox2.Size = new System.Drawing.Size(84, 16);
            this.MICcheckBox2.TabIndex = 14;
            this.MICcheckBox2.Text = "MicSwitch2";
            this.MICcheckBox2.UseVisualStyleBackColor = true;
            this.MICcheckBox2.CheckedChanged += new System.EventHandler(this.MICcheckBox2_CheckedChanged);
            // 
            // SoundcheckBox3
            // 
            this.SoundcheckBox3.AutoSize = true;
            this.SoundcheckBox3.Location = new System.Drawing.Point(523, 402);
            this.SoundcheckBox3.Name = "SoundcheckBox3";
            this.SoundcheckBox3.Size = new System.Drawing.Size(96, 16);
            this.SoundcheckBox3.TabIndex = 17;
            this.SoundcheckBox3.Text = "SoundSwitch3";
            this.SoundcheckBox3.UseVisualStyleBackColor = true;
            this.SoundcheckBox3.CheckedChanged += new System.EventHandler(this.SoundcheckBox3_CheckedChanged);
            // 
            // MICcheckBox3
            // 
            this.MICcheckBox3.AutoSize = true;
            this.MICcheckBox3.Location = new System.Drawing.Point(523, 380);
            this.MICcheckBox3.Name = "MICcheckBox3";
            this.MICcheckBox3.Size = new System.Drawing.Size(84, 16);
            this.MICcheckBox3.TabIndex = 16;
            this.MICcheckBox3.Text = "MicSwitch3";
            this.MICcheckBox3.UseVisualStyleBackColor = true;
            this.MICcheckBox3.CheckedChanged += new System.EventHandler(this.MICcheckBox3_CheckedChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBox4.Location = new System.Drawing.Point(110, 241);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(118, 26);
            this.textBox4.TabIndex = 18;
            this.textBox4.Text = "44016";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBox5.Location = new System.Drawing.Point(319, 241);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(119, 26);
            this.textBox5.TabIndex = 19;
            this.textBox5.Text = "44015";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBox6.Location = new System.Drawing.Point(523, 241);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(119, 26);
            this.textBox6.TabIndex = 20;
            this.textBox6.Text = "44014";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "IP：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "IP：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(478, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "IP：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Port：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(262, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Port：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(466, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 26;
            this.label7.Text = "Port：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 458);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.SoundcheckBox3);
            this.Controls.Add(this.MICcheckBox3);
            this.Controls.Add(this.SoundcheckBox2);
            this.Controls.Add(this.MICcheckBox2);
            this.Controls.Add(this.SoundcheckBox1);
            this.Controls.Add(this.MICcheckBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Stop2);
            this.Controls.Add(this.Stop1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Connect2);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DLAudioChat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Connect2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Stop1;
        private System.Windows.Forms.Button Stop2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox MICcheckBox1;
        private System.Windows.Forms.CheckBox SoundcheckBox1;
        private System.Windows.Forms.CheckBox SoundcheckBox2;
        private System.Windows.Forms.CheckBox MICcheckBox2;
        private System.Windows.Forms.CheckBox SoundcheckBox3;
        private System.Windows.Forms.CheckBox MICcheckBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}


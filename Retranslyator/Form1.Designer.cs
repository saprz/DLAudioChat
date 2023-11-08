namespace Retranslyator
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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Connect2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Stop1 = new System.Windows.Forms.Button();
            this.Stop2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConnect.Location = new System.Drawing.Point(78, 295);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(118, 32);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "link start1";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(78, 245);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "192.168.3.15";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Connect2
            // 
            this.Connect2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect2.Location = new System.Drawing.Point(267, 295);
            this.Connect2.Name = "Connect2";
            this.Connect2.Size = new System.Drawing.Size(119, 32);
            this.Connect2.TabIndex = 4;
            this.Connect2.Text = "link start2";
            this.Connect2.UseVisualStyleBackColor = true;
            this.Connect2.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(267, 245);
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
            this.Stop1.Location = new System.Drawing.Point(78, 343);
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
            this.Stop2.Location = new System.Drawing.Point(267, 343);
            this.Stop2.Name = "Stop2";
            this.Stop2.Size = new System.Drawing.Size(119, 34);
            this.Stop2.TabIndex = 7;
            this.Stop2.Text = "Stop2";
            this.Stop2.UseVisualStyleBackColor = true;
            this.Stop2.Click += new System.EventHandler(this.Stop2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 443);
            this.Controls.Add(this.Stop2);
            this.Controls.Add(this.Stop1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Connect2);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
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
    }
}


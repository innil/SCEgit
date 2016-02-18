namespace DaqSimulator
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
            this.txtSensValues = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSamplingTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogTime = new System.Windows.Forms.TextBox();
            this.Button_LogToFile = new System.Windows.Forms.Button();
            this.txtAnalogSensors = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLowValue = new System.Windows.Forms.TextBox();
            this.txtHighValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tmSampling = new System.Windows.Forms.Timer(this.components);
            this.tmLog = new System.Windows.Forms.Timer(this.components);
            this.btnSample = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDigSensors = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSensValues
            // 
            this.txtSensValues.Location = new System.Drawing.Point(153, 56);
            this.txtSensValues.Multiline = true;
            this.txtSensValues.Name = "txtSensValues";
            this.txtSensValues.ReadOnly = true;
            this.txtSensValues.Size = new System.Drawing.Size(213, 151);
            this.txtSensValues.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sensor values";
            // 
            // txtSamplingTime
            // 
            this.txtSamplingTime.Location = new System.Drawing.Point(12, 56);
            this.txtSamplingTime.Name = "txtSamplingTime";
            this.txtSamplingTime.Size = new System.Drawing.Size(123, 20);
            this.txtSamplingTime.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sampling time [sec]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Logging time [sec]";
            // 
            // txtLogTime
            // 
            this.txtLogTime.Location = new System.Drawing.Point(12, 160);
            this.txtLogTime.Name = "txtLogTime";
            this.txtLogTime.Size = new System.Drawing.Size(123, 20);
            this.txtLogTime.TabIndex = 4;
            // 
            // Button_LogToFile
            // 
            this.Button_LogToFile.Location = new System.Drawing.Point(12, 186);
            this.Button_LogToFile.Name = "Button_LogToFile";
            this.Button_LogToFile.Size = new System.Drawing.Size(123, 21);
            this.Button_LogToFile.TabIndex = 7;
            this.Button_LogToFile.Text = "Log to file";
            this.Button_LogToFile.UseVisualStyleBackColor = true;
            this.Button_LogToFile.Click += new System.EventHandler(this.Button_LogToFile_Click);
            // 
            // txtAnalogSensors
            // 
            this.txtAnalogSensors.Location = new System.Drawing.Point(397, 56);
            this.txtAnalogSensors.Name = "txtAnalogSensors";
            this.txtAnalogSensors.Size = new System.Drawing.Size(73, 20);
            this.txtAnalogSensors.TabIndex = 8;
            this.txtAnalogSensors.Text = "6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "No. of analog sensors";
            // 
            // txtLowValue
            // 
            this.txtLowValue.Location = new System.Drawing.Point(397, 149);
            this.txtLowValue.Name = "txtLowValue";
            this.txtLowValue.Size = new System.Drawing.Size(73, 20);
            this.txtLowValue.TabIndex = 10;
            this.txtLowValue.Text = "0";
            // 
            // txtHighValue
            // 
            this.txtHighValue.Location = new System.Drawing.Point(397, 187);
            this.txtHighValue.Name = "txtHighValue";
            this.txtHighValue.Size = new System.Drawing.Size(73, 20);
            this.txtHighValue.TabIndex = 11;
            this.txtHighValue.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Low value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "High value";
            // 
            // tmSampling
            // 
            this.tmSampling.Tick += new System.EventHandler(this.tmSampling_Tick);
            // 
            // tmLog
            // 
            this.tmLog.Interval = 1000;
            this.tmLog.Tick += new System.EventHandler(this.tmLog_Tick);
            // 
            // btnSample
            // 
            this.btnSample.Location = new System.Drawing.Point(12, 82);
            this.btnSample.Name = "btnSample";
            this.btnSample.Size = new System.Drawing.Size(123, 21);
            this.btnSample.TabIndex = 14;
            this.btnSample.Text = "Sample";
            this.btnSample.UseVisualStyleBackColor = true;
            this.btnSample.Click += new System.EventHandler(this.btnSample_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "No. of digital sensors";
            // 
            // txtDigSensors
            // 
            this.txtDigSensors.Location = new System.Drawing.Point(397, 97);
            this.txtDigSensors.Name = "txtDigSensors";
            this.txtDigSensors.Size = new System.Drawing.Size(73, 20);
            this.txtDigSensors.TabIndex = 15;
            this.txtDigSensors.Text = "3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(522, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Exit ";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 234);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDigSensors);
            this.Controls.Add(this.btnSample);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHighValue);
            this.Controls.Add(this.txtLowValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAnalogSensors);
            this.Controls.Add(this.Button_LogToFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLogTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSamplingTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSensValues);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DAQ simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSensValues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSamplingTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogTime;
        private System.Windows.Forms.Button Button_LogToFile;
        private System.Windows.Forms.TextBox txtAnalogSensors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLowValue;
        private System.Windows.Forms.TextBox txtHighValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer tmSampling;
        private System.Windows.Forms.Timer tmLog;
        private System.Windows.Forms.Button btnSample;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDigSensors;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}


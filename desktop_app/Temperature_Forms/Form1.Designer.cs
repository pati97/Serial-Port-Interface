namespace Temperature_Forms
{
    partial class TemperatureReadingForm
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
            this.rtbIncomingData = new System.Windows.Forms.RichTextBox();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.btnData = new System.Windows.Forms.Button();
            this.tbPorts = new System.Windows.Forms.TextBox();
            this.tbDataBits = new System.Windows.Forms.TextBox();
            this.tbStopBits = new System.Windows.Forms.TextBox();
            this.tbParity = new System.Windows.Forms.TextBox();
            this.tbBaudRate = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnClear = new System.Windows.Forms.Button();
            this.tBDate = new System.Windows.Forms.TextBox();
            this.tBAccelerometer = new System.Windows.Forms.TextBox();
            this.tBMicroTemperature = new System.Windows.Forms.TextBox();
            this.tBTime = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAccelerometer = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelMicroTemp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbIncomingData
            // 
            this.rtbIncomingData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbIncomingData.Enabled = false;
            this.rtbIncomingData.Location = new System.Drawing.Point(497, 71);
            this.rtbIncomingData.Name = "rtbIncomingData";
            this.rtbIncomingData.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtbIncomingData.ShowSelectionMargin = true;
            this.rtbIncomingData.Size = new System.Drawing.Size(329, 212);
            this.rtbIncomingData.TabIndex = 9;
            this.rtbIncomingData.Text = "";
            this.rtbIncomingData.WordWrap = false;
            this.rtbIncomingData.TextChanged += new System.EventHandler(this.rtbIncomingData_TextChanged);
            // 
            // cbPorts
            // 
            this.cbPorts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(251, 72);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(142, 28);
            this.cbPorts.TabIndex = 10;
            this.cbPorts.Text = "COM3";
            // 
            // cbStopBits
            // 
            this.cbStopBits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Location = new System.Drawing.Point(251, 198);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(142, 28);
            this.cbStopBits.TabIndex = 11;
            this.cbStopBits.Text = "One";
            // 
            // cbParity
            // 
            this.cbParity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Location = new System.Drawing.Point(251, 156);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(142, 28);
            this.cbParity.TabIndex = 12;
            this.cbParity.Text = "None";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Location = new System.Drawing.Point(251, 114);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(142, 28);
            this.cbBaudRate.TabIndex = 13;
            this.cbBaudRate.Text = "115200";
            // 
            // cbDataBits
            // 
            this.cbDataBits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Location = new System.Drawing.Point(251, 240);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(142, 28);
            this.cbDataBits.TabIndex = 14;
            this.cbDataBits.Text = "8";
            // 
            // btnData
            // 
            this.btnData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnData.BackColor = System.Drawing.Color.LightGray;
            this.btnData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnData.Location = new System.Drawing.Point(577, 312);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(152, 43);
            this.btnData.TabIndex = 15;
            this.btnData.Text = "GET DATA";
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.Click += new System.EventHandler(this.btnDataClick);
            // 
            // tbPorts
            // 
            this.tbPorts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPorts.BackColor = System.Drawing.Color.Orange;
            this.tbPorts.Enabled = false;
            this.tbPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPorts.Location = new System.Drawing.Point(27, 71);
            this.tbPorts.Multiline = true;
            this.tbPorts.Name = "tbPorts";
            this.tbPorts.Size = new System.Drawing.Size(150, 36);
            this.tbPorts.TabIndex = 16;
            this.tbPorts.Text = "Ports";
            this.tbPorts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDataBits
            // 
            this.tbDataBits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDataBits.BackColor = System.Drawing.Color.Orange;
            this.tbDataBits.Enabled = false;
            this.tbDataBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbDataBits.Location = new System.Drawing.Point(27, 236);
            this.tbDataBits.Multiline = true;
            this.tbDataBits.Name = "tbDataBits";
            this.tbDataBits.Size = new System.Drawing.Size(150, 36);
            this.tbDataBits.TabIndex = 17;
            this.tbDataBits.Text = "DataBits";
            this.tbDataBits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbStopBits
            // 
            this.tbStopBits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbStopBits.BackColor = System.Drawing.Color.Orange;
            this.tbStopBits.Enabled = false;
            this.tbStopBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbStopBits.Location = new System.Drawing.Point(27, 194);
            this.tbStopBits.Multiline = true;
            this.tbStopBits.Name = "tbStopBits";
            this.tbStopBits.Size = new System.Drawing.Size(150, 36);
            this.tbStopBits.TabIndex = 18;
            this.tbStopBits.Text = "StopBits";
            this.tbStopBits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbParity
            // 
            this.tbParity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbParity.BackColor = System.Drawing.Color.Orange;
            this.tbParity.Enabled = false;
            this.tbParity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbParity.Location = new System.Drawing.Point(27, 152);
            this.tbParity.Multiline = true;
            this.tbParity.Name = "tbParity";
            this.tbParity.Size = new System.Drawing.Size(150, 36);
            this.tbParity.TabIndex = 19;
            this.tbParity.Text = "Parity";
            this.tbParity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbBaudRate
            // 
            this.tbBaudRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBaudRate.BackColor = System.Drawing.Color.Orange;
            this.tbBaudRate.Enabled = false;
            this.tbBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbBaudRate.Location = new System.Drawing.Point(27, 110);
            this.tbBaudRate.Multiline = true;
            this.tbBaudRate.Name = "tbBaudRate";
            this.tbBaudRate.Size = new System.Drawing.Size(150, 36);
            this.tbBaudRate.TabIndex = 20;
            this.tbBaudRate.Text = "BaudRate";
            this.tbBaudRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOpen.Location = new System.Drawing.Point(27, 313);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(99, 43);
            this.btnOpen.TabIndex = 21;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.Location = new System.Drawing.Point(149, 313);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 43);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar.ForeColor = System.Drawing.Color.GreenYellow;
            this.progressBar.Location = new System.Drawing.Point(27, 375);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(366, 30);
            this.progressBar.TabIndex = 23;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClear.Location = new System.Drawing.Point(281, 313);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 43);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tBDate
            // 
            this.tBDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBDate.Location = new System.Drawing.Point(362, 481);
            this.tBDate.Multiline = true;
            this.tBDate.Name = "tBDate";
            this.tBDate.Size = new System.Drawing.Size(458, 42);
            this.tBDate.TabIndex = 26;
            this.tBDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBAccelerometer
            // 
            this.tBAccelerometer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBAccelerometer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBAccelerometer.Location = new System.Drawing.Point(362, 598);
            this.tBAccelerometer.Multiline = true;
            this.tBAccelerometer.Name = "tBAccelerometer";
            this.tBAccelerometer.Size = new System.Drawing.Size(458, 42);
            this.tBAccelerometer.TabIndex = 26;
            this.tBAccelerometer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBMicroTemperature
            // 
            this.tBMicroTemperature.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBMicroTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBMicroTemperature.Location = new System.Drawing.Point(362, 559);
            this.tBMicroTemperature.Multiline = true;
            this.tBMicroTemperature.Name = "tBMicroTemperature";
            this.tBMicroTemperature.Size = new System.Drawing.Size(458, 42);
            this.tBMicroTemperature.TabIndex = 26;
            this.tBMicroTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBTime
            // 
            this.tBTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBTime.Location = new System.Drawing.Point(362, 520);
            this.tBTime.Multiline = true;
            this.tBTime.Name = "tBTime";
            this.tBTime.Size = new System.Drawing.Size(458, 42);
            this.tBTime.TabIndex = 26;
            this.tBTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelData
            // 
            this.labelData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelData.BackColor = System.Drawing.Color.Green;
            this.labelData.Enabled = false;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelData.Location = new System.Drawing.Point(22, 481);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(236, 39);
            this.labelData.TabIndex = 30;
            this.labelData.Text = "DATE";
            this.labelData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTime.BackColor = System.Drawing.Color.Green;
            this.labelTime.Enabled = false;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTime.Location = new System.Drawing.Point(22, 520);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(236, 39);
            this.labelTime.TabIndex = 31;
            this.labelTime.Text = "TIME";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 32;
            // 
            // labelAccelerometer
            // 
            this.labelAccelerometer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAccelerometer.BackColor = System.Drawing.Color.Green;
            this.labelAccelerometer.Enabled = false;
            this.labelAccelerometer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAccelerometer.Location = new System.Drawing.Point(22, 598);
            this.labelAccelerometer.Name = "labelAccelerometer";
            this.labelAccelerometer.Size = new System.Drawing.Size(236, 39);
            this.labelAccelerometer.TabIndex = 33;
            this.labelAccelerometer.Text = "ACCELEROMETER";
            this.labelAccelerometer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.BackColor = System.Drawing.Color.Red;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox5.Location = new System.Drawing.Point(12, 431);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(830, 32);
            this.textBox5.TabIndex = 34;
            this.textBox5.Text = "ACTUAL VALUES";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMicroTemp
            // 
            this.labelMicroTemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMicroTemp.BackColor = System.Drawing.Color.Green;
            this.labelMicroTemp.Enabled = false;
            this.labelMicroTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMicroTemp.Location = new System.Drawing.Point(22, 559);
            this.labelMicroTemp.Name = "labelMicroTemp";
            this.labelMicroTemp.Size = new System.Drawing.Size(236, 39);
            this.labelMicroTemp.TabIndex = 35;
            this.labelMicroTemp.Text = "MICRO-TEMPERATURE";
            this.labelMicroTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(27, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(366, 36);
            this.button1.TabIndex = 36;
            this.button1.Text = "CONFIGURATION PARAMETERS";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(497, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(329, 36);
            this.button2.TabIndex = 37;
            this.button2.Text = "RECEIVE DATA";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // TemperatureReadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(852, 667);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelMicroTemp);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.labelAccelerometer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.tBTime);
            this.Controls.Add(this.tBMicroTemperature);
            this.Controls.Add(this.tBAccelerometer);
            this.Controls.Add(this.tBDate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.tbBaudRate);
            this.Controls.Add(this.tbParity);
            this.Controls.Add(this.tbStopBits);
            this.Controls.Add(this.tbDataBits);
            this.Controls.Add(this.tbPorts);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.cbDataBits);
            this.Controls.Add(this.cbBaudRate);
            this.Controls.Add(this.cbParity);
            this.Controls.Add(this.cbStopBits);
            this.Controls.Add(this.cbPorts);
            this.Controls.Add(this.rtbIncomingData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "TemperatureReadingForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Measure";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TemperatureReadingForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbIncomingData;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.TextBox tbPorts;
        private System.Windows.Forms.TextBox tbDataBits;
        private System.Windows.Forms.TextBox tbStopBits;
        private System.Windows.Forms.TextBox tbParity;
        private System.Windows.Forms.TextBox tbBaudRate;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tBDate;
        private System.Windows.Forms.TextBox tBAccelerometer;
        private System.Windows.Forms.TextBox tBMicroTemperature;
        private System.Windows.Forms.TextBox tBTime;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAccelerometer;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label labelMicroTemp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.sunriseLabel = new System.Windows.Forms.Label();
            this.sunsetLabel = new System.Windows.Forms.Label();
            this.sunriseOutput = new System.Windows.Forms.Label();
            this.sunsetOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cityOutput.ForeColor = System.Drawing.Color.Black;
            this.cityOutput.Location = new System.Drawing.Point(0, 49);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(333, 28);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maxOutput.ForeColor = System.Drawing.Color.DarkRed;
            this.maxOutput.Location = new System.Drawing.Point(100, 150);
            this.maxOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(40, 30);
            this.maxOutput.TabIndex = 32;
            this.maxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxLabel
            // 
            this.maxLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maxLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.maxLabel.Location = new System.Drawing.Point(75, 150);
            this.maxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(35, 30);
            this.maxLabel.TabIndex = 31;
            this.maxLabel.Text = "H:";
            this.maxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minOutput.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.minOutput.Location = new System.Drawing.Point(210, 150);
            this.minOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(40, 30);
            this.minOutput.TabIndex = 30;
            this.minOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minLabel
            // 
            this.minLabel.BackColor = System.Drawing.Color.Transparent;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.minLabel.Location = new System.Drawing.Point(185, 150);
            this.minLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(35, 30);
            this.minLabel.TabIndex = 29;
            this.minLabel.Text = "L:";
            this.minLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(174, 167);
            this.currentOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(29, 16);
            this.currentOutput.TabIndex = 28;
            // 
            // tempLabel
            // 
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.tempLabel.ForeColor = System.Drawing.Color.Black;
            this.tempLabel.Location = new System.Drawing.Point(0, 92);
            this.tempLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(330, 54);
            this.tempLabel.TabIndex = 26;
            this.tempLabel.Text = "Current Temp";
            this.tempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dateLabel.ForeColor = System.Drawing.Color.Black;
            this.dateLabel.Location = new System.Drawing.Point(0, 0);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(333, 34);
            this.dateLabel.TabIndex = 40;
            this.dateLabel.Text = "Today";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Black;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(0, 300);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(330, 50);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "Week Forecast";
            this.forecastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // sunriseLabel
            // 
            this.sunriseLabel.BackColor = System.Drawing.Color.Transparent;
            this.sunriseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sunriseLabel.ForeColor = System.Drawing.Color.Gold;
            this.sunriseLabel.Location = new System.Drawing.Point(70, 190);
            this.sunriseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sunriseLabel.Name = "sunriseLabel";
            this.sunriseLabel.Size = new System.Drawing.Size(80, 30);
            this.sunriseLabel.TabIndex = 42;
            this.sunriseLabel.Text = "Sunrise";
            this.sunriseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sunsetLabel
            // 
            this.sunsetLabel.BackColor = System.Drawing.Color.Transparent;
            this.sunsetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sunsetLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.sunsetLabel.Location = new System.Drawing.Point(180, 190);
            this.sunsetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sunsetLabel.Name = "sunsetLabel";
            this.sunsetLabel.Size = new System.Drawing.Size(80, 30);
            this.sunsetLabel.TabIndex = 43;
            this.sunsetLabel.Text = "Sunset";
            this.sunsetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sunriseOutput
            // 
            this.sunriseOutput.BackColor = System.Drawing.Color.Transparent;
            this.sunriseOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sunriseOutput.ForeColor = System.Drawing.Color.Gold;
            this.sunriseOutput.Location = new System.Drawing.Point(60, 220);
            this.sunriseOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sunriseOutput.Name = "sunriseOutput";
            this.sunriseOutput.Size = new System.Drawing.Size(100, 30);
            this.sunriseOutput.TabIndex = 44;
            this.sunriseOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sunsetOutput
            // 
            this.sunsetOutput.BackColor = System.Drawing.Color.Transparent;
            this.sunsetOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sunsetOutput.ForeColor = System.Drawing.Color.DarkOrange;
            this.sunsetOutput.Location = new System.Drawing.Point(170, 220);
            this.sunsetOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sunsetOutput.Name = "sunsetOutput";
            this.sunsetOutput.Size = new System.Drawing.Size(100, 30);
            this.sunsetOutput.TabIndex = 45;
            this.sunsetOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.sunsetOutput);
            this.Controls.Add(this.sunriseOutput);
            this.Controls.Add(this.sunsetLabel);
            this.Controls.Add(this.sunriseLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.tempLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(330, 350);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label forecastLabel;
        public System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label sunriseLabel;
        private System.Windows.Forms.Label sunsetLabel;
        private System.Windows.Forms.Label sunriseOutput;
        private System.Windows.Forms.Label sunsetOutput;
    }
}

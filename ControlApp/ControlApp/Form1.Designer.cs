namespace ControlApp
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
            this.manualControlBox = new System.Windows.Forms.GroupBox();
            this.backwardBtn = new System.Windows.Forms.Button();
            this.turnRightBtn = new System.Windows.Forms.Button();
            this.turnLeftBtn = new System.Windows.Forms.Button();
            this.forwardBtn = new System.Windows.Forms.Button();
            this.automaticControlBox = new System.Windows.Forms.GroupBox();
            this.wallFollowBtn = new System.Windows.Forms.Button();
            this.randomWalkBtn = new System.Windows.Forms.Button();
            this.serialConnectionBox = new System.Windows.Forms.GroupBox();
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.connectBtn = new System.Windows.Forms.Button();
            this.baudrateComboBox = new System.Windows.Forms.ComboBox();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.baudrateLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.robotStatusBox = new System.Windows.Forms.GroupBox();
            this.batteryStatusProgressBar = new System.Windows.Forms.ProgressBar();
            this.workingStatusTextBox = new System.Windows.Forms.TextBox();
            this.serialResponseTextBox = new System.Windows.Forms.TextBox();
            this.connectionStatusTextBox = new System.Windows.Forms.TextBox();
            this.workingStatusLabel = new System.Windows.Forms.Label();
            this.batteryStatusLabel = new System.Windows.Forms.Label();
            this.serialResponseLabel = new System.Windows.Forms.Label();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.controlModeLabel = new System.Windows.Forms.Label();
            this.automaticModeBtn = new System.Windows.Forms.Button();
            this.manualModeBtn = new System.Windows.Forms.Button();
            this.RFserialPort = new System.IO.Ports.SerialPort(this.components);
            this.manualControlBox.SuspendLayout();
            this.automaticControlBox.SuspendLayout();
            this.serialConnectionBox.SuspendLayout();
            this.robotStatusBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // manualControlBox
            // 
            this.manualControlBox.Controls.Add(this.backwardBtn);
            this.manualControlBox.Controls.Add(this.turnRightBtn);
            this.manualControlBox.Controls.Add(this.turnLeftBtn);
            this.manualControlBox.Controls.Add(this.forwardBtn);
            this.manualControlBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualControlBox.Location = new System.Drawing.Point(12, 119);
            this.manualControlBox.Name = "manualControlBox";
            this.manualControlBox.Size = new System.Drawing.Size(330, 226);
            this.manualControlBox.TabIndex = 0;
            this.manualControlBox.TabStop = false;
            this.manualControlBox.Text = "Manual Mode Control";
            // 
            // backwardBtn
            // 
            this.backwardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backwardBtn.Location = new System.Drawing.Point(114, 126);
            this.backwardBtn.Name = "backwardBtn";
            this.backwardBtn.Size = new System.Drawing.Size(100, 72);
            this.backwardBtn.TabIndex = 0;
            this.backwardBtn.Text = "Backward";
            this.backwardBtn.UseVisualStyleBackColor = true;
            this.backwardBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.backwardBtn_MouseDown);
            this.backwardBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.backwardBtn_MouseUp);
            // 
            // turnRightBtn
            // 
            this.turnRightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnRightBtn.Location = new System.Drawing.Point(221, 126);
            this.turnRightBtn.Name = "turnRightBtn";
            this.turnRightBtn.Size = new System.Drawing.Size(97, 72);
            this.turnRightBtn.TabIndex = 0;
            this.turnRightBtn.Text = "Turn Right";
            this.turnRightBtn.UseVisualStyleBackColor = true;
            this.turnRightBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.turnRightBtn_MouseDown);
            this.turnRightBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.turnRightBtn_MouseUp);
            // 
            // turnLeftBtn
            // 
            this.turnLeftBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnLeftBtn.Location = new System.Drawing.Point(11, 126);
            this.turnLeftBtn.Name = "turnLeftBtn";
            this.turnLeftBtn.Size = new System.Drawing.Size(97, 72);
            this.turnLeftBtn.TabIndex = 0;
            this.turnLeftBtn.Text = "Turn Left";
            this.turnLeftBtn.UseVisualStyleBackColor = true;
            this.turnLeftBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.turnLeftBtn_MouseDown);
            this.turnLeftBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.turnLeftBtn_MouseUp);
            // 
            // forwardBtn
            // 
            this.forwardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forwardBtn.Location = new System.Drawing.Point(114, 50);
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.Size = new System.Drawing.Size(100, 72);
            this.forwardBtn.TabIndex = 0;
            this.forwardBtn.Text = "Forward";
            this.forwardBtn.UseVisualStyleBackColor = true;
            this.forwardBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.forwardBtn_MouseDown);
            this.forwardBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.forwardBtn_MouseUp);
            // 
            // automaticControlBox
            // 
            this.automaticControlBox.Controls.Add(this.wallFollowBtn);
            this.automaticControlBox.Controls.Add(this.randomWalkBtn);
            this.automaticControlBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.automaticControlBox.Location = new System.Drawing.Point(360, 119);
            this.automaticControlBox.Name = "automaticControlBox";
            this.automaticControlBox.Size = new System.Drawing.Size(317, 226);
            this.automaticControlBox.TabIndex = 1;
            this.automaticControlBox.TabStop = false;
            this.automaticControlBox.Text = "Automatic Mode Control";
            // 
            // wallFollowBtn
            // 
            this.wallFollowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wallFollowBtn.Location = new System.Drawing.Point(174, 58);
            this.wallFollowBtn.Name = "wallFollowBtn";
            this.wallFollowBtn.Size = new System.Drawing.Size(117, 61);
            this.wallFollowBtn.TabIndex = 0;
            this.wallFollowBtn.Text = "Wall Follow Mode";
            this.wallFollowBtn.UseVisualStyleBackColor = true;
            this.wallFollowBtn.Click += new System.EventHandler(this.wallFollowBtn_Click);
            // 
            // randomWalkBtn
            // 
            this.randomWalkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomWalkBtn.Location = new System.Drawing.Point(25, 58);
            this.randomWalkBtn.Name = "randomWalkBtn";
            this.randomWalkBtn.Size = new System.Drawing.Size(118, 61);
            this.randomWalkBtn.TabIndex = 0;
            this.randomWalkBtn.Text = "Random Walk Mode";
            this.randomWalkBtn.UseVisualStyleBackColor = true;
            this.randomWalkBtn.Click += new System.EventHandler(this.randomWalkBtn_Click);
            // 
            // serialConnectionBox
            // 
            this.serialConnectionBox.Controls.Add(this.disconnectBtn);
            this.serialConnectionBox.Controls.Add(this.connectBtn);
            this.serialConnectionBox.Controls.Add(this.baudrateComboBox);
            this.serialConnectionBox.Controls.Add(this.portComboBox);
            this.serialConnectionBox.Controls.Add(this.baudrateLabel);
            this.serialConnectionBox.Controls.Add(this.portLabel);
            this.serialConnectionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialConnectionBox.Location = new System.Drawing.Point(12, 351);
            this.serialConnectionBox.Name = "serialConnectionBox";
            this.serialConnectionBox.Size = new System.Drawing.Size(663, 115);
            this.serialConnectionBox.TabIndex = 2;
            this.serialConnectionBox.TabStop = false;
            this.serialConnectionBox.Text = "Serial Connection";
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectBtn.Location = new System.Drawing.Point(373, 69);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(126, 32);
            this.disconnectBtn.TabIndex = 2;
            this.disconnectBtn.Text = "Disconnect";
            this.disconnectBtn.UseVisualStyleBackColor = true;
            this.disconnectBtn.Click += new System.EventHandler(this.disconnectBtn_Click);
            // 
            // connectBtn
            // 
            this.connectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectBtn.Location = new System.Drawing.Point(373, 28);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(126, 32);
            this.connectBtn.TabIndex = 2;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // baudrateComboBox
            // 
            this.baudrateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudrateComboBox.FormattingEnabled = true;
            this.baudrateComboBox.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "74880",
            "115200"});
            this.baudrateComboBox.Location = new System.Drawing.Point(153, 69);
            this.baudrateComboBox.Name = "baudrateComboBox";
            this.baudrateComboBox.Size = new System.Drawing.Size(165, 28);
            this.baudrateComboBox.TabIndex = 1;
            // 
            // portComboBox
            // 
            this.portComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(153, 27);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(165, 28);
            this.portComboBox.TabIndex = 1;
            this.portComboBox.Click += new System.EventHandler(this.portComboBox_Click);
            // 
            // baudrateLabel
            // 
            this.baudrateLabel.AutoSize = true;
            this.baudrateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudrateLabel.Location = new System.Drawing.Point(6, 72);
            this.baudrateLabel.Name = "baudrateLabel";
            this.baudrateLabel.Size = new System.Drawing.Size(86, 20);
            this.baudrateLabel.TabIndex = 0;
            this.baudrateLabel.Text = "Baud Rate";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portLabel.Location = new System.Drawing.Point(6, 30);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(38, 20);
            this.portLabel.TabIndex = 0;
            this.portLabel.Text = "Port";
            // 
            // robotStatusBox
            // 
            this.robotStatusBox.Controls.Add(this.batteryStatusProgressBar);
            this.robotStatusBox.Controls.Add(this.workingStatusTextBox);
            this.robotStatusBox.Controls.Add(this.serialResponseTextBox);
            this.robotStatusBox.Controls.Add(this.connectionStatusTextBox);
            this.robotStatusBox.Controls.Add(this.workingStatusLabel);
            this.robotStatusBox.Controls.Add(this.batteryStatusLabel);
            this.robotStatusBox.Controls.Add(this.serialResponseLabel);
            this.robotStatusBox.Controls.Add(this.connectionStatusLabel);
            this.robotStatusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.robotStatusBox.Location = new System.Drawing.Point(12, 472);
            this.robotStatusBox.Name = "robotStatusBox";
            this.robotStatusBox.Size = new System.Drawing.Size(663, 140);
            this.robotStatusBox.TabIndex = 3;
            this.robotStatusBox.TabStop = false;
            this.robotStatusBox.Text = "Robot Status";
            // 
            // batteryStatusProgressBar
            // 
            this.batteryStatusProgressBar.Location = new System.Drawing.Point(153, 98);
            this.batteryStatusProgressBar.Name = "batteryStatusProgressBar";
            this.batteryStatusProgressBar.Size = new System.Drawing.Size(165, 23);
            this.batteryStatusProgressBar.TabIndex = 2;
            // 
            // workingStatusTextBox
            // 
            this.workingStatusTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.workingStatusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workingStatusTextBox.Location = new System.Drawing.Point(397, 69);
            this.workingStatusTextBox.Name = "workingStatusTextBox";
            this.workingStatusTextBox.Size = new System.Drawing.Size(242, 29);
            this.workingStatusTextBox.TabIndex = 1;
            this.workingStatusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // serialResponseTextBox
            // 
            this.serialResponseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialResponseTextBox.Location = new System.Drawing.Point(153, 66);
            this.serialResponseTextBox.Name = "serialResponseTextBox";
            this.serialResponseTextBox.Size = new System.Drawing.Size(165, 26);
            this.serialResponseTextBox.TabIndex = 1;
            // 
            // connectionStatusTextBox
            // 
            this.connectionStatusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionStatusTextBox.Location = new System.Drawing.Point(153, 34);
            this.connectionStatusTextBox.Name = "connectionStatusTextBox";
            this.connectionStatusTextBox.Size = new System.Drawing.Size(165, 26);
            this.connectionStatusTextBox.TabIndex = 1;
            // 
            // workingStatusLabel
            // 
            this.workingStatusLabel.AutoSize = true;
            this.workingStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workingStatusLabel.Location = new System.Drawing.Point(393, 34);
            this.workingStatusLabel.Name = "workingStatusLabel";
            this.workingStatusLabel.Size = new System.Drawing.Size(149, 24);
            this.workingStatusLabel.TabIndex = 0;
            this.workingStatusLabel.Text = "Working Status";
            // 
            // batteryStatusLabel
            // 
            this.batteryStatusLabel.AutoSize = true;
            this.batteryStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryStatusLabel.Location = new System.Drawing.Point(6, 101);
            this.batteryStatusLabel.Name = "batteryStatusLabel";
            this.batteryStatusLabel.Size = new System.Drawing.Size(111, 20);
            this.batteryStatusLabel.TabIndex = 0;
            this.batteryStatusLabel.Text = "Battery Status";
            // 
            // serialResponseLabel
            // 
            this.serialResponseLabel.AutoSize = true;
            this.serialResponseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialResponseLabel.Location = new System.Drawing.Point(6, 69);
            this.serialResponseLabel.Name = "serialResponseLabel";
            this.serialResponseLabel.Size = new System.Drawing.Size(126, 20);
            this.serialResponseLabel.TabIndex = 0;
            this.serialResponseLabel.Text = "Serial Response";
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.AutoSize = true;
            this.connectionStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionStatusLabel.Location = new System.Drawing.Point(6, 34);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(141, 20);
            this.connectionStatusLabel.TabIndex = 0;
            this.connectionStatusLabel.Text = "Connection Status";
            // 
            // controlModeLabel
            // 
            this.controlModeLabel.AutoSize = true;
            this.controlModeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlModeLabel.Location = new System.Drawing.Point(256, 9);
            this.controlModeLabel.Name = "controlModeLabel";
            this.controlModeLabel.Size = new System.Drawing.Size(201, 33);
            this.controlModeLabel.TabIndex = 4;
            this.controlModeLabel.Text = "Control Mode";
            // 
            // automaticModeBtn
            // 
            this.automaticModeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.automaticModeBtn.Location = new System.Drawing.Point(420, 45);
            this.automaticModeBtn.Name = "automaticModeBtn";
            this.automaticModeBtn.Size = new System.Drawing.Size(182, 55);
            this.automaticModeBtn.TabIndex = 5;
            this.automaticModeBtn.Text = "Automatic Mode";
            this.automaticModeBtn.UseVisualStyleBackColor = true;
            this.automaticModeBtn.Click += new System.EventHandler(this.automaticModeBtn_Click);
            // 
            // manualModeBtn
            // 
            this.manualModeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualModeBtn.Location = new System.Drawing.Point(106, 45);
            this.manualModeBtn.Name = "manualModeBtn";
            this.manualModeBtn.Size = new System.Drawing.Size(182, 55);
            this.manualModeBtn.TabIndex = 5;
            this.manualModeBtn.Text = "Manual Mode";
            this.manualModeBtn.UseVisualStyleBackColor = true;
            this.manualModeBtn.Click += new System.EventHandler(this.manualModeBtn_Click);
            // 
            // RFserialPort
            // 
            this.RFserialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.RFserialPort_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 625);
            this.Controls.Add(this.manualModeBtn);
            this.Controls.Add(this.automaticModeBtn);
            this.Controls.Add(this.controlModeLabel);
            this.Controls.Add(this.robotStatusBox);
            this.Controls.Add(this.serialConnectionBox);
            this.Controls.Add(this.automaticControlBox);
            this.Controls.Add(this.manualControlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Vacuum Robot Control App";
            this.manualControlBox.ResumeLayout(false);
            this.automaticControlBox.ResumeLayout(false);
            this.serialConnectionBox.ResumeLayout(false);
            this.serialConnectionBox.PerformLayout();
            this.robotStatusBox.ResumeLayout(false);
            this.robotStatusBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox manualControlBox;
        private System.Windows.Forms.Button backwardBtn;
        private System.Windows.Forms.Button turnRightBtn;
        private System.Windows.Forms.Button turnLeftBtn;
        private System.Windows.Forms.Button forwardBtn;
        private System.Windows.Forms.GroupBox automaticControlBox;
        private System.Windows.Forms.Button wallFollowBtn;
        private System.Windows.Forms.Button randomWalkBtn;
        private System.Windows.Forms.GroupBox serialConnectionBox;
        private System.Windows.Forms.Button disconnectBtn;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.ComboBox baudrateComboBox;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.Label baudrateLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.GroupBox robotStatusBox;
        private System.Windows.Forms.ProgressBar batteryStatusProgressBar;
        private System.Windows.Forms.TextBox workingStatusTextBox;
        private System.Windows.Forms.TextBox serialResponseTextBox;
        private System.Windows.Forms.TextBox connectionStatusTextBox;
        private System.Windows.Forms.Label workingStatusLabel;
        private System.Windows.Forms.Label batteryStatusLabel;
        private System.Windows.Forms.Label serialResponseLabel;
        private System.Windows.Forms.Label connectionStatusLabel;
        private System.Windows.Forms.Label controlModeLabel;
        private System.Windows.Forms.Button automaticModeBtn;
        private System.Windows.Forms.Button manualModeBtn;
        private System.IO.Ports.SerialPort RFserialPort;
    }
}


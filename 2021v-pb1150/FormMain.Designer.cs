
namespace _2021v_pb1150
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comPortSelect = new System.Windows.Forms.ComboBox();
            this.bitRateSelect = new System.Windows.Forms.ComboBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.sendDataTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.receiveButton = new System.Windows.Forms.Button();
            this.receivedDataTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageConnection = new System.Windows.Forms.TabPage();
            this.tabPageConfig = new System.Windows.Forms.TabPage();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.buttonReadConfig = new System.Windows.Forms.Button();
            this.textBoxTagname = new System.Windows.Forms.TextBox();
            this.textBoxLRV = new System.Windows.Forms.TextBox();
            this.textBoxURV = new System.Windows.Forms.TextBox();
            this.textBoxAL = new System.Windows.Forms.TextBox();
            this.textBoxAH = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageConnection.SuspendLayout();
            this.tabPageConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Com port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bit rate:";
            // 
            // comPortSelect
            // 
            this.comPortSelect.FormattingEnabled = true;
            this.comPortSelect.Location = new System.Drawing.Point(114, 0);
            this.comPortSelect.Name = "comPortSelect";
            this.comPortSelect.Size = new System.Drawing.Size(158, 33);
            this.comPortSelect.Sorted = true;
            this.comPortSelect.TabIndex = 2;
            // 
            // bitRateSelect
            // 
            this.bitRateSelect.FormattingEnabled = true;
            this.bitRateSelect.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.bitRateSelect.Location = new System.Drawing.Point(114, 39);
            this.bitRateSelect.Name = "bitRateSelect";
            this.bitRateSelect.Size = new System.Drawing.Size(158, 33);
            this.bitRateSelect.TabIndex = 3;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(114, 78);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(158, 45);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(114, 129);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(158, 43);
            this.disconnectButton.TabIndex = 5;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // sendDataTextBox
            // 
            this.sendDataTextBox.Location = new System.Drawing.Point(438, 3);
            this.sendDataTextBox.Name = "sendDataTextBox";
            this.sendDataTextBox.Size = new System.Drawing.Size(351, 31);
            this.sendDataTextBox.TabIndex = 6;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(321, 6);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(111, 45);
            this.sendButton.TabIndex = 7;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // receiveButton
            // 
            this.receiveButton.Location = new System.Drawing.Point(321, 57);
            this.receiveButton.Name = "receiveButton";
            this.receiveButton.Size = new System.Drawing.Size(111, 45);
            this.receiveButton.TabIndex = 8;
            this.receiveButton.Text = "Receive";
            this.receiveButton.UseVisualStyleBackColor = true;
            this.receiveButton.Click += new System.EventHandler(this.receiveButton_Click);
            // 
            // receivedDataTextBox
            // 
            this.receivedDataTextBox.Location = new System.Drawing.Point(438, 40);
            this.receivedDataTextBox.Multiline = true;
            this.receivedDataTextBox.Name = "receivedDataTextBox";
            this.receivedDataTextBox.ReadOnly = true;
            this.receivedDataTextBox.Size = new System.Drawing.Size(351, 324);
            this.receivedDataTextBox.TabIndex = 9;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 704);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1241, 42);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(240, 32);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageConnection);
            this.tabControlMain.Controls.Add(this.tabPageConfig);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1241, 704);
            this.tabControlMain.TabIndex = 11;
            // 
            // tabPageConnection
            // 
            this.tabPageConnection.Controls.Add(this.disconnectButton);
            this.tabPageConnection.Controls.Add(this.connectButton);
            this.tabPageConnection.Controls.Add(this.sendDataTextBox);
            this.tabPageConnection.Controls.Add(this.receivedDataTextBox);
            this.tabPageConnection.Controls.Add(this.bitRateSelect);
            this.tabPageConnection.Controls.Add(this.sendButton);
            this.tabPageConnection.Controls.Add(this.receiveButton);
            this.tabPageConnection.Controls.Add(this.label2);
            this.tabPageConnection.Controls.Add(this.label1);
            this.tabPageConnection.Controls.Add(this.comPortSelect);
            this.tabPageConnection.Location = new System.Drawing.Point(4, 34);
            this.tabPageConnection.Name = "tabPageConnection";
            this.tabPageConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnection.Size = new System.Drawing.Size(1233, 666);
            this.tabPageConnection.TabIndex = 0;
            this.tabPageConnection.Text = "Connection";
            this.tabPageConnection.UseVisualStyleBackColor = true;
            // 
            // tabPageConfig
            // 
            this.tabPageConfig.Controls.Add(this.textBoxAH);
            this.tabPageConfig.Controls.Add(this.textBoxAL);
            this.tabPageConfig.Controls.Add(this.textBoxURV);
            this.tabPageConfig.Controls.Add(this.textBoxLRV);
            this.tabPageConfig.Controls.Add(this.textBoxTagname);
            this.tabPageConfig.Controls.Add(this.buttonReadConfig);
            this.tabPageConfig.Controls.Add(this.label3);
            this.tabPageConfig.Location = new System.Drawing.Point(4, 34);
            this.tabPageConfig.Name = "tabPageConfig";
            this.tabPageConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfig.Size = new System.Drawing.Size(1233, 666);
            this.tabPageConfig.TabIndex = 1;
            this.tabPageConfig.Text = "Config";
            this.tabPageConfig.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // buttonReadConfig
            // 
            this.buttonReadConfig.Location = new System.Drawing.Point(291, 77);
            this.buttonReadConfig.Name = "buttonReadConfig";
            this.buttonReadConfig.Size = new System.Drawing.Size(75, 23);
            this.buttonReadConfig.TabIndex = 1;
            this.buttonReadConfig.Text = "Read";
            this.buttonReadConfig.UseVisualStyleBackColor = true;
            this.buttonReadConfig.Click += new System.EventHandler(this.buttonReadConfig_Click);
            // 
            // textBoxTagname
            // 
            this.textBoxTagname.Location = new System.Drawing.Point(420, 73);
            this.textBoxTagname.Name = "textBoxTagname";
            this.textBoxTagname.Size = new System.Drawing.Size(100, 31);
            this.textBoxTagname.TabIndex = 2;
            // 
            // textBoxLRV
            // 
            this.textBoxLRV.Location = new System.Drawing.Point(543, 71);
            this.textBoxLRV.Name = "textBoxLRV";
            this.textBoxLRV.Size = new System.Drawing.Size(100, 31);
            this.textBoxLRV.TabIndex = 3;
            // 
            // textBoxURV
            // 
            this.textBoxURV.Location = new System.Drawing.Point(671, 73);
            this.textBoxURV.Name = "textBoxURV";
            this.textBoxURV.Size = new System.Drawing.Size(100, 31);
            this.textBoxURV.TabIndex = 4;
            // 
            // textBoxAL
            // 
            this.textBoxAL.Location = new System.Drawing.Point(795, 69);
            this.textBoxAL.Name = "textBoxAL";
            this.textBoxAL.Size = new System.Drawing.Size(100, 31);
            this.textBoxAL.TabIndex = 5;
            // 
            // textBoxAH
            // 
            this.textBoxAH.Location = new System.Drawing.Point(911, 71);
            this.textBoxAH.Name = "textBoxAH";
            this.textBoxAH.Size = new System.Drawing.Size(100, 31);
            this.textBoxAH.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 746);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoftSensConf";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageConnection.ResumeLayout(false);
            this.tabPageConnection.PerformLayout();
            this.tabPageConfig.ResumeLayout(false);
            this.tabPageConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comPortSelect;
        private System.Windows.Forms.ComboBox bitRateSelect;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.TextBox sendDataTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button receiveButton;
        private System.Windows.Forms.TextBox receivedDataTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageConnection;
        private System.Windows.Forms.TabPage tabPageConfig;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox textBoxTagname;
        private System.Windows.Forms.Button buttonReadConfig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAH;
        private System.Windows.Forms.TextBox textBoxAL;
        private System.Windows.Forms.TextBox textBoxURV;
        private System.Windows.Forms.TextBox textBoxLRV;
    }
}


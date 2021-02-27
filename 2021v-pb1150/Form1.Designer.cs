
namespace _2021v_pb1150
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Com port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bit rate:";
            // 
            // comPortSelect
            // 
            this.comPortSelect.FormattingEnabled = true;
            this.comPortSelect.Location = new System.Drawing.Point(129, 6);
            this.comPortSelect.Name = "comPortSelect";
            this.comPortSelect.Size = new System.Drawing.Size(158, 33);
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
            this.bitRateSelect.Location = new System.Drawing.Point(129, 48);
            this.bitRateSelect.Name = "bitRateSelect";
            this.bitRateSelect.Size = new System.Drawing.Size(158, 33);
            this.bitRateSelect.TabIndex = 3;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(129, 93);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(158, 45);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(129, 145);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(158, 43);
            this.disconnectButton.TabIndex = 5;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            // 
            // sendDataTextBox
            // 
            this.sendDataTextBox.Location = new System.Drawing.Point(437, 6);
            this.sendDataTextBox.Name = "sendDataTextBox";
            this.sendDataTextBox.Size = new System.Drawing.Size(351, 31);
            this.sendDataTextBox.TabIndex = 6;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(320, 6);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(111, 45);
            this.sendButton.TabIndex = 7;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // receiveButton
            // 
            this.receiveButton.Location = new System.Drawing.Point(320, 57);
            this.receiveButton.Name = "receiveButton";
            this.receiveButton.Size = new System.Drawing.Size(111, 45);
            this.receiveButton.TabIndex = 8;
            this.receiveButton.Text = "Receive";
            this.receiveButton.UseVisualStyleBackColor = true;
            // 
            // receivedDataTextBox
            // 
            this.receivedDataTextBox.Location = new System.Drawing.Point(437, 57);
            this.receivedDataTextBox.Multiline = true;
            this.receivedDataTextBox.Name = "receivedDataTextBox";
            this.receivedDataTextBox.ReadOnly = true;
            this.receivedDataTextBox.Size = new System.Drawing.Size(351, 381);
            this.receivedDataTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.receivedDataTextBox);
            this.Controls.Add(this.receiveButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.sendDataTextBox);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.bitRateSelect);
            this.Controls.Add(this.comPortSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SoftSensConf";
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
    }
}


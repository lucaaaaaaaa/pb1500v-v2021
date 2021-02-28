using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;

namespace _2021v_pb1150
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            bitRateSelect.SelectedItem = "9600";
            var ports = System.IO.Ports.SerialPort.GetPortNames();
            foreach (String port in ports)
            {
                comPortSelect.Items.Add(port);
            }
            if (comPortSelect.Items.Count > 0)
            {
                comPortSelect.SelectedIndex = comPortSelect.Items.Count - 1;
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (comPortSelect.SelectedIndex <= -1)
                return; // FIXME error message
            if (bitRateSelect.SelectedIndex <= -1)
                return; // FIXME error message

            serialPort.PortName = comPortSelect.Items[comPortSelect.SelectedIndex].ToString();
            serialPort.BaudRate = Convert.ToInt32(bitRateSelect.Items[bitRateSelect.SelectedIndex]);
            //serialPort.Open();
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            //serialPort.Close();
        }

        private void receiveButton_Click(object sender, EventArgs e)
        {
            //var data = serialPort.ReadExisting();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            //serialPort.WriteLine(sendDataTextBox.Text);
        }

        private void buttonReadConfig_Click(object sender, EventArgs e)
        {
            string receivedConfig = "QT420;0.0;500.0;50;450";

            string[] instrumentConfigs = receivedConfig.Split(';');

            textBoxTagname.Text = instrumentConfigs[0];
            textBoxLRV.Text = instrumentConfigs[1];
            textBoxURV.Text = instrumentConfigs[2];
            textBoxAL.Text = instrumentConfigs[3];
            textBoxAH.Text = instrumentConfigs[4];
        }

        private void buttonUpdateConfig_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSaveConfig_Click(object sender, EventArgs e)
        {

        }
    }
}

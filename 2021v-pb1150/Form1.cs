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
    public partial class Form1 : Form
    {
        public Form1()
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
                comPortSelect.SelectedIndex = comPortSelect.Items.Count-1;
            }
        }
    }
}

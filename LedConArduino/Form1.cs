using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports; // Libreria para el uso de puertos seriales

namespace LedConArduino
{
    public partial class Form1 : Form
    {
        public SerialPort ArduinoPort { get; }
        public Form1()
        {
            InitializeComponent();
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM3";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();

            this.FormClosing += cerrandoForm1;
            this.FormClosing += btn_prender_Click;
            this.FormClosing += btn_apagar_Click;
        }

        private void btn_prender_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("b");
        }
        private void btn_apagar_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("a");
        }
        private void cerrandoForm1(object sender, EventArgs e)
        {
            ArduinoPort.Close();
        }
    }
}

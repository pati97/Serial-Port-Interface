using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Documents;
using System.Windows.Controls;
using System.Xaml;
using System.Runtime.InteropServices;

namespace Temperature_Forms
{
    public partial class TemperatureReadingForm : Form
    {
        static SerialPort serialPort = new SerialPort();
        string dataIn;

        public TemperatureReadingForm()
        {
            InitializeComponent();

            cbPorts.Items.Add("COM1");
            cbPorts.Items.Add("COM2");
            cbPorts.Items.Add("COM3");
            cbPorts.Items.Add("COM4");
            cbPorts.Items.Add("COM5");

            cbBaudRate.Items.Add(300);
            cbBaudRate.Items.Add(600);
            cbBaudRate.Items.Add(1200);
            cbBaudRate.Items.Add(2400);
            cbBaudRate.Items.Add(9600);
            cbBaudRate.Items.Add(14400);
            cbBaudRate.Items.Add(19200);
            cbBaudRate.Items.Add(38400);
            cbBaudRate.Items.Add(57600);
            cbBaudRate.Items.Add(115200);
            cbBaudRate.Items.ToString();

            cbParity.Items.Add("None");
            cbParity.Items.Add("Even");
            cbParity.Items.Add("Odd");

            cbStopBits.Items.Add("One");
            cbStopBits.Items.Add("Two");

            cbDataBits.Items.Add(8);
            cbDataBits.Items.Add(16);

        }

        private void btnDataClick(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.DataReceived += new SerialDataReceivedEventHandler(Data_Received);
            }
        }

        private void Data_Received(object sender, SerialDataReceivedEventArgs e)
        {
            dataIn = serialPort.ReadExisting();
            this.Invoke(new EventHandler(SetText));
            this.Invoke(new EventHandler(SetActualValues));
        }

        private void SetText(object sender, EventArgs e)
        {
            rtbIncomingData.AppendText(dataIn);
        }

        private void SetActualValues(object sender, EventArgs e)
        {
                 for (int i = 0; i<rtbIncomingData.Lines.Length; i++)
            {
                string str = rtbIncomingData.Lines[i];
                if (str.Contains("d"))
                {
                    tBDate.Text = str.Substring(1).TrimEnd(';');
                }
                else if (str.Contains("t"))
                {
                    tBTime.Text = str.Substring(1).TrimEnd(';');
                }
                else if (str.Contains("u"))
                {
                    tBMicroTemperature.Text = str.Substring(1).TrimEnd(';');
                }
                else if (str.Contains("a"))
                {
                    tBAccelerometer.Text = str.Substring(1).TrimEnd(';');
                }
                str = String.Empty;
            }
        }
            //using (var fs = new FileStream(@"C:\Users\pati\Desktop\test.txt", FileMode.Truncate, FileAccess.Write, FileShare.ReadWrite))
            //{
            //    using (var writer = new StreamWriter(fs, Encoding.GetEncoding(28591)))
            //    {
            //        for (int i = 0; i < rtbIncomingData.Lines.Length; i++)
            //        {
            //            writer.WriteLine(rtbIncomingData.Lines[i]);
            //        }
            //        writer.Flush();
            //    }
            //}

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.PortName = Convert.ToString(cbPorts.Text);
                serialPort.BaudRate = Convert.ToInt32(cbBaudRate.Text);
                serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), cbParity.Text);
                serialPort.DataBits = Convert.ToInt16(cbDataBits.Text);
                serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbStopBits.Text);

                cbPorts.Enabled = false;
                cbParity.Enabled = false;
                cbStopBits.Enabled = false;
                cbDataBits.Enabled = false;
                cbBaudRate.Enabled = false;

                serialPort.ReadTimeout = 500;
                serialPort.WriteTimeout = 500;
                serialPort.Open();
                progressBar.Value = 100;
                rtbIncomingData.ReadOnly = false;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                progressBar.Value = 0;
                rtbIncomingData.ReadOnly = true; 
            }

            rtbIncomingData.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            rtbIncomingData.Enabled = true;
            cbPorts.Enabled = true;
        }

        private void rtbIncomingData_TextChanged(object sender, EventArgs e)
        {
            rtbIncomingData.SelectionStart = rtbIncomingData.Text.Length;
            rtbIncomingData.ScrollToCaret();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbIncomingData.Clear();
            tBDate.Clear();
            tBTime.Clear();
            tBMicroTemperature.Clear();
            tBAccelerometer.Clear();
        }

        private void TemperatureReadingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.DiscardOutBuffer();
                serialPort.DiscardInBuffer();
                serialPort.Close();
            }
            Application.Exit();
        }
    }
}

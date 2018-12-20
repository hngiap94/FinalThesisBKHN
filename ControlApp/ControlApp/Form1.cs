using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace ControlApp
{
    public partial class Form1 : Form
    {
        string dataInput;

        public Form1()
        {
            InitializeComponent();
            ResetControlApp();
        }

        /// <summary>
        /// Event when port combobox is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// created by hngiap
        private void portComboBox_Click(object sender, EventArgs e)
        {
            portComboBox.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            portComboBox.Items.AddRange(ports);
        }

        /// <summary>
        /// Event when button "Connect" is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// created by hngiap
        private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (portComboBox.Text == "" || baudrateComboBox.Text == "")
                {
                    MessageBox.Show("Please choose Port and Baud Rate to continue!");
                }
                else
                {
                    RFserialPort.PortName = portComboBox.Text;
                    RFserialPort.BaudRate = Convert.ToInt32(baudrateComboBox.Text);
                    RFserialPort.Open();
                    connectBtn.Enabled = false;
                    disconnectBtn.Enabled = true;
                    connectionStatusTextBox.Text = "Connected!";
                    connectionStatusTextBox.BackColor = Color.Green;
                    automaticModeBtn.Enabled = true;
                    manualControlBox.Enabled = true;
                    workingStatusTextBox.Text = "Manual Control Mode!";
                    batteryStatusProgressBar.Value = 60;
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Some errors occuured. Please try again!");
            }
        }

        /// <summary>
        /// Event when button "Disconnect" is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// created by hngiap
        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                RFserialPort.Close();
                //RFserialPort.Write("M");
                ResetControlApp();
                //RFserialPort.Write("S");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Some errors occuured. Please try again!");
            }
        }

        /// <summary>
        /// Event when RF module received a message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// created by hngiap
        private void RFserialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataInput = RFserialPort.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        /// <summary>
        /// Function to show received data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// created by hngiap
        private void ShowData(object sender, EventArgs e)
        {
            serialResponseTextBox.Text = dataInput;
        }

        #region Manual control functions

        private void forwardBtn_MouseDown(object sender, MouseEventArgs e)
        {
            RFserialPort.Write("F");
        }

        private void forwardBtn_MouseUp(object sender, MouseEventArgs e)
        {
            RFserialPort.Write("S");
        }

        private void backwardBtn_MouseDown(object sender, MouseEventArgs e)
        {
            RFserialPort.Write("B");
        }

        private void backwardBtn_MouseUp(object sender, MouseEventArgs e)
        {
            RFserialPort.Write("S");
        }

        private void turnLeftBtn_MouseDown(object sender, MouseEventArgs e)
        {
            RFserialPort.Write("L");
        }

        private void turnLeftBtn_MouseUp(object sender, MouseEventArgs e)
        {
            RFserialPort.Write("S");
        }

        private void turnRightBtn_MouseDown(object sender, MouseEventArgs e)
        {
            RFserialPort.Write("R");
        }

        private void turnRightBtn_MouseUp(object sender, MouseEventArgs e)
        {
            RFserialPort.Write("S");
        }

        #endregion

        /// <summary>
        /// Event when button "Manual Mode" is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// created by hngiap
        private void manualModeBtn_Click(object sender, EventArgs e)
        {
            RFserialPort.Write("M");
            manualModeBtn.Enabled = false;
            manualControlBox.Enabled = true;
            automaticModeBtn.Enabled = true;
            automaticControlBox.Enabled = false;
            randomWalkBtn.Enabled = false;
            wallFollowBtn.Enabled = true;
            workingStatusTextBox.Text = "Automatic: Random Walk!";
            RFserialPort.Write("S");
        }

        /// <summary>
        /// Event when button "Automatic Mode" is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// created by hngiap
        private void automaticModeBtn_Click(object sender, EventArgs e)
        {
            RFserialPort.Write("A");
            manualModeBtn.Enabled = true;
            manualControlBox.Enabled = false;
            automaticModeBtn.Enabled = false;
            automaticControlBox.Enabled = true;
            randomWalkBtn.Enabled = false;
            wallFollowBtn.Enabled = true;
            workingStatusTextBox.Text = "Automatic: Random Walk!";
        }

        /// <summary>
        /// Event when button "Random Walk Mode" is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// created by hngiap
        private void randomWalkBtn_Click(object sender, EventArgs e)
        {
            RFserialPort.Write("D");
            randomWalkBtn.Enabled = false;
            wallFollowBtn.Enabled = true;
            workingStatusTextBox.Text = "Automatic: Random Walk!";
        }

        /// <summary>
        /// Event when button "Wall Follow Mode" is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// created by hngiap
        private void wallFollowBtn_Click(object sender, EventArgs e)
        {
            RFserialPort.Write("W");
            randomWalkBtn.Enabled = true;
            wallFollowBtn.Enabled = false;
            workingStatusTextBox.Text = "Automatic: Wall Follow!";
        }

        /// <summary>
        /// Function to reset the App state
        /// </summary>
        /// created by hngiap
        public void ResetControlApp()
        {
            manualModeBtn.Enabled = false;
            automaticModeBtn.Enabled = false;
            manualControlBox.Enabled = false;
            automaticControlBox.Enabled = false;
            connectionStatusTextBox.BackColor = Color.Red;
            connectionStatusTextBox.Text = "Disconnected!";
            baudrateComboBox.SelectedIndex = 0;
            connectBtn.Enabled = true;
            disconnectBtn.Enabled = false;
            serialResponseTextBox.Text = "";
            batteryStatusProgressBar.Value = 0;
            workingStatusTextBox.Text = "Offline!";
        }
    }
}
/* List of command:
        M: enable manual control
        A: automatic mode
        F: run foward
        B: run backward
        R: turn right
        L: turn left
        S: stop
        Z: zigzag mode
        D: random mode
        W: wall follow mode
*/

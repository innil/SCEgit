using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaqSimulator
{

    public partial class Form1 : Form
    {

        double samplingTime = 2.7;
        double logTime = 16.0;
        double highvalue;
        double lowValue;

        int counter;
        int noAnalogSensors;
        int noDigitalSensors;
        string sTxtAn, sTxtDig;

        Sensor[] sensorArray;
        Sensor[] digSensorArray;
        

        public Form1()
        {
            InitializeComponent();

            highvalue = Convert.ToDouble(txtHighValue.Text);
            lowValue = Convert.ToDouble(txtLowValue.Text);
            noAnalogSensors = Convert.ToInt32(txtAnalogSensors.Text);
            noDigitalSensors = Convert.ToInt32(txtDigSensors.Text);

            sensorArray = new Sensor[noAnalogSensors];

            for (counter = 0; counter < noAnalogSensors; counter++)
            {
                sensorArray[counter] = new Sensor(counter);
            }

            digSensorArray = new Sensor[noDigitalSensors];
            for (counter = 0; counter < noDigitalSensors; counter++)
            {
                digSensorArray[counter] = new Sensor(counter);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmSampling.Start();
            tmLog.Start();

        }


        private void tmSampling_Tick(object sender, EventArgs e)
        {
            if (samplingTime > 0.0)
            {
                samplingTime -= 0.1;
            }
            else
            {
                tmSampling.Stop();
            }

            txtSamplingTime.Text = Convert.ToString(Math.Round(samplingTime, 1));

        }

        private void tmLog_Tick(object sender, EventArgs e)
        {
            if (logTime > 0.0)
            {
                logTime -= 1.0;
            }
            else
            {
                tmLog.Stop();
            }

            txtLogTime.Text = Convert.ToString(Math.Round(logTime, 1));
        }

        private void Button_LogToFile_Click(object sender, EventArgs e)
        {

            if (logTime < 0.1)
            {
                using (System.IO.StreamWriter write = new System.IO.StreamWriter(@"C:\Users\Linn-Ingrid\Documents\Skole\SCE\Vår 2016\Object oriented analysis\Assignment 1\Log.txt", true))
                {
                    write.Write("Log.txt" + write.NewLine + write.NewLine);
                    write.Write("Analog sensor devices" + write.NewLine);
                    write.Write(sTxtAn + write.NewLine);
                    write.Write("Digital sensor devices");
                    write.Write(sTxtDig + write.NewLine);
                }

                txtSensValues.Text = null;
                logTime = 16.0;
                tmLog.Start();
            }

            else
            {
                MessageBox.Show("Please wait for logging time to count down", "Info", System.Windows.Forms.MessageBoxButtons.OK);

            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application for sampling and logging of sensor values", "About",
                System.Windows.Forms.MessageBoxButtons.OK);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSample_Click_1(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtAnalogSensors.Text)|| string.IsNullOrWhiteSpace(txtDigSensors.Text)||
                string.IsNullOrWhiteSpace(txtLowValue.Text) || string.IsNullOrWhiteSpace(txtHighValue.Text))
            {
                MessageBox.Show("Please input valus in all input textboxes", "Missing input values!",
                    System.Windows.Forms.MessageBoxButtons.OK);
            }
                else
            {

                if (samplingTime < 0.1)
                {
                    sTxtAn = "";
                    sTxtDig = "";
                   

                    for (counter = 0; counter < noAnalogSensors; counter++)
                    {

                        sTxtAn = sTxtAn + sensorArray[counter].GetsSensNo() + "     " +
                            sensorArray[counter].GetValue(highvalue, lowValue).ToString("F3") +
                            "       " + DateTime.Now + System.Environment.NewLine;

                    }

                    for (counter = 0; counter < noDigitalSensors; counter++)
                    {
                        sTxtDig = sTxtDig + digSensorArray[counter].GetsSensNo() + "        " +
                            digSensorArray[counter].GetValue().ToString() +
                            "           " + DateTime.Now + System.Environment.NewLine;
                    }


                    txtSensValues.Text = sTxtAn + sTxtDig;

                    samplingTime = 2.7;
                    tmSampling.Start();                   

                }
                else
                {
                    MessageBox.Show("Please wait for sampling time to count down", "Info", System.Windows.Forms.MessageBoxButtons.OK);
                }
            }       
        }
    }

    class Sensor
    {
        double sensValue;
        int sensorNumber;
        Random rnd;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="number">The sensor number in the array</param>
        public Sensor(int number)
        {
            sensorNumber = number;
            rnd = new Random(number);
            sensValue = 0.0F;
        }



        /// <summary>
        /// Sets a random sensor value in given range
        /// </summary>
        /// <param name="highRange">max value in given range</param>
        /// <param name="lowRange">min value in given range</param>
        /// <returns>returns the sensors value</returns>
        public double GetValue(double highRange, double lowRange)
        {
            sensValue = rnd.NextDouble() * (highRange - lowRange) + lowRange;
            return sensValue;
        }

        /// <summary>
        /// Sets a random sensor value of 1 or 0
        /// </summary>
        /// <returns>returns the sensors value</returns>
        public double GetValue()
        {
            sensValue = Convert.ToDouble(rnd.Next(2));
            return sensValue;
        }

        /// <summary>
        /// Gets the sensors number/id in the array
        /// </summary>
        /// <returns>returns the sensor number</returns>
        public int GetsSensNo()
        {
            return sensorNumber;
        }
    }


}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Utils;
using NAudio.Wave;
using NAudio.CoreAudioApi;
using System.IO;

namespace Vernam_Crypto_Tool
{
    public partial class Form2 : Form
    {
        public WaveIn waveSource = null;
        public WaveFileWriter waveFile = null;

        public string wavOutput;
        private int seconds;

        public Form2()
        {
            InitializeComponent();

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.Items.Clear();
            toolStripButton1.Enabled = false;
            toolStripButton2.Enabled = false;

            for (int n = 0; n < WaveIn.DeviceCount; n++)
            {
                var caps = WaveIn.GetCapabilities(n);
                toolStripComboBox1.Items.Add(n + ":" + caps.ProductName);
                Console.WriteLine($"{n}: {caps.ProductName}");
            }

            if (toolStripComboBox1.Items.Count > 0)
            {
                toolStripComboBox1.SelectedIndex = 0;
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            toolStripButton1.Enabled = false;
            toolStripButton2.Enabled = false;
            stopRec();
        }

        private void Log(string s)
        {
            rtb2.Text += s + "\n";
            rtb2.SelectionStart = rtb2.Text.Length;
            rtb2.ScrollToCaret();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SaveFileDialog d = new SaveFileDialog();
            d.Filter = "wav Audio files (*.wav)|*.wav";
            string stamp = DateTime.Now.ToShortDateString() + "_" + DateTime.Now.ToLongTimeString() + "_";
            stamp = stamp.Replace(".", "_");
            stamp = stamp.Replace(":", "_");
            d.FileName = stamp + "_key_" + ".wav";
            if (d.ShowDialog() == DialogResult.OK)
            {
                wavOutput = d.FileName;
                Log("Save " + d.FileName + " as output WAV file.");
                toolStripButton1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            toolStripLabel3.Text = seconds.ToString();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            toolStripButton2.Enabled = true;
            int n = toolStripComboBox1.SelectedIndex;
            startRec(n, wavOutput);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            stopRec();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        void startRec(int device, string file)
        {
            waveSource = new WaveIn() { DeviceNumber = device };
            waveSource.WaveFormat = new WaveFormat(44100, 1);

            waveSource.DataAvailable += new EventHandler<WaveInEventArgs>(waveSource_DataAvailable);
            waveSource.RecordingStopped += new EventHandler<StoppedEventArgs>(waveSource_RecordingStopped);

            waveFile = new WaveFileWriter(file, waveSource.WaveFormat);

            waveSource.StartRecording();
        }

        void stopRec()
        {
            waveSource.StopRecording();
        }

        void waveSource_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (waveFile != null)
            {
                waveFile.Write(e.Buffer, 0, e.BytesRecorded);
                waveFile.Flush();
            }
        }

        void waveSource_RecordingStopped(object sender, StoppedEventArgs e)
        {
            if (waveSource != null)
            {
                waveSource.Dispose();
                waveSource = null;
            }

            if (waveFile != null)
            {
                waveFile.Dispose();
                waveFile = null;
            }
        }




    }
}

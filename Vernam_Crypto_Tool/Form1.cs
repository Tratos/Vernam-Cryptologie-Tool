using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Be.Windows.Forms;

namespace Vernam_Crypto_Tool
{
    public partial class Form1 : Form
    {
        public byte[] dataEncrypt, dataDecrypt, wavInput;
        public string dEncrypt, dDecrypt, dwav;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Log(string s)
        {
            rtb1.Text += s + "\n";
            rtb1.SelectionStart = rtb1.Text.Length;
            rtb1.ScrollToCaret();
        }

        private void generateWAVFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "wav Audio files (*.wav)|*.wav";
            if (d.ShowDialog() == DialogResult.OK)
            {
                wavInput = File.ReadAllBytes(d.FileName);
                hb2.ByteProvider = new DynamicByteProvider(wavInput);
                dwav = d.FileName;
                Log("Loaded " + wavInput.Length + " bytes as input WAV file from " + d.FileName);
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "All files (*.*)|*.*";
            if (d.ShowDialog() == DialogResult.OK)
            {
                dataDecrypt = File.ReadAllBytes(d.FileName);
                hb2.ByteProvider = new DynamicByteProvider(dataDecrypt);
                dDecrypt = d.FileName;
                Log("Loaded " + dataDecrypt.Length + " bytes as Decrypt file from " + d.FileName);
            }
        }

        private void decryptTheFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog d = new SaveFileDialog();
            d.Filter = "All files (*.*)|*.*";
            string stamp = DateTime.Now.ToShortDateString() + "_" + DateTime.Now.ToLongTimeString() + "_";
            stamp = stamp.Replace(".", "_");
            stamp = stamp.Replace(":", "_");
            d.FileName = stamp + "_decrypt_";

            if (d.ShowDialog() == DialogResult.OK)
            {
                string filename = d.FileName;
                cryptFile(dDecrypt, dwav, filename);
            }
        }

        private void generateWAVFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void encryptTheFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog d = new SaveFileDialog();
            d.Filter = "All files (*.*)|*.*";
            string stamp = DateTime.Now.ToShortDateString() + "_" + DateTime.Now.ToLongTimeString() + "_";
            stamp = stamp.Replace(".", "_");
            stamp = stamp.Replace(":", "_");
            d.FileName = stamp + "_encrypt_";

            if (d.ShowDialog() == DialogResult.OK)
            {
                string filename = d.FileName;
                cryptFile(dEncrypt, dwav, filename);
            }
        }

        private void loadWAVFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "wav Audio files (*.wav)|*.wav";
            if (d.ShowDialog() == DialogResult.OK)
            {
                wavInput = File.ReadAllBytes(d.FileName);
                hb2.ByteProvider = new DynamicByteProvider(wavInput);
                dwav = d.FileName;
                Log("Loaded " + wavInput.Length + " bytes as input WAV file from " + d.FileName);
            }
        }

        private void openSourceFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "All files (*.*)|*.*";
            if (d.ShowDialog() == DialogResult.OK)
            {
                dataEncrypt = File.ReadAllBytes(d.FileName);
                hb1.ByteProvider = new DynamicByteProvider(dataEncrypt);
                dEncrypt = d.FileName;
                Log("Loaded " + dataEncrypt.Length + " bytes as Enrypt file from " + d.FileName);
            }
        }

        private void cryptFile(string DataStream, string WAVStream, string OutStream)
        {
            byte[] dataCount = File.ReadAllBytes(DataStream);
            byte[] dataWAVES = File.ReadAllBytes(WAVStream);

            if (dataCount.Length < dataWAVES.Length)
            {
                try
                {
                    using (FileStream inStream = new FileStream(DataStream, FileMode.Open))
                    using (FileStream waveStream = new FileStream(WAVStream, FileMode.Open))
                    using (FileStream outStream = new FileStream(OutStream, FileMode.Create))
                    {
                        waveStream.Position = 100000;


                        int reading = inStream.ReadByte();
                        while (reading != -1)
                        {
                            waveStream.ReadByte();
                            int w = waveStream.ReadByte();
                            int a = reading ^ w;

                            outStream.WriteByte((byte)a);
                            reading = inStream.ReadByte();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Log("Error: " + ex.Message);
                }
            }
            else
            {
                Log("Error: WAV File to Small...");
            }
            
        }

    }
}

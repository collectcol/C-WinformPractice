using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;

namespace sin_WavPlayer
{
    public partial class Form1 : Form
    {
        Thread PlayThre = null;

        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("winmm.DLL")]
        public static extern bool PlaySound(string szSound, System.IntPtr hMod, PlaySoundFlags flags);

        public enum PlaySoundFlags : int
        {
            SND_SYNC = 0x0000,
            SND_ASYNC = 0x0001,
            SND_NODEFAULT = 0x0002,
            SND_LOOP = 0x0008,
            SND_NOSTOP = 0x0010,
            SND_NOWAIT = 0x00002000,
            SND_FILENAME = 0x00020000,
            SND_RESOURCE = 0x00040004
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if (this.ofdFile.ShowDialog() == DialogResult.OK)
            {
                this.txtPath.Text = this.ofdFile.FileName;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(this.txtPath.Text);
            if (fi.Exists == true)
            {
                PlayThre = new Thread(new ParameterizedThreadStart(PlaySoundRun));
                PlayThre.Start(this.txtPath.Text);
            }
            else
            {
                MessageBox.Show("실행할 Wav 파일이 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PlaySoundRun(object o)
        {
            string FilePath = (string)o;
            PlaySound(FilePath, new System.IntPtr(), PlaySoundFlags.SND_SYNC);
            PlayThre.Abort();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PlayThre != null)
            {
                PlayThre.Abort();
            }
        }
    }
}

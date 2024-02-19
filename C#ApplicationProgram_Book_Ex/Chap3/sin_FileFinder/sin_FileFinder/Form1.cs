using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace sin_FileFinder
{
    public partial class Form1 : Form
    {
        Thread threadFileView = null;
        private CancellationTokenSource cancellationTokenSource = null;
        private Task fileViewTask = null;

        private delegate void OnDelegateFile(string fn, string fl, string fc, bool flag);
        private OnDelegateFile OnFile = null;
        bool Flag01 = true;
        bool Flag02 = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OnFile = new OnDelegateFile(FileResult);
        }

        private void FileResult(string fn, string fl, string fc, bool flag)
        {
            if (flag)
            {
                string fSize = GetFileSize(Convert.ToDouble(fl));
                FileInfo fi = new FileInfo(fn);
                this.lvFile.Items.Add(new ListViewItem(new string[] {fi.DirectoryName, fi.Name, fSize}));
            }
            else
            {
                this.lvFile.Items.Add(new ListViewItem(new string[] { fn, "", fc, "" }));
            }
        }

        private string GetFileSize(double byteCount) 
        {
            string size = "0 Bytes";
            if (byteCount >= 1073741824.0)
            {
                size = String.Format("{0:##.##}", byteCount / 1073741824.0) + " GB";
            }
            else if (byteCount >= 1048576.0)
            {
                size = String.Format("{0:##.##}", byteCount / 1048576.0) + " MB";
            }
            else if (byteCount >= 1024.0)
            {
                size = String.Format("{0:##.##}", byteCount / 1024.0) + " KB";
            }
            else if (byteCount > 0 && byteCount < 1024.0)
            {
                size = byteCount.ToString() + " Bytes";
            }

            return size;
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            if (this.fbdFolder.ShowDialog() == DialogResult.OK)
            {
                this.lvFile.Items.Clear();
                this.txtPath.Text = this.fbdFolder.SelectedPath;

                cancellationTokenSource = new CancellationTokenSource();
                fileViewTask = Task.Factory.StartNew(() => FileView(this.fbdFolder.SelectedPath, cancellationTokenSource.Token), cancellationTokenSource.Token);
            }
        }

        private void FileView(string path, CancellationToken cancellationToken)
        {
            DirectoryInfo di = new DirectoryInfo((string)path);
            DirectoryInfo[] dti = di.GetDirectories();

            if (Flag02)
            {
                foreach (var f in di.GetFiles())
                {
                    if (cancellationToken.IsCancellationRequested)
                        break;

                    if (Flag01 || f.Attributes.ToString().Contains(FileAttributes.Hidden.ToString()))
                    {
                        Invoke(OnFile, f.FullName, f.Length.ToString(), f.CreationTime.ToString(), Flag02);
                    }
                }
            }
            else
            {
                if (Flag01 || di.Attributes.ToString().Contains(FileAttributes.Hidden.ToString()))
                {
                    Invoke(OnFile, path, "", di.CreationTime.ToString(), Flag02);
                }
            }

            foreach (var subdir in dti)
            {
                if (cancellationToken.IsCancellationRequested)
                    break;

                try
                {
                    FileView(subdir.FullName, cancellationToken);
                }
                catch
                {
                    continue;
                }

            }
        }

        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            Flag01 = true;
            if (cancellationTokenSource != null)
            {
                cancellationTokenSource.Cancel();
            }

            if (this.txtPath.Text != "")
            {
                this.lvFile.Items.Clear();
                cancellationTokenSource = new CancellationTokenSource();
                fileViewTask = Task.Factory.StartNew(() => FileView(this.fbdFolder.SelectedPath, cancellationTokenSource.Token), cancellationTokenSource.Token);
            }
        }

        private void rbtnHidden_CheckedChanged(object sender, EventArgs e)
        {
            Flag01 = false;
            if (cancellationTokenSource != null)
            {
                cancellationTokenSource.Cancel(); 
            }

            if (this.txtPath.Text != "")
            {
                this.lvFile.Items.Clear();
                cancellationTokenSource = new CancellationTokenSource();
                fileViewTask = Task.Factory.StartNew(() => FileView(this.fbdFolder.SelectedPath, cancellationTokenSource.Token), cancellationTokenSource.Token);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cancellationTokenSource != null)
            {
                cancellationTokenSource.Cancel(); 
            }
        }

        private void rbtnDire_CheckedChanged(object sender, EventArgs e)
        {
            Flag02 = false;
        }

        private void rbtnFile_CheckedChanged(object sender, EventArgs e)
        {
            Flag02 = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (fileViewTask != null && fileViewTask.Status == TaskStatus.Running)
            {
                if (cancellationTokenSource != null)
                {
                    cancellationTokenSource.Cancel();
                    MessageBox.Show("중지되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("현재 작업이 실행 중이 아닙니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

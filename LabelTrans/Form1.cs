using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;

namespace LabelTrans
{
    public partial class Form1 : Form
    {
        public string originpath;
        public string datapath;
        public int ii = 0;

        delegate void SetValueCallback(int value);
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonopen_Click(object sender, EventArgs e)
        {
            //选定数据集文件夹
            try
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.ShowNewFolderButton = false;
                folderBrowserDialog.SelectedPath = @"D:\资料\库\数据集\VisDrone";
                folderBrowserDialog.Description = "请选择存放数据集的文件夹";
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    originpath = folderBrowserDialog.SelectedPath;
                    datapath = Path.Combine(folderBrowserDialog.SelectedPath, "annotations");
                    string[] files = Directory.GetFiles(datapath);
                    output("已选定" + files.Length.ToString() + "个文件。");
                }
                progressBar.BeginInvoke(new Action(() => { 
                    progressBar.Value = 0;
                    progressBar.Step = 1;
                    progressBar.Style = ProgressBarStyle.Continuous;
                }));
            }
            catch (Exception ex)
            {
                output(ex.Message);
            }
        }

        private void buttondo_Click(object sender, EventArgs e)
        {
            //启动转换线程
            ThreadStart start = new ThreadStart(Do);
            Thread thread = new Thread(start);
            thread.Start();
        }

        public void Do()
        {
            //转换函数
            try
            {
                Trans trans = new Trans();
                XmlDocument xd = new XmlDocument();
                xd.AppendChild(xd.CreateXmlDeclaration("1.0", "ISO-8859-1", ""));
                XmlElement root = xd.CreateElement("dataset");
                xd.AppendChild(root);
                XmlElement name = xd.CreateElement("name");
                name.InnerText = "Visdrone";
                root.AppendChild(name);
                XmlElement com = xd.CreateElement("comment");
                com.InnerText = "Made by Lilingze.";
                root.AppendChild(com);
                XmlElement tasks = xd.CreateElement("images");
                root.AppendChild(tasks);
                string[] files = Directory.GetFiles(datapath);
                progressBar.BeginInvoke(new Action(() =>
                {
                    progressBar.Maximum = files.Length;
                            }));
                for (int i = 0; i < files.Length; i++)
                {
                    trans.Txttrans(xd, tasks, files[i]);
                    output(Path.GetFileName(files[i]) + "已转换。");
                    ii = i;
                    SetProcessBarValue(i);
                }
                progressBar.BeginInvoke(new Action(() => { 
                    progressBar.Value = progressBar.Maximum;
                }));
                xd.Save(Path.Combine(originpath, textBoxfilename.Text + ".xml"));
                output("转换结束。" + ii.ToString() + "个文件已转换。已保存到" + textBoxfilename.Text + ".xml。");
            }
            catch (Exception ex)
            {
                output(ex.Message);
            }
        }

        public void output(string str)
        {
            //输出信息
            textBoxinfo.BeginInvoke(new Action(() =>
            {
                textBoxinfo.AppendText(str + "\r\n");
                textBoxinfo.ScrollToCaret();
            }));
        }

        private void SetProcessBarValue(int value)
        {
            //改变进度条的委托
            if (this.progressBar.InvokeRequired)
            {
                SetValueCallback d = new SetValueCallback(SetProcessBarValue);
                this.Invoke(d, new object[] { value });
            }
            else
            {
                this.progressBar.Value = value;
            }
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            //退出
            if (MessageBox.Show("是否退出？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
                Process.GetCurrentProcess().Kill();
            }
        }
    }
}

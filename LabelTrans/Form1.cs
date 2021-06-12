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
        public int type = 0;
        public bool isignore = false;
        public string[] ignores = new string[0];

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
            CheckType();
            ThreadStart start = new ThreadStart(Do);
            Thread thread = new Thread(start);
            thread.Start();
        }

        public void Do()
        {
            //转换函数
            try
            {
                if (type != 0)
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
                    int ignore = 0;
                    int s = 0;
                    int z = 0;
                    for (int i = 0; i < files.Length; i++)
                    {
                        if (isignore)
                        {
                            if (CheckIgnore("images/" + Path.GetFileNameWithoutExtension(files[i]) + ".jpg")) 
                            {
                                output(Path.GetFileName(files[i]) + "已忽略。");
                                ignore++;
                            }
                            else
                            {
                               string info = trans.Txttrans(xd, tasks, files[i], type);
                                if (info == "ok") 
                                {
                                    output(Path.GetFileName(files[i]) + "已转换。");
                                }
                                else if(info == "zero")
                                {
                                    z++;
                                    output(Path.GetFileName(files[i]) + "不包含该标签，已跳过。");
                                }
                                else
                                {
                                    string[] tmp = info.Split(':');
                                    int small = Convert.ToInt32(tmp[1]);
                                    s += small;
                                    output(Path.GetFileName(files[i]) + "已转换。其中有" + small.ToString() + "个不合格的标注已忽略。");
                                }
                            }
                        }
                        else
                        {
                            string info = trans.Txttrans(xd, tasks, files[i], type);
                            if (info == "ok")
                            {
                                output(Path.GetFileName(files[i]) + "已转换。");
                            }
                            else if (info == "zero")
                            {
                                z++;
                                output(Path.GetFileName(files[i]) + "不包含该标签，已跳过。");
                            }
                            else
                            {
                                string[] tmp = info.Split(':');
                                int small = Convert.ToInt32(tmp[1]);
                                s += small;
                                output(Path.GetFileName(files[i]) + "已转换。其中有" + small.ToString() + "个不合格的标注已忽略。");
                            }
                        }
                        ii = i;
                        SetProcessBarValue(i);
                    }
                    progressBar.BeginInvoke(new Action(() =>
                    {
                        progressBar.Value = progressBar.Maximum;
                    }));
                    if(File.Exists(Path.Combine(originpath, textBoxfilename.Text + ".xml")))
                    { 
                        File.Delete(Path.Combine(originpath, textBoxfilename.Text + ".xml"));
                    }
                    xd.Save(Path.Combine(originpath, textBoxfilename.Text + ".xml"));
                    if (isignore)
                    {
                        output("转换结束。" + (ii - ignore - z).ToString() + "个文件已转换。" + ignore.ToString() + "个文件已忽略。已跳过" + z.ToString() + "个不包含该标签的文件。" +
                            s.ToString() + "个不合格的标注已忽略。\r\n已保存到" + textBoxfilename.Text + ".xml。");
                    }
                    else
                    {
                        output("转换结束。" + (ii - z).ToString() + "个文件已转换。已跳过" + z.ToString() + "个不包含该标签的文件。" +
                            s.ToString() + "个不合格的标注已忽略。\r\n已保存到" + textBoxfilename.Text + ".xml。");
                    }
                }
                else
                {
                    MessageBox.Show("请选择要转换的标签类型！");
                }
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

        public void CheckType()
        {
            //确定要转换的标签
            switch (comboBox1.SelectedItem.ToString())
            {
                case "行人":
                    type = 1;
                    break;
                case "车上的人":
                    type = 2;
                    break;
                case "自行车":
                    type = 3;
                    break;
                case "汽车":
                    type = 4;
                    break;
                case "卡车":
                    type = 6;
                    break;
                case "三轮车":
                    type = 7;
                    break;
                case "公交车":
                    type = 9;
                    break;
                case "摩托车":
                    type = 10;
                    break;
                case "全部":
                    type = 999;
                    break;
            }
            output("标签的类型为" + comboBox1.SelectedItem.ToString() + "，序号为" + type.ToString() + "。");
        }

        private void buttonignore_Click(object sender, EventArgs e)
        {
            //载入忽略文件列表
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "文本文件(*.txt)|*.txt";
            int count = 0;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        count++;
                        Array.Resize(ref ignores, count);
                        ignores[count - 1] = sr.ReadLine().Trim();
                    }
                }
                output("ignore文件载入完成。");
                isignore = true;
            }
        }

        public bool CheckIgnore(string file)
        {
            //检查是否忽略文件
            foreach(var ignore in ignores)
            {
                if (file == ignore)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

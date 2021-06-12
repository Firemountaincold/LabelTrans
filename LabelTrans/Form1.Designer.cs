
namespace LabelTrans
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxinfo = new System.Windows.Forms.TextBox();
            this.buttonopen = new System.Windows.Forms.Button();
            this.buttondo = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxfilename = new System.Windows.Forms.TextBox();
            this.buttonignore = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxinfo
            // 
            this.textBoxinfo.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxinfo.Location = new System.Drawing.Point(16, 88);
            this.textBoxinfo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxinfo.Multiline = true;
            this.textBoxinfo.Name = "textBoxinfo";
            this.textBoxinfo.ReadOnly = true;
            this.textBoxinfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxinfo.Size = new System.Drawing.Size(582, 288);
            this.textBoxinfo.TabIndex = 0;
            // 
            // buttonopen
            // 
            this.buttonopen.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonopen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonopen.Location = new System.Drawing.Point(19, 21);
            this.buttonopen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonopen.Name = "buttonopen";
            this.buttonopen.Size = new System.Drawing.Size(94, 20);
            this.buttonopen.TabIndex = 1;
            this.buttonopen.Text = "选择文件夹";
            this.buttonopen.UseVisualStyleBackColor = false;
            this.buttonopen.Click += new System.EventHandler(this.buttonopen_Click);
            // 
            // buttondo
            // 
            this.buttondo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttondo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttondo.Location = new System.Drawing.Point(503, 21);
            this.buttondo.Margin = new System.Windows.Forms.Padding(2);
            this.buttondo.Name = "buttondo";
            this.buttondo.Size = new System.Drawing.Size(94, 20);
            this.buttondo.TabIndex = 1;
            this.buttondo.Text = "开始转换";
            this.buttondo.UseVisualStyleBackColor = false;
            this.buttondo.Click += new System.EventHandler(this.buttondo_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(16, 381);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(581, 18);
            this.progressBar.TabIndex = 2;
            // 
            // buttonexit
            // 
            this.buttonexit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonexit.Location = new System.Drawing.Point(503, 54);
            this.buttonexit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(94, 20);
            this.buttonexit.TabIndex = 3;
            this.buttonexit.Text = "退出软件";
            this.buttonexit.UseVisualStyleBackColor = false;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "生成文件名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = ".xml";
            // 
            // textBoxfilename
            // 
            this.textBoxfilename.Location = new System.Drawing.Point(368, 21);
            this.textBoxfilename.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxfilename.Name = "textBoxfilename";
            this.textBoxfilename.Size = new System.Drawing.Size(85, 21);
            this.textBoxfilename.TabIndex = 5;
            this.textBoxfilename.Text = "train";
            this.textBoxfilename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonignore
            // 
            this.buttonignore.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonignore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonignore.Location = new System.Drawing.Point(19, 54);
            this.buttonignore.Name = "buttonignore";
            this.buttonignore.Size = new System.Drawing.Size(94, 20);
            this.buttonignore.TabIndex = 6;
            this.buttonignore.Text = "载入ignore";
            this.buttonignore.UseVisualStyleBackColor = false;
            this.buttonignore.Click += new System.EventHandler(this.buttonignore_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "行人",
            "车上的人",
            "自行车",
            "汽车",
            "卡车",
            "三轮车",
            "公交车",
            "摩托车",
            "全部"});
            this.comboBox1.Location = new System.Drawing.Point(190, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 20);
            this.comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "选择类别：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(613, 407);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonignore);
            this.Controls.Add(this.textBoxfilename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.buttondo);
            this.Controls.Add(this.buttonopen);
            this.Controls.Add(this.textBoxinfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LabelTrans";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxinfo;
        private System.Windows.Forms.Button buttonopen;
        private System.Windows.Forms.Button buttondo;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxfilename;
        private System.Windows.Forms.Button buttonignore;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}


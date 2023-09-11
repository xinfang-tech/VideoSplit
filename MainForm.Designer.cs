namespace VideoSplit
{
    partial class MainForm
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
            this.fileSelect = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSplit = new System.Windows.Forms.Button();
            this.txtNewFileName = new System.Windows.Forms.TextBox();
            this.txtOldFileName = new System.Windows.Forms.TextBox();
            this.numStartMin = new System.Windows.Forms.NumericUpDown();
            this.numStartHour = new System.Windows.Forms.NumericUpDown();
            this.numStartSec = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numEndSec = new System.Windows.Forms.NumericUpDown();
            this.numEndHour = new System.Windows.Forms.NumericUpDown();
            this.numEndMin = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndMin)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSelect
            // 
            this.fileSelect.FileName = "fileSelect";
            this.fileSelect.Filter = "文件|*.mp4";
            this.fileSelect.FileOk += new System.ComponentModel.CancelEventHandler(this.fileSelect_FileOk);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(3, 3);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "选择文件";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSplit);
            this.panel1.Controls.Add(this.txtNewFileName);
            this.panel1.Controls.Add(this.txtOldFileName);
            this.panel1.Controls.Add(this.btnSelectFile);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 130);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "新文件";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "源文件";
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(308, 3);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(75, 23);
            this.btnSplit.TabIndex = 3;
            this.btnSplit.Text = "分割";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // txtNewFileName
            // 
            this.txtNewFileName.Location = new System.Drawing.Point(50, 83);
            this.txtNewFileName.Name = "txtNewFileName";
            this.txtNewFileName.Size = new System.Drawing.Size(315, 21);
            this.txtNewFileName.TabIndex = 2;
            // 
            // txtOldFileName
            // 
            this.txtOldFileName.Location = new System.Drawing.Point(50, 47);
            this.txtOldFileName.Name = "txtOldFileName";
            this.txtOldFileName.Size = new System.Drawing.Size(315, 21);
            this.txtOldFileName.TabIndex = 1;
            // 
            // numStartMin
            // 
            this.numStartMin.Location = new System.Drawing.Point(202, 177);
            this.numStartMin.Name = "numStartMin";
            this.numStartMin.Size = new System.Drawing.Size(82, 21);
            this.numStartMin.TabIndex = 2;
            // 
            // numStartHour
            // 
            this.numStartHour.Location = new System.Drawing.Point(91, 177);
            this.numStartHour.Name = "numStartHour";
            this.numStartHour.Size = new System.Drawing.Size(82, 21);
            this.numStartHour.TabIndex = 3;
            // 
            // numStartSec
            // 
            this.numStartSec.Location = new System.Drawing.Point(313, 177);
            this.numStartSec.Name = "numStartSec";
            this.numStartSec.Size = new System.Drawing.Size(82, 21);
            this.numStartSec.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "时";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "分";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "秒";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "秒";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "分";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "时";
            // 
            // numEndSec
            // 
            this.numEndSec.Location = new System.Drawing.Point(313, 226);
            this.numEndSec.Name = "numEndSec";
            this.numEndSec.Size = new System.Drawing.Size(82, 21);
            this.numEndSec.TabIndex = 11;
            // 
            // numEndHour
            // 
            this.numEndHour.Location = new System.Drawing.Point(91, 226);
            this.numEndHour.Name = "numEndHour";
            this.numEndHour.Size = new System.Drawing.Size(82, 21);
            this.numEndHour.TabIndex = 10;
            // 
            // numEndMin
            // 
            this.numEndMin.Location = new System.Drawing.Point(202, 226);
            this.numEndMin.Name = "numEndMin";
            this.numEndMin.Size = new System.Drawing.Size(82, 21);
            this.numEndMin.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "开始时间:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "结束时间:";
            // 
            // VideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 380);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numEndSec);
            this.Controls.Add(this.numEndHour);
            this.Controls.Add(this.numEndMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numStartSec);
            this.Controls.Add(this.numStartHour);
            this.Controls.Add(this.numStartMin);
            this.Controls.Add(this.panel1);
            this.Name = "VideoForm";
            this.Text = "视频快速切割";
            this.Load += new System.EventHandler(this.VideoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog fileSelect;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNewFileName;
        private System.Windows.Forms.TextBox txtOldFileName;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numStartMin;
        private System.Windows.Forms.NumericUpDown numStartHour;
        private System.Windows.Forms.NumericUpDown numStartSec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numEndSec;
        private System.Windows.Forms.NumericUpDown numEndHour;
        private System.Windows.Forms.NumericUpDown numEndMin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}


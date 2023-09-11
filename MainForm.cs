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
using System.Diagnostics;
using VideoSplit.Properties;
using System.Reflection;
using System.Resources;
using System.IO.Pipes;

namespace VideoSplit
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if (fileSelect.ShowDialog() != DialogResult.OK)
            { return; }

            string strFile = fileSelect.FileName;

            string videoName = Path.GetFileName(strFile);

            string videoSplitName = Path.GetFileNameWithoutExtension(strFile) + DateTime.Now.ToString("_MMdd_hhmmss") + Path.GetExtension(strFile);


            txtOldFileName.Text = videoName;
            txtNewFileName.Text = videoSplitName;

            numStartHour.Value = 0;
            numStartMin.Value = 0;
            numStartSec.Value = 0;




            string basePath = Directory.GetCurrentDirectory();

            string ffmpegfile = Path.Combine(basePath, "ffmpeg.exe");

            if (!File.Exists(strFile) || !File.Exists(ffmpegfile))
            {
                Console.WriteLine("没有文件");
                return;
            }

            List<int> entTimeList = new List<int>();
            using (System.Diagnostics.Process ffmpeg = new System.Diagnostics.Process())
            {

                String duration;  // soon will hold our video's duration in the form "HH:MM:SS.UU"
                String result;  // temp variable holding a string representation of our video's duration
                StreamReader errorreader;  // StringWriter to hold output from ffmpeg

                // we want to execute the process without opening a shell
                ffmpeg.StartInfo.UseShellExecute = false;
                //ffmpeg.StartInfo.ErrorDialog = false;
                ffmpeg.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                // redirect StandardError so we can parse it
                // for some reason the output comes through over StandardError
                ffmpeg.StartInfo.RedirectStandardError = true;

                // set the file name of our process, including the full path
                // (as well as quotes, as if you were calling it from the command-line)
                ffmpeg.StartInfo.FileName = ffmpegfile;
                ffmpeg.StartInfo.WorkingDirectory = Path.GetDirectoryName(strFile);

                // set the command-line arguments of our process, including full paths of any files
                // (as well as quotes, as if you were passing these arguments on the command-line)
                ffmpeg.StartInfo.Arguments = "-i " + videoName;

                // start the process
                ffmpeg.Start();

                // now that the process is started, we can redirect output to the StreamReader we defined
                errorreader = ffmpeg.StandardError;

                // wait until ffmpeg comes back
                ffmpeg.WaitForExit();

                // read the output from ffmpeg, which for some reason is found in Process.StandardError
                result = errorreader.ReadToEnd();

                // a little convoluded, this string manipulation...
                // working from the inside out, it:
                // takes a substring of result, starting from the end of the "Duration: " label contained within,
                // (execute "ffmpeg.exe -i somevideofile" on the command-line to verify for yourself that it is there)
                // and going the full length of the timestamp


                // a little convoluded, this string manipulation...
                // working from the inside out, it:
                // takes a substring of result, starting from the end of the "Duration: " label contained within,
                // (execute "ffmpeg.exe -i somevideofile" on the command-line to verify for yourself that it is there)
                // and going the full length of the timestamp

                duration = result.Substring(result.IndexOf("Duration: ") + ("Duration: ").Length, ("00:00:00").Length);

                if (duration.IndexOf(":") > -1)
                {
                    var listDurn = duration.Split(':');


                    entTimeList = listDurn.ToList().Select(t => int.Parse(t)).ToList();
                }

                if (entTimeList.Count == 3)
                {
                    numEndHour.Value = entTimeList[0];
                    numEndMin.Value = entTimeList[1];
                    numEndSec.Value = entTimeList[2];
                }

                // read the output from ffmpeg, which for some reason is found in Process.StandardError


            }
        }


        private void fileSelect_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnSplit_Click(object sender, EventArgs e)
        {

            string basePath = Directory.GetCurrentDirectory();
            string ffmpegfile = Path.Combine(basePath, "ffmpeg.exe");

            string strFile = fileSelect.FileName;

            string videoName = Path.GetFileName(strFile);

            string videoSplitName = Path.Combine(basePath, Path.GetFileNameWithoutExtension(strFile) + DateTime.Now.ToString("_MMdd_hhmmss") + Path.GetExtension(strFile));

            if (!File.Exists(strFile) || !File.Exists(ffmpegfile))
            {
                Console.WriteLine("没有文件");
                return;
            }

            /*
             * 快速切割视频
             * ffmpeg.exe -i EZVZ0218.MP4  -to 00:08:30 -c:v copy -c:a copy EZVZ0218_Cli.MP4
             */

            string startTimeStr = numStartHour.Value.ToString().PadLeft(2, '0') + ":" + numStartMin.Value.ToString().PadLeft(2, '0') + ":" + numStartSec.Value.ToString().PadLeft(2, '0');
            string endTimeStr = numEndHour.Value.ToString().PadLeft(2, '0') + ":" + numEndMin.Value.ToString().PadLeft(2, '0') + ":" + numEndSec.Value.ToString().PadLeft(2, '0');

            try
            {
                DateTime.Parse("2000-1-1 " + startTimeStr);
                DateTime.Parse("2000-1-1 " + endTimeStr);
            }
            catch (Exception)
            {
                MessageBox.Show("请确认开始和结束时间是否符合要求,分钟和秒不要大于59");
                return;
            }


            string strCMD = "-i \"" + videoName + "\"  -ss " + startTimeStr + "  -to " + endTimeStr + " -c:v copy -c:a copy \"" + videoSplitName + "\"";
            Console.WriteLine(strCMD);
            using (System.Diagnostics.Process ffmpeg = new System.Diagnostics.Process())
            {
                String duration;  // soon will hold our video's duration in the form "HH:MM:SS.UU"
                String result;  // temp variable holding a string representation of our video's duration
                StreamReader errorreader;  // StringWriter to hold output from ffmpeg

                // we want to execute the process without opening a shell
                ffmpeg.StartInfo.UseShellExecute = true;
                //ffmpeg.StartInfo.ErrorDialog = false;
                ffmpeg.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                // redirect StandardError so we can parse it
                // for some reason the output comes through over StandardError
                //ffmpeg.StartInfo.RedirectStandardError = true;

                // set the file name of our process, including the full path
                // (as well as quotes, as if you were calling it from the command-line)
                ffmpeg.StartInfo.FileName = ffmpegfile;
                ffmpeg.StartInfo.WorkingDirectory = Path.GetDirectoryName(strFile);

                // set the command-line arguments of our process, including full paths of any files
                // (as well as quotes, as if you were passing these arguments on the command-line)
                ffmpeg.StartInfo.Arguments = strCMD;

                // start the process
                ffmpeg.Start();

                // now that the process is started, we can redirect output to the StreamReader we defined
                //errorreader = ffmpeg.StandardError;

            }


        }

        private void VideoForm_Load(object sender, EventArgs e)
        {
            //{
            //    System.Reflection.Assembly assembly = GetType().Assembly;
            //    Stream streamSmall = assembly.GetManifestResourceStream("ImageAreaSelector.Resources.template.xlsx");

            string basePath = Directory.GetCurrentDirectory();
            string ffmpegfile = Path.Combine(basePath, "ffmpeg.exe");

            if (!File.Exists(ffmpegfile))
            {
                var ffmpeg = Properties.Resources.ffmpeg;

                using (var pFileStream = new FileStream(ffmpegfile, FileMode.Create, FileAccess.Write))
                {
                    pFileStream.Write(ffmpeg, 0, ffmpeg.Length);
                }
            }
        }
    }
}

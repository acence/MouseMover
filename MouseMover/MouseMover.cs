using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseMover
{
    public partial class MouseMover : Form
    {
        Thread shutdownThread;
        private static Random randomizer = new Random();
        public MouseMover()
        {
            InitializeComponent();
            timePicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 00, 00);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timMove.Start();
            if (shutdownThread != null && (shutdownThread.ThreadState == ThreadState.Running || shutdownThread.ThreadState == ThreadState.WaitSleepJoin))
            {
                shutdownThread.Interrupt();
            }
            shutdownThread = new Thread(new ParameterizedThreadStart(ShutdownWait));
            if (cbShutdown.Checked)
            {
                shutdownThread.Start(timePicker.Value);
            }
            cbShutdown.Enabled = false;
            timePicker.Enabled = false;
            lblStatus.Text = "Running";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timMove.Stop();
            if (shutdownThread != null && (shutdownThread.ThreadState == ThreadState.Running || shutdownThread.ThreadState == ThreadState.WaitSleepJoin))
            {
                shutdownThread.Interrupt();
            }
            cbShutdown.Enabled = true;
            timePicker.Enabled = true;
            lblStatus.Text = "Stopped";
        }

        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private void timMove_Tick(object sender, EventArgs e)
        {
            if (cb_Mouse.Checked)
            {
                var newPosX = randomizer.Next(0, 1920);
                var newPosY = randomizer.Next(0, 1080);
                this.Cursor = new Cursor(Cursor.Current.Handle);
                Cursor.Position = new Point(newPosX, newPosY);
            }

            if (cb_Keyboard.Checked)
            {
                SendKeys.Send(chars[randomizer.Next(0, 35)].ToString());
                SendKeys.Send("{BACKSPACE}");
            }
        }

        static void ShutdownWait(object time)
        {
            try
            {
                var shutdownTime = (DateTime)time;
                var diff = Math.Max(Convert.ToInt32((shutdownTime - DateTime.Now).TotalMilliseconds) + randomizer.Next(0, 5 * 60 * 1000), 0);
                Thread.Sleep(diff);
                System.Diagnostics.Process.Start("cmd.exe", "/c shutdown /s /t 0");
            }
            catch {
            }
        }
    }
}

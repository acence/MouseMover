using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseMover
{
    public partial class MouseMover : Form
    {
        private bool move = false;
        private Random randomizer = new Random();
        public MouseMover()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            move = true;   
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            move = false;
        }

        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private void timMove_Tick(object sender, EventArgs e)
        {
            if (move)
            {
                var newPosX = randomizer.Next(0, 1920);
                var newPosY = randomizer.Next(0, 1080);
                this.Cursor = new Cursor(Cursor.Current.Handle);
                Cursor.Position = new Point(newPosX, newPosY);
                SendKeys.Send(chars[randomizer.Next(0, 35)].ToString());
            }
        }
    }
}

//===== GameFuN, 2011-2015 =====\\

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace minecraftlauncher
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point last;

        private void toppanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                last = MousePosition;
            }
        }

        private void toppanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point cur = MousePosition;
                int dx = cur.X - last.X;
                int dy = cur.Y - last.Y;
                Point loc = new Point(Location.X + dx, Location.Y + dy);
                Location = loc;
                last = cur;
            }
        }

        private void toplabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                last = MousePosition;
            }
        }

        private void toplabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point cur = MousePosition;
                int dx = cur.X - last.X;
                int dy = cur.Y - last.Y;
                Point loc = new Point(Location.X + dx, Location.Y + dy);
                Location = loc;
                last = cur;
            }
        }

        private void vk_Click(object sender, EventArgs e)
        {
            Process.Start(@"http://vk.com/gamefun_vk"); //Открывается страница группы в браузере по умолчанию
        }

        private void windows_Click(object sender, EventArgs e)
        {
            OSInfo osinfo = new OSInfo();
            osinfo.ShowDialog();
        }

        private void email_Click(object sender, EventArgs e)
        {
            //Process.Start(@"http://vk.com/write?email=gamefun.offmail@gmail.com"); //Открывается страница сайта в браузере по умолчанию
            Process.Start(@"mailto:gamefun.offmail@gmail.com"); //Отправка письма на электронную почту через протокол MAILTO:
        }
    }
}
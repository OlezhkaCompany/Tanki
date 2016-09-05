using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Threading;


namespace MyFirstGame
{
    partial class UC : UserControl
    {
        Model model;
        public UC(Model model)
        {
            InitializeComponent(); this.model = model;

        }
        void Draw(PaintEventArgs e)
        {
            DrawWall(e);
            DrawApple(e);
            DrawTank(e);
            DrawAndr(e);
            DrawFire(e);
            DrawBoom(e);
            if (model.game != GameStatus.plaing)
                return;
            Thread.Sleep(model.speedgame);
            Invalidate();
        }
        private void DrawTank(PaintEventArgs e)
        {
            foreach (Tank t in model.Tanks)
            e.Graphics.DrawImage(t.Img1, new Point(t.X, t.Y));
        }
        private void DrawWall(PaintEventArgs e)
        {
            for (int y = 20; y < 400; y += 40)
                for (int x = 20; x < 400; x += 40)
                    e.Graphics.DrawImage(model.wall.Img1, new Point(x, y));
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Draw(e);
        }
        private void DrawApple(PaintEventArgs  e)
        {
            for(int i=0; i<model.Apple1 .Count ; i++)
            {
                e.Graphics.DrawImage(model.Apple1[i].Img1, new Point(model.Apple1[i].X, model.Apple1[i].Y));
            }
        }
        private void DrawAndr(PaintEventArgs e)
        {
            e.Graphics.DrawImage(model.Andr.Img1, new Point(model.Andr.X, model.Andr.Y));
        } 
        private void DrawBoom(PaintEventArgs e)
        {
            e.Graphics.DrawImage(model.B.Imag1, new Point(model.B.X, model.B.Y));
        }
        private void DrawFire(PaintEventArgs e)
        {
            foreach (FireTank1 im in model.FT1)
                e.Graphics.DrawImage(im.Img, new Point(im.X, im.Y));
        }
    }

}

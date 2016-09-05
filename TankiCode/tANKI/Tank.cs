using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;

namespace MyFirstGame
{
    class Tank : IRun, ITool, ITransparent, Iimage
    {
        TankImg ti = new TankImg();
        protected Image img;
        protected int x = 0, y = 0, direct_x, direct_y;
        protected static Random s;
        int sizeField;
        public int Direct_y
        {
            get { return direct_y; }
            set
            {
                if (value == 0 || value == -1 || value == 1) direct_y = value;
                else direct_y = 0;
            }
        }
        public int Direct_x
        {
            get { return direct_x; }
            set
            {

                if (value == 0 || value == -1 || value == 1)
                    direct_x = value;
                else direct_x = 0;
            }
        }
        public Image Img1
        {
            get { return img; }

        }
        public int Y
        {
            get { return y; }

        }
        public int X
        {
            get { return x; }

        }
        public Tank(int sizeField, int x, int y)
        {
            s = new Random();
            this.sizeField = sizeField;
            img = ti.Img0;
            if (s.Next(5000) < 2500)
            {
                Direct_y = 0;
            loop:
                Direct_x = s.Next(-1, 2);
                if (Direct_x == 0)
                    goto loop;
            }
            else
            {
                Direct_x = 0;
            loop:
                Direct_y = s.Next(-1, 2);
                if (Direct_y == 0)
                    goto loop;
            }
            putimg();
            this.x = x;
            this.y = y;

        }
        public void run()
        {
            
            x += direct_x;
            y += direct_y;
            if (Math.IEEERemainder(x, 40) == 0 && Math.IEEERemainder(y, 40) == 0)
            {
                Turn();
            }
            putimg(); 
            Transparent();
        }
        public void Turn()
        {
            if (s.Next(5000) < 2500)
            {
                if (Direct_y == 0)
                {
                    direct_x = 0;
                    while (Direct_y == 0)

                        Direct_y = s.Next(-1, 2);

                }
            }

            else
            {
                if (Direct_x == 0)
                {
                    direct_y = 0;
                    while (Direct_x == 0)
                    {
                        Direct_x = s.Next(-1, 2);
                    }
                }
            }
        }
        public void Transparent()
        {
            if (x == -1)
            {
                x = sizeField - 21;
            }
            if (x == sizeField - 19)
            {
                x = 1;
            }
            if (y == -1)
            {
                y = sizeField - 21;
            }
            if (y == sizeField - 19)
                y = 1;

        }
        private void putimg()
        {
            if (direct_x == 1)
                img = ti.Img1;
            if (direct_x == -1)
                img = ti.Img3;
            if (direct_y == 1)
                img = ti.Img2;
            if (direct_y == -1)
                img = ti.Img0;
        }
        public void TurnAround()
        {
            Direct_x = -1 * Direct_x;
            Direct_y = -1 * Direct_y;
            putimg();
        }
    }
}

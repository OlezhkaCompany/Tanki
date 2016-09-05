using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;

namespace MyFirstGame
{
    class Android : IRun, Iimage, ITool
    {
        AndroinImg andr = new AndroinImg();
        Image img;
        int x, y, direct_x, direct_y, next_direct_x, next_direct_y;

        public int Next_direct_y
        {
            get { return next_direct_y; }
             set
            {
                if (value == 0 || value == -1 || value == 1) next_direct_y = value;
                else next_direct_y  = 0;
            }
        }

        public int Next_direct_x
        {

            get { return next_direct_x; }
             set
            {
                if (value == 0 || value == -1 || value == 1) next_direct_x = value;
                else next_direct_x = 0;
            }
        }

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
            set { y = value; }

        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public Android(int sizeField)
        {

            this.sizeField = sizeField;
            this.x = 200;
            this.y = 400;
            this.Direct_x = 0;
            this.Direct_y = 0;
            img = andr.Img1;
            putimg();

        }
        public void run()
        {
            
                x += direct_x;
                y += direct_y;
            
            if (Math.IEEERemainder(x, 40) == 0 && Math.IEEERemainder(y, 40) == 0)
            {
                Turn();
            } putimg(); Transparent();
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
        void putimg()
        {
            if (direct_x == 1)
                img = andr.Img2;
            if (direct_x == -1)
                img = andr.Img4;
            if (direct_y == 1)
                img = andr.Img3;
            if (direct_y == -1)
                img = andr.Img1;
        }
        public void TurnAround()
        {
            Direct_x = -1 * Direct_x;
            Direct_y = -1 * Direct_y;
            putimg();
        }
        public void Turn()
        {
            Direct_x = Next_direct_x;
            Direct_y = Next_direct_y;
        }
    }
}
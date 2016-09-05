using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;

namespace MyFirstGame
{
    class Boom
    {
        private int km;

        public int Km
        {
            get { return km; }
            set { km = value; }
        }
        private BoomImg img = new BoomImg();
        Image Imag;
        int x, y, direct_x, direct_y;
        public Image Imag1
        {
            get { return Imag; }
        }
        public int Direct_y
        {
            get { return direct_y; }
            set
            {
                if (value == 0 || value == -1 || value == 1) direct_y = value;
                else direct_y = 0;
            }
        }
        public int Y
        {
            set { y = value; }
            get { return y; }

        }
        public int X
        {
            get { return x; }
            set { x = value; }


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
        public Boom()
        {
            Imag = img.IMG;
            X = Y = -10;
            Direct_x = Direct_y = 0;
        }

        public void run()
        {
            km+=2;
            if (km > 80)
            {
                X = 600; Y = 600;
            return;}
            x +=Direct_x*3;
            y+=Direct_y*3;
        }

    }
}

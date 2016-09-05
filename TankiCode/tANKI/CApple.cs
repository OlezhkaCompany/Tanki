using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;

namespace MyFirstGame
{
    class CApple: Iimage
    {
        AppleImg ai = new AppleImg();
        Image img;
        int x, y;

        public int Y
        {
            get { return y; }
            
        }

        public int X
        {
            get { return x; }
          
        }
        public Image Img1
        {
            get { return img; }
            
        }
        public CApple(int x, int y)
        {
            this.x = x;
            this.y = y;
            img = ai.Appleimg;
        }
    }
}

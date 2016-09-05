using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing ;

namespace MyFirstGame
{
    class Wall: Iimage
    {
        WallImg wi = new WallImg();
        Image img;

        public Image Img1
        {
            get { return img; }
            
        }
        public Wall()
        {
            img = wi.IMG;
        }
    }
}

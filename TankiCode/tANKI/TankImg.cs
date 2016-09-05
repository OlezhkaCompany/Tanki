using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing ;

namespace MyFirstGame
{
    class TankImg
    {
        Image img = Properties.Resources.images;
        Image img1 = Properties.Resources.images1;

        public Image Img1
        {
            get { return img1; }
            set { img1 = value; }
        }
        Image img2 = Properties.Resources.images2;

        public Image Img2
        {
            get { return img2; }
            set { img2 = value; }
        }
        Image img3 = Properties.Resources.images3;

        public Image Img3
        {
            get { return img3; }
            set { img3 = value; }
        }

        public Image Img0
        {
            get { return img; }
            set { img = value; }
        }
    }
}

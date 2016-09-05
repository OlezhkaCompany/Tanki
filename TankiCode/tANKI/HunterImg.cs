using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;
namespace MyFirstGame
{
    class HunterImg
    {
        Image andimg1 = Properties.Resources.apple_quarreling_with_android;
        Image andimg2 = Properties.Resources.apple_quarreling_with_android1;

        public Image Img2
        {
            get { return andimg2; }

        }
        Image andimg3 = Properties.Resources.apple_quarreling_with_android2;

        public Image Img3
        {
            get { return andimg3; }
            set { andimg3 = value; }
        }
        Image andimg4 = Properties.Resources.apple_quarreling_with_android3;
        public Image Img4
        {
            get { return andimg4; }
            set { andimg4 = value; }
        }

        public Image Img1
        {
            get { return andimg1; }
        }
    }
}

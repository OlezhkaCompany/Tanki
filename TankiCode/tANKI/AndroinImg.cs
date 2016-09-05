using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing ;

namespace MyFirstGame
{
    class AndroinImg
    {
        Image andimg1 = Properties.Resources.images__2_;
        Image andimg2 = Properties.Resources.images1__2_;

        public Image Img2
        {
            get { return andimg2; }
            
        }
        Image andimg3 = Properties.Resources.images1_2_2_;

        public Image Img3
        {
            get { return andimg3; }
            set { andimg3 = value; }
        }
        Image andimg4 = Properties.Resources.images1_3_2_;

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

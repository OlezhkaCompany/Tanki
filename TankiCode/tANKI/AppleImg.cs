using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;

namespace MyFirstGame
{
    class AppleImg
    {
        Image appleimg = Properties.Resources.macintosh_Logo;

        public Image Appleimg
        {
            get { return appleimg; }
            set { appleimg = value; }
        }
      
    }
}

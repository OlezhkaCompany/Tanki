using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;

namespace MyFirstGame
{
    class BoomImg
    {
        Image wallimg = Properties.Resources.Image1;
        public Image IMG
        {
            get { return wallimg; }
            set { wallimg = value; }
        }
    }
}

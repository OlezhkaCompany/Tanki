using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;

namespace MyFirstGame
{
    class WallImg
    {
        Image wallimg = Properties.Resources.images4;
        public Image IMG
        {
            get { return wallimg; }
            set { wallimg = value; }
        }
    }
}

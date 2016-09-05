using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;

namespace MyFirstGame
{
    class Fire
    {
        Image[] fire = new Image[] { Properties.Resources.Image4, Properties.Resources.Image5, Properties.Resources.Image6 };

        public Image[] Fire1
        {
            get { return fire; }
            set { fire = value; }
        }
    }
}

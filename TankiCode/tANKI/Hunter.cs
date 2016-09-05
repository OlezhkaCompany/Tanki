using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;

namespace MyFirstGame
{
    class Hunter : Tank
    {
        HunterImg andr = new HunterImg();
        public Hunter(int sizeField, int x, int y) : base(sizeField, x, y) { }
        public void run(int target_x, int target_y)
        {
            x += direct_x;
            y += direct_y;
            if (Math.IEEERemainder(x, 40) == 0 && Math.IEEERemainder(y, 40) == 0)
            {
                Turn(target_x, target_y);
            }
            putimg();
            Transparent();
        }
        new public void TurnAround()
        {
            Direct_x = -1 * Direct_x;
            Direct_y = -1 * Direct_y;
            putimg();
        }
        void putimg()
        {
            if (direct_x == 1)
                img = andr.Img1;
            if (direct_x == -1)
                img = andr.Img3;
            if (direct_y == 1)
                img = andr.Img2;
            if (direct_y == -1)
                img = andr.Img4;
        }
        public void Turn(int targetX, int targetY)
        {
            Direct_y = Direct_x = 0;
            if (targetX < X)
                Direct_x = -1;
            if (targetY < Y)
                Direct_y = -1;
            if (targetY > Y)
                Direct_y = 1;
            if (targetX > X)
                Direct_x = 1;
            if (Direct_y != 0 && Direct_x != 0)
                if (s.Next(5000) < 2500)
                    Direct_x = 0;
                else Direct_y = 0;
        }
    }
}

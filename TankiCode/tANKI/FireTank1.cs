using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;
namespace MyFirstGame
{
    class FireTank1
    {
        Image curimg;

        public Image Img
        {
            get { return curimg; }
            set { curimg = value; }
        }
    Fire Firemg =new Fire ();
    Image[] img;
    int x, y;
        int k;
    public int Y
    {
        get { return y; }
        
    }

    public int X
    {
        get { return x; }
       
    }
        public void putCurectImg()
        {
            curimg =img[k];
            k++;
            if (k == 3)
                k = 0;
        }
        public void Fir()
        {
            putCurectImg();
        }
      public  FireTank1(int x, int y)
    {
        this.x = x;
        this.y = y;
        img = Firemg.Fire1;
        putCurectImg();
    }
    }
}

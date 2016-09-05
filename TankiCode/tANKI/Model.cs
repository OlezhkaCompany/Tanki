using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;



namespace MyFirstGame
{
    class Model
    {
        public static int life = 100;
        public static int len = 0;
        static int g = 0;
        static int h = 0;
        int sizeField;
        int countTank;
        int apple;
        public Hunter hunter;
        static Random r;
        Boom b;
        public int speedgame;
        List<FireTank1> FT; 
        internal List<FireTank1> FT1
        {
            get { return FT; }
        }
        internal Boom B
        {
            get { return b; }
        }
        Android andr;

        internal Android Andr
        {
            get { return andr; }

        }

        private List<Tank> tanks;
        List<CApple> Apple;

        internal List<CApple> Apple1
        {
            get { return Apple; }

        }
        public List<Tank> Tanks
        {
            get { return tanks; }

        }
        public GameStatus game;
        public Wall wall;

        public Model(int sizeField, int countTank, int apple, int speedgame)
        {  this.sizeField = sizeField;
            this.countTank = countTank;
            this.apple = apple;
            this.speedgame = speedgame;r = new Random();
            NewGame();
        }
        private void CreatTank()
        {
            int x, y;
            while (tanks.Count < countTank)
            {
                if (tanks.Count == 0)
                {
                    tanks.Add(new Hunter(sizeField, 200, 200));
                }
                x = r.Next(10) * 40;
                y = r.Next(1, 7) * 40;
                bool flag = true;
                foreach (Tank t in tanks)
                    if (t.X == x && t.Y == y)
                    {
                        flag = false;
                        break;
                    }
                if (flag)
                {
                    tanks.Add(new Tank(sizeField, x, y));
                }

            }
        }
        private void CreatApple()
        {
            int x, y;
            while (Apple.Count < apple)
            {
                x = r.Next(10) * 40;
                y = r.Next(10) * 40;
                bool flag = true;
                foreach (CApple a in Apple)
                    if (a.X == x && a.Y == y)
                    {
                        flag = false;
                        break;
                    }
                if (flag)
                {
                    Apple.Add(new CApple(x, y));
                }

            }
        }
        public void Play()
        {
            while (game == GameStatus.plaing)
            {
                Thread.Sleep(speedgame);
                b.run();
                andr.run();
                if (len >= 5)
                    ((Hunter)tanks[0]).run(andr.X, andr.Y);
                for (int i = 1; i < tanks.Count; i++)
                {
                    tanks[i].run();
                }
                foreach (FireTank1 fita in FT)
                    fita.Fir();
                for (int i = 1; i < tanks.Count; i++)
                {
                    if(Math.Abs(tanks[i].X -B.X )<11 && Math .Abs (tanks[i].Y-B.Y)<11)
                    {
                        B.Y = 600;
                        B.X = 600;
                        FT.Add(new FireTank1(tanks[i].X, tanks[i].Y));
                        tanks.RemoveAt(i);
                    }
                }
                    for (int i = 0; i < tanks.Count - 1; i++)
                        for (int j = i + 1; j < tanks.Count; j++)
                            if ((Math.Abs(tanks[i].X - tanks[j].X) <= 20 && (tanks[i].Y == tanks[j].Y))
                                ||
                               (Math.Abs(tanks[i].Y - tanks[j].Y) <= 20 && (tanks[i].X == tanks[j].X))
                                ||
                               (Math.Abs(tanks[i].X - tanks[j].X) <= 20 && Math.Abs(tanks[i].Y - tanks[j].Y) <= 20))
                            {
                                if (i == 0)
                                {
                                    ((Hunter)tanks[i]).TurnAround();
                                }
                                else tanks[i].TurnAround();
                                tanks[j].TurnAround();

                            }
                for (int i = 0; i < tanks.Count; i++)
                    if ((Math.Abs(tanks[i].X - andr.X) <= 17 && (tanks[i].Y == andr.Y))
                        ||
                       (Math.Abs(tanks[i].Y - andr.Y) <= 17 && (tanks[i].X == andr.X))
                        ||
                       (Math.Abs(tanks[i].X - andr.X) <= 17 && Math.Abs(tanks[i].Y - andr.Y) <= 17))
                    {
                        h++;
                        
                        andr.X = 200;
                        andr.Y = 400;
                        andr.Next_direct_y = 0;
                        andr.Next_direct_x = 0;
                        andr.Direct_x = 0;
                        andr.Direct_y = -1;
                        if (h == 1)
                        {
                            life = 86;
                        }
                        else if (h == 2)
                        {
                            life = 61;
                        }
                        else if (h == 3)
                        {
                            life = 14;
                        }
                        else if (h == 4)
                        {
                            life = 0;  DialogResult d=MessageBox.Show("Вы поиграли! Еще раз хотите проиграть ?", "Losser", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                            game = GameStatus.loozing;
                            if (d == DialogResult.OK)
                                NewGame();
                        }
                    }

                for (int i = 0; i < Apple.Count; i++)
                    if (andr.X == Apple[i].X && andr.Y == Apple[i].Y)
                    {
                        Apple[i] = new CApple(0 + (20 * Model.g), 420);
                        len++;
                        Model.g++;
                    }
                if (len == 21)
                {
                    game = GameStatus.wining;
                    DialogResult d = MessageBox.Show("Победа!", "Ура, Вы победели! Еще ?", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    if (d == DialogResult.OK)
                        NewGame();

                }


            }
        }
        public void NewGame()
        {
            b = new Boom();
            hunter = new Hunter(sizeField, 200, 200);
            tanks = new List<Tank>();
            Apple = new List<CApple>();
            andr = new Android(sizeField);
            CreatTank();
            CreatApple();
            wall = new Wall();
            game = GameStatus.stoping;
            FT = new List<FireTank1>();
            Model.life = 100;
            Model.len = 0;
            Model.g = 0;
            Model.h = 0;
        }
    }
}

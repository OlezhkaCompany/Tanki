using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Threading;
using System.Media;
[assembly: CLSCompliant (true)]
namespace MyFirstGame
{
    public delegate void Iinvoker();
    public partial class ConMainForm : Form
    {
        UC uc;
        Model Mo;
        Thread ModelPlay;
        Thread Total;
        Object thisLock;
        public static int boomm = 100;
        public ConMainForm() : this(420) { }
        public ConMainForm(int sizeField) : this(sizeField, 15) { }
        public ConMainForm(int sizeField, int countTank) : this(sizeField, countTank, 21) { }
        public ConMainForm(int sizeField, int countTank, int apple) : this(sizeField, countTank, apple, 40) { }
        public ConMainForm(int sizeField, int countTank, int apple, int speedgame)
        {
            InitializeComponent(); Mo = new Model(sizeField, countTank, apple, speedgame);
            uc = new UC(Mo);
            thisLock = new object();
            this.Controls.Add(uc);
        }

        private void Start_Stop_Click(object sender, EventArgs e)
        {
           
            if (Mo.game == GameStatus.plaing)
            {
                ModelPlay.Abort();
                Mo.game = GameStatus.stoping;
            }
            else
            {
                Mo.game = GameStatus.plaing;

                pictureBox1.Focus();
                ModelPlay = new Thread(Mo.Play);

                ModelPlay.Start();
                uc.Invalidate();
            }

        }
        void To()
        {
            Invoke(new Iinvoker(Totaal));
        }
        private void ConMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (ModelPlay != null)
            {
                ModelPlay.Abort();
                Mo.game = GameStatus.stoping;
            }
            DialogResult dr = MessageBox.Show("Вы уверены что хотите покинуть игру ?", "Закрытие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk,MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            if (dr == DialogResult.Yes)
                e.Cancel = false;
            else e.Cancel = true;
        }
        private void Totaal()
        {
            
                label2.Text = " " + Model.len;
                label4.Text = " " + Model.life + "%";
                label6.Text = " " + boomm;
            
        }
        

        private void pictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyData.ToString())
            {
                case "A":
                    Totaal();
                    {
                        Mo.Andr.Next_direct_x = -1;
                        Mo.Andr.Next_direct_y = 0;


                    } break;
                case "W":
                    {
                        Mo.Andr.Next_direct_x = 0;
                        Mo.Andr.Next_direct_y = -1;
                        Totaal();

                    } break;
                case "D":
                    {
                        Totaal();
                        Mo.Andr.Next_direct_x = 1;
                        Mo.Andr.Next_direct_y = 0;

                    } break;
                case "S":
                    {
                        Totaal();

                        Mo.Andr.Next_direct_x = 0;
                        Mo.Andr.Next_direct_y = 1;

                    } break;
                case "Q":
                    {
                        Totaal();

                        Mo.Andr.Next_direct_x = 0;
                        Mo.Andr.Next_direct_y = 0;
                    } break;
                case "F":
                    if (boomm != 0)
                    {
                        Mo.B.Km = 0;
                        Totaal();
                        boomm -= 1;
                        Mo.B.Direct_x = Mo.Andr.Direct_x;
                        Mo.B.Direct_y = Mo.Andr.Direct_y;
                        if (Mo.Andr.Direct_y == -1)
                        {
                            Mo.B.Y = Mo.Andr.Y - 10;
                            Mo.B.X = Mo.Andr.X + 5;

                        }
                        if (Mo.Andr.Direct_y == 1)
                        {
                            Mo.B.X = Mo.Andr.X + 5;
                            Mo.B.Y = Mo.Andr.Y + 20;
                        }
                        if (Mo.Andr.Direct_x == -1)
                        {
                            Mo.B.X = Mo.Andr.X - 10;
                            Mo.B.Y = Mo.Andr.Y + 5;
                        }
                        if (Mo.Andr.Direct_x == 1)
                        {
                            Mo.B.X = Mo.Andr.X + 15;
                            Mo.B.Y = Mo.Andr.Y + 5;
                        }
                    } break;
                default: break;
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Mo.NewGame();
            uc.Refresh();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ModelPlay != null)
            {
                ModelPlay.Abort();
                Mo.game = GameStatus.stoping;
            }
            DialogResult d = MessageBox.Show("Вам это всеравно не интересно. Но все же закодил Олег ВВ", " About", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
          if (d == DialogResult.OK)
          {
              Mo.game = GameStatus.plaing;
             
          }
        }
    }
}

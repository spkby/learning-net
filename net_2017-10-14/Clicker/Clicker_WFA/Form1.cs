using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Clicker_WFA
{
    public partial class Form1 : Form
    {
        int pnts = 0;
        int miss;
        Graphics gameField=null;
        List<Figure> figures= new List<Figure>();
        bool dbClick = false;

        public Form1()
        {
            InitializeComponent();

            gameField = this.CreateGraphics();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            if (dbClick) return;
            dbClick = true;

            labelOk.Text = "";
            labelOk.Visible = true;

            labelMiss.Text = "";
            labelMiss.Visible = true;

            timer1.Start();
            timer2.Start();

            miss = 0;
        }

        private void DrawFigures()
        {
            foreach (var item in figures)
            {
                item.Draw();
            }
        }

        private void TTL()
        {
            Queue<Figure> delFigures=new Queue<Figure>();
            
            foreach (var fgr in figures)
            {
                fgr.TTL--;
                if (fgr.TTL <= 0)
                {
                    delFigures.Enqueue(fgr);
                    fgr.ClearDraw(this.BackColor);
                    miss+=5;
                    labelMiss.Text = miss.ToString();
                }
            }

            while (delFigures.Count>0)
            {
                figures.Remove(delFigures.Dequeue());
            }
        }

        private void AddNewFigures()
        {
            int x0, y0, r, ttl;
            int typeFrg;
            Color clr;
            //Figure fgr = null;
            
            Random rnd = new Random();

            typeFrg = rnd.Next(1,4);

            r = rnd.Next(1, 15);

            ttl = rnd.Next(5, 15);
            x0 = rnd.Next(0, this.Width);
            y0 = rnd.Next(0, this.Height);

            clr = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));

            switch (typeFrg)
            {
                case 1:
                    figures.Add(new Circle(x0 - r, y0 - r, x0 + r, y0 + r, ttl, clr,
                          this.Width, this.Height, this.gameField));
                    break;
                case 2:
                    figures.Add(new Quadrat(x0 - r, y0 -r , x0 + r, y0 + r, ttl, clr,
                          this.Width, this.Height, this.gameField));
                    break;
                case 3:
                    figures.Add(new Triangel(x0 - r, y0 - r, x0 + r, y0 + r, ttl, clr,
                          this.Width, this.Height, this.gameField));
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AddNewFigures();
            TTL();
            DrawFigures();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Color clr = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            Figure fgr = new Triangel(100 - 10, 100 - 10, 100 + 10, 100 + 10, 5, clr, this.Width, this.Height, this.gameField);
            fgr.Draw();

            /*
            AddNewFigures();
            DrawFigures();
            */
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Figure delFigure=null;

            bool OK = false;

            foreach (var fgr in figures)
            {
                if (fgr.CheckPoint(e.X, e.Y))
                {
                    OK = true;
                    delFigure = fgr;
                    pnts += fgr.GetPoint();
                    fgr.ClearDraw(this.BackColor);
                    labelOk.Text = pnts.ToString();
                }
            }

            if(OK == false)
            {
                miss++;
                labelMiss.Text = miss.ToString();
            }
            figures.Remove(delFigure);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            foreach(Figure fig in figures)
            {
                fig.ClearDraw(this.BackColor);
                fig.MoveDown();
                fig.Draw();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using Lib;

namespace App
{
    public partial class TankGame : Form
    {
        Bullet bullet;
        Tank redTank, blueTank;
        GameField gameField;

        int w, h;

        private void timer1_Tick(object sender, EventArgs e)
        {
            redTank.Draw();
            blueTank.Draw();


          /*
            ball.ClearDraw();
            ball.Move(redTank, blueTank);
            ball.Draw();
            */
        }

        public TankGame()
        {
            InitializeComponent();

            w = this.Width - 15;
            h = this.Height - 40;

            gameField = new GameField(0, 0, w, h, this.CreateGraphics(), this.BackColor);
//            ball = new Ball(w / 2, h / 2, 10, Color.Red, 10, gameField, -1, h / 2 + w / 2);

            redTank = new Tank(5, h / 2 - 40, 10, 100, Color.Green, 5, gameField);
            blueTank = new Tank(w - 15, 20, 10, 100, Color.Blue, 5, gameField);

            //Pad right = new Pad(w, 0, 10, h, Color.Yellow, 1, gameField);
//            timer2.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Width = 800;
            this.Height = 600;

        }
    }
}

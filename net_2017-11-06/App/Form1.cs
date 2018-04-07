using System;

using System.Drawing;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        Ball ball;
        Pad leftPad, rightPad;
        GameField gameField;

        int w, h;


        public Form1()
        {
            InitializeComponent();

            w = this.Width-15;
            h = this.Height-40;

            gameField = new GameField(0, 0, w, h, this.CreateGraphics(),this.BackColor);
            ball = new Ball(w / 2, h / 2, 10, Color.Red, 10, gameField, -1, h / 2 + w / 2);

            leftPad = new Pad(5, h / 2 - 40, 10, 100, Color.Green, 5, gameField);
            rightPad = new Pad(w-15, 20, 10, 100, Color.Blue, 5, gameField);

            //Pad right = new Pad(w, 0, 10, h, Color.Yellow, 1, gameField);
            timer2.Start();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            leftPad.Draw();
            rightPad.Draw();


            ball.ClearDraw();
            ball.Move(leftPad, rightPad);
            ball.Draw();

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            leftPad.ClearDraw();
            rightPad.ClearDraw();
            switch (e.KeyCode)
            {
                case Keys.ControlKey:
                    leftPad.MoveUp();
                    break;
                case Keys.Menu:
                    leftPad.MoveDown();
                    break;
                case Keys.Up:
                    rightPad.MoveUp();
                    break;
                case Keys.Down:
                    rightPad.MoveDown();
                    break;
            }
            rightPad.Draw();
            leftPad.Draw();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

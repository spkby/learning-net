using System.Drawing;

namespace PingPong
{
    public class Ball
    {
        /// <summary>
        /// center X,Y and R - radius
        /// </summary>
        public int x { get; set; }
        public int y { get; set; }
        public int r { get; set; }


        private Color color;
        private int step;

        private GameField gameField;

        /// <summary>
        /// y=k*x+b
        /// </summary>
        private double k;
        private double b;

        /// <summary>
        /// constructor Ball
        /// </summary>
        /// <param name="x">center X</param>
        /// <param name="y">center Y</param>
        /// <param name="r">radius</param>
        /// <param name="color">color</param>
        /// <param name="step">speed</param>
        /// <param name="gameField"></param>
        /// <param name="k">K</param>
        /// <param name="b">B</param>
        public Ball(int x, int y, int r, Color color,
            int step, GameField gameField, double k, double b)
        {
            this.x = x;
            this.y = y;
            this.r = r;
            this.color = color;
            this.gameField = gameField;
            this.k = k;
            this.b = b;
            this.step = step;
        }

        /// <summary>
        /// Draw Ball
        /// </summary>
        public void Draw()
        {
            gameField.graphics.FillEllipse(new SolidBrush(color),
                x - r, y - r, 2 * r, 2 * r);
        }
        /// <summary>
        /// Erase ball
        /// </summary>
        public void ClearDraw()
        {
            gameField.graphics.FillEllipse(new SolidBrush(gameField.color),
                x - r, y - r, 2 * r, 2 * r);
        }

        private double Y()
        {
            return k * x + b;
        }

        private double X()
        {
            return (y - b) / k;
        }

        /// <summary>
        /// Check Board Min X
        /// </summary>
        /// <returns></returns>
        public bool CheckMinX()
        {
            if (x <= gameField.minX+r) { return true; }
            else { return false; }
        }

        /// <summary>
        /// Check Board Max X
        /// </summary>
        /// <returns></returns>
        public bool CheckMaxX()
        {
            if (x >= gameField.maxX-r) { return true; }
            else { return false; }
        }

        /// <summary>
        /// Check Board Min Y
        /// </summary>
        /// <returns></returns>
        public bool CheckMinY()
        {
            if (y <= gameField.minY+r) { return true; }
            else { return false; }
        }

        /// <summary>
        /// Check Board Max Y
        /// </summary>
        /// <returns></returns>
        public bool CheckMaxY()
        {
            if (y >= gameField.maxY-r) { return true; }
            else { return false; }
        }

        /// <summary>
        /// check board pad
        /// </summary>
        /// <param name="pad"></param>
        /// <returns></returns>
        public bool CheckPad(Pad pad)
        {
            if (((y <= pad.y + pad.height) && (y >= pad.y)) && ((x >= pad.x - r - 3) && (x <= (pad.x + pad.width + r + 3))))
            {
                return true;
            }
            else { return false; }

        }

        public void Move(params Pad[] pads)
        {
            x += step;
            y = (int)Y();
            if ((CheckPad(pads[0])) ||(CheckPad(pads[1])))
            {
                k = -k;
                b = y - (k * x);
                step = -step;
            }
            if (CheckMinX() || CheckMaxX())
            {
                k = -k;
                b = y - (k * x);
                step = -step;
            }
            
            if (CheckMaxY() || CheckMinY())
            {
                k = -k;
                b = y - (k * x);
            }


        }
    }
}

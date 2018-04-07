using System.Drawing;


namespace Lib
{
    public class Tank
    {

        public int armor { get; set; }
        public int power { get; set; }
        public int speed { get; set; }


        // координаты верхнего левого угла
        public int x { get; set; }
        public int y { get; set; }

        public int width { get; set; }

        public int height { get; set; }

        private Color color;
        private int step;
        private GameField gameField;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="x">point x left up</param>
        /// <param name="y">point x left up</param>
        /// <param name="width">width pad</param>
        /// <param name="height">height pad</param>
        /// <param name="color">color pad</param>
        /// <param name="step">speed pad</param>
        /// <param name="gameField"></param>
        public Tank(int x, int y, int width, int height, Color color, int step, GameField gameField)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.color = color;
            this.step = step;
            this.gameField = gameField;
        }

        /// <summary>
        /// move up pad
        /// </summary>
        public void MoveUp()
        {
            if (y - step < gameField.minY) { y = gameField.minY; }
            else { y -= step; }
        }

        /// <summary>
        /// move down pad
        /// </summary>
        public void MoveDown()
        {
            y += step;
            if ((y + height) > gameField.maxY) { y = gameField.maxY - height; }
            //else {  }
        }

        /// <summary>
        /// drawing pad
        /// </summary>
        public void Draw()
        {
            gameField.graphics.FillRectangle(new SolidBrush(color), x, y, width, height);
        }

        /// <summary>
        /// erase pad
        /// </summary>
        public void ClearDraw()
        {
            gameField.graphics.FillRectangle(new SolidBrush(gameField.color), x, y, width, height);
        }



    }
}

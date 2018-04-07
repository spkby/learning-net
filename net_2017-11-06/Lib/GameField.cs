using System.Drawing;

namespace PingPong
{
    public class GameField
    {

        public int minX { get; set; }
        public int minY { get; set; }

        public int maxX { get; set; }
        public int maxY { get; set; }

        public Graphics graphics { get; set; }

        public Color color;

        public GameField(int minX, int minY, int maxX, int maxY, Graphics graphics, Color color)
        {
            this.minX = minX;
            this.minY = minY;
            this.maxX = maxX;
            this.maxY = maxY;
            this.graphics = graphics;
            this.color = color;
        }




    }
}

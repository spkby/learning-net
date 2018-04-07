using System.Drawing;

namespace ClassLibrary1
{
    public class Triangel : Figure
    {
        public Triangel(int leftUpX, int leftUpY, int rightDownX,
            int rightDownY, int TTL, Color color,
            int maxX, int maxY, Graphics gameField) :
            base(leftUpX, leftUpY, rightDownX, rightDownY,
                 TTL, color, maxX, maxY, gameField)
        { }

        public override bool CheckPoint(int X, int Y)
        {
            if (((X >= leftUpX) && (X <= rightDownX)) && ((Y >= leftUpY) && (Y <= rightDownY)))
            { return true; }
            else
            { return false; }

        }

        public override void ClearDraw(Color clrColor)
        {
            int r = rightDownX - leftUpX;
            Point[] points = new Point[3];

            points[0].X = leftUpX;
            points[0].Y = leftUpY;

            points[1].X = rightDownX;
            points[1].Y = leftUpY;

            points[2].X = leftUpX + (rightDownX - leftUpX)/2;
            points[2].Y = rightDownY;

            gameField.FillPolygon(new SolidBrush(clrColor), points);
        }

        public override int GetPoint()
        {
            return 5;
        }
    }
}

using System.Drawing;

namespace ClassLibrary1
{
    public class Quadrat : Figure
    {

        public Quadrat(int leftUpX, int leftUpY, int rightDownX,
            int rightDownY, int TTL, Color color,
            int maxX, int maxY, Graphics gameField) : 
            base(leftUpX, leftUpY, rightDownX, rightDownY,
                 TTL, color, maxX, maxY, gameField)
        {

        }
    public override bool CheckPoint(int X, int Y)
        {
            if ( ((X >= leftUpX) && (X <= rightDownX)) && ((Y >= leftUpY) && (Y <= rightDownY)))
            { return true; }
            else
            { return false; }

        }

        public override void ClearDraw(Color clrColor)
        {
            int r = rightDownX - leftUpX;
            gameField.FillRectangle(new SolidBrush(clrColor), leftUpX, leftUpY, r, r);
        }

        public override int GetPoint()
        {
            return 5;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Rectangle
    {
        public Point TopLeft { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(Point topLeft, int width, int height)
        {
            TopLeft = topLeft;
            Width = width;
            Height = height;
        }

        public void Move(int dx, int dy)
        {
            TopLeft = new Point(TopLeft.X + dx, TopLeft.Y + dy);
        }

        public void Resize(int newWidth, int newHeight)
        {
            Width = newWidth;
            Height = newHeight;
        }

        public Rectangle GetBoundingRectangle(Rectangle other)
        {
            int minX = Math.Min(TopLeft.X, other.TopLeft.X);
            int minY = Math.Min(TopLeft.Y, other.TopLeft.Y);
            int maxX = Math.Max(TopLeft.X + Width, other.TopLeft.X + other.Width);
            int maxY = Math.Max(TopLeft.Y + Height, other.TopLeft.Y + other.Height);

            int newWidth = maxX - minX;
            int newHeight = maxY - minY;

            return new Rectangle(new Point(minX, minY), newWidth, newHeight);
        }

        public Rectangle GetIntersection(Rectangle other)
        {
            int x1 = Math.Max(TopLeft.X, other.TopLeft.X);
            int y1 = Math.Max(TopLeft.Y, other.TopLeft.Y);
            int x2 = Math.Min(TopLeft.X + Width, other.TopLeft.X + other.Width);
            int y2 = Math.Min(TopLeft.Y + Height, other.TopLeft.Y + other.Height);

            if (x2 < x1 || y2 < y1)
            {
                // No intersection
                return null;
            }
            else
            {
                int width = x2 - x1;
                int height = y2 - y1;
                return new Rectangle(new Point(x1, y1), width, height);
            }
        }
    }
}

using System;
namespace Prototype.PrototypePattern.LinePrototype
{
    public class Point
    {
        public int X, Y;

        public override string ToString()
        {
            return $"{nameof(X)}:  {X}, {nameof(Y)}:  {Y}";
        }
    }

    public class Line
    {
        public Point Start, End;

        public Line DeepCopy()
        {
            var newStart = new Point { X = Start.X, Y = Start.Y };
            var newEnd = new Point { X = End.X, Y = End.Y };
            return new Line { Start = newStart, End = newEnd };
        }

        public override string ToString()
        {
            return $"{nameof(Start)}:  {Start}, {nameof(End)}:  {End}";
        }
    }
}

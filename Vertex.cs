using System;
using System.Diagnostics.CodeAnalysis;

namespace BFS
{
    public class Vertex : IComparable<Vertex>
    {
        public Color Color { get; set; }
        public Vertex Parent { get; set; }
        public int Number { get; set; }
        public int Distance { get; set; }
        public char Label { get; set; }

        public Vertex(Color color, Vertex parent, int number, int distance)
        {
            Color = color;
            Parent = parent;
            Number = number;
            Distance = distance;
            Label = (char)(114 + Number);
        }

        public int CompareTo([AllowNull] Vertex other)
        {
            return Distance.CompareTo(other.Distance);
        }
    }

    public enum Color
    {
        WHITE = 1,
        GRAY = 2,
        BLACK = 3
    }

}

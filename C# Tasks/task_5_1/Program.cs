using System.Reflection.Metadata;

namespace task_5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            point_3d a = new point_3d(2, 3, 5);   
            Console.WriteLine(a);
            string x = a;
            Console.WriteLine(x);
        }
        class point_3d
        {
            private int x;
            private int y;
            private int z;
            public point_3d(int x)
            {
                this.x = x;
            }
            public point_3d(int x, int y) : this(x)
            {
                this.y = y;
            }
            public point_3d(int x, int y, int z) : this(x,y)
            {
                this.z = z;
            }
            public static implicit operator string(point_3d point)
            {
                return point.ToString();
            }
            public override string ToString()
            {
                return $"Point Coordinates: ({x}, {y}, {z})";
            }

        }
    }
}

namespace task_5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Durattion a = new Durattion(120);
            Durattion b = new Durattion(200);
            Console.WriteLine(a + b);
            int x = 5;
            Console.WriteLine(a + x);
            Console.WriteLine(x + a);
            Console.WriteLine(++a);
            Console.WriteLine(--a);
            Console.WriteLine(a < b);
            Console.WriteLine(a > b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a >= b);
            DateTime obj = (DateTime)b;
            Console.WriteLine(obj);
        }
        class Durattion
        {
            private int duration;
            public int Hour { get; set; }
            public int Minute { get; set; }

            public int Second { get; set; }

            public Durattion(int duration)
            {
                this.duration = duration;
                this.Hour = duration / 3600;
                this.Minute = (duration % 3600) / 60;
                this.Second = (duration % 3600) % 60;
            }
            public static Durattion operator +(Durattion d1, Durattion d2)
            {
                var value = d1.duration + d2.duration;
                return new Durattion(value);
            }

            public static Durattion operator +(Durattion d1, int d2)
            {
                var value = d1.duration + d2;
                return new Durattion(value);
            }
            public static Durattion operator +(int d1, Durattion d2)
            {
                var value = d1 + d2.duration;
                return new Durattion(value);
            }

            public static Durattion operator ++(Durattion d2)
            {
                var value = d2.duration + 1;
                return new Durattion(value);
            }

            public static Durattion operator --(Durattion d2)
            {
                var value = d2.duration - 1;
                return new Durattion(value);
            }

            public static bool operator <(Durattion d1, Durattion d2)
            {
                return d1.duration < d2.duration;
            }

            public static bool operator >(Durattion d1, Durattion d2)
            {
                return d1.duration > d2.duration;
            }
            public static bool operator <=(Durattion d1, Durattion d2)
            {
                return d1.duration <= d2.duration;
            }

            public static bool operator >=(Durattion d1, Durattion d2)
            {
                return d1.duration >= d2.duration;
            }
            public static explicit operator DateTime(Durattion d1)
            {
                DateTime referenceDate = DateTime.MinValue;  // 1/1/0001
                return referenceDate.AddHours(d1.Hour).AddMinutes(d1.Minute).AddSeconds(d1.Second);
            }
            public override string ToString()
            {
                return $"Duraion: {duration} -> Hours: {Hour}, Minutes: {Minute}, Seconds: {Second}";
            }
        }
    }
}

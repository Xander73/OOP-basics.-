

namespace _7_Lesson
{
    public class Circle : Point
    {
        private int _radius;

        public int Radius
        {
            get => _radius;
            set => _radius = value;
        }

        public Circle(int x, int y, int radius) : base(x, y) 
        {
            Radius = radius;
        }


        public double Areal() => 3.14 * Radius * Radius;

        public override string ToString() => base.ToString() + "Radius - " + Radius.ToString() + '\n';
    }
}



namespace _7_Lesson
{
    public class Rectangle : Point
    {
        public int Width
        { get; private set; }

        public int Height { get; private set; }


        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {
            Width = width;
            Height = height;
        }


        public double Areal() => Width * Height;


        public override string ToString() => base.ToString() + 
                                            "Width - " + Width.ToString() + 
                                            "\nHeight - " + Height.ToString() + '\n';
    }
}

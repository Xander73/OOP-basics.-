using System.Collections.Generic;

namespace _7_Lesson
{
    public abstract class Figure : IFigure
    {
        private string _color;
        private bool _hidden;
        private KeyValuePair<int, int> _coordinates;

        public string Color
        {
            get => _color;
            set => _color = value;
        }

        public bool Hidden
        {
            get => _hidden;
            set => _hidden = value;
        }

        public KeyValuePair<int, int> Coordinates
        {
            get => _coordinates;
            private set => _coordinates = value;
        }


        public Figure(int x, int y, string color = "black", bool hidden = false)
        {
            Coordinates = new KeyValuePair<int, int>(x, y);
            Color = color ?? "black";
            Hidden = hidden;
        }


        public void MoveHorisontal (int x) => 
            Coordinates = new KeyValuePair<int, int>(Coordinates.Key + x, Coordinates.Value);


        public void MoveVertical(int y) => 
            Coordinates = new KeyValuePair<int, int>(Coordinates.Key, Coordinates.Value + y);


        public override string ToString() =>
            $"Coordinate: X - {Coordinates.Key}, Y - {Coordinates.Value}\n" +
            $"Color - {Color}\n" +
            $"Hidden - {Hidden}\n";
    }
}

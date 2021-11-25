

namespace _7_Lesson
{
    public class BCoder : ICoder
    {
        private string _internalString;
        public string InternalString
        {
            get => _internalString;
            set
            {
                _internalString = value;
            }
        }


        public BCoder(string inString)
        {
            InternalString = inString;
        }



        public string Decode()
        {
            string temp = "";

            foreach (var c in InternalString)
            {

                temp += Char.IsUpper(c) ? (char) ('A' + ('Z' - c)) : (char) ('a' + ('z' - c));
            }
            return temp;
        }


        public string Encode()
        {
            string temp= "";

            foreach (var c in InternalString)
            {
                temp += Char.IsUpper(c) ? (char) ('Z' - (c - 'A')) : (char) ('z' - (c - 'a'));
            }
            InternalString = temp;
            return temp;
        }
    }
}

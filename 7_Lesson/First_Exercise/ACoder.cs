

namespace _7_Lesson
{
    //Свойство принимает обычные строки и сразу их кодирует
    //Т.к. в интерфейсе методы не имеют аргументов, пришлось сперва присваивать внутренней строке
    //значение некодированной строки а потом ее кодировать и переприсваивать закодированное значение
    public class ACoder : ICoder
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

        public ACoder(string inString) 
        {
            InternalString = inString;
        }


        public string Decode()
        {
            string temp = "";
            foreach (char c in InternalString)
            {
                temp += (char) (c - 1);
            }

            return temp;
        }



        public string Encode()
        {
            string temp = "";
            foreach (char c in InternalString)
            {
                temp += (char)(c + 1);
            }

            _internalString = temp;

            return InternalString;
        }
    }
}

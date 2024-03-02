namespace _20._02
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = new String("Hello world");
            Console.WriteLine($"String: {str}. Length: {str.Length}");
            String str2 = new String(str, 6);
            Console.WriteLine($"String: {str2}. Length: {str2.Length}");
            String str3 = new String(10);
            Console.WriteLine($"String: {str3}. Length: {str3.Length}");

        }
        public class String
        {
            public char[] characters;
            public int Length
            {
                get { return characters.Length; }
            }
            public String(string str)
            {
                characters = str.ToCharArray();
            }
            public String(int length)
            {
                characters = new char[length];
            }
            public String(String otherString, int n)
            {
                if (n > otherString.Length)
                    throw new ArgumentException("The length to copy cannot be bigger than the length of the original string.");

                characters = new char[n];
                Array.Copy(otherString.characters, characters, n);
            }
            public char this[int index]
            {
                get
                {
                    if (index < 0 || index >= characters.Length)
                        throw new IndexOutOfRangeException("Index is out of range.");

                    return characters[index];
                }
                set
                {
                    if (index < 0 || index >= characters.Length)
                        throw new IndexOutOfRangeException("Index is out of range.");

                    characters[index] = value;
                }
            }
            public override string ToString()
            {
                return new string(characters);
            }
        }
    }
}

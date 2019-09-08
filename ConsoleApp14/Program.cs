using ClassLibrary1;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        [Mode(Mode.Mode1 | Mode.Mode2)]
        public int Property { get; set; }
    }
}

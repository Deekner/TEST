using System;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Dennis", 26);
            SayHi("John", 28);
            SayHi("Thomas", 28);

        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hi {0}", name + "Your age is " + age);
        }
    }
}

using System;

namespace SimpleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Students s = new Students();
            s.Id = 1;
            s.Name = "nilesh";
            s.Introduction();
            Console.ReadKey();
        }
    }

    
}

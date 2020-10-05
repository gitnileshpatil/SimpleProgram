using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleProgram
{
    class Students
    {
        public int Id;
        public string Name;

        public void Introduction()
        {
            Console.WriteLine("My name is:" + Name + "and Id is" + Id);
        }
    }
}

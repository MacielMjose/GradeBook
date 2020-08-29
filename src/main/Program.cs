using System;
using System.Collections.Generic;

namespace GradeBookProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var bdf = new Book("asudhauishd");
            bdf.addGrade(10);
            bdf.addGrade(20);
            Console.WriteLine(bdf.average());
        }
    }
}

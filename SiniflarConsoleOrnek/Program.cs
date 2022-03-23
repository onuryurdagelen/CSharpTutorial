using System;

namespace SiniflarConsoleOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeOfStudents tevfik = new GradeOfStudents();
            tevfik.Chemistry = 40;
            tevfik.Mathematics = 60;
            tevfik.Physics = 70;

            GradeOfStudents ozan = new GradeOfStudents();
            ozan.Physics = 75;
            ozan.Mathematics = 40;
            ozan.Chemistry = 50;

            tevfik = ozan;
            Console.WriteLine(tevfik.Mathematics); //40
            Console.WriteLine(tevfik.Physics); // 75
            Console.WriteLine(tevfik.Chemistry); // 50

            Console.WriteLine("****************");

            tevfik.Chemistry = 80;

            Console.WriteLine(ozan.Chemistry); // 50
            Console.WriteLine(tevfik.Physics); // 75
        }
    }
}

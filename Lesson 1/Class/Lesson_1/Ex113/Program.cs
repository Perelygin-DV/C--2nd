using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex113
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            Robot robot2 = new Robot(Name: "Имя_1");
            Robot robot3 = new Robot(Name: "Имя_1");
            Robot robot4 = new Robot(Name: "Имя_1");

            Console.WriteLine($"{robot.Name} {robot.Level}");
            Console.WriteLine($"{robot2.Name} {robot.Level}");
            Console.WriteLine($"{robot3.Name} {robot.Level}");
            Console.WriteLine($"{robot4.Name} {robot.Level}");
        }
    }
}

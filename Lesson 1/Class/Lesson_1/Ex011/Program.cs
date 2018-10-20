using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex011
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot(Name: "Имя_1", Level: 1);
            Robot robot2 = new Robot(Name: "Имя_1", Level: 1);
            Robot robot3 = new Robot(Name: "Имя_1", Level: 1);
            Robot robot4 = new Robot(Name: "Имя_1", Level: 1);

            Console.WriteLine($"{robot.Name} {robot.Level}");
            Console.WriteLine($"{robot2.Name} {robot.Level}");
            Console.WriteLine($"{robot3.Name} {robot.Level}");
            Console.WriteLine($"{robot4.Name} {robot.Level}");
 
        }
    }
}

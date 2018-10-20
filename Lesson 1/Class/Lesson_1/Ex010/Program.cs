using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex010
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot(Name: "Имя_1", Level: 1);

            Console.WriteLine($"{robot.Name} {robot.Level}");

            robot.StartBIOS();
            robot.StartOS();
            robot.SayHi();

            //////

            robot.SayBye();
            robot.StopOS();
            robot.StopBIOS();



        }
    }
}

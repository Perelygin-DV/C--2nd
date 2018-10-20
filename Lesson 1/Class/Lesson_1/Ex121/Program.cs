using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex121
{
    class Program
    {
        static void Main(string[] args)
        {
            HeroAgillity heroAgillity = new HeroAgillity();
            HeroIntelligence heroIntelligence = new HeroIntelligence();
            HeroStrength heroStrength = new HeroStrength();

            Console.WriteLine(heroAgillity.GetInfo());
            Console.WriteLine(heroIntelligence.GetInfo());
            Console.WriteLine(heroStrength.GetInfo());
            Console.WriteLine();

            heroAgillity.GetDamage(heroStrength.Attack());
            Console.WriteLine(heroAgillity.GetInfo());

            heroAgillity.GetDamage(heroStrength.Attack());
            Console.WriteLine(heroAgillity.GetInfo());

            heroAgillity.ToBeHealed(heroIntelligence.Healing());
            Console.WriteLine(heroAgillity.GetInfo());

            heroAgillity.ToBeHealed(heroIntelligence.Healing());
            Console.WriteLine(heroAgillity.GetInfo());

        }
    }
}

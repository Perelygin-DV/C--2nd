using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex123
{
    class Program
    {
        static void Main(string[] args)
        {


            HeroBase hero = new HeroBase();
            Console.WriteLine(hero.GetInfo());

            hero = new HeroIntelligence();
            Console.WriteLine(hero.GetInfo());

            HeroIntelligence a = new HeroIntelligence();
            Console.WriteLine(a.GetInfo());

            hero = new HeroAgillity();
            Console.WriteLine(hero.GetInfo());

            hero = new HeroStrength();
            Console.WriteLine(hero.GetInfo());

            return;


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

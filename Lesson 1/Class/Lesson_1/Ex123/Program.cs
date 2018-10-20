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
            #region Ex4

          
            List<HeroBase> team = new List<HeroBase>();

            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                switch (r.Next(0, 3))
                {
                    case 0: team.Add(new HeroIntelligence()); break;
                    case 1: team.Add(new HeroAgillity()); break;
                    default: team.Add(new HeroStrength()); break;
                }

               Console.WriteLine(team[i].GetInfo());
            }

            if (team[0].GetType() == typeof(HeroIntelligence))
            {
                Console.WriteLine("Лечим");

                ((HeroIntelligence)team[0]).Healing(team[0]);
            }
            else
            {
                Console.WriteLine("Не HeroIntelligence");
            }


            if (team[0] is HeroIntelligence)
            {
                Console.WriteLine("Лечим");

                (team[0] as HeroIntelligence).Healing(team[0]);
            }
            else
            {
                Console.WriteLine("Не HeroIntelligence");
            }

            #endregion


            #region Ex3

            //HeroBase hero = new HeroBase();
            //Console.WriteLine(hero.GetInfo());

            //hero = new HeroIntelligence();
            //Console.WriteLine(hero.GetInfo());

            //hero = new HeroAgillity();
            //Console.WriteLine(hero.GetInfo());

            //hero = new HeroStrength();
            //Console.WriteLine(hero.GetInfo());

            #endregion

            #region Ex2

            //int teamCount = 10;

            //Random r = new Random();
            //int agillity = r.Next(0, teamCount);
            //int intelligence = r.Next(0, teamCount - agillity);
            //int strength = teamCount - agillity - intelligence;

            //Console.WriteLine($"{agillity} {intelligence} {strength}");

            //HeroAgillity[] heroAgillities = new HeroAgillity[agillity];
            //HeroIntelligence[] heroIntelligences = new HeroIntelligence[intelligence];
            //HeroStrength[] heroStrengths = new HeroStrength[strength];

            //for (int i = 0; i < heroAgillities.Length; i++)
            //{
            //    heroAgillities[i] = new HeroAgillity();
            //    Console.WriteLine(heroAgillities[i].GetInfo());
            //} 


            //for (int i = 0; i < heroIntelligences.Length; i++)
            //{
            //    heroIntelligences[i] = new HeroIntelligence();
            //    Console.WriteLine(heroIntelligences[i].GetInfo());
            //}

            //for (int i = 0; i < heroStrengths.Length; i++)
            //{
            //    heroStrengths[i] = new HeroStrength();
            //    Console.WriteLine(heroStrengths[i].GetInfo());
            //}

            #endregion

            #region Ex1

            //HeroAgillity heroAgillity = new HeroAgillity();
            //HeroIntelligence heroIntelligence = new HeroIntelligence();
            //HeroStrength heroStrength = new HeroStrength();

            //Console.WriteLine(heroAgillity.GetInfo());
            //Console.WriteLine(heroIntelligence.GetInfo());
            //Console.WriteLine(heroStrength.GetInfo());
            //Console.WriteLine();

            ////heroAgillity.GetDamage(heroStrength.Attack());


            //heroStrength.Attack(heroAgillity);
            //Console.WriteLine(heroAgillity.GetInfo());

            //heroStrength.Attack(heroAgillity);
            //Console.WriteLine(heroAgillity.GetInfo());

            //heroIntelligence.Healing(heroAgillity);
            //Console.WriteLine(heroAgillity.GetInfo());

            //heroIntelligence.Healing(heroAgillity);
            //Console.WriteLine(heroAgillity.GetInfo());

            #endregion



        }
    }
}

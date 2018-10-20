using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex121
{
    class HeroStrength
    {
        private static int number;
        private static Random r;

        private string name;
        private int hp;
        private int maxHp;

        private int casting;
        private int rage;
        private int maxRage;

        static HeroStrength()
        {
            HeroStrength.number = 0;
            HeroStrength.r = new Random();
        }


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Name">Имя героя</param>
        /// <param name="Hp">Максимальное количество здоровья</param>
        /// <param name="Rage">Максимальное количество Ярости</param>
        public HeroStrength(string Name, int Hp, int Rage)
        {
            this.name = Name;
            this.hp = Hp;
            this.maxHp = Rage;
            this.rage = Rage;
            this.maxRage = Rage;
            this.casting = 10;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public HeroStrength() :
            this($"Hero #{++HeroStrength.number}",
                HeroStrength.r.Next(200, 300),
                HeroStrength.r.Next(150, 200)
                )
        {

        }

        /// <summary>
        /// Метод, описывающий атаку
        /// </summary>
        /// <returns></returns>
        public int Attack()
        {
            if (this.rage - casting >= 0) { return HeroStrength.r.Next(10, 20); }
            else { return 0; }
        }


        /// <summary>
        /// Метод, описывающий инфрмацию о герое
        /// </summary>
        /// <returns>Состояние объекта</returns>
        public string GetInfo()
        {
            return $"Name: {this.name,10} Hp: {this.hp,4} Rage: {this.rage,4} Type: {this.GetType(),15}";
        }

        /// <summary>
        /// Метод, описывающий логику получения лечения
        /// </summary>
        /// <param name="Hp">Количество лечения</param>
        public void ToBeHealed(int Hp)
        { this.hp = Hp + this.hp > this.maxHp ? this.maxHp : Hp + this.hp; }

        /// <summary>
        /// Метод, описывающий логику получения урона
        /// </summary>
        /// <param name="Damage">Количество урона</param>
        public void GetDamage(int Damage)
        {
            if (this.hp - Damage > 0) { this.hp -= Damage; }
            // else { Die(); }
        }
    }
}

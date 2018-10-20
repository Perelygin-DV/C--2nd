using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex121
{
    /// <summary>
    /// Класс HeroAgillity
    /// </summary>
    class HeroAgillity
    {
        private static int number;
        private static Random r;

        private string name;
        private int hp;
        private int maxHp;

        private int mp;
        private int maxMp;

        static HeroAgillity()
        {
            HeroAgillity.number = 0;
            HeroAgillity.r = new Random();
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Name">Имя героя</param>
        /// <param name="Hp">Максимальное количество здоровья</param>
        /// <param name="Mp">Максимальное количество маны</param>
        public HeroAgillity(string Name, int Hp, int Mp)
        {
            this.name = Name;
            this.hp = Hp;
            this.maxHp = Hp;
            this.mp = Mp;
            this.maxMp = Mp;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public HeroAgillity() :
            this($"Hero #{++HeroAgillity.number}", 
                HeroAgillity.r.Next(100, 200),
                HeroAgillity.r.Next(50, 150)
                )
        {

        }

        /// <summary>
        /// Метод, описывающий атаку
        /// </summary>
        /// <returns></returns>
        public int Attack()
        {
            return HeroAgillity.r.Next(10, 20);
        }

        /// <summary>
        /// Метод, описывающий инфрмацию о герое
        /// </summary>
        /// <returns>Состояние объекта</returns>
        public string GetInfo()
        {
            return $"Name: {this.name, 10} Hp: {this.hp, 4} Mp: {this.mp,4} Type: {this.GetType(), 15} ";
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

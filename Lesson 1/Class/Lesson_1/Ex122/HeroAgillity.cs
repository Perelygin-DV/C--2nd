using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex123
{
    class HeroAgillity: HeroBase
    {
        private int mp;
        private int maxMp;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Name">Имя героя</param>
        /// <param name="Hp">Максимальное количество здоровья</param>
        /// <param name="Mp">Максимальное количество маны</param>
        public HeroAgillity(string Name, int Hp, int Mp):base(Name, Hp)
        {
            this.mp = Mp;
            this.maxMp = Mp;
            
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public HeroAgillity() :
            this($"Hero #{++HeroBase.number}",
                HeroBase.r.Next(100, 200),
                HeroBase.r.Next(50, 150)
                )
        {
            
        }

        /// <summary>
        /// Метод, описывающий атаку
        /// </summary>
        /// <returns></returns>
        public int Attack()
        {
            return HeroBase.r.Next(10, 20);
        }

        /// <summary>
        /// Метод, описывающий инфрмацию о герое
        /// </summary>
        /// <returns>Состояние объекта</returns>
        public string GetInfo()
        {
            return base.GetInfo()+ $" Mp: {this.mp}";
        }

    }
}

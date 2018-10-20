using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex121
{
    public class Hero
    {
        private string name;
        private int hp;
        private int maxHp;
        private static int number;
        private static Random r;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Name">Имя героя</param>
        /// <param name="Hp">Максимальное количество здоровья</param>
        public Hero(string Name, int Hp)
        {
            this.name = Name;
            this.hp = Hp;
            this.maxHp = Hp;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Hero() :
            this($"Hero #{++Hero.number}", Hero.r.Next(100, 200))
        {

        }

        /// <summary>
        /// Метод, описывающий инфрмацию о герое
        /// </summary>
        /// <returns>Состояние объекта</returns>
        public string GetInfo()
        {
            return $"Name: {this.name,15} Hp: {this.hp,5} Type: {this.GetType(),15} ";
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

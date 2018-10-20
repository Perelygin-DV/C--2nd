using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex010
{
    public class Robot
    {
        /// <summary>
        /// Уровень робота
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// Имя робота
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Создание робота
        /// </summary>
        /// <param name="Name">Имя робота !Не должно начинаться с цифры</param>
        /// <param name="Level">Уровень робота</param>
        public Robot(string Name, int Level)
        {
            this.Name = Name;
            this.Level = Level;
        }

        #region Методы вкл\выкл подсистем

        /// <summary>
        /// Загрузка BIOS
        /// </summary>
        public void StartBIOS() { Console.WriteLine("Start BIOS..."); }

        /// <summary>
        /// Загрузка OS
        /// </summary>
        public void StartOS() { Console.WriteLine("Start OS..."); }

        /// <summary>
        /// Приветствие
        /// </summary>
        public void SayHi() { Console.WriteLine("Hello world..."); }

        /// <summary>
        /// Выгрузка BIOS
        /// </summary>
        public void StopBIOS() { Console.WriteLine("Stop BIOS..."); }
        
        /// <summary>
        /// Выгрузка OS
        /// </summary>
        public void StopOS() { Console.WriteLine("Stop OS..."); }

        /// <summary>
        /// Прощание
        /// </summary>
        public void SayBye() { Console.WriteLine("Bye..."); }

        #endregion


    }
}

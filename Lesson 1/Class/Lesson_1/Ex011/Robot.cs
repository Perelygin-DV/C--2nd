using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex011
{
    public class Robot
    {

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


        /// <summary>
        /// Уровень робота
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// Имя робота
        /// </summary>
        public string Name { get; set; }

        #region Инкапсуляция v 1.0
        /// <summary>
        /// Метод включения
        /// </summary>
        public void PowerOn()
        {
            this.StartBIOS();
            this.StartOS();
            this.SayHi();
        }

        /// <summary>
        /// Метод выключения
        /// </summary>
        public void PowerOff()
        {
            this.SayBye();
            this.StopOS();
            this.StopBIOS();
        }

        #endregion


        #region Методы вкл\выкл подсистем

        /// <summary>
        /// Загрузка BIOS
        /// </summary>
        private void StartBIOS() { Console.WriteLine("Start BIOS..."); }

        /// <summary>
        /// Загрузка OS
        /// </summary>
        private void StartOS() { Console.WriteLine("Start OS..."); }

        /// <summary>
        /// Приветствие
        /// </summary>
        private void SayHi() { Console.WriteLine("Hello world..."); }

        /// <summary>
        /// Выгрузка BIOS
        /// </summary>
        private void StopBIOS() { Console.WriteLine("Stop BIOS..."); }

        /// <summary>
        /// Выгрузка OS
        /// </summary>
        private void StopOS() { Console.WriteLine("Stop OS..."); }

        /// <summary>
        /// Прощание
        /// </summary>
        private void SayBye() { Console.WriteLine("Bye..."); }

        #endregion

    }
}

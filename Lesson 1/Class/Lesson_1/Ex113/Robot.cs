using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex113
{
    /// <summary>
    /// Состояния робота
    /// </summary>
    enum State
    {
        /// <summary>
        /// Включен
        /// </summary>
        PowerOn,

        /// <summary>
        /// Выключен
        /// </summary>
        PowerOff
    }

    public class Robot
    {

        static int DefaultIndex;
        static List<string> nameCol;

        /// <summary>
        /// Статитеческий конструктор
        /// </summary>
        static Robot()
        {
            nameCol = new List<string>();
            DefaultIndex = 1;
        }

        private Robot(string Name, int Level)
        {
            if ((Name == String.Empty || char.IsDigit(Name[0])) || Robot.nameCol.IndexOf(Name) != -1)
            { this.name = $"DefaultName_{Robot.DefaultIndex++}"; }

            else { this.name = Name; Robot.nameCol.Add(Name); }
            this.level = Level;
            this.state = State.PowerOff;
        }

        public Robot(string Name): this(Name, 1)
        {
 
        }

        public Robot(): this(String.Empty)
        {
 
        }

        #region Инкапсуляция v 2.0

        private State state;
     
        /// <summary>
        /// Включение / Выключение робота
        /// </summary>
        public void Power()
        {
            if (this.state == State.PowerOn)
            {
                this.PowerOff();
                this.state = State.PowerOff;
            }
            else
            {
                this.PowerOn();
                this.state = State.PowerOn;
            }
        }

        #endregion

        #region Инкапсуляция v 1.0
        /// <summary>
        /// Метод включения
        /// </summary>
        private void PowerOn()
        {
            this.StartBIOS();
            this.StartOS();
            this.SayHi();
        }

        /// <summary>
        /// Метод выключения
        /// </summary>
        private void PowerOff()
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


        private int level;
        private string name;

        /// <summary>
        /// Уровень робота
        /// </summary>
        public int Level
        {
            get { return this.level; }
            private set { this.level = value; }
        }

        /// <summary>
        /// Имя робота
        /// </summary>
        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
    }
}

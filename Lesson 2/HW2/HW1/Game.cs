using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace HW1
{

	static class Game
	{
		private static BufferedGraphicsContext _context;
		private static Bullet _bullet;
		private static Asteroid[] _asteroids;
	
		public static BufferedGraphics Buffer;
		public static BaseObject[] _objs;
		public static Random r = new Random();
		//private static int width;
		//private static int height;
		// Свойства
		// Ширина и высота игрового поля
		public static int Width { get; set; }
		public static int Height { get; set; }

		//public static int Width { get { return width; } set { if (value > 1000 || value < 0) throw new ArgumentOutOfRangeException( $"{nameof(value)} must be more than 0 and less than 1000"); width = value; }  }
		//public static int Height {	get { return height; }	set	{	if (value > 1000 || value < 0) throw new ArgumentOutOfRangeException($"{nameof(value)} must be more than 0 and less than 1000"); height = value;	}}

		static Game()
		{
		}
		public static void Init(Form form)
		{
			// Графическое устройство для вывода графики            
			Graphics g;
			// Предоставляет доступ к главному буферу графического контекста для текущего приложения
			_context = BufferedGraphicsManager.Current;
			g = form.CreateGraphics();
			// Создаем объект (поверхность рисования) и связываем его с формой
			// Запоминаем размеры формы
			Width = form.ClientSize.Width;
			Height = form.ClientSize.Height;
			// Связываем буфер в памяти с графическим объектом, чтобы рисовать в буфере
			Buffer = _context.Allocate(g, new Rectangle(0, 0, Width, Height));

			Timer timer = new Timer { Interval = 100 };
			timer.Start();
			timer.Tick += Timer_Tick;
			Load();

		}

		private static void Timer_Tick(object sender, EventArgs e)
		{
			Draw();
			Update();
		}

		public static void Draw()
		{
		
			Buffer.Graphics.Clear(Color.Black);
			foreach (BaseObject obj in _objs)
				obj.Draw();
			foreach (Asteroid a in _asteroids)
				a.Draw();
			_bullet.Draw();
			Buffer.Render();
			
		}

		public static void Update()
		{
			foreach (BaseObject obj in _objs)
				obj.Update();
			foreach (Asteroid a in _asteroids)
			{
				a.Update();
				if (a.Collision(_bullet)) { System.Media.SystemSounds.Hand.Play();a.Update(); }
			}
			_bullet.Update();

		}



		public static void Load()
		{
			_objs = new BaseObject[30];
			_bullet = new Bullet(new Point(0, 200), new Point(5, 0), new Size(4, 1));
			_asteroids = new Asteroid[3];
			var rnd = new Random();
			for (var i = 0; i < _objs.Length; i++)
			{
				int r = rnd.Next(5, 50);
				_objs[i] = new Star(new Point(1000, rnd.Next(0, Game.Height)), new Point(-r, r), new Size(3, 3));
			}
			for (var i = 0; i < _asteroids.Length; i++)
			{
				int r = rnd.Next(5, 50);
				_asteroids[i] = new Asteroid(new Point(1000, rnd.Next(0, Game.Height)), new Point(-r / 5, r), new Size(r, r));
			}
		}


	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HW1
{
	class MyObject1 : BaseObject
	{
		
		public MyObject1(Point pos, Point dir, Size size) : base(pos, dir, size)
		{
		}
		public override void Draw()
		{
			Game.Buffer.Graphics.DrawRectangle(Pens.Red, Pos.X, Pos.Y, Size.Width, Size.Height);
			
		}
		public override void Update()
		{
			Pos.Y = Pos.Y - Dir.Y;
			Pos.X = Pos.X - Dir.X;
			if (Pos.X < 0) Dir.X = -Dir.X;
			if (Pos.X > Game.Width) Dir.X = -Dir.X;
			if (Pos.Y < 0) Dir.Y = -Dir.Y;
			if (Pos.Y > Game.Height) Dir.Y = -Dir.Y;
		}

	}

}
using System.Drawing;

namespace HW1
{
	interface ICollision
	{
		bool Collision(ICollision obj);
		Rectangle Rect { get; }
	}
}

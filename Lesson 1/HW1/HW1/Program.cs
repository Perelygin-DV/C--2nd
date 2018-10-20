using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1
{
	class Program
	{
		static void Main(string[] args)
		{
			Form1 form = new Form1();
			form.Width = 800;
			form.Height = 600;
			Game.Init(form);
			form.Show();
			Game.Draw();
			Application.Run(form);
		}
	}
}


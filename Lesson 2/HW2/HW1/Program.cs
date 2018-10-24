using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;

namespace HW1
{

	class Program
	{
		static void Main(string[] args)
		{
			
			Form1 form = new Form1();
			{
				
				

				try
				{
					form.Width = Screen.PrimaryScreen.Bounds.Width;
					form.Height = Screen.PrimaryScreen.Bounds.Height;
					if (form.Width < 0 || form.Width > 1000) throw new ArgumentOutOfRangeException();
					if (form.Height < 0 || form.Height > 1000) throw new ArgumentOutOfRangeException();
				}
				catch (ArgumentOutOfRangeException e)
				{
					MessageBox.Show("Значение Width и/или Height превышает 1000");
					form.Width = Screen.PrimaryScreen.Bounds.Width;
					form.Height = Screen.PrimaryScreen.Bounds.Height;
				}
			};

			Game.Init(form);
			form.Show();
			Game.Load();
			Game.Draw();
			Application.Run(form);
		}
	}
}


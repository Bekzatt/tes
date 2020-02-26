using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecchia

{
	class Shenber
	{
		private int x, y;
		private double r;
		public int X
		{
			get { return x; }
			set { x = value; }
		}
		public int Y
		{
			get { return y; }
			set { y = value; }
		}
		public double R
		{
			get { return r; }
			set { if (value > 0)
					r = value;
				else r = 1;
			}
		}
	}
	class Program
	{ 
		static void Main(string[] args)
		{
			Shenber A = new Shenber();
			 A.X = 5;A.R = -3; A.Y = 2;
				Console.WriteLine(A.X + " " + A.Y + " " + A.R);
		}
	}
}

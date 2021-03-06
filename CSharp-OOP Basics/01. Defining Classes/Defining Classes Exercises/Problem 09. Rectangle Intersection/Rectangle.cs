﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_09.Rectangle_Intersection
{
	class Rectangle
	{

		

		public string ID { get; set; }
		public double Width { get; set; }
		public double Height { get; set; }
		public double  X { get; set; }
		public double Y { get; set; }


		public bool IntersectsWith(Rectangle rect)
		{
			if (Math.Abs(this.X) < Math.Abs(rect.X + rect.Width))
			{
				if (Math.Abs(this.X + this.Width) >= Math.Abs(rect.X))
				{
					if (this.Y < Math.Abs((rect.Y - rect.Height)))
					{
						if (Math.Abs(this.Y + this.Height) >= Math.Abs(rect.Y))
						{
							return true;
						}
					}
				}
			}

			return false;
		}
	}
}

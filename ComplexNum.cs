using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHS
{
	class ComplexNum
	{
		float x, y;
		byte pr;

		public ComplexNum(float x, float y, int type)
		{
			this.x = x;
			this.y = y;
			this.pr = (byte)type;
		}

		public String getCN()
		{
			if (x == 0 && y == 0) return "z = 0";
			else if(pr == 1)
				return "z = " + (x == 0 ? "" : x.ToString()) + (y < 0 ? "" : "+") + (y == 0 ? "" : (y.ToString() + "i"));
			else
			{
				float r = (float)Math.Sqrt(x*x - y*y);
				float f1 = (float)Math.Acos(x / r);								//!!!
				float f2 = (float)Math.Asin(y / r);								//!!!

				return "z = " + r + "*(cos(" + f1 + ") + i*sin(" + f2 + "))";
			}
		}

		public static ComplexNum operator +(ComplexNum a, ComplexNum b)
		{
			return new ComplexNum(a.x + b.x, a.y + b.y, 1);
		}

		public static ComplexNum operator -(ComplexNum a, ComplexNum b)
		{
			return new ComplexNum(a.x - b.x, a.y - b.y, 1);
		}

		public static ComplexNum operator *(ComplexNum a, ComplexNum b)
		{
			return new ComplexNum(a.x * b.x - a.y * b.y, a.x * b.y + a.y * b.x, 1);
		}

		public static ComplexNum operator /(ComplexNum a, ComplexNum b)
		{
			if (b.x == 0 && b.y == 0) return null;
			return new ComplexNum((a.x * b.x + a.y * b.y)/(b.x*b.x + b.y*b.y), (a.y * b.x + a.x * b.y)/(b.x * b.x + b.y * b.y), 1);
		}
	}
}

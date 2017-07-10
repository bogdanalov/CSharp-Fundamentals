﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06.Animals
{
	class Dog : Animal
	{
		public Dog(string name, int age, string gender)
			: base(name,age,gender)
		{
		}
		public override string ProduceSound()
		{
			return "BauBau";
		}
	}
}

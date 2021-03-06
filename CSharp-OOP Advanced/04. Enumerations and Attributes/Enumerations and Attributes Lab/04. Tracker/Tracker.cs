﻿
using System;
using System.Linq;
using System.Reflection;

class Tracker
{
	public void PrintMethodsByAuthor()
	{
		var type = typeof(StartUp);
		var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);

		foreach (var methodInfo in methods)
		{
			if (methodInfo.CustomAttributes.Any(n=> n.AttributeType == typeof(SoftUniAttribute)))
			{
				var attrs = methodInfo.GetCustomAttributes(false);
				foreach (SoftUniAttribute softUniAttribute in attrs)
				{
					Console.WriteLine($"{methodInfo.Name} is written by {softUniAttribute.Name}");
				}
			}
		}

	}
}


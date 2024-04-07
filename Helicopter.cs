using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Laba10
{
	public class Helicopter : Aircraft, ICloneable
	{
		protected int bladesNumber;

		public int BladesNumber
		{
			get { return bladesNumber; }
			set
			{
				if (value < 0)
				{
					bladesNumber = 0;
				}
				else
				{
					bladesNumber = value;
				}
			}
		}

		public Helicopter() : base()
		{
			bladesNumber = 0;
		}

		public Helicopter(string model, int year, string type, int number, int bladesNumber) : base(model, year, type, number)
		{
			BladesNumber = bladesNumber;
		}

		public override void Show()
		{
			Console.WriteLine($"Helicopter: \nМодель = {Model}, \nГод производства = {Year}, \nТип двигателя = {Type}, \nКоличество людей экипажа = {Number}, \nКоличество лопастей = {BladesNumber}");
		}

		public override void Init()
		{
			base.Init();

			Console.WriteLine("Введите, пожалуйста, количество лопастей:");
			try
			{
				BladesNumber = int.Parse(Console.ReadLine());
			}
			catch
			{
				BladesNumber = 10;
			}
		}

		public override void RandomInit()
		{
			base.RandomInit();
			BladesNumber = rnd.Next(1, 500);
		}

		public override string ToString()
		{
			return $"{base.ToString()}, {BladesNumber}";
		}


		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;

			Helicopter otherHelicopter = (Helicopter)obj;
			return Model == otherHelicopter.Model && Year == otherHelicopter.Year && Type == otherHelicopter.Type && Number == otherHelicopter.Number && BladesNumber == otherHelicopter.BladesNumber;
		}

		public object Clone()
		{
			return new Helicopter(Model, Year, Type, Number, BladesNumber);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}

}

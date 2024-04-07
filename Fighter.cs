using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba10
{
	public class Fighter : Plane
	{
		protected string fighterClass;
		static string[] Classes = { "Фронтовой", "Перехватчик", "Палубный", "Многофункциональный", "Тактический" };

		public string FighterClass { get; set; }

		public Fighter() : base()
		{
			FighterClass = "Нет";
		}

		public Fighter(string model, int year, string type, int number, int passengersNumber, int range, string fighterClass) : base(model, year, type, number, passengersNumber, range)
		{
			FighterClass = fighterClass;
		}

		public override void Show()
		{
			Console.WriteLine($"Fighter: \nМодель = {Model}, \nГод производства = {Year}, \nТип двигателя = {Type}, \nКоличество людей экипажа = {Number},  \nКоличество пассажиров {PassengersNumber}, \nДальность полета = {Range}, \nКласс = {FighterClass}");
		}

		public override void Init()
		{
			base.Init();

			Console.WriteLine("Введите, пожалуйста, класс по функциям (например, фронтовой)");
			FighterClass = Console.ReadLine();

		}
		public override void RandomInit()
		{
			base.RandomInit();

			FighterClass = Classes[rnd.Next(Classes.Length)];
		}
		public override string ToString()
		{
			return base.ToString() + $", класс {FighterClass}";
		}

		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;

			Fighter otherFighter = (Fighter)obj;
			return Model == otherFighter.Model && Year == otherFighter.Year && Type == otherFighter.Type && Number == otherFighter.Number && PassengersNumber == otherFighter.PassengersNumber && Range == otherFighter.Range && FighterClass == otherFighter.FighterClass;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}

}

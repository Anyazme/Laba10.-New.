using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba10
{
	public class Runner : IInit, IComparable<Runner>
	{
		//инициализация полей
		public double speed;
		public double distance;
		//статическая переменная для подсчета количества объектов
		public static int count = 0;
		//инициализация свойства Speed
		public double Speed
		{
			get { return speed; }
			set
			{
				if (value > 0)
				{
					speed = value;
				}
				else
				{   //инициализация нового исключения
					throw new Exception("Скорость не может быть меньше 0");
				}
			}
		}
		//инициализация свойства Distance
		public double Distance
		{
			get { return speed; }
			set
			{
				if (value > 0)
				{
					distance = value;
				}
				else
				{   //инициализация нового исключения
					throw new Exception("Дистанция не может быть меньше 0");
				}
			}
		}
		//пустой конструктор (без параметров)
		public Runner()
		{
			Count();
		}
		//конструктор с параметрами
		public Runner(double speed, double distance)
		{
			this.Speed = speed;
			this.Distance = distance;

		}

		//конструктор копирования
		public Runner(Runner otherRunner)
		{
			this.speed = otherRunner.speed;
			this.distance = otherRunner.distance;

		}

		//вывод информации полей
		public void Show()
		{
			Console.WriteLine($"Runner: \nСредняя скорость = {Speed}, \nРасстояние {Distance}");
		}




		// сравнение двух объектов реализованного класса
		public override bool Equals(object obj)//метод сравнивает текущий объект класса с переданным
		{
			if (obj == null)
			{
				return false;
			}
			if (obj == null || GetType() != obj.GetType())
			{
				return false;
			}
			return ((Runner)obj).speed == this.speed && ((Runner)obj).distance == this.distance; //возвращает результаты сравнения

		}

		//представление в виде строки
		public override string ToString()
		{
			return $"Средняя скорость: {Speed} км/ч, Расстояние =  {Distance} км";
		}
		//подсчет количества созданных объектов
		public static void Count()
		{
			count++;
		}

		//вывод количества 
		public static int OutputCount()
		{
			return count;
		}

		// Метод для создания объекта
		public void Init()
		{
			this.Speed = speed;
			this.Distance = distance;
			Count();
		}

		public void RandomInit()
		{
			Random rnd = new Random();
			Speed = rnd.Next(1, 20); // Примерный диапазон скорости
			Distance = rnd.Next(1, 100); // Примерный диапазон расстояния
			Count();
		}

		public int CompareTo(Runner otherRunner)
		{
			if (otherRunner != null)
			{
				// Сравнение объектов по скорости
				return this.Speed.CompareTo(otherRunner.Speed);
			}
			else
			{
				throw new ArgumentException("Объект не принадлежит классу Runner");
			}
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}

}

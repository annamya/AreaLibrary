using System;

namespace AreaLibrary
{
    public class FigureArea
    {
        public abstract class Figure
        {
            public abstract string Area();
            public abstract string Name();
            public abstract string Checking();

            public void ShowInfo()
            {
                //Вывод информации в консоль
                Console.WriteLine($"Площадь: {Area()}\n" + $"Фигура: {Name()}\n" + Checking());
            }
        }
        public class Traingl : Figure
        {
            double SideA, SideB, SideC;

            //конструктор
            public Traingl(double sideA, double sideB, double sideC)
            {
                this.SideA = sideA;
                this.SideB = sideB;
                this.SideC = sideC;
            }

            public override string Checking()
            {
                //проверка является ли треугольник прямоугольным
                if ((SideA * SideA + SideB * SideB == SideC * SideC) || (SideA * SideA + SideC * SideC == SideB * SideB)
                    || (SideB * SideB + SideC * SideC == SideA * SideA))
                {
                    return "Прямоугольный";
                }
                return "Не прямоугольный";
            }

            public override string Area()
            {
                //вычисление по формуле
                double P = (SideA + SideB + SideC) / 2;
                return Math.Round(Math.Sqrt(P * (P - SideA) * (P - SideB) * (P - SideC))).ToString();
            }

            public override string Name()
            {
                return "Треугольник";
            }
        }

        public class Circle : Figure
        {
            double Radius;

            //конструктор
            public Circle(double radius)
            {
                Radius = radius;
            }

            public override string Area()
            {
                //вычисление по формуле
                return Math.Round((Math.PI * Math.Pow(Radius, 2))).ToString();
            }

            public override string Checking()
            {
                //возврат пустой строки, тк круг
                return "";
            }

            public override string Name()
            {
                return "Круг";
            }
        }
    }
}

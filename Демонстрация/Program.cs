using System;
using static AreaLibrary.FigureArea;

namespace Демонстрация
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 0;
            do
            {
                if (row == 0 || row >= 6)
                    ResetConsole();
                string inputD = Console.ReadLine();
                string[] inputData = inputD.Split(new Char[] { ' ' });
                if (inputData.Length == 1)
                {
                    double radius = double.Parse(inputData[0]);
                    Figure figure = new Circle(radius);
                    figure.ShowInfo();
                }
                else if (inputData.Length == 3)
                {
                    double _sideA = double.Parse(inputData[0]);
                    double _sideB = double.Parse(inputData[1]);
                    double _sideC = double.Parse(inputData[2]);

                    Figure figure = new Traingl(_sideA, _sideB, _sideC);
                    figure.ShowInfo();
                }
                row += 3;
            } while (true);
            //return;

            void ResetConsole()
            {
                if (row > 0)
                {
                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                    Console.ReadKey();
                }
                Console.Clear();
                Console.WriteLine("Введите данные через пробел. Для завершения ввода нажмите Enter");
                row += 3;
            }
        }
    }
}

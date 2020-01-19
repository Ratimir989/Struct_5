using System;

namespace Struct_5
{
    static class ForPrint
    {
        public static void Print(string stroka, int color)
        {
            Colors colors = (Colors)color;
            switch (colors)
            {
                case Colors.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(stroka);
                    break;
                case Colors.Cyan:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(stroka);
                    break;
                case Colors.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(stroka);
                    break;
                case Colors.Gray:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(stroka);
                    break;
                case Colors.Magenta:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(stroka);
                    break;
                case Colors.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(stroka);
                    break;
                case Colors.White:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(stroka);
                    break;
                case Colors.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(stroka);
                    break;
            }
        }
    }

    enum Colors
    {
        White = 1,
        Yellow,
        Red,
        Cyan,
        Blue,
        Green,
        Magenta,
        Gray
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input; int numOfColor;
            Console.WriteLine("Введите строку:");
            input = Console.ReadLine();
            Console.WriteLine("Теперь выберите цвет текста. 1-Белый, 2-Желтый, 3-Красный, 4-Голубо-зеленый, 5-Синий, 6-Зеленый, 7-Пурпурный, 8-Серый");
            numOfColor = Convert.ToInt32(Console.ReadLine());
            if (numOfColor < 1 || numOfColor > 8) { Console.WriteLine("Wrong input!"); }
            else
            {
                Console.WriteLine("Ваша информация: ");
                ForPrint.Print(input, numOfColor);
            }
            Console.ReadKey();
        }
    }
}

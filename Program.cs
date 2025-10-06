//1.Напишите перечисление DayOfWeek, которое содержит значения для дней недели: Monday, Tuesday, Wednesday, Thursday, Friday,
//Saturday и Sunday. Затем напишите метод, который принимает на вход значение этого перечисления и выводит на консоль соответствующий
//день недели на русском языке.
//2. Напишите перечисление Color, которое содержит значения для цветов: Red, Green, Blue, Yellow, Cyan и Magenta.
//Затем напишите метод, который принимает на вход значение этого перечисления и возвращает его шестнадцатеричный код
//в виде строки.
//3. Напишите перечисление Operation, которое содержит значения для арифметических операций: Add, Subtract, Multiply
//и Divide. Затем напишите метод, который принимает на вход два числа и значение этого перечисления и возвращает
//результат выполнения соответствующей операции над числами.
using System;

namespace KT6
{
    enum DayOfWeek {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday

    }

    enum Color {
        Red,
        Green,
        Blue,
        Yellow,
        Cyan,
        Magenta
    }

    enum Operation {
        Add,
        Subtract,
        Multiply,
        Divide
    }

    class Program
    {

        static void DayWRu(DayOfWeek day)
        {
            string russianDay;

            switch (day)
            {
                case DayOfWeek.Monday:
                    russianDay = "Понедельник";
                    break;
                case DayOfWeek.Tuesday:
                    russianDay = "Вторник";
                    break;
                case DayOfWeek.Wednesday:
                    russianDay = "Среда";
                    break;
                case DayOfWeek.Thursday:
                    russianDay = "Четверг";
                    break;
                case DayOfWeek.Friday:
                    russianDay = "Пятница";
                    break;
                case DayOfWeek.Saturday:
                    russianDay = "Суббота";
                    break;
                case DayOfWeek.Sunday:
                    russianDay = "Воскресенье";
                    break;
                default:
                    russianDay = "Неизвестный день";
                    break;
            }

            Console.WriteLine($"{day} -> {russianDay}");
        }

        static string HexCode(Color code)
        {
            switch (code)
            {
                case Color.Red:
                    return "#FF0000";
                case Color.Green:
                    return "#00FF00";
                case Color.Blue:
                    return "#0000FF";
                case Color.Yellow:
                    return "#FFFF00";
                case Color.Cyan:
                    return "#00FFFF";
                case Color.Magenta:
                    return "#FF00FF";
                default:
                    return "#000000";
            }
        }

        static double Calculate(double a, double b, Operation operation)
        {
            switch (operation)
            {
                case Operation.Add:
                    return a + b;
                case Operation.Subtract:
                    return a - b;
                case Operation.Multiply:
                    return a * b;
                case Operation.Divide:
                    if (b == 0)
                        throw new DivideByZeroException("Деление на ноль!");
                    return a / b;
                default:
                    throw new ArgumentException("Неизвестная операция");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Перевод дней недели на русский:");
            
            DayWRu(DayOfWeek.Monday);
            DayWRu(DayOfWeek.Tuesday);
            DayWRu(DayOfWeek.Wednesday);
            DayWRu(DayOfWeek.Thursday);
            DayWRu(DayOfWeek.Friday);
            DayWRu(DayOfWeek.Saturday);
            DayWRu(DayOfWeek.Sunday);

            Console.WriteLine("\nШестнадцатеричные коды цветов:");

            Console.WriteLine($"{Color.Red} -> {HexCode(Color.Red)}");
            Console.WriteLine($"{Color.Green} -> {HexCode(Color.Green)}");
            Console.WriteLine($"{Color.Blue} -> {HexCode(Color.Blue)}");
            Console.WriteLine($"{Color.Yellow} -> {HexCode(Color.Yellow)}");
            Console.WriteLine($"{Color.Cyan} -> {HexCode(Color.Cyan)}");
            Console.WriteLine($"{Color.Magenta} -> {HexCode(Color.Magenta)}");

            Console.WriteLine("\nКалькулятор арифметических операций:");
            Console.WriteLine("Введите первое число");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Числа: {x} и {y}");
            Console.WriteLine();

            Console.WriteLine($"{Operation.Add} -> {Calculate(x, y, Operation.Add)}");
            Console.WriteLine($"{Operation.Subtract} -> {Calculate(x, y, Operation.Subtract)}");
            Console.WriteLine($"{Operation.Multiply} -> {Calculate(x, y, Operation.Multiply)}");
            Console.WriteLine($"{Operation.Divide} -> {Calculate(x, y, Operation.Divide)}");


        }


    }

}

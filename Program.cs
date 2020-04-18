using System;

namespace ConsoleApp3
{
    class Calculatores
    {
        int a, b, c;
        public void Sum()
        {
            Console.WriteLine("Введите первое число");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = int.Parse(Console.ReadLine());
            c = a + b;
            Console.WriteLine("Сумма {0} и {1} равна: {2}", a, b, c);
        }
        public void Sbst()
        {
            Console.WriteLine("Введите первое число");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = int.Parse(Console.ReadLine());
            c = a - b;
            Console.WriteLine("Разность {0} и {1} равна: {2}", a, b, c);
        }
        public void Mult()
        {
            Console.WriteLine("Введите первое число");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = int.Parse(Console.ReadLine());
            c = a * b;
            Console.WriteLine("Произведение {0} и {1} равно: {2}", a, b, c);
        }
        public void Div()
        {
            Console.WriteLine("Введите первое число");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double y = double.Parse(Console.ReadLine());
            if (y == 0.0)
                Console.WriteLine("Нельзя делить на ноль");
            else
            {
                double z = x / y;
                Console.WriteLine("Частное от деления {0} на {1} равно: {2}", x, y, z);
            }
        }
    }
    public class Pro
    {
        static void Main()
        {
            int choise;
            Calculatores calc = new Calculatores();
            Console.Write("Выберите номер операции (1 -сложение; 2 - разность;");
            Console.WriteLine("3 - произведение; 4 - деление)");
            try
            {
            L: choise = int.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        Console.Write("\t\tВы выбрали сложение \n");
                        calc.Sum();
                        break;
                    case 2:
                        Console.Write("\t\tВы выбрали разность \n");
                        calc.Sbst();
                        break;
                    case 3:
                        Console.Write("\t\tВы выбрали произведение \n");
                        calc.Mult();
                        break;
                    case 4:
                        Console.Write("\t\tВы выбрали деление \n");
                        calc.Div();
                        break;
                    default:
                        Console.WriteLine("Введите ещё раз!");
                        goto L;

                }
            }
            catch
            {
                Console.WriteLine("Вы ввели вместо цифр символы!!! ");
                Console.WriteLine("\t\t\tПрограмма завершена");
            }
        }
    }

}

using System;
using System.Linq.Expressions;


namespace project
{
    class Calculator
    {

        static double[] resultHistory = new double[5]; // объявили масив для хранения результатов                                        
        static int history_count = 0; // счетчик кол-ва внутри массива
        static void Main()
        {

            short num_menu = 0;

            while (num_menu != 7)
            {
                try
                {
                    Console.WriteLine("====================================");
                    Console.WriteLine("===========Калькулятор==============");
                    Console.WriteLine("====================================");
                    Console.WriteLine("1.Сложить числа.");
                    Console.WriteLine("2.Вычесть число.");
                    Console.WriteLine("3.Умножить числа.");
                    Console.WriteLine("4.Разделить на число.");
                    Console.WriteLine("5.Остаток от деления.");
                    Console.WriteLine("6.Возвести число в степень.");
                    Console.WriteLine("7.Выход.");
                    Console.WriteLine("====================================");
                    Console.Write("Выберите операцию: ");
                    num_menu = Convert.ToInt16(Console.ReadLine());


                    switch (num_menu)
                    {
                        case 1:
                            double result = Addition();
                            StoryAction(result);
                            break;
                        case 2:
                            result = Subtraction();
                            StoryAction(result);
                            break;
                        case 3:
                            result = Multiply();
                            StoryAction(result);
                            break;
                        case 4:
                            result = Division();
                            StoryAction(result);
                            break;
                        case 5:
                            result = Modulus();
                            StoryAction(result);
                            break;
                        case 6:
                            result = Pow();
                            StoryAction(result);
                            break;
                        case 7:
                            Console.WriteLine("Закрытие программы.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка ввода.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Деление на 0!");
                }
            }




        }
        static double Addition()
        {
            double a, b, result;
            Console.Write("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            result = a + b;
            //Console.WriteLine("====================================");
            //Console.WriteLine("Результат: " + result);
            //Console.WriteLine("====================================");
            return result;
        }
        static double Subtraction()
        {
            double a, b, result;
            Console.Write("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            result = a - b;
            //Console.WriteLine("====================================");
            //Console.WriteLine("Результат: " + result);
            //Console.WriteLine("====================================");
            return result;
        }
        static double Multiply()
        {
            double a, b, result;
            Console.Write("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            result = a * b;
            //Console.WriteLine("====================================");
            //Console.WriteLine("Результат: " + result);
            //Console.WriteLine("====================================");
            return result;
        }
        static double Division()
        {
            double a, b, result;
            Console.Write("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            result = a / b;
            //Console.WriteLine("====================================");
            //Console.WriteLine("Результат: " + result);
            //Console.WriteLine("====================================");
            return result;
        }
        static double Pow()
        {
            double a, b, result;
            Console.Write("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            result = Math.Pow(a, b);
            //Console.WriteLine("====================================");
            //Console.WriteLine("Результат: " + result);
            //Console.WriteLine("====================================");
            return result;
        }
        static double Modulus()
        {
            double a, b, result;
            Console.Write("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            result = a % b;
            //Console.WriteLine("====================================");
            //Console.WriteLine("Результат: " + result);
            //Console.WriteLine("====================================");
            return result;
        }
        static void StoryAction(double result)
        {

            if (history_count < 5)
            {
                resultHistory[history_count] = result;
                history_count++;
            }// по очереди заполняет массив истриии результатов
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    resultHistory[i] = resultHistory[i + 1];

                }// перебирает весь массив с 0 индекса по 4 и перезаписывает последние значение в 4 номер индекса
                resultHistory[4] = result;
            }
            Console.WriteLine("\n========История==========");
            for (int i = 0; i < history_count && i < 5; i++)
            {
                Console.WriteLine($"{i + 1}) {resultHistory[i]}");
            }


        }
    }
}


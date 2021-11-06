using System;

namespace homework06
{
    class Program
    {
        static void Main(string[] args)
        {
            homework();
        }
        static void homework() {
            norm_color();
            Console.WriteLine("1 - Гипотенуза \n2 - Следующее - предыдущее \n3 - Яблоки и школьники \n4 - Яблоки в корзинке \n5 - Байкер МКАДа \n6 - Следующее чётное \n7 - Смена значение переменной \n8 - Сумма цифр трехзначного числа");
            Console.Write("Введите номер задания из списка: ");
            color_next();
            int choice = get_int();
            switch(choice){
                case 1:
                    less_1();
                    break;
                case 2:
                    less_2();
                    break;
                case 3:
                    less_3_4();
                    break;
                case 4:
                    less_3_4();
                    break;
                case 5:
                    less_5();
                    break;
                case 6:
                    less_6();
                    break;
                case 7:
                    less_7();
                    break;
                case 8:
                    less_8();
                    break;
                case 0:
                    bb();
                    Console.WriteLine("See You!");
                    break;
                default:
                    mistake();
                    Console.WriteLine("Введите число из списка: ");
                    homework();
                    break;
            }

        }
        //общие методы 
        static int get_int() {
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                return n;
            }
            catch {
                mistake();
                Console.Write("Введите челое число: ");
                color_next();
                return get_int();
            }
        }
        static double get_d()
        {
            try
            {
                double d = Convert.ToDouble(Console.ReadLine());
                return d;
            }
            catch {
                mistake();
                Console.Write("Введите вещественное число: ");
                color_next();
                return get_d();
            }
        }
        static void color_next() {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }
        static void mistake() {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        static void norm_color() {
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void bb (){
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        static void back() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1 - Вернуться в меню \n0 - Выход");
            int c = get_int();
            switch (c) {
                case 1:
                    homework();
                    break;
                case 0:
                    bb();
                    Console.WriteLine("See You");
                    break;
                default:
                    mistake();
                    Console.WriteLine("Введите число из списка: ");
                    back();
                    break;
            }
        }
        // задание 1
        static void less_1() {
            Console.Write("Введите катет 'a': ");
            double a = get_d();
            Console.Write("Введите катет 'b': ");
            double b = get_d();
            Console.WriteLine($"Гипотенуза равна: {Math.Sqrt(a * a + b * b)}");
            back();
        }
        //задание 2
        static void less_2() {
            Console.Write("Введите целое число: ");
            int num = get_int();
            Console.WriteLine($"The next number for the number {num} is {num + 1}.");
            Console.WriteLine($"The previous number for the number {num} is {num - 1}.");
            back();
        }
        //задание 3 и 4
        static void less_3_4() {
            Console.Write("Введите количество школьников: ");
            int n = get_int();
            Console.Write("Введите количество яблок: ");
            int k = get_int();
            Console.WriteLine($"Каждому школьнику досталось {k / n} яблок");
            Console.WriteLine($"В корзине осталось {k % n} яблок");
            back();
        }
        //задание 5
        static void less_5() {
            Console.Write("Введите скорость байкера: ");
            int v = get_int();
            Console.Write("Введите количество часов для остановки: ");
            int t = get_int();
            if (v > 0)
            {
                Console.WriteLine($"Байкер остановится на { v * t % 109} километре");
            }
            else {               
                Console.WriteLine($"Байкер остановится на {109 - Math.Abs(v * t % 109)} километре");
            }
            back();
        }
        //задание 6
        static void less_6() {
            Console.Write("Введите целое число: ");
            int n = get_int();
            Console.WriteLine($"Следующее четное число {(n / 2 + 1) * 2}");
            back();
        }
        //задание 7
        static void less_7()
        {
            Console.Write("Введите значение переменной а: ");
            int a = get_int();
            Console.Write("Введите значение переменной b: ");
            int b = get_int();
            a += b;
            b = a - b;
            a = Math.Abs(b - a);
            Console.WriteLine($"Обмен значений завершён: \na = {a} \nb = {b}");
            back();
        }
        //задание 8
        static void less_8() {
            Console.Write("Введите трехзначное число: ");
            int num = get_int();          
            Console.WriteLine($"Сумма цифр = {Math.Abs(num / 100 + num / 10 % 10 + num % 10)}");
            back();
        }
        
    }
    

}

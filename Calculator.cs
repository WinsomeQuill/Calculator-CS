using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Threading;

namespace calculator
{
    class Program
    {
        static void ConsoleClear()
        {
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
        }
/*
        static void ConsoleRestart()
        {
        
        } */
        static void Main(string[] args)
        {
            //-----------------------------[Переменные]-----------------------------//
            double a, b;
            string op, line, hline;
            int engine = 1;
            const string version = "0.4";
            string email = "doshikplayer@gmail.com";
            do
            {
                //-----------------------------[Меню]-----------------------------//
                Console.WriteLine("Calc - калькулятор");
                Console.WriteLine("Version(ver) - версия");
                Console.WriteLine("Clear - очистить консоль");
                Console.WriteLine("Help - помощь");
                Console.WriteLine("Exit - выход\n");
                Console.Write("Line: ");
                line = Convert.ToString(Console.ReadLine());

                //-----------------------------[Код калькулятора]-----------------------------//
                if (line == "calc" || line == "Calc")
                {
                    try
                    {
                        Console.Write("Введи A: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введи оператор: ");
                        op = Convert.ToString(Console.ReadLine());

                        if (op == "k")
                        {
                            double ot = Math.Sqrt(a);
                            Console.WriteLine("Корень из {0}\nОтвет: {1}\n", a, ot);
                            continue;
                        }
                        if (op == "cos")
                        {
                            double ot = Math.Cos(a);
                            Console.WriteLine("Косинус {0}\nОтвет: {1}\n", a, ot);
                            continue;
                        }
                        if (op == "sin")
                        {
                            double ot = Math.Sin(a);
                            Console.WriteLine("Синус {0}\nОтвет: {1}\n", a, ot);
                            continue;
                        }
                        if (op == "tg")
                        {
                            double ot = Math.Tan(a);
                            Console.WriteLine("Тангенс {0}\nОтвет: {1}\n", a, ot);
                            continue;
                        }
                        if (op == "+" || op == "-" || op == "*" || op == "/" || op == "%" || op == "^") //Чекер
                        {
                            Console.Write("Введи B: ");
                            b = Convert.ToDouble(Console.ReadLine());

                            if (op == "+")
                            {
                                double ot = a + b;
                                Console.WriteLine("Ответ: {0}\n", ot);
                            }
                            if (op == "-")
                            {
                                double ot = a - b;
                                Console.WriteLine("Ответ: {0}\n", ot);
                            }
                            if (op == "*")
                            {
                                double ot = a * b;
                                Console.WriteLine("Ответ: {0}\n", ot);
                            }
                            if (op == "/")
                            {
                                if (b == 0)
                                {
                                    Console.WriteLine("На ноль делить нельзя!\n");
                                }
                                else
                                {
                                    double ot = a / b;
                                    Console.WriteLine("Ответ: {0}\n", ot);
                                }
                            }
                            if (op == "%")
                            {
                                double ot = a % b;
                                Console.WriteLine("Ответ: {0}\n", ot);
                            }
                            if (op == "^")
                            {
                                double ot = Math.Pow(a, b);
                                Console.WriteLine("Возводим число {0} в {1} степень ({0}^{1})", a, b);
                                Console.WriteLine("Ответ: {0}\n", ot);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Такого оператора нету!"); //Чекер (ответ)
                        }
                    }
                    catch
                    {
                        Console.WriteLine("<WARNING> Обнаружена попытка краша!");
                        continue;
                    }
                    //-----------------------------[Код меню версии]-----------------------------//
                    if (line == "version" || line == "Version" || line == "ver" || line == "Ver")
                    {
                        Console.WriteLine("Текущаю версия: {0}", version);
                        Console.WriteLine("By WinsomeQUill \"1991c\" ");
                        Console.WriteLine("Email: {0}\n", email);
                        Console.Write("\r B");
                        Thread.Sleep(300);
                        Console.Write("\r  By");
                        Thread.Sleep(300);
                        Console.Write("\r   By ");
                        Thread.Sleep(300);
                        Console.Write("\r    By W");
                        Thread.Sleep(300);
                        Console.Write("\r     By Wi");
                        Thread.Sleep(300);
                        Console.Write("\r      By Win");
                        Thread.Sleep(300);
                        Console.Write("\r       By Wins");
                        Thread.Sleep(300);
                        Console.Write("\r        By Winso");
                        Thread.Sleep(300);
                        Console.Write("\r         By Winsom");
                        Thread.Sleep(300);
                        Console.Write("\r          By Winsome");
                        Thread.Sleep(300);
                        Console.Write("\r           By WinsomeQ");
                        Thread.Sleep(300);
                        Console.Write("\r            By WinsomeQu");
                        Thread.Sleep(300);
                        Console.Write("\r             By WinsomeQui");
                        Thread.Sleep(300);
                        Console.Write("\r              By WinsomeQuil");
                        Thread.Sleep(300);
                        Console.Write("\r               By WinsomeQuill");
                        Thread.Sleep(300);
                        Console.Write("\r                By WinsomeQuill ");
                        Thread.Sleep(300);
                        Console.Write("\r                 By WinsomeQuill :D\n");
                    }
                }
                //-----------------------------[Код help меню]-----------------------------//
                if (line == "help" || line == "Help")
                {
                    int hengine = 1;
                    do
                    {

                        Console.WriteLine("---------Меню помощи---------");
                        Console.WriteLine("Введи цифру чтобы открыть нужный раздел");
                        Console.WriteLine("1. Операторы калькулятора");
                        Console.WriteLine("2. На каком языке написан данный скрипт?");
                        Console.WriteLine("3. Связь с создателем");
                        Console.WriteLine("0. Выход");
                        Console.WriteLine("---------Меню помощи---------");
                        hline = Convert.ToString(Console.ReadLine());

                        if (hline == "1")
                        {
                            Console.WriteLine("\n\"+\" - сложение\n\"-\" - вычитание\n\"*\" - умножение\n\"/\" - деление\n\"k\" - корень\n\"sin\" - синус (в рад.)\n\"cos\" - косинус (в рад.)\n\"tg\" - тангенс\n\"^\" - степень\n");
                        }

                        if (hline == "2")
                        {
                            Console.WriteLine("\nДанный скрипт написан на языке программирования C#\n");
                        }

                        if (hline == "3")
                        {
                            Console.WriteLine("\n VK - vk.com/winsomequill \n Site - Forum.QuartzLand.Ru\n");
                        }

                        if (hline == "0")
                        {
                            Console.WriteLine("\nНадеюсь, я помог тебе :)\n");
                            hengine = 0;
                        }
                    }
                    while (hengine == 1);
                }
                
                if (line == "Exit" || line == "exit")
                {
                	Console.WriteLine("Завершаем процесс...");
        			if (engine == 1)
        			{
        			Console.WriteLine("Процесс завершен.");
        			engine = 0;
        			}
        			else
        			{
        			Console.WriteLine("Упс... Что-то пошло не так ×_×");
        			}
                }
                
                if (line == "Restart" || line == "restart")
                {
                	Console.WriteLine("Завершаем процесс...");
        			if (engine == 1)
        			{
        			Console.WriteLine("Перезагрузка...");
        			engine = 0;
        			engine = 1;
        				if (engine == 1)
        				{
        					Console.Write("[ ");
        					Console.ForegroundColor = ConsoleColor.Yellow;
        					Console.Write("WAIT");
        					Console.ForegroundColor = ConsoleColor.White;
        					Console.Write(" ] Restart script...");
        					Console.Write("\n[ ");
        					Console.ForegroundColor = ConsoleColor.Green;
        					Console.Write("OK");
        					Console.ForegroundColor = ConsoleColor.White;
        					Console.Write(" ] Restart script...\n");
        					Console.WriteLine("Нажмите любую кнопку чтобы продолжить...");
        					Console.ReadKey();
        				}
        			}
        			else
        			{
        			Console.WriteLine("Упс... Что-то пошло не так ×_×");
        			}
               	}

                if (line == "Clear" || line == "clear")
                {
                    ConsoleClear();
                }
                if (line != "Calc" || line != "calc" || line != "Clear" || line != "clear" || line != "Help" || line != "help" || line != "ver" || line != "Ver" || line != "version" || line != "Version")
                {
                    Console.WriteLine("Комманда {0} не найдена!\n", line);
                }
            } //Цикл
            while (engine == 1);
        }   
    }
}

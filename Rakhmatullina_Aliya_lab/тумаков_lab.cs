using System;

namespace Rakhmatullina_Aliya_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Упражнение 4.1");
        //Написать программу на c#, которая читает с экрана число от 1 до 365 (номер дня в году), переводит этот число в месяц и день месяца. Например, число 40 соответствует 9
        //февраля(високосный год не учитывать).

        Console.Write("Введите номер дня в году (от 1 до 365): ");

            
            if (int.TryParse(Console.ReadLine(), out int dayOfYear) && dayOfYear >= 1 && dayOfYear <= 365)
            {   string[] monthNames = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
                int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                int month = 0;
                while (dayOfYear > daysInMonth[month])
                {
                    dayOfYear -= daysInMonth[month];
                    month++;
                }

               
                Console.WriteLine($" {dayOfYear} {monthNames[month]}.");
            }
            else
            {
                Console.WriteLine("Ошибка: введите корректное число от 1 до 365.");
            }
        




            Console.WriteLine("Упражнение 4.2");
            //Добавить к задаче из предыдущего упражнения проверку числа введенного
            //пользователем.Если число меньше 1 или больше 365, программа должна вырабатывать
            //исключение, и выдавать на экран сообщение.




            int[] daysInMonth2 = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] monthNames2 = { "января", "февраля", "марта", "апреля", "мая", "июня","июля", "августа", "сентября", "октября", "ноября", "декабря" };

            Console.Write("Введите номер дня в году (от 1 до 365): ");
            int dayOfYear2;

            try
            {
                if (!int.TryParse(Console.ReadLine(), out dayOfYear2) || dayOfYear2 < 1 || dayOfYear2 > 365)
                {
                    throw new ArgumentOutOfRangeException("dayOfYear2", "Число должно быть в диапазоне от 1 до 365.");
                }

                int month2 = 0;
                int day = dayOfYear2;

                for (int i = 0; i < daysInMonth2.Length; i++)
                {
                    if (day <= daysInMonth2[i])
                    {
                        month2 = i; 
                        break;
                    }
                    day -= daysInMonth2[i];
                }

                
                Console.WriteLine($"{day} {monthNames2[month2]}");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено некорректное значение. Пожалуйста, введите целое число.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
            }

            

        }
    }
}

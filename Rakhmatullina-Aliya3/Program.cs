using System;

namespace Rakhmatullina_Aliya3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 задание");
            //Дана последовательность из 10 чисел. Определить, является ли эта последовательность
            //упорядоченной по возрастанию.В случае отрицательного ответа определить
            //порядковый номер первого числа, которое нарушает данную последовательность.
            //Использовать break.

            int[] numbers = new int[10];


            Console.WriteLine("Введите 10 чисел: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Число {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            bool isOrdered = true;
            int firstForceIndex = -1;


            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    isOrdered = false;
                    firstForceIndex = i;
                    break;
                }
            }


            if (isOrdered)
            {
                Console.WriteLine("Последовательность упорядочена по возрастанию.");
            }
            else
            {
                Console.WriteLine($"Последовательность не упорядочена. Первое нарушение происходит на позиции: {firstForceIndex + 1} (число {numbers[firstForceIndex]}).");


            }

            Console.WriteLine("2 задание");
            //Игральным картам условно присвоены следующие порядковые номера в зависимости от
            //их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.
            //Порядковые номера остальных карт соответствуют их названиям(«шестерка»,
            //«девятка» и т.п.).По заданному номеру карты k(6 <= k <= 14) определить достоинство
            //соответствующей карты. Использовать try-catch-finally.



            try
            {
                Console.Write("Введите порядковый номер карты (6 - 14): ");
                int k = int.Parse(Console.ReadLine());

                
                if (k < 6 || k > 14)
                {
                    throw new ArgumentOutOfRangeException(nameof(k), "Порядковый номер карты должен быть в диапазоне от 6 до 14.");
                }

                
                string cardValue;
                switch (k)
                {
                    case 6: cardValue = "Шестёрка"; break;
                    case 7: cardValue = "Семёрка"; break;
                    case 8: cardValue = "Восьмёрка"; break;
                    case 9: cardValue = "Девятка"; break;
                    case 10: cardValue = "Десятка"; break;
                    case 11: cardValue = "Валет"; break;
                    case 12: cardValue = "Дама"; break;
                    case 13: cardValue = "Король"; break;
                    case 14: cardValue = "Туз"; break;
                    default: cardValue = "Некорректный номер"; break;
                }

                Console.WriteLine($"Достоинство карты: {cardValue}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: необходимо ввести корректное число.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Спасибо за использование программы.");
            }

        }
    }

}

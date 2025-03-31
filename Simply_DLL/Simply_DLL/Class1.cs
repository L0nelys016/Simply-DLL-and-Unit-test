using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simply_DLL
{
    public class Class1
    {
        /// Вычисляет факториал заданного числа.
        public static double CalculateFactorial(double number)
        {
            try
            {
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(number), "Значение должно быть неотрицательным.");
                }

                if (number == 0 || number == 1)
                {
                    return 1;
                }

                return number * CalculateFactorial(number - 1);
            }

            catch (StackOverflowException)
            {
                Console.WriteLine("ОШИБКА: Переполнение стека при вычислении факториала.");
                throw;
            }
        }

        /// Проверяет, является ли заданное число простым.
        public static bool IsPrime(double num)
        {
            try
            {
                if (num <= 1)
                {
                    return false;
                }

                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
            catch (ArgumentOutOfRangeException) when (num < 0)
            {
                Console.WriteLine($"ОШИБКА: Нельзя проверять отрицательное число {num} на простоту.");
                throw;
            }
        }

        /// Вычисляет n-й член арифметической прогрессии.
        public static double ArithmeticProgressionTerm(int termNumber, double firstTerm, double commonDifference)
        {
            try
            {
                if (commonDifference == 0 && termNumber != 1)
                {
                    throw new DivideByZeroException("Невозможно выполнить операцию. Разность равна нулю.");
                }

                return firstTerm + commonDifference * (termNumber - 1);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("ОШИБКА: Попытка деления на ноль.");
                throw;
            }
        }
    }

}

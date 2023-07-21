using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccountingSystem.Helpers
{
    public static class Helper
    {
        /// <summary>
        /// Метод для прочтения строки.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string ReadString(string text)
        {
            Console.Write(text);
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) throw new ArgumentNullException("Пустая строка", nameof(input));
            return input;
        }

        /// <summary>
        /// Метод для прочтения числа.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static int ReadInt(string text)
        {
            Console.Write(text);
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                throw new Exception("Неверный формат входных данных");
            }
            return result;
        }

    }
}

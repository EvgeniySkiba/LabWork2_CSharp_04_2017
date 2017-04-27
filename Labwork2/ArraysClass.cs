using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork2
{
    public class ArraysClass
    {
        private int[] firstArray;
        private int[] secondArray;       

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="firstArrSize">размер первого массива</param>
        /// <param name="secondArrSize">размер второго  массива</param>
        public ArraysClass(int firstArrSize, int secondArrSize)
        {
            firstArray = new int[firstArrSize];
            secondArray = new int[secondArrSize];
        }

        public int[] FirstArray
        {
            get { return firstArray; }
            set { firstArray = value; }
        }

        public int[] SecondArray
        {
            get { return secondArray; }
            set { secondArray = value; }
        }

        private bool IsPrime(int d)
        {
            int _sqrt_int = (int)Math.Sqrt(d); //Целая часть от квадратного корня из d

            if ((d % 2) == 0)
                return false;

            for (int i = 3; i <= _sqrt_int; i += 2)
                if ((d % i) == 0) //Проверка: остаток от деления d/i==0?
                    return false;

            return true;
        }

        /// <summary>
        /// поиск количества простых чисел для первого массива 
        /// </summary>
        /// <returns></returns>
        public int getCountSimpleDigitsFromFirstArray()
        {
            int result = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (IsPrime(firstArray[i]))
                    result++;
            }

             return result;
        }

        public int getCountSimpleDigitsFromSecondArray()
        {
            int result = 0;

            for (int i = 0; i < secondArray.Length; i++)
            {
                if (IsPrime(secondArray[i]))
                    result++;
            }

            return result;
        }
    }
}

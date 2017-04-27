using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork2
{
    class Program
    {
        /// <summary>
        /// ввод данных 
        /// </summary>
        /// <param name="title">отображаемый текст</param>
        /// <returns>вееденное число</returns>
        static int InputDigit(String title)
        {
            String line;
            int number = 0;

            do
            {
                Console.Write(title);
                line = Console.ReadLine();

                if (line == "q")
                {
                    Console.WriteLine("Press any key to continue....");
                    Console.ReadLine();
                    System.Environment.Exit(-1); 
                }                
            } while (!int.TryParse(line, out number));

            return number;
        }

        static int Main(string[] args)
        {
            System.Console.WriteLine("Enter q for quit ");

            int firstArraySize = InputDigit("Please enter the first array size : ");
            int secondArraySize = InputDigit("Please enter the second array size : ");
            
            int[] firstArray = new int[firstArraySize];
            int[] secondArray = new int[secondArraySize];

            Console.WriteLine("Please enter the first arrays numbers : ");
            for (int i = 0; i < firstArraySize; i++)
            {
                firstArray[i] = InputDigit("[" + i + "] : ");
            }

            Console.WriteLine("Please enter the second arrays numbers : ");
            for (int i = 0; i < secondArraySize; i++)
            {
                secondArray[i] = InputDigit("[" + i + "] : ");
            }


            ArraysClass array = new ArraysClass(firstArraySize, secondArraySize);
            // присвоить значения массивов через свойства класса 
            array.FirstArray = firstArray;
            array.SecondArray = secondArray;

            // подсчет елементов 
            int simpleNumsFirstArray = array.getCountSimpleDigitsFromFirstArray();
            int simpleNumSecondArray = array.getCountSimpleDigitsFromSecondArray();

            if (simpleNumsFirstArray > simpleNumSecondArray)
                Console.WriteLine("In the first array there has more simple elements");
            else if (simpleNumsFirstArray < simpleNumSecondArray)
                Console.WriteLine("In the second array there has more simple elements");
            else
                Console.WriteLine("The same number of simple elements");

            Console.WriteLine("Press any key to continue....");
            Console.ReadLine();
            return 0;



        }
    }
}


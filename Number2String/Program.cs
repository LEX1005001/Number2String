using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number2String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //массив строк значений
            string[] Values = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            // ввод числа с клавиатуры
            string inputNumber=Console.ReadLine();

            //проверки ввода
            if(inputNumber == null )
            {
                return;
            }
            if(Convert.ToInt32(inputNumber)>9)
            {
                Console.WriteLine("Значение больше 9");
            }
            if( Convert.ToInt32(inputNumber)<0) 
            {
                Console.WriteLine("Значение меньше 0");
            }
            
            // Прогоняемся по массиву значений и если индекс == введёному числу, то выводи Value[индекс]
            for(int i = 0;i< Values.Length; i++)
            {
                if (i == Convert.ToInt32(inputNumber)) 
                {
                    Console.WriteLine(Values[i]);
                }
            }
            Console.ReadKey();
        }
    }
}

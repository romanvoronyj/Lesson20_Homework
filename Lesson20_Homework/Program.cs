using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson20_Homework
{
    /*У колекцію ArrayList, через виклик методу Add 
     * додайте елементи value та reference типу, переберіть дану колекцію, виводячи на екран за допомогою циклу for - З якою проблемою ви зіткнулися?
     */
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myValue = new ArrayList();

            myValue.Add(7);
            myValue.Add("string");
            myValue.Add('!');

            for (int i = 0; i < myValue.Count; i++)// проблема у застосуванні властивості Count?
            {
                Console.Write($"{myValue[i]}");
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson20_Homework_Task3
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    Створіть клас ArrayList. Реалізуйте в найпростішому наближенні можливість використання його екземпляра аналогічно примірнику классу 
    ArrayList з простору імен System.Collections.
    */
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList(); // примірник классу ArrayList з простору імен System.Collections недоступний, так як в нас створено однойменний клас ArrayList

            ArrayList myarraylistclass = new ArrayList();//екземпляр класу. 

            myarraylistclass.Add();

            Console.ReadKey();
        }
    }
}

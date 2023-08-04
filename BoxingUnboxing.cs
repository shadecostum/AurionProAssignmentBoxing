using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 100; //stack stored
            Console.WriteLine(""+number1);
            object obj1 = number1;//Boxing convert value type to address type stack variable ->object referenc to heap of number1
           //heap value stored reference obj1 stored in stack
            int number2=(int)obj1;//unboxing convert reference type to value type type casting needed (int) used explicit
            Console.WriteLine(number2);


            double number3=(int)obj1;
            Console.WriteLine(number3);//converted to double datatype variable




            Console.WriteLine("---------new----------");
            double number4 = 50;
            Console.WriteLine(number4);
            object obj4 = number4;
            Console.WriteLine(obj4);
            number4 = 100;
            Console.WriteLine(obj4);//output 50 value not changed
            obj4 = 200;
            Console.WriteLine(number4);
            Console.WriteLine("number4 changed to"+obj4);
            number4=(int)obj4;
            Console.WriteLine(number4);
           
        }
    }
}

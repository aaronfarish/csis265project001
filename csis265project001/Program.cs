using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIS265PROJECT01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double number1 = 0.0;
            double number2 = 0.0;
            double sum;
            double difference;
            double product;
            double quotient;
            System.Console.Write("Enter the first decimal number: ");
            number1 = Convert.ToDouble(System.Console.ReadLine());
            System.Console.Write("enter the second decimal number: ");
            number2 = Convert.ToDouble(System.Console.ReadLine());

            sum = number1 + number2;
            System.Console.WriteLine("The sum is: " + sum);
            difference = number1 - number2;
            System.Console.WriteLine("The difference is: " + difference);
            product = number1 * number2;
            System.Console.WriteLine("The product is: " + product);
            quotient = number1 / number2;
            System.Console.WriteLine("The quotient is: " + quotient);
            System.Console.ReadLine();
        }
    }
}

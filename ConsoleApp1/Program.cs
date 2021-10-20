using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            int op = 0;

            Console.Write("Type a number, and then press Enter:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type another number, and then press Enter:");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to choose an operator.
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\t1 - Add");
            Console.WriteLine("\t2 - Subtract");
            Console.WriteLine("\t3 - Multiply");
            Console.WriteLine("\t4 - Divide");
            Console.WriteLine("\t5 - Prozent");
            Console.WriteLine("\t6 - Potenzen");
            Console.WriteLine("\t7 - Root");
            Console.Write("Your option? ");
            op = Convert.ToInt32(Console.ReadLine());

           
            switch (op)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine(result);
                    break;

                case 2:
                    result = num1 - num2;
                    Console.WriteLine(result);
                    break;

                case 3:
                    result = num1 * num2;
                    Console.WriteLine(result);
                    break;

                case 4:
                    result = num1 / num2;
                    Console.WriteLine(result);
                    break;

                case 5:
                    result = num1 * 100 / num2;
                    Console.WriteLine(result);
                    break;

                case 6:
                    Console.WriteLine(Math.Pow(num1, num2));
                    Console.ReadLine();
                    break;

                case 7:

                    if (op == 7) 
                    {
                        int num;
                        Console.WriteLine("Type a Number and press Enter");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(Math.Sqrt(num));
                    }
                    
                    break;
               
            }
            if (op > 6)
            {
                Console.Write("Error");
            }



            // Wait for the user to respond before closing.
            Console.Write("Press Enter two times to close the app: ");            

        }
 
    }

}




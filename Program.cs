using System;

namespace first_one
{
    class Program
    {
        static void Main(string[] args)
        {
            string dec = " Enter decimal for convert binary to decimal " ;
            string bin = " Enter binary for convert decimal to binary " ;
            Console.WriteLine($"{dec} \n{bin}");

            string input =Console.ReadLine();
            input.ToLower();
            string result = "" ;

            int baseVal = 1 ;
            int decVal = 0 ;


            if (input == "decimal")
            {
                Console.WriteLine("Enter your number : ");

                 int newDec = Convert.ToInt32(Console.ReadLine()) ;

                while (newDec > 1)
                {
                    int reminder = newDec % 2 ;
                    result = Convert.ToString(reminder) + result ;
                    newDec /= 2 ;
                }

                result = Convert.ToString(newDec) + result ;

                System.Console.WriteLine($"Binary : {result}");
            }

            else if ( input == "binary" )
            {

            Console.Write("enter your binary number : ");
            int newBin = Convert.ToInt32(Console.ReadLine()) ;

            if(newBin > 1 )
            {
                while ( newBin > 0 )
                {
                    int reminder = newBin % 10 ;
                    decVal = decVal + reminder * baseVal ;
                    newBin = newBin / 10 ;
                    baseVal = baseVal *2 ;
                }

                Console.WriteLine($"Decimal number is : {decVal}");

            }
            else
            {
                Console.WriteLine("should be only 0s and 1s");
            }

            }


        }
    }
}

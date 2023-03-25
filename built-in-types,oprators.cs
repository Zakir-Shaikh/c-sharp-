/* built-inn type in c-sharp
boolean -only true or false
integral-sbyte,byte,int,short
floating-float and double
decimal-
string-   */

//string

using System;
class Program
{
    static void Main()
    {
        string name = " zakir\n sam\n zaid\n";//escape sequence charecter (aur bhi rehte h like ",',\v-verticle,\t-horizontal)
        Console.WriteLine(name);
    }
}

//verbatim literal 
using System;
class Program
{
    static void Main()
    {
        string name =@" zakir\n sam\n zaid\n";//better read hota h and \ bhi read hota h
        Console.WriteLine(name);
    }
}

//common oprator in c#

/* 
 Assignment Operator =
Arithmetic Operators like +,-,*,/,% 
Comparison Operators like ==, !=,>, >=, <, <= 
Conditional Operators like &&, ||
Ternary Operator ?:
Null Coalescing Operator ??  
 */

 using System;
class Program
{
    static void Main()
    { 
            // Assignment Operator example
            // Single = is the assignment operator
            int i = 10;
            bool b = true;

            // For dividing 2 numbers we can use either
            // % or / operators
            int numerator = 10;
            int denominator = 2;

            // Arithmentic operator / returns quotient
            int quotient = numerator / denominator;
            Console.WriteLine("Quotient = {0}", quotient);

            // Arithmentic operator % returns remainder
            int remainder = numerator % denominator;
            Console.WriteLine("Remainder = {0}", remainder);

            // To compare if 2 numbers are
            // equal use comparison operator ==
            int number = 10;
            if (number == 10)
            {
                Console.WriteLine("Number is equal to 10");
            }

            // To compare if 2 numbers are not
            // equal use comparison operator !=
            if (number != 5)
            {
                Console.WriteLine("Number is not equal to 5");
            }

            // When && operator is used all the conditions must
            // be true for the code in the "if" block to be executed
            int number1 = 10;
            int number2 = 20;

            if (number1 == 10 && number2 == 20)
            {
                Console.WriteLine("Both conditions are true");
            }

            // When || operator is used the code in the "if" block
            // is excuted if any one of the condition is true
            number1 = 10;
            number2 = 21;

            if (number1 == 10 || number2 == 20)
            {
                Console.WriteLine("Atleast one of the condition is true");
            }
        }
    }

    


/*
 C# types  are divided into 2 broad categories.
Value Types  - int, float, double, structs, enums etc
Reference Types – Interface, Class, delegates, arrays etc

By default value types are non nullable. To make them nullable use (?)
int i = 0 (i is non nullable, so "i" cannot be set to null, i = null will generate compiler error)
int? j = 0 (j is nullable int, so j=null is legal)
*/

// with out null collegion
using System;
        static void Main()
        {
            int AvailableTickets;
            int? TicketsOnSale = null;

            if (TicketsOnSale == null)
            {
                AvailableTickets = 0;
            }
            else
            {
                AvailableTickets = (int)TicketsOnSale;
            }

            Console.WriteLine("Available Tickets={0}", AvailableTickets);
        }
 
 // null collegion
 using System;
class Program
{
    static void Main()
    {
        int AvailableTickets;
        int? TicketsOnSale = null;

        //Using null coalesce operator ??
        AvailableTickets = TicketsOnSale ?? 0;

        Console.WriteLine("Available Tickets={0}", AvailableTickets);
    }
}

/* datatype convertion 

1. Implicit conversions
2. Explicit Conversions
3. Difference between Parse() and TryParse()
*/

/* Difference between Parse and TryParse
1. If the number is in a string format you have 2 options - Parse() and TryParse() 
2. Parse() method throws an exception if it cannot parse the value, whereas TryParse() returns a bool indicating whether it succeeded or failed. */

//Implicit Conversion
using System;
class Program
{
    public static void Main()
    {
        int i = 100;

        // float is bigger datatype than int. So, no loss of
        // data and exceptions. Hence implicit conversion
        float f = i;

        Console.WriteLine(f);
    }
}

//Explicit Conversion 
using System;
class Program
{
    public static void Main()
    {
        float f = 100.25F;

        // Cannot implicitly convert float to int.
        // Fractional part will be lost. Float is a
        // bigger datatype than int, so there is
        // also a possiblity of overflow exception
        // int i = f;

        // Use explicit conversion using cast () operator
        int i = (int)f;

        // OR use Convert class
        // int i = Convert.ToInt32(f);

        Console.WriteLine(i);
    }
}


    



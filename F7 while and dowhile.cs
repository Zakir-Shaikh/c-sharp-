/*
while loop
while loop check condition first 
if the condition is true statement of loop will execute 
this process is repeated as long as condition evaluates to true 
*/

using System;
class Program
{
    static void Main()
    { 
        Console.WriteLine("please enter your target ?");
        int UserTarget = int.Parse(Console.ReadLine());

        int start = 0;

        while (start <= UserTarget)
        {
            Console.WriteLine(start);
            start = start +2;
        }
    }
}

/*
do while
while loop cheks the condition at the beginigs where as do while cheks at thee end 
do whiile guranted to exceute at least one 
*/
using System;
class Program
{
    static void Main()
    { 
        Console.WriteLine("please enter your target ?");
        int UserTarget = int.Parse(Console.ReadLine());

        int start = 0;

        while (start <= UserTarget)
        {
            Console.Write(start + " ");
            start = start +2;
        }
        do
        {
            Console.WriteLine("invalid choice ,say yes or no");

            Console.WriteLine("do you want to continoue ?");
            string userchoice = Console.ReadLine();
            if (userchoice! = "yes" && userchoice != "no")
            {
                Console.WriteLine("invalid choice ,say yes or no");
            }
        }while (userchoice! = "yes" && userchoice != "no");
    }
}

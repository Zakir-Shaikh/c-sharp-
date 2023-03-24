//namespace is used to organize your code and its collection of classes,interface,structs,ensumes and delegates
using system ;
class program
{
  static void main()
  {
    console.writeline("welcome to c# trainig");
  }
}

//main
using system ;
class program
{
  static void main1()
  {
    console.writeline("welcome to c# trainig1");
  }
static void main()
  {
    console.writeline("welcome to c# trainig");
    main1()
  }
}

/* there are two ways to writing to the console
1 : concadination
2 : place holder syntax-(most use)  */

// concatination
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("enter your name");
        string username = Console.ReadLine();
        Console.WriteLine("hii" + username);
  
    }
}

//place holder
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("enter your name");
        string username = Console.ReadLine();
        Console.WriteLine("hii {0}", username);
  
    }
}

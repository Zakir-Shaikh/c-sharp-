//switch statement
using System;

namespace ConsoleApp7
{
class Program
{
static void Main(string[] args)
{
Console.WriteLine("Enter Your Number");
int Usernumber = int.Parse(Console.ReadLine());
switch (Usernumber)
{
  case 10;
Console.WriteLine("Dear User Your Number is 1");
  break;
}
{
 case 20;
Console.WriteLine("Dear User Your Number is 20");
  break;
}
{
   case 30;
Console.WriteLine("Dear User Your Number is 30");
  break;
}
{
  default:
Console.WriteLine("Dear User Your Number is 10,20 &30");
  break;
}
}
}
}

//switch continue
// syntax
for (int i = 0; i < 10; i++) 
{
  if (i == 4) 
  {
    continue;
  }
  Console.WriteLine(i);
}



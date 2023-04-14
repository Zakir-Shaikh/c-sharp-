// namespace
/*
namespace are used to organised your program
it to provide assistence to avoid classhes 
*/

using System ;
namespace projectA teamA
{
  class ClassA 
  {
    public static void print()
    {
      console.writeline("this is team a print method");
    }

  }   
}
namespace projectA TeamB
{
  class ClassA 
  {
    public static void print()
    {
      console.writeline("this is team a print method");
    }

  }
}

/* diffrent namespes member
1 class
2 another namespace
3 interface
4 enum
5 struct
6 delegate
*/

//class
/*
if you want to create a complex custmos types ,then we can make use of class
a class consist of data and behaviour class data is represent by its filed and behaviour is represented by its method 
*/

using System;
class customer
{
  string firstname;
  string lastname;
  public customer(string firstname,string lastname)
  {
    this.firstname = firstname ;
    this.lastname = lastname ;
  }
  public void printfullname()
  {
    console.writeline("full name = {0}",firstname +  " " + lastname);
  }
}

class program
{
  public static void main()
  {
    customer c1 = new customer();
    c1.printfullname();
  }
}

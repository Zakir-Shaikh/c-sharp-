//methods
/*
methos name can be meaningful name 
parameters are optinal
*/
using System;
class Program
{
  public static void main()
  {
    Program.evennumber(30);
    Program p = new Program();

    int sum = p.add(10,20);
    console.WriteLine("sum ={0}",sum);

  }
  public int add (int fn,int sn)
  {
    return fn + sn ;
  }
  public static void evennumber(int target)
  {
    int start=0;
    while(start<=target)
    {
      console.WriteLine(start);
      start = start+2; 
    }
  }
}

//methods parameters
/*
there are 4 type of methods parameters
1 value parameters
2 reference parameters
3 out parameters 
4 parameters arreys
*/

class program 
{
  public static void main()
  {
    int[] numbers = new int [3];

    numbers[0] = 101;
    numbers[1] = 102;
    numbers[2] = 103;

    paramsmethod(1,2,3,4,5);
  }
  public static void paramsmethod (params int[]number)
  {
    console.writeline("there are {0} elements",numbers.lenght);
    foreach (int i in numbers)
    {
      console.writeline(i);
    }
  }
}

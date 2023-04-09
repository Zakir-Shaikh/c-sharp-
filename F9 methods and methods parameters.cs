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
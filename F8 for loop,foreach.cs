//for loop 
/*
for loop is very similar to the while loop we do initiate one place condition ,,check at another place
and modifying at variable another where for loop has the same loop at place
*/
using System;
class Program
{
static void Main(string[] args)
{
 int number = new int [3];

number [0]=101;
number [1]=102;
number [2]=103;

for (int j=0;j< number.lenght;j++)
{
  console.WriteLine(number[j]);
}

int i=0;
while (i< number.lenght)
{
  console.WriteLine(number[i]);
  i++;
}
}



//for each
/*
for each loop use in a collection and array
*/
class Program
{
static void Main(string[] args)
{
Console.WriteLine("Enter Number:");
int count = int.Parse(Console.ReadLine());

int[] number = new int[count];
int sum = 0;
//int k =0;

foreach (int i in number)
{
number[i] = (i+1)*10;
//number[i] = (i + 1) * 10;
//k++;
sum += number[i];
Console.WriteLine("Number: {0}", number[i]);
Console.WriteLine("Sum: {0}", sum);
Console.WriteLine("");
}
}
}

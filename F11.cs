//inheritencs

using system;
public class employee
{
  string firstname;
  string lastname;
  string email;
  public void fullname()
  {

  }
}
public class full employee : employee 
{
  float yearlysalay;
}
public class program 
{
  public static void main()
  {
     float yearlysalay;
  }
}
public class fulltimeemployee : employee
{
  public static void main()
  {
     public float HourlyRate;
  }
}
public  class program 
{
  public static void main ()
  {
    fulltimeemployee FTE = new fulltimeemployee ();
    FTE.firstname =  "zakir";
    FTE.lastname = "shk";
    FTE.yearlysalay = 5000 ;
    FTE.printfullname();
  }
}

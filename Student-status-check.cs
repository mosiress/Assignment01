using System;
namespace test01
{
class Program
{
static void Main(string[] args)
{
string modeOfStudy;
System.Console.WriteLine("Are you a PartTime or FullTime Student?");
modeOfStudy = Console.ReadLine();
if (modeOfStudy "FullTime")
{
System.Console.WriteLine("What course are you studying?");
string course = Console.ReadLine();
System.Console.WriteLine(course + is a good course");
}
==
else if (modeOfStudy == "PartTime")
{
System.Console.WriteLine("How many unit are you taking?");
int unit = Convert.ToInt32(Console.ReadLine());
if (unit > 6){
System.Console.WriteLine("Too much unit for a PartTime Sudent");
}
else{
System.Console.WriteLine("Proceed to the screen!");
}
}
}
}

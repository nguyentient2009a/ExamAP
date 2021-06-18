using System;

namespace Exam_AP
{
    internal class Program
    {
      public static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Anar";
            person.Age = 40;
            Console.WriteLine("Person deatails - Name = " +person.Name+", Age = "+person.Age);
            Console.WriteLine("Person deatails (After incrementing age) - Name = " +person.Name+", Age = "+(person.Age+1));
        }
    }
}

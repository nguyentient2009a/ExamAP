using System;

namespace Exam_AP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Armar";
            person.Age = 40;
            Console.WriteLine("Person details - {0}", person);
            
            person.Age += 1;
            Console.WriteLine("Person details ( After increnenting age ) - {0}", person);
        }
    }
}
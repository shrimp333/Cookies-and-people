using System;

namespace people
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Brad","Smith","10/10/1000",190);
            Person p2 = new Person("Serena", "Smith", "21/2/1990", 160);
            Person p3 = new Person("Kyle", "Cool", "5/8/1996", 184);
            Console.WriteLine($"{p1.getFullName()} has a {p1.getHeightDifference(p2)}cm height difference between {p2.getFullName()}");
            Subject s1 = new Subject("Maths", "2012");
            Subject s2 = new Subject("English", "2012");
            Subject s3 = new Subject("Science", "1683");
            p1.addSubject(s1);
            p1.addSubject(s2);
            p1.addSubject(s3);
            Console.WriteLine(p1.listSubjects());

        }
    }
}

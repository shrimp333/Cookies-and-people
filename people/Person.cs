using System;
using System.Collections.Generic;
namespace people
{
    class Person
    {
        string firstName;
        string lastName;
        string Dob;
        int height;
        string id;
        List<Subject> SubjectList = new List<Subject>();
        public Person(string pFirstName, string pLastName, string pDob, int pHeight)
        {
            Random rnd = new Random();
            firstName = pFirstName; 
            lastName = pLastName;
            Dob = pDob;
            height = pHeight;
            id = rnd.Next(1000,9999).ToString();
        }
        public string getFullName() => $"{firstName} {lastName}";
        public int getHeightDifference(Person p2) => Math.Abs(this.height - p2.height);
        public void addSubject(Subject s) => SubjectList.Add(s);
        public string listSubjects()
        {
            string output = "";
            foreach(var s in SubjectList)
            {
                output += $"{s.name} ";
            }
            return output.Trim();
        }
    }

    class Subject
    {
        string Name;
        public string name
        { 
            get{return Name;} 
            set{Name = name;} 
        }
        string YearOfDelivery;
        public Subject(string pName, string pYearOfDelivery)
        {
            Name = pName;
            YearOfDelivery = pYearOfDelivery;
        }
    }
}

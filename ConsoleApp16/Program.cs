using System;
using System.Collections.Generic;

namespace ConsoleApp15
{
    abstract class Student
    {
        protected const int allLectionsNumber = 20;
        protected int visitedLections;
        public abstract string Name { get; set; }
        public abstract string Surname { get; set; }

        public abstract bool PassExam();
    }
    class SimpleStudent : Student
    {
        private string _name;
        private string _surname;

        public SimpleStudent(int visitedLections)
        {
            this.visitedLections = visitedLections;
        }

        public override string Name { get => _name; set => _name = value; }
        public override string Surname { get => _name; set => _name = value; }

        public override bool PassExam()
        {
            if (visitedLections == allLectionsNumber)
            {
                return true;
            }
            else
            {
                Random random = new Random();
                return visitedLections > (double)allLectionsNumber / 2 ? random.Next(0, 1) == 1 : false;
            }
        }
    }
    class NotBadStudent : Student
    {
        private string _name;
        private string _surname;

        public NotBadStudent(int visitedLections)
        {
            this.visitedLections = visitedLections;
        }

        public override string Name { get => _name; set => _name = value; }
        public override string Surname { get => _name; set => _name = value; }

        public override bool PassExam()
        {
            if (visitedLections == allLectionsNumber)
            {
                return true;
            }
            else
            {
                Random random = new Random();
                return visitedLections > (double)allLectionsNumber / 2 ? random.Next(0, 3) != 1 : false;
            }
        }
    }
    class GeniusStudent : Student
    {
        private string _name;
        private string _surname;

        public GeniusStudent(int visitedLections)
        {
            this.visitedLections = visitedLections;
        }

        public override string Name { get => _name; set => _name = value; }
        public override string Surname { get => _name; set => _name = value; }

        public override bool PassExam()
        {
            return visitedLections > 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentGroup = new List<Student>();

            SimpleStudent Sanya = new SimpleStudent(5);
            Sanya.Name = "Sanya";
            Sanya.Surname = "Kovalenko";
            studentGroup.Add(Sanya);

            SimpleStudent Vasya = new SimpleStudent(20);
            Vasya.Name = "Vasya";
            Vasya.Surname = "Valenko";
            studentGroup.Add(Vasya);

            SimpleStudent Afanasiy = new SimpleStudent(11);
            Afanasiy.Name = "Afanasiy";
            Afanasiy.Surname = "Ivanovich";
            studentGroup.Add(Afanasiy);

            SimpleStudent Ihor = new SimpleStudent(1);
            Ihor.Name = "Ihor";
            Ihor.Surname = "Paharenko";
            studentGroup.Add(Ihor);

            SimpleStudent Roman = new SimpleStudent(9);
            Roman.Name = "Roman";
            Roman.Surname = "Lenko";
            studentGroup.Add(Roman);

            NotBadStudent Alex = new NotBadStudent(3);
            Alex.Name = "Alex";
            Alex.Surname = "Apple";
            studentGroup.Add(Alex);

            NotBadStudent John = new NotBadStudent(20);
            John.Name = "John";
            John.Surname = "Horn";
            studentGroup.Add(John);

            NotBadStudent Kristina = new NotBadStudent(15);
            Kristina.Name = "Kristina";
            Kristina.Surname = "Nuts";
            studentGroup.Add(Kristina);

            NotBadStudent Nate = new NotBadStudent(20);
            Nate.Name = "Nate";
            Nate.Surname = "Mask";
            studentGroup.Add(Nate);

            GeniusStudent Acelynn = new GeniusStudent(2);
            Acelynn.Name = "Acelynn";
            Acelynn.Surname = "Acelynno";
            studentGroup.Add(Acelynn);

            Console.WriteLine("Result of exam:");
            studentGroup.ForEach(student =>
            {
                Console.WriteLine($"{student.Name} {student.Surname} - {(student.PassExam() ? "passed" : "failed")} ");
            });
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР11._2
{
    internal class Person
    {
        private string name;
        private string surname;
        private DateTime BirthDay;
        public string Name
        {
            get { return name; }
            set
            {
                if (value != null && value.Length >= 2)
                {
                    name = value;
                }
                else
                {
                    name = "Oleg";
                }
            }
        }
        public string Surname
        {
            get { return surname; }
            set
            {
                if (value != null && value.Length >= 2)
                {
                    surname = value;
                }
                else
                {
                    surname = "White";
                }
            }
        }
        public DateTime birthDay
        {
            get { return birthDay; }
            set
            {
                int age = DateTime.Now.Year - value.Year;

                if (DateTime.Now < value.AddYears(age))
                {
                    age--;
                }
                if (age >= 100)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    birthDay = value;
                }
            }
        }

        public Person (string name, string surname, DateTime birthDay)
        {
            Name = name;
            Surname = surname;
            BirthDay = birthDay;
        }

        public Person(){}

        public override string ToString()
        {
            return $"Name = {Name} + Surname = {Surname} + BirthDay = {BirthDay:d}";
        }

        public virtual string ToShortString ()
        {
            return $"{Name} + {Surname}";
        }

    }
}

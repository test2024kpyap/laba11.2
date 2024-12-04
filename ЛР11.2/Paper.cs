using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР11._2
{
    internal class Paper
    {
        public string Name {  get; set; }
        Person author;
        public Person Author {
           get{
                if(author == null)
                {
                    return new Person("", "", DateTime.Now);
                }else
                {
                    return author;
                }
            }
            set { author = value; }
        }
        public DateTime DatePublication { get; set; }

        public Paper() { }
        public Paper(string name, Person author, DateTime datePublication) {
            Name = name;
            Author = author;
            DatePublication = datePublication;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Author {Author.Name}, Publication {DatePublication:d}";
        }

    }
}

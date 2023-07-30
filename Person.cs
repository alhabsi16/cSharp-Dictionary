using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Dictionary
{
    internal class Person
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Gander { get; set; }

        public Person(long Id, string Name, string Gander) 
        {
            this.Id = Id;
            this.Name = Name;
            this.Gander = Gander;
        }
        public override string ToString()
        {
            return ($"name: {Name}, Gander: {Gander}");
        }
    }
}

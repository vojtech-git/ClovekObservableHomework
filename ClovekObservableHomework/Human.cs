using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClovekObservableHomework
{
    public class Human
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public string FullName { get; set; }

        public Human(string _name, string _lastName, int _birthYear)
        {
            Name = _name;
            LastName = _lastName;
            BirthYear = _birthYear;
            FullName = _name + " " + _lastName;
        }
    }
}

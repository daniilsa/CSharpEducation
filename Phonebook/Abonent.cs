using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Abonent
    {
        string name = null;
        string phone = null;

        public string Name { get {return name; } set {name = value; } }
        public string Phone { get {return phone; } set { phone = value; } }

        public Abonent()
        {
            name = "None";
            phone = "None";
        }
        public Abonent(string phone) : this()
        {
            this.name = phone;
        }
        public Abonent(string name, string phone) : this()
        {
            this.name = name;
            this.phone = phone;
        }
    }
}

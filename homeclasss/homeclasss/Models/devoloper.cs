using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeclasss.Models
{
    internal class devoloper:Person
    {
        
        public int Salary;
        public devoloper()
        {
            Console.WriteLine("ilk ishe dusen methoddur");
        }
        public devoloper(string name) : this()
        {
            this.name = name;


        }

        public devoloper(string name, string surname, int age = 20) : this(name)
        {

            this.surname = surname;
            this.age = age;
        }
        public void Info()
        {
            Console.WriteLine($"ad {name}  soyad {surname}  yas {age}  ");
        }
    }
}

using System;

namespace homeclasss.Models
{
    internal class Student:Person 
    {
        
        public int profession;
        public Student()
        {
            Console.WriteLine("ilk ishe dusen methoddur");
        }
        public Student(string name):this()
        {
            this.name = name;


        }

        public Student(string name, string surname, int age=20) : this(name)
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

using System;
using homeclasss.Models;

namespace homeclasss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region object
            //string name1 = "Aqil";
            //string surname1 = "Xalilov";
            //int age1 = 20;
            //string name2 = "Xalil";
            //string surname2 = "Quliyev";
            //int age2 = 20;
            //var obj1 = new
            //{
            //    name = "Aqil",
            //    surname = "xalilov",
            //    age = 20,
            #endregion
            #region classs
            //Student Students1 = new Student("Aqil ", "Xalilov");
            //Students1.Info();

            //Students1.name = "Aqil";
            //Students1.surname = "Xalilov";
            //Students1.Info();

            #endregion

            #region inh
            devoloper dev1 = new devoloper();
            dev1.age = 20;
            dev1.Salary = 500;
            Console.WriteLine(dev1.age);
            Console.WriteLine( dev1.Salary);

        #endregion
                }


        }


    }

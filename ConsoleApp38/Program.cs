using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, FirstName = "ilknur", LastName = "güzel", City = "ankara" };
            Customer customer2 = new Customer ( 2, "İrem", "Güzel", "ankara" );
            




        }
        
    }


    class Customer
    {   // default constructor
        public  Customer(int ıd, string firstName,string lastName,string city)  //parametre ekleyerek 14 satırdaki kodu çalışır hale getirdik ancak bu şekilde 13 satır çalışır durumda değil
        {
            Console.WriteLine("Yapıcı blok çalıştı");

        }
        public Customer() //bu method ile overloading ederek kodu ezdik
        {

        }


        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }

}

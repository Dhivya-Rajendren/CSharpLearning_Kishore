using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsLearning.BookStore
{
    public class Person  //parent class , Super class, base class
    {
        public string Name { get; set; }
        public long Contact { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string IdProof { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"Details are :{Name}, {Email}, {Contact}");
        }

    }

       public class BookStoreMember:Person   // Child class, sub class, dervied class
    {
        public int MemberId { get; set; }
    }

     public class Author:Person
    {
        public string AuthorId { get; set; }
    }

    public class Supplier:Person
    {
        public int SupplierId { get; set; }
    }
}

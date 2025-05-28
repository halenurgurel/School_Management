using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public void getPeople()
        {
            Console.WriteLine("1. Öğrenci Bilgisi: ");
            Console.WriteLine($"Ad: {Name}, Soyad: {Surname}, Doğum Tarihi: {BirthDate.ToShortDateString()}");

           /* Console.WriteLine("2. Öğrenci Bilgisi: ");
            Console.WriteLine($"Ad: {student2.Name}, Soyad: {student2.Surname}, Doğum Tarihi: {student2.BirthDate.ToShortDateString()}");

            Console.WriteLine("1. Öğretmen Bilgisi: ");
            Console.WriteLine($"Ad: {teacher1.Name}, Soyad: {teacher1.Surname}, Doğum Tarihi: {teacher1.BirthDate.ToShortDateString()}");

            Console.WriteLine("2. Öğretmen Bilgisi: ");
            Console.WriteLine($"Ad: {teacher2.Name}, Soyad: {teacher2.Surname}, Doğum Tarihi: {teacher2.BirthDate.ToShortDateString()}");*/
        }

    }
}

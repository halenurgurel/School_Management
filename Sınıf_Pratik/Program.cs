using System;
using Sınıf_Pratik;
class Program
{
    static void Main()
    {
        Person student1 = new Person
        {
            Name = "Ali",
            Surname = "Yılmaz",
            BirthDate = new DateTime(2000, 5, 15)
        };

        Person student2 = new Person
        {
            Name = "Ayşe",
            Surname = "Demir",
            BirthDate = new DateTime(2001, 3, 22)
        };

        Person teacher1 = new Person
        {
            Name = "Mehmet",
            Surname = "Kara",
            BirthDate = new DateTime(1985, 7, 10)
        };

        Person teacher2 = new Person
        {
            Name = "Fatma",
            Surname = "Çelik",
            BirthDate = new DateTime(1990, 11, 5)
        };

        Console.WriteLine("1. Öğrenci Bilgisi: ");
        Console.WriteLine($"Ad: {student1.Name}, Soyad: {student1.Surname}, Doğum Tarihi: {student1.BirthDate.ToShortDateString()}");

        Console.WriteLine("2. Öğrenci Bilgisi: ");
        Console.WriteLine($"Ad: {student2.Name}, Soyad: {student2.Surname}, Doğum Tarihi: {student2.BirthDate.ToShortDateString()}");

        Console.WriteLine("1. Öğretmen Bilgisi: ");
        Console.WriteLine($"Ad: {teacher1.Name}, Soyad: {teacher1.Surname}, Doğum Tarihi: {teacher1.BirthDate.ToShortDateString()}");

        Console.WriteLine("2. Öğretmen Bilgisi: ");
        Console.WriteLine($"Ad: {teacher2.Name}, Soyad: {teacher2.Surname}, Doğum Tarihi: {teacher2.BirthDate.ToShortDateString()}");

    }
}
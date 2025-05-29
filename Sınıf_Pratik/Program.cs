using System;
using School_Management;
class Program
{
    //Bu program , okul yönetim sistemi için öğrenci ve öğretmen bilgilerini tutan bir sınıf tanımlamaktadır.
    static void Main()
    // Öğrenci ve öğretmen bilgilerini tutan Person sınıfını tanımlıyoruz.
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

        // Öğrenci ve öğretmen bilgilerini ekrana yazdırıyoruz.
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
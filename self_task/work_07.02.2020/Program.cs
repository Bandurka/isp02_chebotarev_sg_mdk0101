using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student01 = new Student("Ivan", 2, "Male");
            Employee employee01 = new Employee("Ivan", "Officer", 10);
            WorkShop workshop01 = new WorkShop("GG133", 20);
            Book book01 = new Book("Metro", new string[] { "Glukhovsky" }, 900);
            Offset offset01 = new Offset("Ivanov Ivan Ivanovich", "Petrov Sergey Petrovich", 15.02, 3);
            Adress adress01 = new Adress(1337, "Volzhskiy", "Lenina", 69, 7);
            Product product01 = new Product("Milk", 100, 50, 24.02);
            StudyGroup studygroup01 = new StudyGroup("2.18", 19, 2018, "ISP2");
            Banknote banknote01 = new Banknote(1488, 5, "five");
            ComputerGame computergame01 = new ComputerGame("CS:GO", "Valve", 2012, "Shooter");

            Console.WriteLine(student01);
            Console.WriteLine(employee01);
            Console.WriteLine(workshop01);
            Console.WriteLine(book01);
            Console.WriteLine(offset01);
            Console.WriteLine(adress01);
            Console.WriteLine(product01);
            Console.WriteLine(studygroup01);
            Console.WriteLine(banknote01);
            Console.WriteLine(computergame01);

            Console.ReadKey();
        }

    }
}

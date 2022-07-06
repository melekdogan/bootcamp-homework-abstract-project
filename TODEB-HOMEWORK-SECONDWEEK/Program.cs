using System;
using TODEB_HOMEWORK_SECONDWEEK.Abstract;
using TODEB_HOMEWORK_SECONDWEEK.Concrete;

namespace TODEB_HOMEWORK_SECONDWEEK
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract sınıflar, kendisinden türetilen sınıfların referanslarını tutabilirler. 
            Employee Teacher = new Teacher() { 
                NameSurname = "Elif Demirel",
                Birthday = Convert.ToDateTime("28/12/1990"),
                Branch="Math"
            };
            Employee principal = new Principal() {
                NameSurname = "Veli Başar", 
                Birthday = Convert.ToDateTime("01/08/1971") 
            };

            Teacher.GetInfoAbout();            
            principal.GetInfoAbout();
            Teacher.PayASalary();
            principal.PayASalary();

            
        }
    }
}

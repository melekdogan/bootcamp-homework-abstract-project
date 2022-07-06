using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODEB_HOMEWORK_SECONDWEEK.Abstract
{
    ////Class, method ve property için internal access modifier ı kullanmamın sebebi, bu proje dışından erişecek başka bir proje bulunmamasıdır.Dolayısıyla public yapmaya gerek yoktur. 
    internal abstract class Employee
    {
        private string _NameSurname;
        private string _IdentityNumber;
        private string _PhoneNumber;
        private DateTime _Birthday;
        private string _Salary;

        internal string NameSurname
        {
            get { return _NameSurname; }
            set { _NameSurname = value; }
        }
        internal string IdentityNumber
        {
            get { return _IdentityNumber; }
            set { _IdentityNumber = value; }
        }
        internal string PhoneNumber
        {
            get { return _PhoneNumber; }
            set { _PhoneNumber = value; }
        }
        internal DateTime Birthday
        {
            get { return _Birthday; }
            set { _Birthday = value; }
        }
        internal string Salary {
            get {return _Salary;}
            set { _Salary = value;}
        }

        internal virtual void GetInfoAbout()
        {
            Console.WriteLine(NameSurname+'\n'+Birthday.ToShortDateString());
        }
        internal virtual void PayASalary()
        {
            Console.WriteLine("Hello Dear "+NameSurname+"! Your Salary Has Been Paid. :)");
        }
    }
}

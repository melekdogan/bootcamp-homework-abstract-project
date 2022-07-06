using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODEB_HOMEWORK_SECONDWEEK.Abstract;

namespace TODEB_HOMEWORK_SECONDWEEK.Concrete
{
    //class için herhangi bir erişim belirteci kullanmadım çünkü belirteç kullanılmazsa zaten default olarak internal erişim belirteci ile oluşur. Başka bir proje/katman bulunmadığından, public işaretlemeye gerek yoktur.
    
    class Teacher : Employee // Öğretmen (sınıfı) bir çalışandır. 
    {
        internal string Branch { get; set; } //property ve metod için internal access modifier ı kullanmamın sebebi, bu proje dışından erişecek başka bir proje bulunmamasıdır.Dolayısıyla public yapmaya gerek yoktur. 

        internal override void GetInfoAbout()
        {
            Console.WriteLine(base.NameSurname + '\n' + base.Birthday.ToShortDateString()+'\n'+Branch+" Teacher"+'\n');
        }
        //Propertyler base classtan geldiği için propertyleri belirtirken base kelimesi ile sınıfın türetildiği soyut sınıfı belirtiriz. 
        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;



namespace Consol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // формируем список людей
            person my = new person("Ann", 18, 66, 170);
            person my1 = new person("Anton", 19, 70, 190);
            person my2 = new person("Nasty", 18, 80 , 160);
            People all = new People();
            all.People_add(my);
            all.People_add(my1);
            all.People_add(my2);

            //ввод через консоль  
            person p = new person();
            p.person_int();
            all.People_add(p);

            all.People_out();

            //вывод данных о соотношении роста и веса
            string s = all.Age_Weig(my);
            Console.WriteLine(s);
            s = all.Age_Weig(my1);
            Console.WriteLine(s);
            s = all.Age_Weig(my2);
            Console.WriteLine(s);

            //ищем имена на букву
            string w;
            Console.WriteLine("Введите букву: ");
            w = Console.ReadLine();
            all.Sort(w);

            Console.ReadLine();
        }
    }
}

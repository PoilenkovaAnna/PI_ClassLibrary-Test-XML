using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1

{
    
    /// <summary>
    /// struct person
    /// </summary>
    public struct person
    {
        /// <summary>
        /// name 
        /// </summary>
        public string name { get; set; } //даем доступ для чтения и для записи
        /// <summary>
        /// age
        /// </summary>
        public int age { get; set; }
        /// <summary>
        /// weight 
        /// </summary>
        public double weight { get; set; }
        /// <summary>
        /// growth
        /// </summary>
        public int growth { get; set; }
        /// <summary>
        /// data of person
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="age">age</param>
        /// <param name="weight">weight</param>
        /// <param name="growth">growth</param>
        public person(string name, int age, double weight, int growth)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.growth = growth;
        }
        /// <summary>
        /// output data adout person 
        /// </summary>
        public void person_out()
        {
            Console.WriteLine($"Name: {name}  Age: {age}  Weight: {weight}  Growth: {growth} ");
        }

        /// <summary>
        /// input data about one person
        /// </summary>
        public void person_int()
        {
            Console.WriteLine("Name:");
            name = Console.ReadLine();
            Console.WriteLine("Age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Weight:");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Growth:");
            growth  = Convert.ToInt32(Console.ReadLine());
        }

    }


   /// <summary>
   /// class People
   /// </summary>
    public class People
    {
        /// <summary>
        /// list of people
        /// </summary>
        public List<person> peopl = new List<person>();

        /// <summary>
        /// form people from person
        /// </summary>
        /// <param name="p">STRUCT person</param>
        public void People_add(person p)
        {
            peopl.Add(p);
        }
        /// <summary>
        /// out all people in data
        /// </summary>
        public void People_out()
        {
            for (int i = 0; i < peopl.Count(); i++)
            {
                Console.WriteLine($"Name: {peopl[i].name}  Age: {peopl[i].age}  Weight: {peopl[i].weight}  Growth: {peopl[i].growth} ");
            }
        }
        /// <summary>
        /// dependence of the growth of the weight
        /// </summary>
        public string Age_Weig(person p)
        {
            string res;
            //for (int i = 0; i < peopl.Count(); i++)     // для обработки всего
           // {
                Console.WriteLine($"{p.name}");
                double r;
                r = p.growth - p.weight;
                if ((r >= 110) && (r <= 125)) res ="ниже среднего";
                else
                {
                    if ((r <= 110) && (r >= 96)) res = "нормально";
                    else
                    {
                        if ((r <= 97) && (r >= 85)) res = "выше среднего";
                        else
                        {
                            if ((r <= 84) && (r >= 40)) res = "ожирение";
                            else
                            {
                                    res = "вне диапазона";
                            }
                        }
                    }
                }
            return res;
        }
       
        /// <summary>
        /// sort by first letter
        /// </summary>
        /// <param name="s">name</param>
        /// <returns></returns>
        public string Sort(string  s)
        {
            List<string> NameS = new List<string>();
            //LINQ метод
            var selectedTeams = from t in peopl  // определяем каждый объект из teams как t
                                where t.name.ToUpper().StartsWith(s) //фильтрация по критерию
                                orderby t.name  // упорядочиваем по возрастанию
                                select t.name; // выбираем объект
            foreach (var x in selectedTeams)
                NameS.Add(x);
            Console.WriteLine(NameS[0]);
            return NameS[0];

        }

    
    }

}
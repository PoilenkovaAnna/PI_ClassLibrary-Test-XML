using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAge()
        {
            person p;
            p = new person("Ann", 18, 33, 90);
            int t = 0;
            if ((p.age > 16) && (p.age < 110)) t = 1;
            Console.WriteLine("Диапазон возрата от 16 до 110");
            Assert.AreEqual(t, 1);
        }


        [TestMethod]
        public void TestAge2()
        {
            person p;
            p = new person("Annn", 18, 33, 90);
            Assert.AreEqual(p.age, 18);
        }

        [TestMethod]
        public void TestT()
        {
            person p;
            People all = new People();
            p = new person("Annn", 18, 71, 180);
            all.People_add(p);
            string s = all.Age_Weig(p);
            Assert.AreEqual(s, "нормально");
        }

        [TestMethod]
        public void TestT2()
        {
            person p;
            People all = new People();
            p = new person("Annn", 18, 70, 180);
            all.People_add(p);
            string s = all.Age_Weig(p);
            Assert.AreEqual(s, "ниже среднего");
        }

        [TestMethod]
        public void TestT3()
        {
            person p;
            People all = new People();
            p = new person("Annn", 18, 90, 180);
            all.People_add(p);
            string s = all.Age_Weig(p);
            Assert.AreEqual(s, "выше среднего");
        }


    }


}

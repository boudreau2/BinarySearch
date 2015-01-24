using NHLPlayer;
using Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerTests
{
    public class PlayerTests
    {
        SortedArray sa;

        [SetUp]
        public void Setup()
        {
            sa = new SortedArray(10);
        }

        [Test]
        public void Test1()
        {
            sa.Insert(new Player(1, "John", "None"));
            sa.Insert(new Player(2, "John", "None"));
            sa.Insert(new Player(3, "John", "None"));
            sa.Insert(new Player(4, "John", "None"));
            sa.Insert(new Player(5, "John", "None"));
            sa.Insert(new Player(6, "John", "None"));
            sa.Insert(new Player(7, "John", "None"));
            sa.Insert(new Player(8, "John", "None"));
            sa.Insert(new Player(9, "John", "None"));
            sa.Insert(new Player(10, "John", "None"));
            Assert.Throws<NullReferenceException>(() => sa.Insert(new Player(11, "John", "None")));
        }

        [Test]
        public void Test2()
        {
            sa.Insert(new Player(1, "Albert", "None"));
            sa.Find(new Player(1, "Albert", "None"));
        }

        [Test]
        public void Test3()
        {
            sa.Insert(new Player(1, "John", "None"));
            sa.Insert(new Player(2, "John", "None"));
            sa.Insert(new Player(3, "John", "None"));
            sa.Insert(new Player(4, "John", "None"));
            sa.Insert(new Player(5, "John", "None"));
            sa.Insert(new Player(6, "John", "None"));
            sa.Insert(new Player(7, "John", "None"));
            sa.Insert(new Player(8, "John", "None"));
            sa.Insert(new Player(9, "John", "None"));
            sa.Insert(new Player(10, "John", "None"));
        }

        [Test]
        public void Test4()
        {
            sa.Insert(new Player(1, "John", "None"));
            sa.Find(new Player(3, "Albert", "None"));
            Console.WriteLine("Player does not exist");
        }

        [Test]
        public void Test5()
        {
            Assert.IsFalse(sa.IsEmpty());
        }

        [Test]
        public void Test6()
        {
            Assert.IsTrue(sa.IsEmpty());
        }

        [Test]
        public void Test7()
        {
            Assert.AreEqual(1, sa.Find(new Player(1, "Albert", "None")));
        }

        [Test]
        public void Test8()
        {
            Assert.AreNotEqual(3, sa.Find(new Player(1, "Albert", "None")));
        }

        [Test]
        public void Test9()
        {
            Assert.AreNotEqual(1, sa.Find(new Player(1, "Albert", "None")));
        }
        [Test]
        public void Test10()
        {
            Assert.AreEqual(3, sa.Find(new Player(1, "Albert", "None")));
        }
    }
}

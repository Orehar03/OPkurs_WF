using NUnit.Framework;
using OP_k_WF;

namespace TestProgKurs
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSort1()
        {
            int[] mas = new int[] { 29, 43, 19, 53, 99, 85, 125 };
            int[] r = new int[] { 19, 29, 43, 53, 85, 99, 125 };

            GnomeSortProg gs = new GnomeSortProg();
            gs.GnomeSort(mas);


            Assert.AreEqual(r, mas);
        }
        [Test]
        public void TestSort2()
        {
            int[] mas = new int[] { 31, 99, 3, 64, 123, 53, 11 };
            int[] r = new int[] { 3, 11, 31, 53, 64, 99, 123 };

            GnomeSortProg gs = new GnomeSortProg();
            gs.GnomeSort(mas);


            Assert.AreEqual(r, mas);
        }
        [Test]
        public void TestSort3()
        {
            int[] mas = new int[] { 12, 57, 18, 8, 56, 9, 77 };
            int[] r = new int[] { 8, 9, 12, 18, 56, 57, 77 };

            GnomeSortProg gs = new GnomeSortProg();
            gs.GnomeSort(mas);


            Assert.AreEqual(r, mas);
        }
        [Test]
        public void TestSort4()
        {
            int[] mas = new int[] { 30, 41, 88, 56, 12, 22, 99 };
            int[] r = new int[] { 12, 22, 30, 41, 56, 88, 99 };

            GnomeSortProg gs = new GnomeSortProg();
            gs.GnomeSort(mas);


            Assert.AreEqual(r, mas);
        }
    }
}
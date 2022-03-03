using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_1.lab_2;
using lab_1.ex;

namespace lab_3.Tests
{
    [TestClass]
    public class RomanNumber_isWorkCorrect
    {
        private RomanNumber t1;

        [TestMethod]
        public void RomanNumber_isCreateCorrect()
        {
            t1 = new RomanNumber(12);
            Assert.AreEqual("XII", t1.ToString());
        }

        [TestMethod]
        public void RomanNumber_isCreateCorrect_False()
        {
            t1 = new RomanNumber(16);
            Assert.AreNotEqual("XII", t1.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void RomanNumber_isCreateCorrect_Null()
        {
            t1 = new RomanNumber(0);
        }

        [TestMethod]
        public void RomanNumber_checkAllLiterals()
        {
            short[] Values = new short[]
            { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            string[] Numerals = new string[]
            { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            for (int i = 0; i < Values.Length; ++i)
            {
                t1 = new RomanNumber(((ushort)Values[i]));
                Assert.AreEqual(Numerals[i], t1.ToString());
            }
        }

    }


    [TestClass]
    public class RomanNumber_IsAddingWorkCorrect
    {
        private  RomanNumber t1;
        private  RomanNumber t2;

        [TestMethod]
        public void CheckAddWithSameNumbers()
        {
            t1 = new RomanNumber(10);
            Assert.AreEqual("XX", (t1 + t1).ToString());
        }

        [TestMethod]
        public void CheckAddWithNotSameNumbers()
        {
            t1 = new RomanNumber(1);
            t2 = new RomanNumber(6);
            Assert.AreEqual("VII", (t1 + t2).ToString());
        }

        [TestMethod]
        public void CheckAddWithNotSameNumbers_false()
        {
            t1 = new RomanNumber(1);
            t2 = new RomanNumber(6);
            Assert.AreNotEqual("VAAAII", (t1 + t2).ToString());
        }


        [TestMethod]
        public void CheckAddWithSameNumbers_false()
        {
            t1 = new RomanNumber(10);
            Assert.AreNotEqual("XAAAX", (t1 + t1).ToString());
        }

    }

    [TestClass]
    public class RomanNumber_isSubWorkCorrect
    {
        private RomanNumber t1;
        private RomanNumber t2;

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void CheckSubException()
        {
            t1 = new RomanNumber(10);
            var obj = t1 - t1;
        }

        [TestMethod]
        public void CheckSub()
        {
            t1 = new RomanNumber(6);
            t2 = new RomanNumber(1);
            Assert.AreEqual("V", (t1 - t2).ToString());
        }

        [TestMethod]
        public void CheckAddWithNotSameNumbers()
        {
            t1 = new RomanNumber(6);
            t2 = new RomanNumber(1);
            Assert.AreNotEqual("VAAAII", (t1 - t2).ToString());
        }


        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void CheckExceptionNull()
        {
            t1 = new RomanNumber(10);
            var obj = t1 - t1;
        }
    }

    [TestClass]
    public class RomanNumber_IsMultWorkCorrect
    {
        private RomanNumber t1;
        private RomanNumber t2;

        [TestMethod]
        public void CheckMul_onOne()
        {
            t1 = new RomanNumber(1);
            Assert.AreEqual("I", (t1 * t1).ToString());
        }

        [TestMethod]
        public void CheckMul_NotSame()
        {
            t1 = new RomanNumber(2);
            t2 = new RomanNumber(3);
            Assert.AreEqual("VI", (t1 * t2).ToString());
        }
    }

    [TestClass]
    public class RomanNumber_IsDivWorkCorrect
    {
        private RomanNumber t1;
        private RomanNumber t2;

        [TestMethod]
        public void CheckMul_onOne()
        {
            t1 = new RomanNumber(1);
            Assert.AreEqual("I", (t1 / t1).ToString());
        }

        [TestMethod]
        public void CheckMul_NotSame()
        {
            t1 = new RomanNumber(6);
            t2 = new RomanNumber(3);
            Assert.AreEqual("II", (t1 / t2).ToString());
        }
    }

    [TestClass]
    public class RomanNumber_IsToStringParserWorkCorrect
    {
        private RomanNumber t1;
        [TestMethod]
        public void CheckString_numb()
        {
            t1 = new RomanNumber(1);
            Assert.AreEqual("I", t1.ToString());
        }

        [TestMethod]
        public void CheckString_numb2()
        {
            t1 = new RomanNumber(10);
            Assert.AreEqual("X", t1.ToString());
        }
    }

    [TestClass]
    public class RomanNumber_IsToCompareWorkCorrect
    {
        private RomanNumber t1;
        private RomanNumber t2;

        [TestMethod]
        public void CheckCompare_11()
        {
            t1 = new RomanNumber(1);
            t2 = new RomanNumber(1);
            Assert.AreEqual(0, t1.CompareTo(t2));
        }

        [TestMethod]
        public void CheckCompare_12()
        {
            t1 = new RomanNumber(1);
            t2 = new RomanNumber(2);
            Assert.AreEqual(-1, t1.CompareTo(t2));
        }

        [TestMethod]
        public void CheckCompare_21()
        {
            t1 = new RomanNumber(2);
            t2 = new RomanNumber(1);
            Assert.AreEqual(1, t1.CompareTo(t2));
        }
    }

    [TestClass]
    public class RomanNumber_isClonningWorkCorrect
    {
        private RomanNumber t1;

        [TestMethod]
        public void CheckClone_sbtrue()
        {
            t1 = new RomanNumber(1);
            var t2 = t1.Clone();
            Assert.AreEqual(t1.ToString(), t2.ToString());
        }
    }
}

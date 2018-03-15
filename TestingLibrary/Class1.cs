using NUnit.Framework;
using TestingCa2018.Controllers;

namespace TestingLibrary
{
    [TestFixture]
    public class NUnitTests
    {
        static PremController sut;
        //test
        [SetUp]
        public void Init()
        {
            sut = new PremController();
        }

        [Test]
        public void TestNotNull()
        {
            Assert.NotNull(sut, "Object not created");
        }

        [Test]
        public void Test1()
        {
            double res = sut.CalcPremium(20, "female");
            Assert.That(res, Is.EqualTo(5.0));
        }

        [Test]
        public void Test2()
        {
            double res = sut.CalcPremium(32, "female");
            Assert.That(res, Is.EqualTo(3.5));
        }
        [Test]
        public void Test3()
        {
            double res = sut.CalcPremium(20, "male");
            Assert.That(res, Is.EqualTo(6.0));
        }

        [Test]
        public void Test4()
        {
            double res = sut.CalcPremium(37, "male");
            Assert.That(res, Is.EqualTo(5.0));
        }

        [Test]
        public void Test5()
        {
            double res = sut.CalcPremium(55, "male");
            Assert.That(res, Is.EqualTo(2.5));
        }

        [Test]
        public void Test6()
        {
            double res = sut.CalcPremium(55, "female");
            Assert.That(res, Is.EqualTo(1.75));
        }

        [Test]
        public void Test7()
        {
            double res = sut.CalcPremium(16, "female");
            Assert.That(res, Is.EqualTo(0.0));
        }

        [Test]
        public void Test8()
        {
            double res = sut.CalcPremium(16, "male");
            Assert.That(res, Is.EqualTo(0.0));
        }

        [Test]
        public void Test9()
        {
            double res = sut.CalcPremium(18, "");
            Assert.That(res, Is.EqualTo(0.0));
        }

        //Q6
        [TestCase(15, "female", ExpectedResult = 0.0)]
        [TestCase(19, "female", ExpectedResult = 5.0)]
        [TestCase(30, "female", ExpectedResult = 5.0)]
        [TestCase(31, "female", ExpectedResult = 2.5)]
        [TestCase(50, "female", ExpectedResult = (2.5 * 0.15))]
        [Test]
        public double FemaleTests(int a, string b)
        {
            
            return sut.CalcPremium(a, b);
        }

        [TestCase(18, "male", ExpectedResult = 6.0)]
        [TestCase(19, "male", ExpectedResult = 6.0)]
        [TestCase(35, "male", ExpectedResult = 6.0)]
        [TestCase(36, "male", ExpectedResult = 5.0)]
        [TestCase(50, "male", ExpectedResult = (5.0 * 0.15))]
        [Test]
        public double MaleTests(int a, string b)
        {
            return sut.CalcPremium(a, b);
        }

        

        [TestCase(18, "female", ExpectedResult = 5.0)]
        [TestCase(18, "Female", ExpectedResult = 5.0)]
        [TestCase(18, "FEMALE", ExpectedResult = 5.0)]
        [TestCase(18, "male", ExpectedResult = 6.0)]
        [TestCase(18, "Male", ExpectedResult = 6.0)]
        [TestCase(18, "MALE", ExpectedResult = 6.0)]
        [Test]
        public double CheckCase(int a, string b)
        {
            //should be case insensitive?
            return sut.CalcPremium(a, b);
        }

    }
}

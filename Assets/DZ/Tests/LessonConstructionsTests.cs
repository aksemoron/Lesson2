using NUnit.Framework;
using static Sample.LessonConstructions;

namespace Tests
{
    [TestFixture]
    public sealed class LessonConstructionsTests
    {
        [Test]
        public void QuadraticRootNumberTest()
        {
            Assert.AreEqual(1, QuadraticRootNumber(1.0, 2.0, 1.0));
            Assert.AreEqual(2, QuadraticRootNumber(1.0, 3.0, 2.0));
            Assert.AreEqual(0, QuadraticRootNumber(1.0, 4.0, 10.0));
        }

        [Test]
        public void GradeNotationTest()
        {
            Assert.AreEqual("отлично", GradeNotation(5));
            Assert.AreEqual("удовлетворительно", GradeNotation(3));
        }

        [Test]
        public void FactorialTest()
        {
            Assert.AreEqual(1.0, Factorial(0), 1e-5);
            Assert.AreEqual(1.0, Factorial(1), 1e-5);
            Assert.AreEqual(6.0, Factorial(3), 1e-5);
            Assert.AreEqual(120.0, Factorial(5), 1e-5);
            Assert.AreEqual(3628800.0, Factorial(10), 1e-5);
            Assert.AreEqual(2.43290200817664E18, Factorial(20), 1E10);
        }

        [Test]
        public void AgeDescriptionTest()
        {
            Assert.AreEqual("1 год", AgeDescription(1));
            Assert.AreEqual("21 год", AgeDescription(21));
            Assert.AreEqual("132 года", AgeDescription(132));
            Assert.AreEqual("12 лет", AgeDescription(12));
            Assert.AreEqual("111 лет", AgeDescription(111));
            Assert.AreEqual("199 лет", AgeDescription(199));
        }

        [Test]
        public void WhichRookThreatensTest()
        {
            Assert.AreEqual(0, WhichRookThreatens(1, 2, 3, 4, 5, 6));
            Assert.AreEqual(1, WhichRookThreatens(5, 3, 7, 3, 4, 8));
            Assert.AreEqual(2, WhichRookThreatens(6, 8, 8, 6, 6, 3));
            Assert.AreEqual(3, WhichRookThreatens(3, 7, 8, 7, 3, 5));
        }

        [Test]
        public void TriangleKindTest()
        {
            Assert.AreEqual(-1, TriangleKind(3.0, 7.5, 4.0));
            Assert.AreEqual(1, TriangleKind(5.0, 3.0, 4.0));
            Assert.AreEqual(2, TriangleKind(4.0, 6.0, 8.0));
            Assert.AreEqual(0, TriangleKind(1.0, 1.5, 1.5));
        }

        [Test]
        public void FibonacciTest()
        {
            Assert.AreEqual(1, Fibonacci(1));
            Assert.AreEqual(1, Fibonacci(2));
            Assert.AreEqual(2, Fibonacci(3));
            Assert.AreEqual(5, Fibonacci(5));
            Assert.AreEqual(21, Fibonacci(8));
            Assert.AreEqual(102334155, Fibonacci(40));
            Assert.AreEqual(1134903170, Fibonacci(45));
            Assert.AreEqual(1836311903, Fibonacci(46));
        }

        [Test]
        public void MinDivisorTest()
        {
            Assert.AreEqual(2, MinDivisor(2));
            Assert.AreEqual(3, MinDivisor(75));
            Assert.AreEqual(5, MinDivisor(75 / 3));
            Assert.AreEqual(97, MinDivisor(97));
            Assert.AreEqual(7, MinDivisor(49));
            Assert.AreEqual(17, MinDivisor(8653));
        }

        [Test]
        public void RevertTest()
        {
            Assert.AreEqual(87431, Revert(13478));
            Assert.AreEqual(0, Revert(0));
            Assert.AreEqual(3, Revert(3));
            Assert.AreEqual(111, Revert(111));
            Assert.AreEqual(17571, Revert(17571));
            Assert.AreEqual(123456789, Revert(987654321));
        }
    }
}
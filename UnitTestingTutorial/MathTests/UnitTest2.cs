using MyMath;
using System.Diagnostics;

namespace MathTests
{
    [TestClass]
    public class UnitTest2
    {
        //[AssemblyInitialize]
        //public static void AssemblyInitialize(TestContext testContext)
        //{
        //}

        //[AssemblyCleanup]
        //public static void AssemblyCleanup()
        //{
        //}

        

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            //Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine("ClassInitialize2");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Trace.WriteLine("ClassCleanup2");
        }
        [TestMethod]
        public void BasicRooterTest()
        {
            //Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
           
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine("BasicRooterTest2");
            // Create an instance to test:
            Rooter rooter = new Rooter();
            // Define a test input and output value:
            double expectedResult = 2.0;
            double input = expectedResult * expectedResult;
            // Run the method under test:
            double actualResult = rooter.SquareRoot(input);
            // Verify the result:
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100);
        }

        [TestMethod]
        [DataRow(2)]
        [DataRow(4)]
        public void TestMethod2(double expectedResult) 
        {
            // Create an instance to test:
            Rooter rooter = new Rooter();
            double input = expectedResult * expectedResult;
            // Run the method under test:
            double actualResult = rooter.SquareRoot(input);
            // Verify the result:
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100);
        }
    }
}
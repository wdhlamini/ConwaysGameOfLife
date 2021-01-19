using NUnit.Framework;
using ConwaysGameOfLife;


namespace ConwaysGameOfLifeTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void transformArrayTest()
        {
            TwoDimenArray arrayTest = new TwoDimenArray();
            int[,] tempArray = new int[5, 5] {
                {1,1,0,1,1},
                {1,0,0,1,1},
                {0,0,1,0,0},
                {0,0,0,0,0},
                {1,0,1,0,1},
            };

            int[,] methodResult = arrayTest.transformArray(tempArray);

            int[,] resultArray = new int[5, 5] {
                {1,1,1,1,1},
                {1,0,0,0,1},
                {0,0,0,1,0},
                {0,1,0,1,0},
                {0,0,0,0,0},
            };

            Assert.That(methodResult, Is.EqualTo(resultArray));
        }

        

       
       /* int[,] cornerArray= new int[3, 3] { {0,1,0}, {1,1,0}, {0,0,0} };
        
        [Test]
        [TestCase((new int[3,3] { {0,1,0}, {1,1,0}, {0,0,0}, };) , new int[3, 3] { { }, { }, { }, })]
        [TestCase(10, 45)]
        [TestCase(20, 50)]
        public void transformArrayTest(int[,] initialArray, int[,] nextArray)
        {
            TwoDimenArray arrayTest = new TwoDimenArray();
            int[,] result = arrayTest.transformArray(initialArray);
            Assert.AreEqual(result, nextArray);
        }*/
    }
}
namespace Project._0._1.Unit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSum()
        {

            //Arrange

            var nr1 = 1;
            var nr2 = 2;

            //Act
            var result = Exercises.Sum(nr1, nr2 );


            //Assert
            Assert.AreEqual(3, result );

        }
        [TestMethod]
        public void TestLessthan100()
        {

            //Arrange

            var nr40 = 40;
            var nr20 = 20;

            //Act

            var result = Exercises.LessThan100 ( 40, 20 );

            //Assert

            Assert.IsTrue( result );


        }
    }
}
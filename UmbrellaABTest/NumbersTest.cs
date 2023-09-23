using UmbrellaAB;

namespace UmbrellaABTest
{
    [TestClass]
    public class NumbersTest
    {
        [TestMethod]
        public void Testin_AddNumbers_in_2_3_answer_5()
        {
            //Arrange
            Numbers number = new Numbers();
            int x = 2;
            int y = 3;
            //Act
            int result = number.Add(x, y);
            int expected = 5;
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Testin_AddNumbers_in_4_4_answer_8()
        {
            //Arrange
            Numbers number = new Numbers();
            int x = 4;
            int y = 4;
            //Act
            int result = number.Add(x, y);
            int expected = 9;
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
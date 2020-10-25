using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximumGenerics;

namespace FindMaximumGenericsTest
{
   
        [TestClass]
        public class UnitTest1
        {
            //TC3.1
            [TestMethod]
            public void Maximum_Value_PassedAt_First_Parameter_Should_Return_Maximum_Value()
            {
                string firstValue = "Carrot", secondValue = "Banana", thirdValue = "Apple";
                string expected = "Carrot";
                FindMaximum find = new FindMaximum();
                string actual = find.MaximumStringNumber(firstValue, secondValue, thirdValue);
                Assert.AreEqual(expected, actual);
            }
            //TC3.2
            [TestMethod]
            public void Maximum_Value_PassedAt_Second_Parameter_Should_Return_Maximum_Value()
            {
                string firstValue = "Banana", secondValue = "Carrot", thirdValue = "Apple";
                string expected = "Carrot";
                FindMaximum find = new FindMaximum();
                string actual = find.MaximumStringNumber(firstValue, secondValue, thirdValue);
                Assert.AreEqual(expected, actual);
            }
            //TC3.3
            [TestMethod]
            public void Maximum_Value_PassedAt_Third_Parameter_Should_Return_Maximum_Value()
            {
                string firstValue = "Apple", secondValue = "Banana", thirdValue = "Carrot";
                string expected = "Carrot";
                FindMaximum find = new FindMaximum();
                string actual = find.MaximumStringNumber(firstValue, secondValue, thirdValue);
                Assert.AreEqual(expected, actual);
            }
        }
}

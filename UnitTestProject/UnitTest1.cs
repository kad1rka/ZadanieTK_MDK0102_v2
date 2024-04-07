using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ZadanieTKExam;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SuccesMarks()
        {
            var page = new Page1();
            Assert.IsTrue(page.CheckMarks("20","20","20") == 5);
            Assert.IsTrue(page.CheckMarks("15", "15", "15") == 4);
            Assert.IsTrue(page.CheckMarks("8", "5", "10") == 3);
            Assert.IsTrue(page.CheckMarks("3", "3","3") == 2);
            Assert.IsTrue(page.CheckMarks("0", "0", "0") == 2);

        }
        [TestMethod]
        public void UnsuccesMarks()
        {
            var page = new Page1();
            Assert.IsTrue(page.CheckMarks("-12", "0", "3") == -1);
            Assert.IsTrue(page.CheckMarks("23", "10", "10") == -1);
            Assert.IsTrue(page.CheckMarks("10", "39", "10") == -1);
            Assert.IsTrue(page.CheckMarks("10","10","21") == -1);
            Assert.IsTrue(page.CheckMarks("", "", "") == -1);
            Assert.IsTrue(page.CheckMarks("-2","10","10") == -1);
            Assert.IsTrue(page.CheckMarks("10", "-1", "10") == -1);
            Assert.IsTrue(page.CheckMarks("10", "10", "-1") == -1);
            
        }
    }
}

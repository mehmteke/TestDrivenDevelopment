using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.Operation;

namespace TDD.UnitTest
{
    [TestClass]
    public class StringHelperTest
    {
        [TestMethod]
        public void Delete_Unnecessary_Spaces()
        {
            //Arrange
            string phrase = "   Mehmet Teker    ";
            string expected = "Mehmet Teker";
            // Act
            string actual = StringHelper.DeleteUnnecessarySpaces(phrase);
            // Assert
            Assert.AreEqual(expected,actual);
        }

    }
}

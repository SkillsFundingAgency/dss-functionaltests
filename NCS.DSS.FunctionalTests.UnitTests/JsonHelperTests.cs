using NCS.DSS.FunctionalTests.Core;
using NUnit.Framework;

namespace NCS.DSS.FunctionalTests.UnitTests
{
    public class Tests
    {
        #region DocumentCount
        [Test]
        public void DocumentCount_SingleDocument_ReturnsCorrectCount()
        {
            // Arrange
            var json = @"[{ ActionId: 1, Name: ""Testing"" }]";

            // Act
            var count = JsonHelper.DocumentCount(json);

            //Assert
            Assert.AreEqual(count, 1);
        }

        [Test]
        public void DocumentCount_MultipleDocument_ReturnsCorrectCount()
        {
            // Arrange
            var json = @"[{ CustomerId: 1, Name: ""Testing"" },{ CustomerId: 2, Name: ""Testing1"" },{ CustomerId: 3, Name: ""Testing3"" }]";

            // Act
            var count = JsonHelper.DocumentCount(json);

            //Assert
            Assert.AreEqual(count, 3);
        }

        [Test]
        public void DocumentCount_EmptyString_ReturnsCorrectCount()
        {
            // Arrange
            var json = "";

            // Act
            var count = JsonHelper.DocumentCount(json);

            //Assert
            Assert.AreEqual(count, 0);
        }

        [Test]
        public void DocumentCount_StringIsNull_ReturnsCorrectCount()
        {
            // Arrange
            string json = null;

            // Act
            var count = JsonHelper.DocumentCount(json);

            //Assert
            Assert.AreEqual(count, 0);
        }
        #endregion

        #region GetValueByKey
        [Test]
        public void GetValueByKey_NonExistentProperty_ReturnsNull()
        {
            // Arrange
            var json = @"{ CustomerId: 1, Name: ""Testing"" }";


            // Act
            var value = JsonHelper.GetValueByKey(json, "InvalidKey");

            //Assert
            Assert.IsNull(value);
        }

        [Test]
        public void GetValueByKey_GetValidProperty_ReturnsValue()
        {
            // Arrange
            var json = @"{ CustomerId: 1, Name: ""DSS TEsting"" }";

            // Act
            var value = JsonHelper.GetValueByKey(json, "Name");

            //Assert
            Assert.AreEqual(value, "DSS TEsting");
        }

        [Test]
        public void GetValueByKey_JsonIsNull_ReturnsNull()
        {
            // Arrange
            string json = null;

            // Act
            var value = JsonHelper.GetValueByKey(json, "Name");

            //Assert
            Assert.IsNull(value);
        }


        [Test]
        public void GetValueByKey_JsonIsEmptyString_ReturnsNull()
        {
            // Arrange
            var json = "";

            // Act
            var value = JsonHelper.GetValueByKey(json, "Name");

            //Assert
            Assert.IsNull(value);
        }

        [Test]
        public void GetValueByKey_InvalidJson_ReturnsNull()
        {
            // Arrange
            string json = @"{ SomeInvalid Json: ";

            // Act
            var value = JsonHelper.GetValueByKey(json, "Name");

            //Assert
            Assert.IsNull(value);
        }
        #endregion

        #region JsonContains
        [Test]
        public void JsonContains_TargetJsonNull_ReturnsFalse()
        {
            // Arrange
            var json = @"{ ActionId: 1, Name: ""Testing"" }";

            // Act
            var value = JsonHelper.JsonContains(null, json);

            //Assert
            Assert.False(value);
        }

        [Test]
        public void JsonContains_SourceJsonNull_ReturnsFalse()
        {
            // Arrange
            var json = @"{ ActionId: 1, Name: ""Testing"" }";

            // Act
            var value = JsonHelper.JsonContains(json, null);

            //Assert
            Assert.False(value);
        }

        [Test]
        public void JsonContains_TargetAndSourceJsonNull_ReturnsFalse()
        {
            // Arrange
            var json = @"{ ActionId: 1, Name: ""Testing"" }";

            // Act
            var value = JsonHelper.JsonContains(null, null);

            //Assert
            Assert.False(value);
        }


        [Test]
        public void JsonContains_TargetJsonInvalid_ReturnsFalse()
        {
            // Arrange
            string InvalidTargetJson = @"{ ActionId: }";
            var sourceJson = @"{ ActionId: 1}";

            // Act
            var value = JsonHelper.JsonContains(InvalidTargetJson, sourceJson);

            //Assert
            Assert.False(value);
        }

        [Test]
        public void JsonContains_SourceJsonInvalid_ReturnsFalse()
        {
            // Arrange
            string targetJson = @"{ ActionId: 1}";
            var InvalidSourceJson = @"{ ActionId: }";

            // Act
            var value = JsonHelper.JsonContains(targetJson, InvalidSourceJson);

            //Assert
            Assert.False(value);
        }

        [Test]
        public void JsonContains_TargetArrayContainsJsonDocument_ReturnsTrue()
        {
            // Arrange
            string targetJson = @"[{ Customer: ""SomeTest"", Age: 300, Height: 200},{ Customer: ""Bob the Builder"", Age: 1, Height: 100},{ Customer: ""Spiderman"", Age: 25, Height: 150}]";
            var sourceJson = @"{ Customer: ""SomeTest"", Age: 300, Height: 200}";

            // Act
            var value = JsonHelper.JsonContains(targetJson, sourceJson);

            //Assert
            Assert.True(value);
        }

        [Test]
        public void JsonContains_TargetArrayContainsJsonDocumentCaseInsensitiveValue_ReturnsTrue()
        {
            // Arrange
            string targetJson = @"[{ Customer: ""SomeTest"", Age: 300, Height: 200},{ Customer: ""Bob the Builder"", Age: 1, Height: 100},{ Customer: ""Spiderman"", Age: 25, Height: 150}]";
            var sourceJson = @"{ Customer: ""SOMeTesT"", Age: 300, Height: 200}";

            // Act
            var value = JsonHelper.JsonContains(targetJson, sourceJson);

            //Assert
            Assert.True(value);
        }

        [Test]
        public void JsonContains_TargetJsonDocumentContainsDocument_ReturnsTrue()
        {
            // Arrange
            string targetJson = @"{ Customer: ""SomeTest"", Age: 300, Height: 200}";
            var sourceJson = @"{ Customer: ""SOMeTesT"", Age: 300, Height: 200}";

            // Act
            var value = JsonHelper.JsonContains(targetJson, sourceJson);

            //Assert
            Assert.True(value);
        }

        [Test]
        public void JsonContains_TargetJsonDocumentDoesNotContainsDocument_ReturnsFalse()
        {
            // Arrange
            string targetJson = @"{ Customer: ""SomeTest"", Age: 300, Height: 200}";
            var sourceJson = @"{ Customer: ""some invalid customer text"", Age: 300, Height: 200}";

            // Act
            var value = JsonHelper.JsonContains(targetJson, sourceJson);

            //Assert
            Assert.False(value);
        }

        /// <summary>
        /// Test that matches everything on source object to that of target but ignores extra properties on Target
        /// </summary>
        [Test]
        public void JsonContains_TargetJsonContainsSourceJsonIgnoresExtraProperties_ReturnsFalse()
        {
            // Arrange
            string targetJson = @"{ Customer: ""SomeTest"", Age: 300, Height: 200}";
            var sourceJson = @"{ Customer: ""SOMeTesT""}";

            // Act
            var value = JsonHelper.JsonContains(targetJson, sourceJson);

            //Assert
            Assert.True(value);
        }
        #endregion
    }
}
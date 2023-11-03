using Skottår_Kalkylator;

namespace Skottår_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsLeap_ThrowsNotImplementedException()
        {
            // Arrange
            int årAttKontrollera = 2024;

            // Act and Assert
            Assert.Throws<NotImplementedException>(() => År.ÄrSkottår(årAttKontrollera));
        }

        [Test]
        public void När_ÅrÄrDelbartMed400_ShouldReturnTrue()
        {
            Assert.Pass();
        }
    }
}
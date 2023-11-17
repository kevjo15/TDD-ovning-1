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
        public void ÄrSkottÅr_RetuneraTrue()
        {
            // Arrange
            int årAttKontrollera = 2024;

            // Act
            bool resultat = År.ÄrSkottår(årAttKontrollera);

            // Assert
            Assert.IsTrue(resultat);
        }

        [Test]
        public void GetDagNummer_ShouldReturnCorrectDayNumber()
        {
            // Arrange
            DateTime förstaJanuari2023 = new DateTime(2023, 1, 1);

            // Act
            int dagNummer = År.GetDagNummer(förstaJanuari2023);

            // Assert
            Assert.AreEqual(1, dagNummer);
        }
    }
}
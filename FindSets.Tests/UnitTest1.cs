using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindSets.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HigestValues_MockCards()
        {
            //Arrange
            var cards = BuildMockCards();
            var setLength = 2;
            var maxHighestValues = 2;
            var sut = new SetFinder();

            //Act
            var result = sut.HighestValuesInValidSets(cards, setLength, maxHighestValues);
            //Assert
            Assert.IsTrue(result.Contains(10));
            Assert.IsTrue(result.Contains(8));
        }

        [TestMethod]
        public void FourValidSets_MockCards_SetLengthTwo()
        {
            //Arrange
            var cards = BuildMockCards();
            var setLength = 2;
            var sut = new SetFinder();

            //Act
            var result = sut.NumberOfValidSets(cards, setLength);
            //Assert
            Assert.AreEqual(result,4);
        }

        [TestMethod]
        public void TwoValidSets_MockCards_SetLengthThree()
        {
            //Arrange
            var cards = BuildMockCards();
            var setLength = 3;
            var sut = new SetFinder();

            //Act
            var result = sut.NumberOfValidSets(cards, setLength);
            //Assert
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void OneValidSet_MockCards_SetLengthFour()
        {
            //Arrange
            var cards = BuildMockCards();
            var setLength = 4;
            var sut = new SetFinder();

            //Act
            var result = sut.NumberOfValidSets(cards, setLength);
            //Assert
            Assert.AreEqual(result, 1);
        }

        private Card[] BuildMockCards()
        {
            var cards = new Card[7];
            cards[0] = new Card{Symbol = CardSymbols.Clubs, Value = 5};
            cards[1] = new Card { Symbol = CardSymbols.Clubs, Value = 10 };
            cards[2] = new Card { Symbol = CardSymbols.Diamonds, Value = 8 };
            cards[3] = new Card { Symbol = CardSymbols.Diamonds, Value = 7 };
            cards[4] = new Card { Symbol = CardSymbols.Hearts, Value = 3 };
            cards[5] = new Card { Symbol = CardSymbols.Hearts, Value = 2 };
            cards[6] = new Card { Symbol = CardSymbols.Spades, Value = 1 };

            return cards;
        }
    }
}

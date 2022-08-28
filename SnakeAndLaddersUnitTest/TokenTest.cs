namespace SnakeAndLaddersTest
{
    public class TokenTest
    {
        [Fact]
        public void GivenGameIsStarted_WhenTokenIsPlaced_ThenTokenIsOnPositionOne()
        {
            //Arrange
            Token token = new Token();

            //Assert
            Assert.Equal(1, token.Position);
        }

        [Fact]
        public void GivenTheTokenIsOnPosition1_WhenIsMoved3Spaces_ThenTokenIsOnPosition4()
        {
            //Arrange
            Token token = new Token();

            //Act
            token.Move(3);

            //Assert
            Assert.Equal(4, token.Position);
        }

        [Fact]
        public void GivenTheTokenIsOnPosition1_WhenIsMoved3Spaces_AndThenisMoved4Spaces_ThenTokenIsOnPosition8()
        {
            //Arrange
            Token token = new Token();

            //Act
            token.Move(3);
            token.Move(4);

            //Assert
            Assert.Equal(8, token.Position);
        }
    }
}
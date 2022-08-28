namespace SnakeAndLaddersTest
{
    public class PlayerTest
    {
        [Fact]
        public void GivenTheTokenIsOnPosition97_WhenTokenIsMoved3Spaces_ThenTheTokenIsInPosition100_AndPlayerHasWonTheGame()
        {
            //Arrange
            Player player = new Player();
            player.Token.MoveTo(97);

            //Act
            player.Token.Move(3);

            //Assert
            Assert.Equal(100, player.Token.Position);
            Assert.True(player.Wins);
        }

        [Fact]
        public void GivenTheTokenIsOnPosition97_WhenTokenIsMoved4Spaces_ThenTheTokenIsInPosition97_AndPlayerHasNotWonTheGame()
        {
            //Arrange
            Player player = new Player();
            player.Token.MoveTo(97);

            //Act
            player.Token.Move(4);

            //Assert
            Assert.Equal(97, player.Token.Position);
            Assert.False(player.Wins);
        }

        [Fact]
        public void GivenTheGameIsStarted_WhenThePlayerRollsADice_ThenResultShouldBeBetween1And6Inclusive()
        {
            //Arrange
            Player player = new Player();

            //Act
            int result = player.Roll();

            //Assert
            Assert.InRange(result, 1, 6);
        }

        [Fact]
        public void GivenThePlayerRollsTheDice_WhenTheyMoveTheirToken_ThenTheTokenShouldMoveDiceResultSpaces()
        {
            //Arrange
            Player player = new Player();
            int startingPosition = player.Token.Position;

            //Act
            int result = player.Roll();
            player.Token.Move(result);

            //Assert
            Assert.Equal(startingPosition + result, player.Token.Position);
        }
    }
}

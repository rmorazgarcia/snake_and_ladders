namespace SnakeAndLaddersLibrary
{
    public class Token
    {
        const int MAX_POSITION = 100;
        private int _position = 1;

        public int Position { get { return _position; }}

        public void Move(int value)
        {
            _position = value + _position <= MAX_POSITION ? value + _position : _position;
        }

        public void MoveTo(int value)
        {
            _position = value;
        }
    }
}
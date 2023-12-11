namespace BoardService
{
    public class Part
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int QtyMovements { get; protected set; }
        public Board Board { get; protected set; }

        public Part(){}
        public Part(Position position, Color color, Board board ){
            Position = position;
            Color = color;
            Board = board;
            QtyMovements = 0;
        }

    }
}
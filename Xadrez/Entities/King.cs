using BoardService;
namespace ProjectXadrez.Xadrez.Entities
{
    public class King : Part
    {
        
        public King(){}
        public King(Color color, Board board) : base(color, board){}

        public override string ToString()
        {
            return "R";
        }
    }
}
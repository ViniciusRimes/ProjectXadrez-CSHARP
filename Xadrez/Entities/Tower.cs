using BoardService;
namespace ProjectXadrez.Xadrez.Entities
{
    public class Tower : Part
    {
        
        public Tower(){}
        public Tower(Color color, Board board) : base(color, board){}

        public override string ToString()
        {
            return "T";
        }
    }
}
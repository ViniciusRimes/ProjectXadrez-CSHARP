namespace BoardService
{
    public class Board
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private Part[,] Parts;

        public Board(){}
        public Board(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            Parts = new Part[lines, columns];
        }
        public Part Part(int line, int column )
        {
            return Parts[line, column];
        }
        public void InsertPart(Part p, Position pos)
        {
            Parts[pos.Lines, pos.Columns] = p;
            p.Position = pos;
        }
    }
}
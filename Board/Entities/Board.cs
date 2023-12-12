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
        public Part Part(Position pos)
        {
            return Parts[pos.Lines, pos.Columns];
        }
        public bool ExistsPart(Position pos)
        {
            CheckPosition(pos);
            return Parts[pos.Lines, pos.Columns] != null;
        }
        public void InsertPart(Part p, Position pos)
        {
            if(ExistsPart(pos))
            {
                throw new BoardException("Já existe uma peça nesta posição!");
            }
            Parts[pos.Lines, pos.Columns] = p;
            p.Position = pos;
        } 
        public bool CheckPosition(Position pos)
        {
            if(pos.Lines < 0 || pos.Lines >= Lines || pos.Columns < 0 || pos.Columns >= Columns)
            {
               throw new BoardException("Posição inválida!");
            }
            return true;
        }
    }
}
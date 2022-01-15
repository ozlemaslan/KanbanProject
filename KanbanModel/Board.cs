using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanModel
{
    public class Board
    {
        public Board()
        {
            Gorevler = new HashSet<Gorev>();
        }
        public int BoardID { get; set; }
        public string BoardName { get; set; }
        public ICollection<Gorev> Gorevler { get; set; }

    }
}


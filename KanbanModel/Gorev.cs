using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanModel
{
    public class Gorev
    {
        public int GorevID { get; set; }
        public int BoardID { get; set; }
        public int DurumID { get; set; }
        public string Aciklama { get; set; }
        public Board Tahta { get; set; }
    }
}

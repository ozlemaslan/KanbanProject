using Kanban.EF.DAL;
using KanbanModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.EF.BLL
{
    public class BoardBLL
    {
        BoardDAL boardDAL;
        
        public BoardBLL()
        {
            boardDAL = new BoardDAL();
        }

        public bool Add(Board board) 
        {
            try
            {
                BosGecilemez(board.BoardName);
                Kontrol(board.BoardName);
                return boardDAL.Insert(board) > 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Guncelle(Board board)
        {
            return boardDAL.Update(board) > 0;
        }

        public bool Delete(Board board)
        {
            return boardDAL.Delete(board)>0;
        }

        public Board GetBoardID(int boardID)
        {
            return boardDAL.GetBoardID(boardID);
        }

        public List<Board> GetBoardListe()
        {
            return boardDAL.GetBoardList();
        }
        public void Kontrol(string boardAdi)
        {
            if (boardAdi.Length>35)
            {
                throw new Exception("Tahta adı 35 karakterden büyük olamaz.");
            }
        }
        void BosGecilemez(string boardAdi)
        {
            if (string.IsNullOrEmpty(boardAdi))
            {
                throw new Exception("Tahta adı boş geçilemez.");
            }
        }
    }
}

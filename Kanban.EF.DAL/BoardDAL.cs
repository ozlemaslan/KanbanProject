using Kanban.EF.DAL.Entities;
using KanbanModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.EF.DAL
{
    public class BoardDAL
    {
        KanbanContext kanban;
        public BoardDAL()
        {
            kanban = new KanbanContext();
        }

        public int Insert(Board board)
        {
            try
            {
                kanban.Tahtalar.Add(board);
                return kanban.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Tahta adı eklenemedi.");
            }
        }
        
        public int Update(Board board)
        {
            try
            {
                kanban.Entry(board).State = EntityState.Modified;
                return kanban.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Tahta adı güncellenemedi.");
            }
        }

        public int Delete(Board board)
        {
            try
            {
                kanban.Entry(board).State = EntityState.Deleted;
                return kanban.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Tahta adı silinemedi.");
            }
        }

        public Board GetBoardID(int boardID)
        {
            return kanban.Tahtalar.SingleOrDefault(a => a.BoardID==boardID);
        }

        public List<Board> GetBoardList()
        {
            return kanban.Tahtalar.ToList();
        }
    }
}

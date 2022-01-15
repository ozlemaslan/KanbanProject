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
    public class GorevDAL
    {
        KanbanContext kanban;
        public GorevDAL()
        {
            kanban = new KanbanContext();
        }

        public int Insert(Gorev gorev)
        {
            try
            {
                kanban.Gorevler.Add(gorev);
                return kanban.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Görev eklenemedi.");
            }
        }

        public int Update(Gorev gorev)
        {
            try
            {
                var sonuc = kanban.Gorevler.Where(a => a.GorevID == gorev.GorevID).FirstOrDefault();
                sonuc.Aciklama = gorev.Aciklama;
                sonuc.BoardID = gorev.BoardID;
                sonuc.DurumID = gorev.DurumID;
                //kanban.Entry(gorev).State= EntityState.Modified;
                return kanban.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Görev güncellenemedi.");
            }
        }

        public int Delete(Gorev gorev)
        {
            try
            {
                kanban.Entry(gorev).State = EntityState.Deleted;
                return kanban.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Görev silinemedi.");
            }
        }

        public Gorev GetGorevID(int gorevID)
        {
            return kanban.Gorevler.SingleOrDefault(a => a.GorevID == gorevID);
        }

        public List<Gorev> GetGorevList()
        {
            return kanban.Gorevler.ToList();
        }

        public List<Gorev> GetGorevByBoardID(int boardID)
        {
            List<Gorev> gorevler = new List<Gorev>();
            //Gorev g= kanban.Gorevler.SingleOrDefault(a => a.BoardID == boardID);
            var sonuc = from b in kanban.Tahtalar
                        join g in kanban.Gorevler
                        on b.BoardID equals g.BoardID
                        where g.BoardID == boardID
                        select g;
            sonuc.ToList().ForEach(item => gorevler.Add(item));

            //if (g==null)
            //{
            //    throw new Exception("Görev boş olamaz.");
            //}
            //gorevler.Add(g);
            return gorevler;

        }

        public Gorev GorevBoardID(int boardID)
        {
            return kanban.Gorevler.SingleOrDefault(a => a.BoardID == boardID);
        }
    }
}

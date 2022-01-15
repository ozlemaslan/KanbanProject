using Kanban.EF.DAL;
using KanbanModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.EF.BLL
{
    public class GorevBLL
    {
        GorevDAL gorevDAL;

        public GorevBLL()
        {
            gorevDAL = new GorevDAL();
        }
        public bool Add(Gorev gorev)
        {
            try
            {
                BosGecilemez(gorev.Aciklama);
                Kontrol(gorev.Aciklama);
                return gorevDAL.Insert(gorev) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Guncelle(Gorev gorev)
        {
            return gorevDAL.Update(gorev) > 0;
        }

        public bool Delete(Gorev gorev)
        {
            return gorevDAL.Delete(gorev) > 0;
        }

        public Gorev GetGorevID(int gorevID)
        {
            return gorevDAL.GetGorevID(gorevID);
        }

        public List<Gorev> GetGorevListe()
        {
            return gorevDAL.GetGorevList();
        }
        public List<Gorev> GetGorevByBoardID(int boardID)
        {
            List<Gorev> gorevler = new List<Gorev>();
            gorevler = gorevDAL.GetGorevByBoardID(boardID);
            return gorevler;

        }
        public Gorev GorevBoardID(int boardID)
        {
            return gorevDAL.GorevBoardID(boardID);
        }
        public void Kontrol(string gorevAdi)
        {
            if (gorevAdi.Length > 35)
            {
                throw new Exception("Görev adı 30 karakterden büyük olamaz.");
            }
        }
        void BosGecilemez(string gorevAdi)
        {
            if (string.IsNullOrEmpty(gorevAdi))
            {
                throw new Exception("Görev adı boş geçilemez.");
            }
        }
    }
}

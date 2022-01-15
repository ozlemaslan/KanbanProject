using Kanban.EF.BLL;
using KanbanModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanban.EF.UI
{
    public partial class frmBoard : Form
    {
        int _boardID;
        List<Gorev> gorevler;
        GorevBLL gorevBLL;
        int gorevID;

        public frmBoard(int boardID)
        {
            InitializeComponent();
            _boardID = boardID;
            gorevler = new List<Gorev>();
            gorevBLL = new GorevBLL();
            pnlTODO.Tag = 1;
            pnlDOING.Tag = 2;
            pnlDONE.Tag = 3;

        }

        private void yeniGörevToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYeniGorev gorevForm = new frmYeniGorev(_boardID);
            gorevForm.Owner = this.Owner;
            gorevForm.ShowDialog();
            FillList();
        }

        public void GorevEkle(List<Gorev> gorevler)
        {
            Label lbl;
            foreach (Gorev item in gorevler)
            {
                lbl = new Label();
                lbl.Name = "lbl." + item.GorevID;
                lbl.Text = item.Aciklama;
                lbl.BorderStyle = BorderStyle.FixedSingle;
                lbl.ContextMenuStrip = contextMenuStrip1;
                lbl.MouseDown += Lbl_MouseDown;
               

                if (item.DurumID == (int)Durum.TODO)
                {
                    lbl.Top = GetTop(pnlTODO);
                    pnlTODO.Controls.Add(lbl);
                }
                else if (item.DurumID == (int)Durum.DOING)
                {
                    lbl.Top = GetTop(pnlDOING);
                    pnlDOING.Controls.Add(lbl);
                }
                else
                {
                    lbl.Top = GetTop(pnlDONE);
                    pnlDONE.Controls.Add(lbl);
                }
            }
        }

        private void Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;
            lbl.DoDragDrop(sender, DragDropEffects.Move);
            
        }

        int GetTop(Panel pnl)
        {
            int top = 0;

            foreach (Control item in pnl.Controls)
            {
                top += item.Height+3;
            }

            return top;
        }

        private void pnlTODO_DragDrop(object sender, DragEventArgs e)
        {
            Label lbl = e.Data.GetData(typeof(Label)) as Label;
            Panel pnl = sender as Panel;
            lbl.Parent.Controls.Remove(lbl);
            lbl.Top = GetTop(pnl);
            pnl.Controls.Add(lbl);

            #region Güncelleme işlemleri
            //Gorev gorev = null;

            //foreach (Control item in this.Controls)
            //{
            //    if (item is Panel)
            //    {
            //        if (item.Tag == null)
            //        {
            //            break;
            //        }
            //        else if ((int)item.Tag == 1 || (int)item.Tag == 2 || (int)item.Tag == 3)
            //        {
            //            foreach (Label label in item.Controls)
            //            {
            //                gorev = new Gorev();
            //                string[] dizi = label.Name.Split('.');
            //                gorevID = Convert.ToInt32(dizi[1]);
            //                gorev.Aciklama = label.Text;
            //                gorev.BoardID = _boardID;
            //                gorev.GorevID = gorevID;

            //                if ((int)item.Tag == (int)Durum.TODO)
            //                {
            //                    gorev.DurumID = (int)Durum.TODO;
            //                }
            //                else if ((int)item.Tag == (int)Durum.DOING)
            //                {
            //                    gorev.DurumID = (int)Durum.DOING;
            //                }
            //                else if ((int)item.Tag == (int)Durum.DONE)
            //                {
            //                    gorev.DurumID = (int)Durum.DONE;
            //                }
            //                gorevBLL.Guncelle(gorev);
            //            }
            //        }
            //    }
            //    else break;
            //}
            #endregion
        }
        private void pnlTODO_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void frmBoard_Load(object sender, EventArgs e)
        {
            #region İlk açıldığında sadece 1 tane görev eklemesi için yaptım.
            //Gorev gorev = new Gorev()
            //{
            //    Aciklama = "Fizik",
            //    BoardID = _boardID,
            //    DurumID = (int)Durum.TODO

            //};
            //gorevBLL.Add(gorev); 
            #endregion

            FillList();
        }

        private void FillList()
        {
            pnlTODO.Controls.Clear();
            pnlDOING.Controls.Clear();
            pnlDONE.Controls.Clear();

            gorevler = gorevBLL.GetGorevByBoardID(_boardID);
            //if (gorevler.Count==0)
            //{
            //    MessageBox.Show("Görev bulunmamaktadır.");
            //}
            GorevEkle(gorevler);
        }

        private void frmBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result=MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result==DialogResult.Yes)
            {
                Gorev gorev = null;
                
                foreach (Control item in this.Controls)
                {
                    if (item is Panel)
                    {
                        if (item.Tag == null)
                        {
                            break;
                        }
                        else if ((int)item.Tag == 1 || (int)item.Tag == 2 || (int)item.Tag == 3)
                        {
                            foreach (Label label in item.Controls)
                            {
                                gorev = new Gorev();
                                string[] dizi = label.Name.Split('.');
                                gorevID = Convert.ToInt32(dizi[1]);
                                gorev.Aciklama = label.Text;
                                gorev.BoardID = _boardID;
                                gorev.GorevID = gorevID;

                                if ((int)item.Tag == (int)Durum.TODO)
                                {
                                    gorev.DurumID = (int)Durum.TODO;
                                }
                                else if ((int)item.Tag == (int)Durum.DOING)
                                {
                                    gorev.DurumID = (int)Durum.DOING;
                                }
                                else if ((int)item.Tag == (int)Durum.DONE)
                                {
                                    gorev.DurumID = (int)Durum.DONE;
                                }
                                gorevBLL.Guncelle(gorev);
                            }
                        }
                    }
                    else break;
                }
            }
            else
            {
                //yapamadım.
                MessageBox.Show("Kaydedilmedi.");

            }
        }

        //BONUS1:
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gorev gorev = gorevBLL.GetGorevID(gorevID);
            gorevBLL.Delete(gorev);
            FillList();
        }
    }
}
